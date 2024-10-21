$(document).ready(function () {
    //Bat su kien click vao cac khoa hoc
    let currentKhoaHocTen; //Tao bien lay ten khoa hoc dang chon hien tai
    let monHocSkip = 0; ////Tao bien dem so mon hoc
    $('.khoaHocCard').click(function () {
        var khoaHocId = $(this).find('a').data('id');
        currentKhoaHocTen = $(this).find('a').text();

        // Show loading gif
        $('#loadingSpinner').show();
        monHocSkip = 0; //reset bien dem ve 0
        $('#monHocTitle').text("Danh sách môn học của khóa học: " + currentKhoaHocTen); //Lay ten khoa hoc hien tai dang chon

        $.ajax({
            url: urls, //Get action tu controller
            type: 'GET',
            data: { id: khoaHocId }, // use id
            success: function (data) {
                // Hide loading gif sau khi get xong du lieu
                $('#loadingSpinner').hide();
                $('#monHocList').empty(); // Xoa danh sach mon hoc cu

                if (data.success) {
                    if (data.data.length === 0) {
                        $('#monHocList').append('<li class="list-group-item">Không có môn học nào cho khóa học này</li>');
                    } else {
                        $.each(data.data, function (index, monHoc) {
                            $('#monHocList').append('<li class="list-group-item">' + (monHocSkip + index + 1) + '. ' + monHoc.TenMonHoc + '</li>');
                        });
                    }
                } else {
                    $('#monHocList').append('<li class="list-group-item">' + data.message + '</li>');
                }
            },
            error: function () {
                // error
                $('#loadingSpinner').hide();
                alert('Có lỗi xảy ra trong quá trình tải dữ liệu!');
            }
        });
    });
});