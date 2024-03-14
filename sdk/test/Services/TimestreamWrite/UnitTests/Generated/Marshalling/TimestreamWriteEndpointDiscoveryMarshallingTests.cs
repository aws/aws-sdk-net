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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.TimestreamWrite;
using Amazon.TimestreamWrite.Model;
using Amazon.TimestreamWrite.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class TimestreamWriteEndpointDiscoveryMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("timestream-write");
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void CreateBatchLoadTaskEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBatchLoadTask");
            var request = InstantiateClassGenerator.Execute<CreateBatchLoadTaskRequest>(operation);
            var marshaller = new CreateBatchLoadTaskEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void CreateDatabaseEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDatabase");
            var request = InstantiateClassGenerator.Execute<CreateDatabaseRequest>(operation);
            var marshaller = new CreateDatabaseEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void CreateTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTable");
            var request = InstantiateClassGenerator.Execute<CreateTableRequest>(operation);
            var marshaller = new CreateTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void DeleteDatabaseEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDatabase");
            var request = InstantiateClassGenerator.Execute<DeleteDatabaseRequest>(operation);
            var marshaller = new DeleteDatabaseEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void DeleteTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTable");
            var request = InstantiateClassGenerator.Execute<DeleteTableRequest>(operation);
            var marshaller = new DeleteTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void DescribeBatchLoadTaskEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBatchLoadTask");
            var request = InstantiateClassGenerator.Execute<DescribeBatchLoadTaskRequest>(operation);
            var marshaller = new DescribeBatchLoadTaskEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void DescribeDatabaseEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDatabase");
            var request = InstantiateClassGenerator.Execute<DescribeDatabaseRequest>(operation);
            var marshaller = new DescribeDatabaseEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void DescribeTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTable");
            var request = InstantiateClassGenerator.Execute<DescribeTableRequest>(operation);
            var marshaller = new DescribeTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void ListBatchLoadTasksEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListBatchLoadTasks");
            var request = InstantiateClassGenerator.Execute<ListBatchLoadTasksRequest>(operation);
            var marshaller = new ListBatchLoadTasksEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void ListDatabasesEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListDatabases");
            var request = InstantiateClassGenerator.Execute<ListDatabasesRequest>(operation);
            var marshaller = new ListDatabasesEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void ListTablesEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>(operation);
            var marshaller = new ListTablesEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void ListTagsForResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>(operation);
            var marshaller = new ListTagsForResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void ResumeBatchLoadTaskEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeBatchLoadTask");
            var request = InstantiateClassGenerator.Execute<ResumeBatchLoadTaskRequest>(operation);
            var marshaller = new ResumeBatchLoadTaskEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void TagResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");
            var request = InstantiateClassGenerator.Execute<TagResourceRequest>(operation);
            var marshaller = new TagResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void UntagResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");
            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>(operation);
            var marshaller = new UntagResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void UpdateDatabaseEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDatabase");
            var request = InstantiateClassGenerator.Execute<UpdateDatabaseRequest>(operation);
            var marshaller = new UpdateDatabaseEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void UpdateTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateTable");
            var request = InstantiateClassGenerator.Execute<UpdateTableRequest>(operation);
            var marshaller = new UpdateTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("TimestreamWrite")]
        public void WriteRecordsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("WriteRecords");
            var request = InstantiateClassGenerator.Execute<WriteRecordsRequest>(operation);
            var marshaller = new WriteRecordsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
    }
}