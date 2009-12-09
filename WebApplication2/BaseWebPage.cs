using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using WebApplication1.Controllers;

namespace WebApplication1
{

    public class BaseWebPage : System.Web.UI.Page, IWebUI
    {

        public BaseWebPage()
        {

            Data = this.GetDAL();
        }

        /// <summary>
        /// Get access to my data!
        /// </summary>
        public IDataAccessLayer Data { get; private set; }

    }

    public interface IWebUI
    {
        /// <summary>
        /// Get access to my data!
        /// </summary>
        IDataAccessLayer Data { get; }
    }

    public interface IDataAccessLayer
    {

        IList<T> GetStuff<T>(int id);

    }

    public static class ExtensionStuff
    {
        
        public static IDataAccessLayer GetDAL(this BaseWebPage webPage)
        {
            return InnerGetMyDAL();
        }

        public static IDataAccessLayer GetDAL(this MyBaseController controller)
        {
            return InnerGetMyDAL();
        }

        private static IDataAccessLayer InnerGetMyDAL()
        {
            return new DataAccessLayer();
        }

    }

    internal class DataAccessLayer : IDataAccessLayer
    {
        #region Implementation of IDataAccessLayer

        public IList<T> GetStuff<T>(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
