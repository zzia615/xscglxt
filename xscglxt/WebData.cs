using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class WebData
{
    public const string 登录用户 = "LoginUser";
    public const string 登录用户名 = "LoginUserName";
    /// <summary>
    /// 登录用户
    /// </summary>
    public static string LoginUser { get; set; }
    /// <summary>
    /// 登录用户名
    /// </summary>
    public static string LoginUserName { get; set; }
    /// <summary>
    /// 登录用户类别
    /// </summary>
    public static string LoginUserType{ get; set; }
    /// <summary>
    /// 系统名称
    /// </summary>
    public const string SystemTitle = "学生处管理系统";
    /// <summary>
    /// 当前打开的菜单名
    /// </summary>
    public static string CurrentMenu { get; set; }
    /// <summary>
    /// 系统菜单
    /// </summary>
    public static Dictionary<string,string> SysMenu
    {
        get
        {
            Dictionary<string, string> _menu = new Dictionary<string, string>();
            _menu.Add("首页", "Default.aspx");
            _menu.Add("用户管理", "Yhgl.aspx");
            _menu.Add("新生管理", "Xsgl.aspx");
            _menu.Add("毕业生管理", "Bysgl.aspx");
            _menu.Add("违纪生管理", "Wjsgl.aspx");
            _menu.Add("困难生管理", "Knsgl.aspx");
            _menu.Add("优秀生管理", "Yxsgl.aspx");
            return _menu;
        }
    }
}