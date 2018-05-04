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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.GuardDuty;
using Amazon.GuardDuty.Model;
using Amazon.GuardDuty.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class GuardDutyMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("guardduty");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void AcceptInvitationMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptInvitation");

            var request = InstantiateClassGenerator.Execute<AcceptInvitationRequest>();
            var marshaller = new AcceptInvitationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AcceptInvitation", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AcceptInvitationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ArchiveFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("ArchiveFindings");

            var request = InstantiateClassGenerator.Execute<ArchiveFindingsRequest>();
            var marshaller = new ArchiveFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ArchiveFindings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ArchiveFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void CreateDetectorMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDetector");

            var request = InstantiateClassGenerator.Execute<CreateDetectorRequest>();
            var marshaller = new CreateDetectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDetector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDetectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDetectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void CreateFilterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFilter");

            var request = InstantiateClassGenerator.Execute<CreateFilterRequest>();
            var marshaller = new CreateFilterRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateFilter", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateFilterResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void CreateIPSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateIPSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateIPSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateIPSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void CreateMembersMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMembers");

            var request = InstantiateClassGenerator.Execute<CreateMembersRequest>();
            var marshaller = new CreateMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void CreateSampleFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSampleFindings");

            var request = InstantiateClassGenerator.Execute<CreateSampleFindingsRequest>();
            var marshaller = new CreateSampleFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateSampleFindings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateSampleFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void CreateThreatIntelSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateThreatIntelSet");

            var request = InstantiateClassGenerator.Execute<CreateThreatIntelSetRequest>();
            var marshaller = new CreateThreatIntelSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateThreatIntelSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateThreatIntelSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeclineInvitationsMarshallTest()
        {
            var operation = service_model.FindOperation("DeclineInvitations");

            var request = InstantiateClassGenerator.Execute<DeclineInvitationsRequest>();
            var marshaller = new DeclineInvitationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeclineInvitations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeclineInvitationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeleteDetectorMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDetector");

            var request = InstantiateClassGenerator.Execute<DeleteDetectorRequest>();
            var marshaller = new DeleteDetectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDetector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteDetectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteDetectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeleteFilterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFilter");

            var request = InstantiateClassGenerator.Execute<DeleteFilterRequest>();
            var marshaller = new DeleteFilterRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteFilter", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteFilterResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeleteInvitationsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteInvitations");

            var request = InstantiateClassGenerator.Execute<DeleteInvitationsRequest>();
            var marshaller = new DeleteInvitationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteInvitations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteInvitationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeleteIPSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteIPSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteIPSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeleteMembersMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMembers");

            var request = InstantiateClassGenerator.Execute<DeleteMembersRequest>();
            var marshaller = new DeleteMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DeleteThreatIntelSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteThreatIntelSet");

            var request = InstantiateClassGenerator.Execute<DeleteThreatIntelSetRequest>();
            var marshaller = new DeleteThreatIntelSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteThreatIntelSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteThreatIntelSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DisassociateFromMasterAccountMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateFromMasterAccount");

            var request = InstantiateClassGenerator.Execute<DisassociateFromMasterAccountRequest>();
            var marshaller = new DisassociateFromMasterAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisassociateFromMasterAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociateFromMasterAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void DisassociateMembersMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateMembers");

            var request = InstantiateClassGenerator.Execute<DisassociateMembersRequest>();
            var marshaller = new DisassociateMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisassociateMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociateMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetDetectorMarshallTest()
        {
            var operation = service_model.FindOperation("GetDetector");

            var request = InstantiateClassGenerator.Execute<GetDetectorRequest>();
            var marshaller = new GetDetectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDetector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDetectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDetectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetFilterMarshallTest()
        {
            var operation = service_model.FindOperation("GetFilter");

            var request = InstantiateClassGenerator.Execute<GetFilterRequest>();
            var marshaller = new GetFilterRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFilter", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetFilterResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetFindings");

            var request = InstantiateClassGenerator.Execute<GetFindingsRequest>();
            var marshaller = new GetFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFindings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetFindingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetFindingsStatisticsMarshallTest()
        {
            var operation = service_model.FindOperation("GetFindingsStatistics");

            var request = InstantiateClassGenerator.Execute<GetFindingsStatisticsRequest>();
            var marshaller = new GetFindingsStatisticsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFindingsStatistics", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFindingsStatisticsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetInvitationsCountMarshallTest()
        {
            var operation = service_model.FindOperation("GetInvitationsCount");

            var request = InstantiateClassGenerator.Execute<GetInvitationsCountRequest>();
            var marshaller = new GetInvitationsCountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetInvitationsCount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetInvitationsCountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetIPSetMarshallTest()
        {
            var operation = service_model.FindOperation("GetIPSet");

            var request = InstantiateClassGenerator.Execute<GetIPSetRequest>();
            var marshaller = new GetIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetIPSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetIPSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIPSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetMasterAccountMarshallTest()
        {
            var operation = service_model.FindOperation("GetMasterAccount");

            var request = InstantiateClassGenerator.Execute<GetMasterAccountRequest>();
            var marshaller = new GetMasterAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMasterAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetMasterAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetMembersMarshallTest()
        {
            var operation = service_model.FindOperation("GetMembers");

            var request = InstantiateClassGenerator.Execute<GetMembersRequest>();
            var marshaller = new GetMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void GetThreatIntelSetMarshallTest()
        {
            var operation = service_model.FindOperation("GetThreatIntelSet");

            var request = InstantiateClassGenerator.Execute<GetThreatIntelSetRequest>();
            var marshaller = new GetThreatIntelSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetThreatIntelSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetThreatIntelSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void InviteMembersMarshallTest()
        {
            var operation = service_model.FindOperation("InviteMembers");

            var request = InstantiateClassGenerator.Execute<InviteMembersRequest>();
            var marshaller = new InviteMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InviteMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = InviteMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InviteMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListDetectorsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDetectorsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDetectorsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListFiltersMarshallTest()
        {
            var operation = service_model.FindOperation("ListFilters");

            var request = InstantiateClassGenerator.Execute<ListFiltersRequest>();
            var marshaller = new ListFiltersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListFilters", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListFiltersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFiltersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("ListFindings");

            var request = InstantiateClassGenerator.Execute<ListFindingsRequest>();
            var marshaller = new ListFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListFindings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListFindingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListInvitationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListInvitations");

            var request = InstantiateClassGenerator.Execute<ListInvitationsRequest>();
            var marshaller = new ListInvitationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListInvitations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListInvitationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListInvitationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListIPSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListIPSets");

            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();
            var marshaller = new ListIPSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListIPSets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListIPSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListIPSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListMembersMarshallTest()
        {
            var operation = service_model.FindOperation("ListMembers");

            var request = InstantiateClassGenerator.Execute<ListMembersRequest>();
            var marshaller = new ListMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void ListThreatIntelSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListThreatIntelSets");

            var request = InstantiateClassGenerator.Execute<ListThreatIntelSetsRequest>();
            var marshaller = new ListThreatIntelSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThreatIntelSets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThreatIntelSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void StartMonitoringMembersMarshallTest()
        {
            var operation = service_model.FindOperation("StartMonitoringMembers");

            var request = InstantiateClassGenerator.Execute<StartMonitoringMembersRequest>();
            var marshaller = new StartMonitoringMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartMonitoringMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartMonitoringMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void StopMonitoringMembersMarshallTest()
        {
            var operation = service_model.FindOperation("StopMonitoringMembers");

            var request = InstantiateClassGenerator.Execute<StopMonitoringMembersRequest>();
            var marshaller = new StopMonitoringMembersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StopMonitoringMembers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StopMonitoringMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void UnarchiveFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("UnarchiveFindings");

            var request = InstantiateClassGenerator.Execute<UnarchiveFindingsRequest>();
            var marshaller = new UnarchiveFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UnarchiveFindings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UnarchiveFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void UpdateDetectorMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDetector");

            var request = InstantiateClassGenerator.Execute<UpdateDetectorRequest>();
            var marshaller = new UpdateDetectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDetector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateDetectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDetectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void UpdateFilterMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFilter");

            var request = InstantiateClassGenerator.Execute<UpdateFilterRequest>();
            var marshaller = new UpdateFilterRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateFilter", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateFilterResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void UpdateFindingsFeedbackMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFindingsFeedback");

            var request = InstantiateClassGenerator.Execute<UpdateFindingsFeedbackRequest>();
            var marshaller = new UpdateFindingsFeedbackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateFindingsFeedback", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFindingsFeedbackResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void UpdateIPSetMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateIPSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateIPSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("GuardDuty")]
        public void UpdateThreatIntelSetMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateThreatIntelSet");

            var request = InstantiateClassGenerator.Execute<UpdateThreatIntelSetRequest>();
            var marshaller = new UpdateThreatIntelSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateThreatIntelSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateThreatIntelSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}