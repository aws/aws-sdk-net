/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Backup;
using Amazon.Backup.Model;
using Amazon.Backup.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class BackupMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("backup");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void CreateBackupPlanMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackupPlan");

            var request = InstantiateClassGenerator.Execute<CreateBackupPlanRequest>();
            var marshaller = new CreateBackupPlanRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackupPlan", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackupPlanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void CreateBackupSelectionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackupSelection");

            var request = InstantiateClassGenerator.Execute<CreateBackupSelectionRequest>();
            var marshaller = new CreateBackupSelectionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackupSelection", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackupSelectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void CreateBackupVaultMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackupVault");

            var request = InstantiateClassGenerator.Execute<CreateBackupVaultRequest>();
            var marshaller = new CreateBackupVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackupVault", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackupVaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DeleteBackupPlanMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackupPlan");

            var request = InstantiateClassGenerator.Execute<DeleteBackupPlanRequest>();
            var marshaller = new DeleteBackupPlanRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackupPlan", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteBackupPlanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DeleteBackupSelectionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackupSelection");

            var request = InstantiateClassGenerator.Execute<DeleteBackupSelectionRequest>();
            var marshaller = new DeleteBackupSelectionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackupSelection", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DeleteBackupVaultMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackupVault");

            var request = InstantiateClassGenerator.Execute<DeleteBackupVaultRequest>();
            var marshaller = new DeleteBackupVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackupVault", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DeleteBackupVaultAccessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackupVaultAccessPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteBackupVaultAccessPolicyRequest>();
            var marshaller = new DeleteBackupVaultAccessPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackupVaultAccessPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DeleteBackupVaultNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackupVaultNotifications");

            var request = InstantiateClassGenerator.Execute<DeleteBackupVaultNotificationsRequest>();
            var marshaller = new DeleteBackupVaultNotificationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackupVaultNotifications", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DeleteRecoveryPointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRecoveryPoint");

            var request = InstantiateClassGenerator.Execute<DeleteRecoveryPointRequest>();
            var marshaller = new DeleteRecoveryPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRecoveryPoint", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DescribeBackupJobMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBackupJob");

            var request = InstantiateClassGenerator.Execute<DescribeBackupJobRequest>();
            var marshaller = new DescribeBackupJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeBackupJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeBackupJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DescribeBackupVaultMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBackupVault");

            var request = InstantiateClassGenerator.Execute<DescribeBackupVaultRequest>();
            var marshaller = new DescribeBackupVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeBackupVault", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeBackupVaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DescribeProtectedResourceMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeProtectedResource");

            var request = InstantiateClassGenerator.Execute<DescribeProtectedResourceRequest>();
            var marshaller = new DescribeProtectedResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeProtectedResource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeProtectedResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DescribeRecoveryPointMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRecoveryPoint");

            var request = InstantiateClassGenerator.Execute<DescribeRecoveryPointRequest>();
            var marshaller = new DescribeRecoveryPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeRecoveryPoint", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeRecoveryPointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void DescribeRestoreJobMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRestoreJob");

            var request = InstantiateClassGenerator.Execute<DescribeRestoreJobRequest>();
            var marshaller = new DescribeRestoreJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeRestoreJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeRestoreJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ExportBackupPlanTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("ExportBackupPlanTemplate");

            var request = InstantiateClassGenerator.Execute<ExportBackupPlanTemplateRequest>();
            var marshaller = new ExportBackupPlanTemplateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ExportBackupPlanTemplate", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ExportBackupPlanTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetBackupPlanMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackupPlan");

            var request = InstantiateClassGenerator.Execute<GetBackupPlanRequest>();
            var marshaller = new GetBackupPlanRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackupPlan", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBackupPlanResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackupPlanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetBackupPlanFromJSONMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackupPlanFromJSON");

            var request = InstantiateClassGenerator.Execute<GetBackupPlanFromJSONRequest>();
            var marshaller = new GetBackupPlanFromJSONRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackupPlanFromJSON", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackupPlanFromJSONResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetBackupPlanFromTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackupPlanFromTemplate");

            var request = InstantiateClassGenerator.Execute<GetBackupPlanFromTemplateRequest>();
            var marshaller = new GetBackupPlanFromTemplateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackupPlanFromTemplate", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackupPlanFromTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetBackupSelectionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackupSelection");

            var request = InstantiateClassGenerator.Execute<GetBackupSelectionRequest>();
            var marshaller = new GetBackupSelectionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackupSelection", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackupSelectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetBackupVaultAccessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackupVaultAccessPolicy");

            var request = InstantiateClassGenerator.Execute<GetBackupVaultAccessPolicyRequest>();
            var marshaller = new GetBackupVaultAccessPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackupVaultAccessPolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackupVaultAccessPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetBackupVaultNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackupVaultNotifications");

            var request = InstantiateClassGenerator.Execute<GetBackupVaultNotificationsRequest>();
            var marshaller = new GetBackupVaultNotificationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackupVaultNotifications", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackupVaultNotificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetRecoveryPointRestoreMetadataMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecoveryPointRestoreMetadata");

            var request = InstantiateClassGenerator.Execute<GetRecoveryPointRestoreMetadataRequest>();
            var marshaller = new GetRecoveryPointRestoreMetadataRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRecoveryPointRestoreMetadata", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRecoveryPointRestoreMetadataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void GetSupportedResourceTypesMarshallTest()
        {
            var operation = service_model.FindOperation("GetSupportedResourceTypes");

            var request = InstantiateClassGenerator.Execute<GetSupportedResourceTypesRequest>();
            var marshaller = new GetSupportedResourceTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSupportedResourceTypes", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetSupportedResourceTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListBackupJobsMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackupJobs");

            var request = InstantiateClassGenerator.Execute<ListBackupJobsRequest>();
            var marshaller = new ListBackupJobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackupJobs", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListBackupJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackupJobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListBackupPlansMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackupPlans");

            var request = InstantiateClassGenerator.Execute<ListBackupPlansRequest>();
            var marshaller = new ListBackupPlansRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackupPlans", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListBackupPlansResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackupPlansResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListBackupPlanTemplatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackupPlanTemplates");

            var request = InstantiateClassGenerator.Execute<ListBackupPlanTemplatesRequest>();
            var marshaller = new ListBackupPlanTemplatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackupPlanTemplates", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackupPlanTemplatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListBackupPlanVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackupPlanVersions");

            var request = InstantiateClassGenerator.Execute<ListBackupPlanVersionsRequest>();
            var marshaller = new ListBackupPlanVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackupPlanVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackupPlanVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListBackupSelectionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackupSelections");

            var request = InstantiateClassGenerator.Execute<ListBackupSelectionsRequest>();
            var marshaller = new ListBackupSelectionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackupSelections", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackupSelectionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListBackupVaultsMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackupVaults");

            var request = InstantiateClassGenerator.Execute<ListBackupVaultsRequest>();
            var marshaller = new ListBackupVaultsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackupVaults", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackupVaultsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListProtectedResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListProtectedResources");

            var request = InstantiateClassGenerator.Execute<ListProtectedResourcesRequest>();
            var marshaller = new ListProtectedResourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListProtectedResources", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListProtectedResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListRecoveryPointsByBackupVaultMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecoveryPointsByBackupVault");

            var request = InstantiateClassGenerator.Execute<ListRecoveryPointsByBackupVaultRequest>();
            var marshaller = new ListRecoveryPointsByBackupVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRecoveryPointsByBackupVault", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRecoveryPointsByBackupVaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListRecoveryPointsByResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecoveryPointsByResource");

            var request = InstantiateClassGenerator.Execute<ListRecoveryPointsByResourceRequest>();
            var marshaller = new ListRecoveryPointsByResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRecoveryPointsByResource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRecoveryPointsByResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListRestoreJobsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRestoreJobs");

            var request = InstantiateClassGenerator.Execute<ListRestoreJobsRequest>();
            var marshaller = new ListRestoreJobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRestoreJobs", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRestoreJobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void ListTagsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTags", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void PutBackupVaultAccessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutBackupVaultAccessPolicy");

            var request = InstantiateClassGenerator.Execute<PutBackupVaultAccessPolicyRequest>();
            var marshaller = new PutBackupVaultAccessPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBackupVaultAccessPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void PutBackupVaultNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("PutBackupVaultNotifications");

            var request = InstantiateClassGenerator.Execute<PutBackupVaultNotificationsRequest>();
            var marshaller = new PutBackupVaultNotificationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBackupVaultNotifications", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void StartBackupJobMarshallTest()
        {
            var operation = service_model.FindOperation("StartBackupJob");

            var request = InstantiateClassGenerator.Execute<StartBackupJobRequest>();
            var marshaller = new StartBackupJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartBackupJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = StartBackupJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartBackupJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void StartRestoreJobMarshallTest()
        {
            var operation = service_model.FindOperation("StartRestoreJob");

            var request = InstantiateClassGenerator.Execute<StartRestoreJobRequest>();
            var marshaller = new StartRestoreJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartRestoreJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = StartRestoreJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartRestoreJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void StopBackupJobMarshallTest()
        {
            var operation = service_model.FindOperation("StopBackupJob");

            var request = InstantiateClassGenerator.Execute<StopBackupJobRequest>();
            var marshaller = new StopBackupJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StopBackupJob", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void TagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void UntagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void UpdateBackupPlanMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackupPlan");

            var request = InstantiateClassGenerator.Execute<UpdateBackupPlanRequest>();
            var marshaller = new UpdateBackupPlanRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateBackupPlan", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBackupPlanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Backup")]
        public void UpdateRecoveryPointLifecycleMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecoveryPointLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecoveryPointLifecycleRequest>();
            var marshaller = new UpdateRecoveryPointLifecycleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRecoveryPointLifecycle", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRecoveryPointLifecycleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}