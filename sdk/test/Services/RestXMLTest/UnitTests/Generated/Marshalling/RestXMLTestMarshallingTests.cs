/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rest-xml-test-2014-01-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RestXMLTest;
using Amazon.RestXMLTest.Model;
using Amazon.RestXMLTest.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public partial class RestXMLTestMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("rest-xml-test");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXMLTest")]
        public void MemberRefOpMarshallTest()
        {
            var operation = service_model.FindOperation("MemberRefOp");

            var request = InstantiateClassGenerator.Execute<MemberRefOpRequest>(operation);
            var marshaller = new MemberRefOpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("MemberRefOp", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXMLTest")]
        public void StaticOpMarshallTest()
        {
            var operation = service_model.FindOperation("StaticOp");

            var request = InstantiateClassGenerator.Execute<StaticOpRequest>(operation);
            var marshaller = new StaticOpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StaticOp", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXMLTest")]
        public void TestOperationMarshallTest()
        {
            var operation = service_model.FindOperation("TestOperation");

            var request = InstantiateClassGenerator.Execute<TestOperationRequest>(operation);
            var marshaller = new TestOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestOperation", request, internalRequest, service_model);

        }
    }
}