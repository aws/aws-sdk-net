using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;

namespace AWSSDK_DotNet35.UnitTests.Generated.Customizations.ConstantClasses
{
    public class ConstantClassTestBase
    {
        private readonly ServiceModel _serviceModelUnderTest;

        public ConstantClassTestBase(string service)
        {
            _serviceModelUnderTest = Utils.LoadServiceModel(service);
        }

        private IEnumerable<string> GetConstantClassValues(IReflect constantClassType)
        {
            return constantClassType.GetFields(BindingFlags.Public | BindingFlags.Static)
                .Select(field => ((ConstantClass)field.GetValue(null)).Value);
        }

        private IEnumerable<string> GetServiceModelEnumValues(string enumName)
        {
            return _serviceModelUnderTest.Enumerations(false)
                .Where(en => en.Name == enumName)
                .SelectMany(en => en.EnumerationValues.Select(v => v.PropertyName));
        }

        public void AssertConstantsMatch(IReflect constantClassType, string enumName)
        {
            var constantClassValues = new HashSet<string>(GetConstantClassValues(constantClassType));
            var serviceModelEnumValues = new HashSet<string>(GetServiceModelEnumValues(enumName));
            Assert.IsTrue(constantClassValues.SetEquals(serviceModelEnumValues));
        }
    }
}
