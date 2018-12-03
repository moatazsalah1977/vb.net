
sub dgv_mystyle
'adjusting Datagrid view
        datagridview1.rowsheadervisable = false
        DataGridView1.GridColor = Color.blue
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.BackgroundColor = Color.white

'Adjusting rows
        datagridview1.rowsheadervisable = false
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.gray
End Sub

'cell selection
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
       