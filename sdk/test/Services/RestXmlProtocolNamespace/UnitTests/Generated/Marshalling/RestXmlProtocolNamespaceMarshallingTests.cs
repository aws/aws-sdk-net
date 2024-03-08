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
 * Do not modify this file. This file is generated from the rest-xml-protocol-namespace-2019-12-16.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RestXmlProtocolNamespace;
using Amazon.RestXmlProtocolNamespace.Model;
using Amazon.RestXmlProtocolNamespace.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class RestXmlProtocolNamespaceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("restxmlwithnamespace-tests-client");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocolNamespace")]
        public void SimpleScalarPropertiesMarshallTest()
        {
            var operation = service_model.FindOperation("SimpleScalarProperties");

            var request = InstantiateClassGenerator.Execute<SimpleScalarPropertiesRequest>(operation);
            var marshaller = new SimpleScalarPropertiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SimpleScalarProperties", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Foo","X-Foo_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as SimpleScalarPropertiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}