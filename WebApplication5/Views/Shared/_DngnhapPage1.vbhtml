<!DOCTYPE html>

<html>
<head  runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    <title>Dăng nhập</title>
</head>
<body>
    <form id="form1" runat="server" align-content="center" style=" color: black">

        <fieldset id="basicInfo" style="width:auto; height:auto; background-color:whitesmoke">
            <p><h1>Đăng nhập</h1></p>



            <tr>
                <label for="email">Email:</label>
                <br />
                <input type="email" id="email" onkeydown="if(event.keyCode === 13) {event.preventDefault(); document.getElementById('password').focus();}" required>
            </tr>
            <br />
            <br />
            <tr>

                <label for="password">Mật khẩu:</label>
                <br />
                <input type="password" id="password" onkeydown="if(event.keyCode === 13) {event.preventDefault(); document.getElementById('submit').click();}" required>

            </tr>
            <br />
            <br />
            <input type="checkbox" /> Ghi nhớ
            <br />
            <br />
            <button type="signup" id="signup" style="width:10%; height:auto;color:white; background-color:forestgreen">
                Đăng nhập
            </button>

            <br />
            <!--mấy cái link là để minh họa-->
            Chưa có tài khoản? Hãy <button type="submit" id="submit" style="width:8%; height:auto;color:white; background-color:forestgreen">
                <a style="color:white" target="_blank" href="http://localhost:64437/Home/Log">
                    Đăng ký
                </a>
            </button> hoặc <button type="signupfb" style="width:20%; height:auto;color:white; background-color:darkblue">
                <a style="color:white" target="_blank" href="https://www.facebook.com">Đăng nhập qua Facebook</a>

            </button>
            <br />
            <br />
            <br />
            <fieldset id="basicInfo" style="width: auto; height: auto; background-color: whitesmoke; color: grey">
                Quên mật khẩu?
                <br />
                <label for="email">Email:</label>
                <br />
                <input type="email" id="email" onkeydown="if(event.keyCode === 13) {event.preventDefault(); document.getElementById('password').focus();}" required>


                <br />

                <br />
                <button type="find" style="width:15%; height:auto;color:white; background-color:forestgreen">
                    <a style="color:white" target="_blank" href="http://localhost:64437/timlaimk.html">Tìm lại mật khẩu</a>
                </button>

            </fieldset>
        </fieldset>

        <div>
            @RenderBody()
        </div>

    </form>
    
</body>
</html>
