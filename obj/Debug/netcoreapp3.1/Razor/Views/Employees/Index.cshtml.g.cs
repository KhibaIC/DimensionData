#pragma checksum "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a709f3ac7cf9a6a4cf311ba0ae963eba3b251a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\_ViewImports.cshtml"
using CMPG323Project2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\_ViewImports.cshtml"
using CMPG323Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a709f3ac7cf9a6a4cf311ba0ae963eba3b251a", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f546a656b2d71e2e59f0756d94cd59b361378b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project2.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a709f3ac7cf9a6a4cf311ba0ae963eba3b251a4574", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.employeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ove18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.educationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.distanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.workLifeBalace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.maritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.overTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.businessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.numCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.empCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.hourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.standardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.jobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.jobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.jobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.monthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.monthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 85 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.percentageSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 88 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.performanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 91 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.environmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 94 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.stockOptionlevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 97 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.relationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 100 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.totalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 103 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.traningTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 106 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.traningAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 109 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.yearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 112 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.yearsSinceLastpromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 115 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.yearsWithCurrentManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 121 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.employeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ove18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.educationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.distanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.workLifeBalace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.maritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.overTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.businessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 157 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.numCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 160 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 163 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 166 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.dailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 169 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.empCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 172 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.hourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 175 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.standardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 178 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.jobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 181 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.jobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 184 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.jobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 187 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.monthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 190 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.monthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 193 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.percentageSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 196 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.performanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 199 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.environmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 202 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.stockOptionlevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 205 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.relationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 208 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.totalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 211 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.traningTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 214 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.traningAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 217 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.yearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 220 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.yearsSinceLastpromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 223 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.yearsWithCurrentManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a709f3ac7cf9a6a4cf311ba0ae963eba3b251a27950", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 226 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
                                       WriteLiteral(item.employeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a709f3ac7cf9a6a4cf311ba0ae963eba3b251a30126", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 227 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
                                          WriteLiteral(item.employeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a709f3ac7cf9a6a4cf311ba0ae963eba3b251a32308", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 228 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
                                         WriteLiteral(item.employeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 231 "C:\Users\itumeleng\source\repos\CMPG323Project2\Views\Employees\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project2.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591