﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterQ
{
    public class LoginController
    {
        private static LoginController instance = new LoginController();
        LoginController(){
            
        }
        public static LoginController getInstance(){
            return instance;
        }
        //public async Task<UIReturn> AuthenuserAsync(Login input)
        //{
        //    if (isEmptyUserName(input)) return new UIReturn(input, false, "", Constants.emptyUserName);
        //    if (isEmptyPassword(input)) return new UIReturn(input, false, "", Constants.emptyPassword);
        //    if (!isValidEmail(input)) return new UIReturn(input, false, "", Constants.invalidEmail);

        //    //List<SampleJSONService> result = await SampleService.CallGetAsync();
        //    SampleJSONService result = await SampleService.CallPostAsync();

        //    UIReturn ret = new UIReturn(input);
        //    if (authen(input, result))
        //    {
        //        input.isLogin = true;
        //        MCust.login = input;
        //    }
        //    else
        //    {
        //        ret.setFail("", Constants.authenFail);
        //    }
        //    return ret;
        //}
        public UIReturn Authenuser(Login input)
        {
            if (String.IsNullOrEmpty(input.username)) return new UIReturn(input, false, Constants.GROUPS_VALIDATE, Constants.FUNCTIONS_EMPTY_INPUT, Constants.CODE_EMPTY_USERNAME);
            if (String.IsNullOrEmpty(input.password)) return new UIReturn(input, false, Constants.GROUPS_VALIDATE, Constants.FUNCTIONS_EMPTY_INPUT, Constants.CODE_EMPTY_PASSWORD);
            if (!Validate.email(input.username)) return new UIReturn(input, false, Constants.GROUPS_VALIDATE, Constants.FUNCTIONS_EMAIL, Constants.CODE_INVALID_EMAIL);

            LoginRs res = LoginService.getInstance().CallLogin(input);


            UIReturn ret = new UIReturn(input,res.header);
            return ret;
        }
        private bool authen(Login input, LoginRs loginuser)
        {
            return loginuser.member.email == input.username && loginuser.member.password == input.password;
        }

    }
}
