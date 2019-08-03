using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace OFBX.Helpers
{
    public class NetworkHelper
    {
        public static string GetConnectionURL(ConnectionSecurity security)
        {
            var ServerIPValue = Preferences.Get("ServerIP", "");
            var ServiceNameValue = Preferences.Get("ServiceName", "");
            if (security==ConnectionSecurity.Unsecure)
            {
                return "http://"+ ServerIPValue + "/" + ServiceNameValue + "/api/";
            }
            else
            {
                return "https://" + ServerIPValue + "/" + ServiceNameValue + "/api/";
            }            
        }

        public static string TestConnection = "TestConnection";

        public enum ConnectionSecurity
        {
            Unsecure = 1,
            Secure
        }
    }
}
