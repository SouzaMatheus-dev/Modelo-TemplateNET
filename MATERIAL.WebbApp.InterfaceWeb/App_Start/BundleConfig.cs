using System.Web;
using System.Web.Optimization;

namespace MATERIAL.WebbApp.InterfaceWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/Scripts/popper.min.js")
                .Include("~/Scripts/moment.min.js")
                .Include("~/Scripts/bootstrap-material-design.min.js")
                .Include("~/Scripts/perfect-scrollbar.jquery.min.js")
                .Include("~/Scripts/bootstrap-datetimepicker.min.js")
                .Include("~/Scripts/bootstrap-notify.js")
                .Include("~/Scripts/bootstrap-selectpicker.js")
                .Include("~/Scripts/bootstrap-tagsinput.js")
                .Include("~/Scripts/core.js")
                .Include("~/Scripts/jasny-bootstrap.min.js")
                .Include("~/Scripts/jquery.bootstrap-wizard.js")
                .Include("~/Scripts/jquery.dataTables.min.js")
                .Include("~/Scripts/jquery.validate.min.js")
                .Include("~/Scripts/jquery-jvectormap.js")
                .Include("~/Scripts/jquery.sharre.js")
                .Include("~/Scripts/nouislider.min.js")
                .Include("~/Scripts/sweetalert2.js")
                .Include("~/Scripts/material-dashboard.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/material-dashboard.min.css"));
        }
    }
}
