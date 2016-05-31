
$(document).ready(function () {
    //注册提交按钮单击事件
    $("#save").click(function () {

        var txtContent = UM.getEditor('content').getContent(); //获取文本框的值
        var topic = $("#topic").val();

        if (UM.getEditor('content').hasContents()) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 

            $.ajax({
                type: "Post",
                url: "/Article/Add",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "Content": encodeURIComponent(txtContent), "topic": topic },
                dataType: "json",
                success: function (data) {
                    //返回类型为text时 要处理一下 

                    alert(data.info);
                    window.location.href = "../index.html";
                },
                error: function (err) {
                    alert(err);
                }
            });
        }
        else {
            alert("内容不得为空！");
        }
    });

});