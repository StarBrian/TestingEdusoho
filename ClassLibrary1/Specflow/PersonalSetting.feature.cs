﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ClassLibrary1.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PersonalSetting")]
    public partial class PersonalSettingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PersonalSetting.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PersonalSetting", "\tIn order to update my personal info\r\n\tAs a user\r\n\tI want to insert user informat" +
                    "ion", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert user information - Validation")]
        [NUnit.Framework.CategoryAttribute("UserInfomration")]
        public virtual void InsertUserInformation_Validation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert user information - Validation", new string[] {
                        "UserInfomration"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "username",
                        "password",
                        "rmb"});
            table1.AddRow(new string[] {
                        "test002",
                        "Test1234",
                        "false"});
#line 8
 testRunner.Given("I have logged in my account", ((string)(null)), table1, "Given ");
#line 11
 testRunner.And("I opened personal setting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ID",
                        "Phone",
                        "Company",
                        "Job",
                        "Title",
                        "Signature",
                        "Site",
                        "Weibo",
                        "QQ"});
            table2.AddRow(new string[] {
                        "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        "aaaa",
                        "qq",
                        "abc",
                        "Tester",
                        "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        "Hello",
                        "sss",
                        "ss",
                        "aaaaa"});
#line 12
 testRunner.And("I updated my personal information", ((string)(null)), table2, "And ");
#line 15
 testRunner.When("I pressed save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "error"});
            table3.AddRow(new string[] {
                        "最多只能输入 18 个字符"});
            table3.AddRow(new string[] {
                        "请正确输入您的身份证号码"});
            table3.AddRow(new string[] {
                        "请输入正确的手机号"});
            table3.AddRow(new string[] {
                        "最多只能输入 24 个字符"});
            table3.AddRow(new string[] {
                        "地址不正确，须以http://或者https://开头。"});
            table3.AddRow(new string[] {
                        "地址不正确，须以http://或者https://开头。"});
            table3.AddRow(new string[] {
                        "请输入正确的QQ号"});
#line 16
    testRunner.Then("The error messages should show up on the page", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert user information - Happy path")]
        public virtual void InsertUserInformation_HappyPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert user information - Happy path", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "username",
                        "password",
                        "rmb"});
            table4.AddRow(new string[] {
                        "test002",
                        "Test1234",
                        "false"});
#line 28
 testRunner.Given("I have logged in my account", ((string)(null)), table4, "Given ");
#line 31
 testRunner.And("I opened personal setting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ID",
                        "Phone",
                        "Company",
                        "Job",
                        "Title",
                        "Signature",
                        "Site",
                        "Weibo",
                        "QQ"});
            table5.AddRow(new string[] {
                        "Test001",
                        "512554199901230233",
                        "13588765420",
                        "fonefix",
                        "Tester",
                        "aa",
                        "BZ",
                        "https://www.google.com/",
                        "https://www.google.com/",
                        "1234567"});
#line 32
 testRunner.And("I updated my personal information", ((string)(null)), table5, "And ");
#line 35
 testRunner.When("I pressed save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("The 基础信息保存成功 message should show upon the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
