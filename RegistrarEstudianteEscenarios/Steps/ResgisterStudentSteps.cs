using ejercicios_ut3.Models;
using System;
using TechTalk.SpecFlow;

namespace RegistrarEstudianteEscenarios.Features
{
    [Binding]
    public sealed class ResgisterStudentSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Estudiante _registerStudent = new Estudiante();
        private int _result;

        public ResgisterStudentSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"name ""(.*)""")]
        public void GivenName(string name)
        {
            _registerStudent.Nombre = name;
        }
        
        [Given(@"lastname ""(.*)""")]
        public void GivenLastname(string lastname)
        {
            _registerStudent.Apellido = lastname;
        }
        
        [Given(@"number (.*)")]
        public void GivenNumber(int number)
        {
            _registerStudent.NroEstudiante = number;
        }
        
        [When(@"create button in pressed")]
        public void WhenCreateButtonInPressed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user should be created")]
        public void ThenTheUserShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
