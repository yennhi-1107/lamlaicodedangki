<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="~/Content/Style.css" >
    <title>Đăng kí</title>
</head>
<body>
  

            <div class="container">

                <form id="submit-fieldset" >
                    <div class="a">
                        <h2> ĐĂNG KÝ</h2>
                    </div>
                    <div class="form-group">
                        <label for="email">Email:</label><br/>
                        <input type="email" id="email" required>
                    </div>
                    <div class="form-group">
                        <label for="password">Mật khẩu:</label><br />
                        <input type="password" id="password" required>
                    </div>
                    <div class="form-group">
                        <label for="confirm-password">Xác nhận mật khẩu:</label><br />
                        <input type="password" id="confirm-password" required>
                    </div>
                    <div class="form-group">
                        <label for="display-name">Tên hiển thị:</label><br />
                        <input type="text" id="display-name" required>
                    </div>
                    <div class="form-group">
                        <label for="birthday">Sinh nhật:</label><br />
                        <input type="date" id="birthday" required>
                    </div>
                    <button type="submit" id="submit" style="width:25%; height:25px;color:white; background-color:forestgreen"><a style="color:white" target="_blank">

    Đăng ký
</a></button>
                    <br />
                    Bạn đã có tài khoản? Hãy <button type="signup" id="signup" style="width:25%; height:25px;color:white; background-color:forestgreen">
    <a style="color:white" target="_blank" href="http://localhost:64437/Home/Sign">
        Đăng nhập
    </a>
</button> hoặc <button type="signupfb" style="width:30%; height:25px;color:white; background-color:darkblue">
    <a style="color:white" target="_blank" href="https://www.facebook.com">Đăng nhập qua Facebook</a>

</button><div>
    @RenderBody()
</div>
               </form>
            </div>
            
            <script src="~/Scripts/Script.js"></script>
    
</body>
</html>
