var userId = 0;

function loadRecibos(_userId) {

    userId = _userId;

    $('#tblGrid').datagrid({
        url: 'api/Recibo',
        method: 'get',
        idField: 'Id',
        height: 320,
        width: 960,
        singleSelect: true,
        pagination: true,
        toolbar: '#toolbar',
        columns: [[
        { field: 'Id', title: '#', width: 45, align: 'right' },
        { field: 'FechaStr', title: 'Fecha', width: 100, align: 'left' },
        { field: 'Proveedor', title: 'Proveedor', width: 190, align: 'left' },
        { field: 'Monto', title: 'Monto', width: 190, align: 'left' },
        { field: 'Moneda', title: 'Moneda', width: 190, align: 'left' },
        { field: 'Comentario', title: 'Comentario', width: 190, align: 'left' }
        ]]
    });

    $.getJSON('api/Proveedor', { ieFix: new Date() }, function (data) {
        var ddl = $('#ProveedorId');
        ddl.empty();
        if (data != null) {
            $.each(data, function (index, item) {
                ddl.append($('<option/>', {
                    value: item.Id,
                    text: item.Nombre
                }));
            });
        }
    });

    $.getJSON('api/Moneda', { ieFix: new Date() }, function (data) {
        var ddl = $('#MonedaId');
        ddl.empty();
        if (data != null) {
            $.each(data, function (index, item) {
                ddl.append($('<option/>', {
                    value: item.Id,
                    text: item.Nombre
                }));
            });
        }
    });

}

function newRecibo() {
    $('#dlg').dialog('open').dialog('center').dialog('setTitle', 'Registar Recibo');
    $('#fm').form('clear');
    $('#UserReg').val(userId);
}

function saveRecibo() {    
    $('#fm').form('submit', {
        url: 'api/Recibo',
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (data) {
            $('#dlg').dialog('close');
            $('#tblGrid').datagrid('reload');
        }
    });
}