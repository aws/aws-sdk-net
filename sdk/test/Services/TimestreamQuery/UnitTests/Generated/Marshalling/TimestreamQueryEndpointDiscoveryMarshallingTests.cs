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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.TimestreamQuery;
using Amazon.TimestreamQuery.Model;
using Amazon.TimestreamQuery.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class TimestreamQueryEndpointDiscoveryMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("timestream-query");
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void CancelQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CancelQuery");
            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void QueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("Query");
            var request = InstantiateClassGenerator.Execute<QueryRequest>();
            var marshaller = new QueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
    }
}