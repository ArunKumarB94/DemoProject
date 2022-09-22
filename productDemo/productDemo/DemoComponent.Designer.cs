
namespace productDemo
{
    partial class DemoComponent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoComponent));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.stockDataset1 = new productDemo.StockDataset();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataset1)).BeginInit();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Solera_Employees;Persist Security Info=True;User ID" +
    "=sa;Password=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT pid, pname, price, AvlQty\r\nFROM     product";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO product\r\n                  (pid, pname, price, AvlQty)\r\nVALUES (@pid," +
    "@pname,@price,@AvlQty); \r\nSELECT pid, pname, price, AvlQty FROM product WHERE (p" +
    "id = @pid)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pid", System.Data.SqlDbType.Int, 0, "pid"),
            new System.Data.SqlClient.SqlParameter("@pname", System.Data.SqlDbType.VarChar, 0, "pname"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Float, 0, "price"),
            new System.Data.SqlClient.SqlParameter("@AvlQty", System.Data.SqlDbType.Int, 0, "AvlQty")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pid", System.Data.SqlDbType.Int, 0, "pid"),
            new System.Data.SqlClient.SqlParameter("@pname", System.Data.SqlDbType.VarChar, 0, "pname"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Float, 0, "price"),
            new System.Data.SqlClient.SqlParameter("@AvlQty", System.Data.SqlDbType.Int, 0, "AvlQty"),
            new System.Data.SqlClient.SqlParameter("@Original_pid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AvlQty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AvlQty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [product] WHERE (([pid] = @Original_pid) AND ((@IsNull_pname = 1 AND " +
    "[pname] IS NULL) OR ([pname] = @Original_pname)) AND ([price] = @Original_price)" +
    " AND ([AvlQty] = @Original_AvlQty))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AvlQty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AvlQty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "product", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pid", "pid"),
                        new System.Data.Common.DataColumnMapping("pname", "pname"),
                        new System.Data.Common.DataColumnMapping("price", "price"),
                        new System.Data.Common.DataColumnMapping("AvlQty", "AvlQty")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // stockDataset1
            // 
            this.stockDataset1.DataSetName = "StockDataset";
            this.stockDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            ((System.ComponentModel.ISupportInitialize)(this.stockDataset1)).EndInit();

        }

        #endregion
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        public System.Data.SqlClient.SqlConnection sqlConnection1;
        public System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        public StockDataset stockDataset1;
    }
}
