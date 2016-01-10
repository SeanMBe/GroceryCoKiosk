﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GroceryCo.Kiosk.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Checkout with items with additional item discount")]
    public partial class CheckoutWithItemsWithAdditionalItemDiscountFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "04 - checkout with additional item discount.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Checkout with items with additional item discount", "In order to improve sales\nAs the business\nI want to have additional item discount" +
                    "s", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("When checking out with a couple items")]
        public virtual void WhenCheckingOutWithACoupleItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When checking out with a couple items", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Barcode",
                        "Price"});
            table1.AddRow(new string[] {
                        "apple",
                        "0.75"});
            table1.AddRow(new string[] {
                        "banana",
                        "1.00"});
#line 7
 testRunner.Given("I have the following products", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Barcode",
                        "Quantity",
                        "NumberDiscounted",
                        "DiscountRate"});
            table2.AddRow(new string[] {
                        "apple",
                        "1",
                        "1",
                        "100"});
#line 11
 testRunner.And("I have additional item discounts", ((string)(null)), table2, "And ");
#line 14
 testRunner.And("I have no quantity discounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table3.AddRow(new string[] {
                        "apple"});
            table3.AddRow(new string[] {
                        "banana"});
            table3.AddRow(new string[] {
                        "apple"});
            table3.AddRow(new string[] {
                        "apple"});
            table3.AddRow(new string[] {
                        "apple"});
            table3.AddRow(new string[] {
                        "apple"});
#line 15
 testRunner.And("my cart is", ((string)(null)), table3, "And ");
#line 23
 testRunner.When("I checkout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines..."});
            table4.AddRow(new string[] {
                        "Receipt:"});
            table4.AddRow(new string[] {
                        "5 apple @ $0.75 is $3.75"});
            table4.AddRow(new string[] {
                        "***Discount on apple: Buy 1 apple get 1 at $0.00, New Price $2.25, Savings $1.50"});
            table4.AddRow(new string[] {
                        "1 banana @ $1.00 is $1.00"});
            table4.AddRow(new string[] {
                        "Total is $3.25"});
#line 24
 testRunner.Then("I should see expected receipt", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When checking out with a couple items at 50% discount")]
        public virtual void WhenCheckingOutWithACoupleItemsAt50Discount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When checking out with a couple items at 50% discount", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Barcode",
                        "Price"});
            table5.AddRow(new string[] {
                        "apple",
                        "0.75"});
            table5.AddRow(new string[] {
                        "banana",
                        "1.00"});
#line 34
 testRunner.Given("I have the following products", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Barcode",
                        "Quantity",
                        "NumberDiscounted",
                        "DiscountRate"});
            table6.AddRow(new string[] {
                        "apple",
                        "1",
                        "1",
                        "50"});
#line 38
 testRunner.And("I have additional item discounts", ((string)(null)), table6, "And ");
#line 41
 testRunner.And("I have no quantity discounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table7.AddRow(new string[] {
                        "apple"});
            table7.AddRow(new string[] {
                        "banana"});
            table7.AddRow(new string[] {
                        "apple"});
            table7.AddRow(new string[] {
                        "apple"});
            table7.AddRow(new string[] {
                        "apple"});
            table7.AddRow(new string[] {
                        "apple"});
#line 42
 testRunner.And("my cart is", ((string)(null)), table7, "And ");
#line 50
 testRunner.When("I checkout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines..."});
            table8.AddRow(new string[] {
                        "Receipt:"});
            table8.AddRow(new string[] {
                        "5 apple @ $0.75 is $3.75"});
            table8.AddRow(new string[] {
                        "***Discount on apple: Buy 1 apple get 1 at $0.38, New Price $3.00, Savings $0.75"});
            table8.AddRow(new string[] {
                        "1 banana @ $1.00 is $1.00"});
            table8.AddRow(new string[] {
                        "Total is $4.00"});
#line 51
 testRunner.Then("I should see expected receipt", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion