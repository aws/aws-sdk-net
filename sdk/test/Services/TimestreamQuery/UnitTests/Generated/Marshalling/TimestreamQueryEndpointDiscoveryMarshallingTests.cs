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
        public void CreateScheduledQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledQuery");
            var request = InstantiateClassGenerator.Execute<CreateScheduledQueryRequest>();
            var marshaller = new CreateScheduledQueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void DeleteScheduledQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteScheduledQuery");
            var request = InstantiateClassGenerator.Execute<DeleteScheduledQueryRequest>();
            var marshaller = new DeleteScheduledQueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void DescribeScheduledQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledQuery");
            var request = InstantiateClassGenerator.Execute<DescribeScheduledQueryRequest>();
            var marshaller = new DescribeScheduledQueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void ExecuteScheduledQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteScheduledQuery");
            var request = InstantiateClassGenerator.Execute<ExecuteScheduledQueryRequest>();
            var marshaller = new ExecuteScheduledQueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void ListScheduledQueriesEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListScheduledQueries");
            var request = InstantiateClassGenerator.Execute<ListScheduledQueriesRequest>();
            var marshaller = new ListScheduledQueriesEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void ListTagsForResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void PrepareQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("PrepareQuery");
            var request = InstantiateClassGenerator.Execute<PrepareQueryRequest>();
            var marshaller = new PrepareQueryEndpointDiscoveryMarshaller();

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
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void TagResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");
            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void UntagResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");
            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamQuery")]
        public void UpdateScheduledQueryEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScheduledQuery");
            var request = InstantiateClassGenerator.Execute<UpdateScheduledQueryRequest>();
            var marshaller = new UpdateScheduledQueryEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
    }
}