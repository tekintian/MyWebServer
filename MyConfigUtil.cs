using System.Configuration;

namespace MyWebServer
{
    public class MyConfigUtil
    {
        //保存app 配置项目
        public static void Save(string key, string val)
        {
            bool isAdd = true;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //判断配置文件中是否存在键为key的项, 存在,则修改,否则增加
            if (KeyExist(key))
            {
                //修改配置文件数据
                config.AppSettings.Settings[key].Value = val;
            }
            else
            {
                //添加配置文件的项，键为keyn，值为val
                config.AppSettings.Settings.Add(key, val);
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        //根据key读取配置信息
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        //判断配置文件中是否存在键为key的项
        public static bool KeyExist(string key)
        {
            bool isExist = false;
            foreach (string k in ConfigurationManager.AppSettings)
            {
                if (k == key)
                {
                    isExist = true;
                }
            }
            return isExist;
        }
    }
}
