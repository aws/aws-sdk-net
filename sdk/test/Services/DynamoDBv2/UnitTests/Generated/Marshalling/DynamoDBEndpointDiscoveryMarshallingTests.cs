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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class DynamoDBEndpointDiscoveryMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("dynamodb");
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void BatchGetItemEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("BatchGetItem");
            var request = InstantiateClassGenerator.Execute<BatchGetItemRequest>();
            var marshaller = new BatchGetItemEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void BatchWriteItemEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("BatchWriteItem");
            var request = InstantiateClassGenerator.Execute<BatchWriteItemRequest>();
            var marshaller = new BatchWriteItemEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void CreateBackupEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackup");
            var request = InstantiateClassGenerator.Execute<CreateBackupRequest>();
            var marshaller = new CreateBackupEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void CreateGlobalTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGlobalTable");
            var request = InstantiateClassGenerator.Execute<CreateGlobalTableRequest>();
            var marshaller = new CreateGlobalTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void CreateTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTable");
            var request = InstantiateClassGenerator.Execute<CreateTableRequest>();
            var marshaller = new CreateTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DeleteBackupEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackup");
            var request = InstantiateClassGenerator.Execute<DeleteBackupRequest>();
            var marshaller = new DeleteBackupEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DeleteItemEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteItem");
            var request = InstantiateClassGenerator.Execute<DeleteItemRequest>();
            var marshaller = new DeleteItemEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DeleteTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTable");
            var request = InstantiateClassGenerator.Execute<DeleteTableRequest>();
            var marshaller = new DeleteTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeBackupEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBackup");
            var request = InstantiateClassGenerator.Execute<DescribeBackupRequest>();
            var marshaller = new DescribeBackupEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeContinuousBackupsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeContinuousBackups");
            var request = InstantiateClassGenerator.Execute<DescribeContinuousBackupsRequest>();
            var marshaller = new DescribeContinuousBackupsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeGlobalTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeGlobalTable");
            var request = InstantiateClassGenerator.Execute<DescribeGlobalTableRequest>();
            var marshaller = new DescribeGlobalTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeGlobalTableSettingsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeGlobalTableSettings");
            var request = InstantiateClassGenerator.Execute<DescribeGlobalTableSettingsRequest>();
            var marshaller = new DescribeGlobalTableSettingsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeKinesisStreamingDestinationEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeKinesisStreamingDestination");
            var request = InstantiateClassGenerator.Execute<DescribeKinesisStreamingDestinationRequest>();
            var marshaller = new DescribeKinesisStreamingDestinationEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeLimitsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLimits");
            var request = InstantiateClassGenerator.Execute<DescribeLimitsRequest>();
            var marshaller = new DescribeLimitsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTable");
            var request = InstantiateClassGenerator.Execute<DescribeTableRequest>();
            var marshaller = new DescribeTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DescribeTimeToLiveEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTimeToLive");
            var request = InstantiateClassGenerator.Execute<DescribeTimeToLiveRequest>();
            var marshaller = new DescribeTimeToLiveEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void DisableKinesisStreamingDestinationEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DisableKinesisStreamingDestination");
            var request = InstantiateClassGenerator.Execute<DisableKinesisStreamingDestinationRequest>();
            var marshaller = new DisableKinesisStreamingDestinationEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void EnableKinesisStreamingDestinationEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("EnableKinesisStreamingDestination");
            var request = InstantiateClassGenerator.Execute<EnableKinesisStreamingDestinationRequest>();
            var marshaller = new EnableKinesisStreamingDestinationEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void GetItemEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("GetItem");
            var request = InstantiateClassGenerator.Execute<GetItemRequest>();
            var marshaller = new GetItemEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void ListBackupsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackups");
            var request = InstantiateClassGenerator.Execute<ListBackupsRequest>();
            var marshaller = new ListBackupsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void ListGlobalTablesEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListGlobalTables");
            var request = InstantiateClassGenerator.Execute<ListGlobalTablesRequest>();
            var marshaller = new ListGlobalTablesEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void ListTablesEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void ListTagsOfResourceEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsOfResource");
            var request = InstantiateClassGenerator.Execute<ListTagsOfResourceRequest>();
            var marshaller = new ListTagsOfResourceEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void PutItemEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("PutItem");
            var request = InstantiateClassGenerator.Execute<PutItemRequest>();
            var marshaller = new PutItemEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
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
        [TestCategory("DynamoDBv2")]
        public void RestoreTableFromBackupEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromBackup");
            var request = InstantiateClassGenerator.Execute<RestoreTableFromBackupRequest>();
            var marshaller = new RestoreTableFromBackupEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void RestoreTableToPointInTimeEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableToPointInTime");
            var request = InstantiateClassGenerator.Execute<RestoreTableToPointInTimeRequest>();
            var marshaller = new RestoreTableToPointInTimeEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void ScanEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("Scan");
            var request = InstantiateClassGenerator.Execute<ScanRequest>();
            var marshaller = new ScanEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
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
        [TestCategory("DynamoDBv2")]
        public void TransactGetItemsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("TransactGetItems");
            var request = InstantiateClassGenerator.Execute<TransactGetItemsRequest>();
            var marshaller = new TransactGetItemsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void TransactWriteItemsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("TransactWriteItems");
            var request = InstantiateClassGenerator.Execute<TransactWriteItemsRequest>();
            var marshaller = new TransactWriteItemsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
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
        [TestCategory("DynamoDBv2")]
        public void UpdateContinuousBackupsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateContinuousBackups");
            var request = InstantiateClassGenerator.Execute<UpdateContinuousBackupsRequest>();
            var marshaller = new UpdateContinuousBackupsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void UpdateGlobalTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGlobalTable");
            var request = InstantiateClassGenerator.Execute<UpdateGlobalTableRequest>();
            var marshaller = new UpdateGlobalTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void UpdateGlobalTableSettingsEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGlobalTableSettings");
            var request = InstantiateClassGenerator.Execute<UpdateGlobalTableSettingsRequest>();
            var marshaller = new UpdateGlobalTableSettingsEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void UpdateItemEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateItem");
            var request = InstantiateClassGenerator.Execute<UpdateItemRequest>();
            var marshaller = new UpdateItemEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void UpdateTableEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateTable");
            var request = InstantiateClassGenerator.Execute<UpdateTableRequest>();
            var marshaller = new UpdateTableEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
 
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("DynamoDBv2")]
        public void UpdateTimeToLiveEndpointDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateTimeToLive");
            var request = InstantiateClassGenerator.Execute<UpdateTimeToLiveRequest>();
            var marshaller = new UpdateTimeToLiveEndpointDiscoveryMarshaller();

            var internalData = marshaller.Marshall(request);
            var validator = new EndpointDiscoveryValidator(internalData, request, service_model, operation);
            validator.Validate();
        }
    }
}