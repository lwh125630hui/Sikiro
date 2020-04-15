﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GS.Interface.Customer.User
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckingPayPasswordRequest
    {
        [Required(ErrorMessage = "请输入用户ID")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "请输入支付密码")]
        public string PayPassword { get; set; }

    }
}
