
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{
    private SqlConnection conn = new SqlConnection();
    private SqlCommand cmd = new SqlCommand();
    private SqlDataAdapter ada = new SqlDataAdapter();
    //private System.Data.OleDb.OleDbTransaction tran;
    private static DB da = new DB();
    public DB()
    {
        conn.ConnectionString = "Data Source=.;Initial Catalog=hrms;Integrated Security=True";
        cmd.Connection = conn;
        ada.SelectCommand = cmd;
    }

    public static Object ExcuteSQL(string sql)
    {
        object f;
        try
        {
            da.conn.Open();
            da.cmd.CommandText = sql;
            f = da.cmd.ExecuteScalar();
            if (null == f)
                f = new object();
        }
        catch (Exception ex)
        {
            DialogResult dr_0 = MessageBox.Show(ex.Message);
            f = null;
        }

        finally
        {
            if (da.conn.State == System.Data.ConnectionState.Open)
                da.conn.Close();
        }

        return f;
    }

       
    public static bool FillDataTable(string sql, DataTable mytable)
    {
        try
        {
            da.ada.SelectCommand.CommandText = sql;
            da.ada.Fill(mytable);

        }

        catch (Exception ex)
        {
            DialogResult dr_1 = MessageBox.Show(ex.Message);
            return false;
        }

        finally
        {
            if (da.conn.State == System.Data.ConnectionState.Open)
                da.conn.Close();
        }

        return true;
    }

    public static bool FillDataSet(string sql, DataSet ds, string name)
    {
        try
        {

            da.ada.SelectCommand.CommandText = sql;
            da.ada.Fill(ds, name);
        }
        catch (Exception ex)
        {
            DialogResult dr_2 = MessageBox.Show(ex.Message);
            //FrameWorkError.WriteError(string.Format("DataAccess.FillDataTab执行出错。执行语句:{0} 异常原因:{1}", sql, ex.ToString()));
            return false;
        }
        finally
        {
            if (da.conn.State == System.Data.ConnectionState.Open)
                da.conn.Close();
        }
        return true;
    }

    //public static bool ExcuteTransaction(string[] sql)
    //{
    //    try
    //    {
    //        da.conn.Open();
    //        da.tran = da.conn.BeginTransaction();
    //        da.cmd.Transaction = da.tran;

    //        foreach (string sql2 in sql)
    //        {
    //            da.cmd.CommandText = sql2;
    //            if (da.cmd.ExecuteNonQuery() <= 0)
    //            {
    //                da.tran.Rollback();
    //                return false;
    //            }

    //        }
    //        da.tran.Commit();
    //        return true;

    //    }

    //    catch
    //    {
    //        da.tran.Rollback();
    //        return false;
    //    }

    //    finally
    //    {
    //        da.conn.Close();

    //    }
    //}
}




