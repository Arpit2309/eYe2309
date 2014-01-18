Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting.Web

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports MyFirst



'''<summary>
'''This is a test class for _DefaultTest and is intended
'''to contain all _DefaultTest Unit Tests
'''</summary>
<TestClass()> _
Public Class _DefaultTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    'TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    ' http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    ' whether you are testing a page, web service, or a WCF service.
    '''<summary>
    '''A test for Page_Load
    '''</summary>
    <TestMethod(), _
     HostType("ASP.NET"), _
     AspNetDevelopmentServerHost("C:\Users\Arpit\Documents\Visual Studio 2010\Projects\MyFirst\MyFirst", "/"), _
     UrlToTest("http://localhost:1057/"), _
     DeploymentItem("MyFirst.dll")> _
    Public Sub Page_LoadTest()
        Dim target As _Default_Accessor = New _Default_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Page_Load(sender, e)
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
