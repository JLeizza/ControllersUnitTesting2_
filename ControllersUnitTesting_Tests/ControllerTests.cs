using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControllersUnitTesting2_;
using ControllersUnitTesting2_.Models;
using ControllersUnitTesting2_.Services;
using Moq;
using ControllersUnitTesting2_.Controllers;

namespace ControllersUnitTesting_Tests
{
    [TestClass]
    internal class ControllerTests
    {
        private Mock<IClientService> _clientServiceMock;
        private  ClientController _controller;

        [TestMethod]
        public void GetAllClientsTest_ShouldReturnOkResult()
        {
            //Arrange
            var mockClients = new List<Client>
            {
                new Client {Id=12, Name="Julian", Money=200, User="j_ulian" },
                new Client {Id=14, Name="Ernesto", Money=-200, User="Nesto" }
            };
            //Esta parte es la que me tiro chat gpt. Entiendo que lo que hace es usar el método setup de mock, pasarle por parametro el metodo de client service, y decirle que devuelva mockclients, no?
            _clientServiceMock.Setup(ClientService => ClientService.GetAll()).Returns(mockClients);
            //Act
            var result = _controller.GetClients();
           
            var okResult = result.Result as OkObjectResult;

            //Assert
            Assert.AreEqual(result, mockClients);
        }
    }
}
