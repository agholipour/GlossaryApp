using System;
using Glossary.Web.Controllers;
using Glossary.Web.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestStack.FluentMVCTesting;

namespace Glossary.Test
{
    [TestClass]
    public class GlossaryControllerTest
    {
        private GlossaryController _sut;
        private Mock<IUnitOfWork> _mockUnitMock;
        [TestInitialize]
        public void Setup()
        {
            _mockUnitMock = new Mock<IUnitOfWork>();
            _sut = new GlossaryController(_mockUnitMock.Object);
        }
        [TestMethod]
        public void Verify_Index_Action_Should_Return_ViewModel_Index()
        {
            _sut.WithCallTo(x => x.Index()).ShouldRenderView("Index");
        }
    }
}
