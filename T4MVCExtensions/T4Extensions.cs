﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public static class T4Extensions
    {
        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result)
        {
            return htmlHelper.ActionLink(linkText, result, null, null, null, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes)
        {
            return htmlHelper.ActionLink(linkText, result, htmlAttributes, null, null, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes, string protocol)
        {
            return htmlHelper.ActionLink(linkText, result, htmlAttributes, protocol, null, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes, string protocol, string hostName)
        {
            return htmlHelper.ActionLink(linkText, result, htmlAttributes, protocol, hostName, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes, string protocol, string hostName, string fragment)
        {
            return htmlHelper.RouteLink(linkText, null, protocol ?? result.GetT4MVCResult().Protocol, hostName, fragment, result.GetRouteValueDictionary(), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes)
        {
            return htmlHelper.ActionLink(linkText, result, htmlAttributes, null, null, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol)
        {
            return htmlHelper.ActionLink(linkText, result, htmlAttributes, protocol, null, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol, string hostName)
        {
            return htmlHelper.ActionLink(linkText, result, htmlAttributes, protocol, hostName, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol, string hostName, string fragment)
        {
            return htmlHelper.RouteLink(linkText, null, protocol ?? result.GetT4MVCResult().Protocol, hostName, fragment, result.GetRouteValueDictionary(), htmlAttributes);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes)
        {
            return htmlHelper.RouteLink(linkText, null, result, htmlAttributes, null, null, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, object htmlAttributes)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, htmlAttributes, null, null, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, object htmlAttributes, string protocol)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, htmlAttributes, protocol, null, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, object htmlAttributes, string protocol, string hostName)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, htmlAttributes, protocol, hostName, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, object htmlAttributes, string protocol, string hostName, string fragment)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), protocol, hostName, fragment);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes)
        {
            return htmlHelper.RouteLink(linkText, null, result, htmlAttributes, null, null, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, IDictionary<string, object> htmlAttributes)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, htmlAttributes, null, null, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, htmlAttributes, protocol, null, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol, string hostName)
        {
            return htmlHelper.RouteLink(linkText, routeName, result, htmlAttributes, protocol, hostName, null);
        }

        public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, string linkText, string routeName, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol, string hostName, string fragment)
        {
            return htmlHelper.RouteLink(linkText, routeName, protocol ?? result.GetT4MVCResult().Protocol, hostName, fragment, result.GetRouteValueDictionary(), htmlAttributes);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result)
        {
            return htmlHelper.BeginForm(result, FormMethod.Post);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod)
        {
            return htmlHelper.BeginForm(result, formMethod, null);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, object htmlAttributes)
        {
            return BeginForm(htmlHelper, result, formMethod, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, IDictionary<string, object> htmlAttributes)
        {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, formMethod, htmlAttributes);
        }

        public static MvcForm BeginRouteForm(this HtmlHelper htmlHelper, ActionResult result)
        {
            return htmlHelper.BeginRouteForm(null, result, FormMethod.Post, null);
        }

        public static MvcForm BeginRouteForm(this HtmlHelper htmlHelper, string routeName, ActionResult result)
        {
            return htmlHelper.BeginRouteForm(routeName, result, FormMethod.Post, null);
        }

        public static MvcForm BeginRouteForm(this HtmlHelper htmlHelper, string routeName, ActionResult result, FormMethod method)
        {
            return htmlHelper.BeginRouteForm(routeName, result, method, null);
        }

        public static MvcForm BeginRouteForm(this HtmlHelper htmlHelper, string routeName, ActionResult result, FormMethod method, object htmlAttributes)
        {
            return htmlHelper.BeginRouteForm(routeName, result, method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm(this HtmlHelper htmlHelper, string routeName, ActionResult result, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return htmlHelper.BeginRouteForm(routeName, result.GetRouteValueDictionary(), method, htmlAttributes);
        }

        public static void RenderAction(this HtmlHelper htmlHelper, ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            htmlHelper.RenderAction(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        public static MvcHtmlString Action(this HtmlHelper htmlHelper, ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.Action(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        /// <summary>
        /// If specific route can be found, return that route with the parameter tokens in route string.
        /// </summary>
        public static string JavaScriptReplacableUrl(this UrlHelper urlHelper, ActionResult result)
        {
            var rvd = result.GetRouteValueDictionary();
            string area = string.Empty;
            object token;

            if (rvd.TryGetValue("area", out token))
                area = token.ToString();

            if (!rvd.TryGetValue("controller", out token))
                throw new Exception("T4MVC JavascriptReplacableUrl could not locate controller in source dictionary");
            string controller = token.ToString();

            if (!rvd.TryGetValue("action", out token))
                throw new Exception("T4MVC JavascriptReplacableUrl could not locate action in source dictionary");
            string action = token.ToString();

            var specificActionUrl = (from r in RouteTable.Routes.OfType<Route>()
                                     where r.DataTokens != null && r.Defaults != null
                                     && r.DataTokens.Any(dt => string.Compare(dt.Key, "area", StringComparison.InvariantCultureIgnoreCase) == 0
                                         && string.Compare(dt.Value.ToString(), area, StringComparison.InvariantCultureIgnoreCase) == 0)
                                     && r.Defaults.Any(dt => string.Compare(dt.Key, "controller", StringComparison.InvariantCultureIgnoreCase) == 0
                                         && string.Compare(dt.Value.ToString(), controller, StringComparison.InvariantCultureIgnoreCase) == 0)
                                     && r.Defaults.Any(dt => string.Compare(dt.Key, "action", StringComparison.InvariantCultureIgnoreCase) == 0
                                         && string.Compare(dt.Value.ToString(), action, StringComparison.InvariantCultureIgnoreCase) == 0)
                                     select r.Url).FirstOrDefault();

            if (String.IsNullOrEmpty(specificActionUrl))
                return urlHelper.RouteUrl(null, result.GetRouteValueDictionary());
            return "/" + specificActionUrl;
        }

        public static string Action(this UrlHelper urlHelper, ActionResult result)
        {
            return urlHelper.Action(result, null, null);
        }

        public static string Action(this UrlHelper urlHelper, ActionResult result, string protocol = null, string hostName = null)
        {
            return urlHelper.RouteUrl(null, result.GetRouteValueDictionary(), protocol ?? result.GetT4MVCResult().Protocol, hostName);
        }

        public static string ActionAbsolute(this UrlHelper urlHelper, ActionResult result)
        {
            return string.Format("{0}{1}", urlHelper.RequestContext.HttpContext.Request.Url.GetLeftPart(UriPartial.Authority),
                urlHelper.RouteUrl(result.GetRouteValueDictionary()));
        }

        public static string RouteUrl(this UrlHelper urlHelper, ActionResult result)
        {
            return urlHelper.RouteUrl(null, result, null, null);
        }

        public static string RouteUrl(this UrlHelper urlHelper, string routeName, ActionResult result)
        {
            return urlHelper.RouteUrl(routeName, result, null, null);
        }

        public static string RouteUrl(this UrlHelper urlHelper, string routeName, ActionResult result, string protocol)
        {
            return urlHelper.RouteUrl(routeName, result, protocol, null);
        }

        public static string RouteUrl(this UrlHelper urlHelper, string routeName, ActionResult result, string protocol, string hostName)
        {
            return urlHelper.RouteUrl(routeName, result.GetRouteValueDictionary(), protocol ?? result.GetT4MVCResult().Protocol, hostName);
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions)
        {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions);
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static MvcHtmlString RouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, ActionResult result, AjaxOptions ajaxOptions)
        {
            return ajaxHelper.RouteLink(linkText, routeName, result, ajaxOptions, null);
        }

        public static MvcHtmlString RouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            return ajaxHelper.RouteLink(linkText, routeName, result, ajaxOptions, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString RouteLink(this AjaxHelper ajaxHelper, string linkText, string routeName, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            return ajaxHelper.RouteLink(linkText, routeName, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions)
        {
            return ajaxHelper.BeginForm(result, ajaxOptions, null);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            return BeginForm(ajaxHelper, result, ajaxOptions, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var callInfo = result.GetT4MVCResult();
            return ajaxHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, ajaxOptions, htmlAttributes);
        }

        public static MvcForm BeginRouteForm(this AjaxHelper ajaxHelper, string routeName, ActionResult result, AjaxOptions ajaxOptions)
        {
            return ajaxHelper.BeginRouteForm(routeName, result, ajaxOptions, null);
        }

        public static MvcForm BeginRouteForm(this AjaxHelper ajaxHelper, string routeName, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            return ajaxHelper.BeginRouteForm(routeName, result, ajaxOptions, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm(this AjaxHelper ajaxHelper, string routeName, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            return ajaxHelper.BeginRouteForm(routeName, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result)
        {
            return MapRoute(routes, name, url, result, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults)
        {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, string[] namespaces)
        {
            return MapRoute(routes, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints)
        {
            return MapRoute(routes, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, string[] namespaces)
        {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces)
        {
            // Create and add the route
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            routes.Add(name, route);
            return route;
        }

        // Note: can't name the AreaRegistrationContext methods 'MapRoute', as that conflicts with the existing methods
        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result)
        {
            return MapRouteArea(context, name, url, result, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults)
        {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, string[] namespaces)
        {
            return MapRouteArea(context, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints)
        {
            return MapRouteArea(context, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, string[] namespaces)
        {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces)
        {
            // Create and add the route
            if ((namespaces == null) && (context.Namespaces != null))
            {
                namespaces = context.Namespaces.ToArray();
            }
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            context.Routes.Add(name, route);
            route.DataTokens["area"] = context.AreaName;
            bool useNamespaceFallback = (namespaces == null) || (namespaces.Length == 0);
            route.DataTokens["UseNamespaceFallback"] = useNamespaceFallback;
            return route;
        }

        private static Route CreateRoute(string url, ActionResult result, object defaults, object constraints, string[] namespaces)
        {
            // Start by adding the default values from the anonymous object (if any)
            var routeValues = new RouteValueDictionary(defaults);

            // Then add the Controller/Action names and the parameters from the call
            foreach (var pair in result.GetRouteValueDictionary())
            {
                routeValues.Add(pair.Key, pair.Value);
            }

            var routeConstraints = new RouteValueDictionary(constraints);

            // Create and add the route
            var route = new Route(url, routeValues, routeConstraints, new MvcRouteHandler());

            route.DataTokens = new RouteValueDictionary();

            if (namespaces != null && namespaces.Length > 0)
            {
                route.DataTokens["Namespaces"] = namespaces;
            }

            return route;
        }

        public static IT4MVCActionResult GetT4MVCResult(this ActionResult result)
        {
            var t4MVCResult = result as IT4MVCActionResult;
            if (t4MVCResult == null)
            {
                throw new InvalidOperationException("T4MVC was called incorrectly. You may need to force it to regenerate by right clicking on T4MVC.tt and choosing Run Custom Tool");
            }
            return t4MVCResult;
        }

        public static RouteValueDictionary GetRouteValueDictionary(this ActionResult result)
        {
            return result.GetT4MVCResult().RouteValueDictionary;
        }

        public static ActionResult AddRouteValues(this ActionResult result, object routeValues)
        {
            return result.AddRouteValues(new RouteValueDictionary(routeValues));
        }

        public static ActionResult AddRouteValues(this ActionResult result, RouteValueDictionary routeValues)
        {
            RouteValueDictionary currentRouteValues = result.GetRouteValueDictionary();

            // Add all the extra values
            foreach (var pair in routeValues)
            {
                ModelUnbinderHelpers.AddRouteValues(currentRouteValues, pair.Key, pair.Value);
            }

            return result;
        }

        public static ActionResult AddRouteValues(this ActionResult result, System.Collections.Specialized.NameValueCollection nameValueCollection)
        {
            // Copy all the values from the NameValueCollection into the route dictionary
            if (nameValueCollection.AllKeys.Any(m => m == null))  //if it has a null, the CopyTo extension will crash!
            {
                var filtered = new System.Collections.Specialized.NameValueCollection(nameValueCollection);
                filtered.Remove(null);
                filtered.CopyTo(result.GetRouteValueDictionary());
            }
            else
                nameValueCollection.CopyTo(result.GetRouteValueDictionary());
            return result;
        }

        public static ActionResult AddRouteValue(this ActionResult result, string name, object value)
        {
            RouteValueDictionary routeValues = result.GetRouteValueDictionary();
            ModelUnbinderHelpers.AddRouteValues(routeValues, name, value);
            return result;
        }

        public static void InitMVCT4Result(this IT4MVCActionResult result, string area, string controller, string action, string protocol = null)
        {
            result.Controller = controller;
            result.Action = action;
            result.Protocol = protocol;
            result.RouteValueDictionary = new RouteValueDictionary();
            result.RouteValueDictionary.Add("Area", area ?? "");
            result.RouteValueDictionary.Add("Controller", controller);
            result.RouteValueDictionary.Add("Action", action);
        }

        public static bool FileExists(string virtualPath)
        {
            if (!HostingEnvironment.IsHosted) return false;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return System.IO.File.Exists(filePath);
        }

        static DateTime CenturyBegin = new DateTime(2001, 1, 1);
        public static string TimestampString(string virtualPath)
        {
            if (!HostingEnvironment.IsHosted) return string.Empty;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return Convert.ToString((System.IO.File.GetLastWriteTimeUtc(filePath).Ticks - CenturyBegin.Ticks) / 1000000000, 16);
        }
    }
}