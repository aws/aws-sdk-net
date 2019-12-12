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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Chime;
using Amazon.Chime.Model;
using Amazon.Chime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ChimeMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("chime");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void AssociatePhoneNumbersWithVoiceConnectorMarshallTest()
        {
            var operation = service_model.FindOperation("AssociatePhoneNumbersWithVoiceConnector");

            var request = InstantiateClassGenerator.Execute<AssociatePhoneNumbersWithVoiceConnectorRequest>();
            var marshaller = new AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AssociatePhoneNumbersWithVoiceConnector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociatePhoneNumbersWithVoiceConnectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void AssociatePhoneNumbersWithVoiceConnectorGroupMarshallTest()
        {
            var operation = service_model.FindOperation("AssociatePhoneNumbersWithVoiceConnectorGroup");

            var request = InstantiateClassGenerator.Execute<AssociatePhoneNumbersWithVoiceConnectorGroupRequest>();
            var marshaller = new AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AssociatePhoneNumbersWithVoiceConnectorGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociatePhoneNumbersWithVoiceConnectorGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void AssociatePhoneNumberWithUserMarshallTest()
        {
            var operation = service_model.FindOperation("AssociatePhoneNumberWithUser");

            var request = InstantiateClassGenerator.Execute<AssociatePhoneNumberWithUserRequest>();
            var marshaller = new AssociatePhoneNumberWithUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AssociatePhoneNumberWithUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AssociatePhoneNumberWithUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociatePhoneNumberWithUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchCreateAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchCreateAttendeeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchCreateAttendeeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchCreateRoomMembershipMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateRoomMembership");

            var request = InstantiateClassGenerator.Execute<BatchCreateRoomMembershipRequest>();
            var marshaller = new BatchCreateRoomMembershipRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchCreateRoomMembership", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchCreateRoomMembershipResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchCreateRoomMembershipResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchDeletePhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeletePhoneNumber");

            var request = InstantiateClassGenerator.Execute<BatchDeletePhoneNumberRequest>();
            var marshaller = new BatchDeletePhoneNumberRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchDeletePhoneNumber", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchDeletePhoneNumberResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchSuspendUserMarshallTest()
        {
            var operation = service_model.FindOperation("BatchSuspendUser");

            var request = InstantiateClassGenerator.Execute<BatchSuspendUserRequest>();
            var marshaller = new BatchSuspendUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchSuspendUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchSuspendUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchSuspendUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchUnsuspendUserMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUnsuspendUser");

            var request = InstantiateClassGenerator.Execute<BatchUnsuspendUserRequest>();
            var marshaller = new BatchUnsuspendUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchUnsuspendUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchUnsuspendUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchUnsuspendUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchUpdatePhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdatePhoneNumber");

            var request = InstantiateClassGenerator.Execute<BatchUpdatePhoneNumberRequest>();
            var marshaller = new BatchUpdatePhoneNumberRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchUpdatePhoneNumber", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchUpdatePhoneNumberResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void BatchUpdateUserMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateUser");

            var request = InstantiateClassGenerator.Execute<BatchUpdateUserRequest>();
            var marshaller = new BatchUpdateUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchUpdateUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchUpdateUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchUpdateUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateAccountMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAccount");

            var request = InstantiateClassGenerator.Execute<CreateAccountRequest>();
            var marshaller = new CreateAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateAttendeeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateAttendeeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateBotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBot");

            var request = InstantiateClassGenerator.Execute<CreateBotRequest>();
            var marshaller = new CreateBotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBot", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateBotResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateMeetingMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateMeetingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateMeetingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreatePhoneNumberOrderMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePhoneNumberOrder");

            var request = InstantiateClassGenerator.Execute<CreatePhoneNumberOrderRequest>();
            var marshaller = new CreatePhoneNumberOrderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreatePhoneNumberOrder", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePhoneNumberOrderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateRoomMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRoom");

            var request = InstantiateClassGenerator.Execute<CreateRoomRequest>();
            var marshaller = new CreateRoomRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateRoom", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateRoomResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateRoomResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateRoomMembershipMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRoomMembership");

            var request = InstantiateClassGenerator.Execute<CreateRoomMembershipRequest>();
            var marshaller = new CreateRoomMembershipRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateRoomMembership", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateRoomMembershipResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateRoomMembershipResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateVoiceConnectorMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVoiceConnector");

            var request = InstantiateClassGenerator.Execute<CreateVoiceConnectorRequest>();
            var marshaller = new CreateVoiceConnectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateVoiceConnector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateVoiceConnectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void CreateVoiceConnectorGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVoiceConnectorGroup");

            var request = InstantiateClassGenerator.Execute<CreateVoiceConnectorGroupRequest>();
            var marshaller = new CreateVoiceConnectorGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateVoiceConnectorGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateVoiceConnectorGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteAccountMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccount");

            var request = InstantiateClassGenerator.Execute<DeleteAccountRequest>();
            var marshaller = new DeleteAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteEventsConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventsConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteEventsConfigurationRequest>();
            var marshaller = new DeleteEventsConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteEventsConfiguration", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteMeetingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeletePhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePhoneNumber");

            var request = InstantiateClassGenerator.Execute<DeletePhoneNumberRequest>();
            var marshaller = new DeletePhoneNumberRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePhoneNumber", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteRoomMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRoom");

            var request = InstantiateClassGenerator.Execute<DeleteRoomRequest>();
            var marshaller = new DeleteRoomRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRoom", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteRoomMembershipMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRoomMembership");

            var request = InstantiateClassGenerator.Execute<DeleteRoomMembershipRequest>();
            var marshaller = new DeleteRoomMembershipRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRoomMembership", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteVoiceConnectorMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVoiceConnector");

            var request = InstantiateClassGenerator.Execute<DeleteVoiceConnectorRequest>();
            var marshaller = new DeleteVoiceConnectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteVoiceConnector", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteVoiceConnectorGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVoiceConnectorGroup");

            var request = InstantiateClassGenerator.Execute<DeleteVoiceConnectorGroupRequest>();
            var marshaller = new DeleteVoiceConnectorGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteVoiceConnectorGroup", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteVoiceConnectorOriginationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVoiceConnectorOrigination");

            var request = InstantiateClassGenerator.Execute<DeleteVoiceConnectorOriginationRequest>();
            var marshaller = new DeleteVoiceConnectorOriginationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteVoiceConnectorOrigination", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteVoiceConnectorStreamingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVoiceConnectorStreamingConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteVoiceConnectorStreamingConfigurationRequest>();
            var marshaller = new DeleteVoiceConnectorStreamingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteVoiceConnectorStreamingConfiguration", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteVoiceConnectorTerminationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVoiceConnectorTermination");

            var request = InstantiateClassGenerator.Execute<DeleteVoiceConnectorTerminationRequest>();
            var marshaller = new DeleteVoiceConnectorTerminationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteVoiceConnectorTermination", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DeleteVoiceConnectorTerminationCredentialsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVoiceConnectorTerminationCredentials");

            var request = InstantiateClassGenerator.Execute<DeleteVoiceConnectorTerminationCredentialsRequest>();
            var marshaller = new DeleteVoiceConnectorTerminationCredentialsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteVoiceConnectorTerminationCredentials", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DisassociatePhoneNumberFromUserMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociatePhoneNumberFromUser");

            var request = InstantiateClassGenerator.Execute<DisassociatePhoneNumberFromUserRequest>();
            var marshaller = new DisassociatePhoneNumberFromUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisassociatePhoneNumberFromUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DisassociatePhoneNumberFromUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociatePhoneNumberFromUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DisassociatePhoneNumbersFromVoiceConnectorMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociatePhoneNumbersFromVoiceConnector");

            var request = InstantiateClassGenerator.Execute<DisassociatePhoneNumbersFromVoiceConnectorRequest>();
            var marshaller = new DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisassociatePhoneNumbersFromVoiceConnector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociatePhoneNumbersFromVoiceConnectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void DisassociatePhoneNumbersFromVoiceConnectorGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociatePhoneNumbersFromVoiceConnectorGroup");

            var request = InstantiateClassGenerator.Execute<DisassociatePhoneNumbersFromVoiceConnectorGroupRequest>();
            var marshaller = new DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisassociatePhoneNumbersFromVoiceConnectorGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociatePhoneNumbersFromVoiceConnectorGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetAccountMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccount");

            var request = InstantiateClassGenerator.Execute<GetAccountRequest>();
            var marshaller = new GetAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetAccountSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountSettings");

            var request = InstantiateClassGenerator.Execute<GetAccountSettingsRequest>();
            var marshaller = new GetAccountSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccountSettings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccountSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAttendeeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAttendeeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetBotMarshallTest()
        {
            var operation = service_model.FindOperation("GetBot");

            var request = InstantiateClassGenerator.Execute<GetBotRequest>();
            var marshaller = new GetBotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBot", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBotResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetEventsConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetEventsConfiguration");

            var request = InstantiateClassGenerator.Execute<GetEventsConfigurationRequest>();
            var marshaller = new GetEventsConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetEventsConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetEventsConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetEventsConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetGlobalSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetGlobalSettings");

            var request = InstantiateClassGenerator.Execute<GetGlobalSettingsRequest>();
            var marshaller = new GetGlobalSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetGlobalSettings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetGlobalSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetMeetingMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetMeetingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetMeetingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetPhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("GetPhoneNumber");

            var request = InstantiateClassGenerator.Execute<GetPhoneNumberRequest>();
            var marshaller = new GetPhoneNumberRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPhoneNumber", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPhoneNumberResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetPhoneNumberOrderMarshallTest()
        {
            var operation = service_model.FindOperation("GetPhoneNumberOrder");

            var request = InstantiateClassGenerator.Execute<GetPhoneNumberOrderRequest>();
            var marshaller = new GetPhoneNumberOrderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPhoneNumberOrder", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPhoneNumberOrderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetPhoneNumberSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetPhoneNumberSettings");

            var request = InstantiateClassGenerator.Execute<GetPhoneNumberSettingsRequest>();
            var marshaller = new GetPhoneNumberSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPhoneNumberSettings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPhoneNumberSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetRoomMarshallTest()
        {
            var operation = service_model.FindOperation("GetRoom");

            var request = InstantiateClassGenerator.Execute<GetRoomRequest>();
            var marshaller = new GetRoomRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRoom", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetRoomResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRoomResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetUserMarshallTest()
        {
            var operation = service_model.FindOperation("GetUser");

            var request = InstantiateClassGenerator.Execute<GetUserRequest>();
            var marshaller = new GetUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetUserSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetUserSettings");

            var request = InstantiateClassGenerator.Execute<GetUserSettingsRequest>();
            var marshaller = new GetUserSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetUserSettings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetUserSettingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetUserSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnector");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorRequest>();
            var marshaller = new GetVoiceConnectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorGroupMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnectorGroup");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorGroupRequest>();
            var marshaller = new GetVoiceConnectorGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnectorGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorLoggingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnectorLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorLoggingConfigurationRequest>();
            var marshaller = new GetVoiceConnectorLoggingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnectorLoggingConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorLoggingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorOriginationMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnectorOrigination");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorOriginationRequest>();
            var marshaller = new GetVoiceConnectorOriginationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnectorOrigination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorOriginationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorStreamingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnectorStreamingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorStreamingConfigurationRequest>();
            var marshaller = new GetVoiceConnectorStreamingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnectorStreamingConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorStreamingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorTerminationMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnectorTermination");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorTerminationRequest>();
            var marshaller = new GetVoiceConnectorTerminationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnectorTermination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorTerminationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void GetVoiceConnectorTerminationHealthMarshallTest()
        {
            var operation = service_model.FindOperation("GetVoiceConnectorTerminationHealth");

            var request = InstantiateClassGenerator.Execute<GetVoiceConnectorTerminationHealthRequest>();
            var marshaller = new GetVoiceConnectorTerminationHealthRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetVoiceConnectorTerminationHealth", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVoiceConnectorTerminationHealthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void InviteUsersMarshallTest()
        {
            var operation = service_model.FindOperation("InviteUsers");

            var request = InstantiateClassGenerator.Execute<InviteUsersRequest>();
            var marshaller = new InviteUsersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InviteUsers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = InviteUsersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InviteUsersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListAccountsMarshallTest()
        {
            var operation = service_model.FindOperation("ListAccounts");

            var request = InstantiateClassGenerator.Execute<ListAccountsRequest>();
            var marshaller = new ListAccountsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAccounts", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAccountsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAccountsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListAttendeesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAttendeesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAttendeesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListBotsMarshallTest()
        {
            var operation = service_model.FindOperation("ListBots");

            var request = InstantiateClassGenerator.Execute<ListBotsRequest>();
            var marshaller = new ListBotsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBots", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListBotsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListMeetingsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMeetings");

            var request = InstantiateClassGenerator.Execute<ListMeetingsRequest>();
            var marshaller = new ListMeetingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListMeetings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListMeetingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListMeetingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListPhoneNumberOrdersMarshallTest()
        {
            var operation = service_model.FindOperation("ListPhoneNumberOrders");

            var request = InstantiateClassGenerator.Execute<ListPhoneNumberOrdersRequest>();
            var marshaller = new ListPhoneNumberOrdersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPhoneNumberOrders", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPhoneNumberOrdersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListPhoneNumbersMarshallTest()
        {
            var operation = service_model.FindOperation("ListPhoneNumbers");

            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();
            var marshaller = new ListPhoneNumbersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPhoneNumbers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPhoneNumbersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListRoomMembershipsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRoomMemberships");

            var request = InstantiateClassGenerator.Execute<ListRoomMembershipsRequest>();
            var marshaller = new ListRoomMembershipsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRoomMemberships", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListRoomMembershipsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRoomMembershipsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListRoomsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRooms");

            var request = InstantiateClassGenerator.Execute<ListRoomsRequest>();
            var marshaller = new ListRoomsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRooms", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListRoomsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRoomsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListUsersMarshallTest()
        {
            var operation = service_model.FindOperation("ListUsers");

            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();
            var marshaller = new ListUsersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListUsers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListUsersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListUsersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListVoiceConnectorGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("ListVoiceConnectorGroups");

            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorGroupsRequest>();
            var marshaller = new ListVoiceConnectorGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListVoiceConnectorGroups", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListVoiceConnectorGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListVoiceConnectorsMarshallTest()
        {
            var operation = service_model.FindOperation("ListVoiceConnectors");

            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorsRequest>();
            var marshaller = new ListVoiceConnectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListVoiceConnectors", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListVoiceConnectorsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ListVoiceConnectorTerminationCredentialsMarshallTest()
        {
            var operation = service_model.FindOperation("ListVoiceConnectorTerminationCredentials");

            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorTerminationCredentialsRequest>();
            var marshaller = new ListVoiceConnectorTerminationCredentialsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListVoiceConnectorTerminationCredentials", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListVoiceConnectorTerminationCredentialsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void LogoutUserMarshallTest()
        {
            var operation = service_model.FindOperation("LogoutUser");

            var request = InstantiateClassGenerator.Execute<LogoutUserRequest>();
            var marshaller = new LogoutUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("LogoutUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = LogoutUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as LogoutUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void PutEventsConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("PutEventsConfiguration");

            var request = InstantiateClassGenerator.Execute<PutEventsConfigurationRequest>();
            var marshaller = new PutEventsConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutEventsConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutEventsConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutEventsConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void PutVoiceConnectorLoggingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("PutVoiceConnectorLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutVoiceConnectorLoggingConfigurationRequest>();
            var marshaller = new PutVoiceConnectorLoggingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutVoiceConnectorLoggingConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutVoiceConnectorLoggingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void PutVoiceConnectorOriginationMarshallTest()
        {
            var operation = service_model.FindOperation("PutVoiceConnectorOrigination");

            var request = InstantiateClassGenerator.Execute<PutVoiceConnectorOriginationRequest>();
            var marshaller = new PutVoiceConnectorOriginationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutVoiceConnectorOrigination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutVoiceConnectorOriginationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void PutVoiceConnectorStreamingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("PutVoiceConnectorStreamingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutVoiceConnectorStreamingConfigurationRequest>();
            var marshaller = new PutVoiceConnectorStreamingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutVoiceConnectorStreamingConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutVoiceConnectorStreamingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void PutVoiceConnectorTerminationMarshallTest()
        {
            var operation = service_model.FindOperation("PutVoiceConnectorTermination");

            var request = InstantiateClassGenerator.Execute<PutVoiceConnectorTerminationRequest>();
            var marshaller = new PutVoiceConnectorTerminationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutVoiceConnectorTermination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutVoiceConnectorTerminationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void PutVoiceConnectorTerminationCredentialsMarshallTest()
        {
            var operation = service_model.FindOperation("PutVoiceConnectorTerminationCredentials");

            var request = InstantiateClassGenerator.Execute<PutVoiceConnectorTerminationCredentialsRequest>();
            var marshaller = new PutVoiceConnectorTerminationCredentialsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutVoiceConnectorTerminationCredentials", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void RegenerateSecurityTokenMarshallTest()
        {
            var operation = service_model.FindOperation("RegenerateSecurityToken");

            var request = InstantiateClassGenerator.Execute<RegenerateSecurityTokenRequest>();
            var marshaller = new RegenerateSecurityTokenRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RegenerateSecurityToken", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RegenerateSecurityTokenResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RegenerateSecurityTokenResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void ResetPersonalPINMarshallTest()
        {
            var operation = service_model.FindOperation("ResetPersonalPIN");

            var request = InstantiateClassGenerator.Execute<ResetPersonalPINRequest>();
            var marshaller = new ResetPersonalPINRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ResetPersonalPIN", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ResetPersonalPINResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ResetPersonalPINResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void RestorePhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("RestorePhoneNumber");

            var request = InstantiateClassGenerator.Execute<RestorePhoneNumberRequest>();
            var marshaller = new RestorePhoneNumberRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RestorePhoneNumber", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RestorePhoneNumberResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void SearchAvailablePhoneNumbersMarshallTest()
        {
            var operation = service_model.FindOperation("SearchAvailablePhoneNumbers");

            var request = InstantiateClassGenerator.Execute<SearchAvailablePhoneNumbersRequest>();
            var marshaller = new SearchAvailablePhoneNumbersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SearchAvailablePhoneNumbers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SearchAvailablePhoneNumbersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateAccountMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccount");

            var request = InstantiateClassGenerator.Execute<UpdateAccountRequest>();
            var marshaller = new UpdateAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateAccountSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountSettings");

            var request = InstantiateClassGenerator.Execute<UpdateAccountSettingsRequest>();
            var marshaller = new UpdateAccountSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateAccountSettings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAccountSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateBotMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBot");

            var request = InstantiateClassGenerator.Execute<UpdateBotRequest>();
            var marshaller = new UpdateBotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateBot", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateBotResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateGlobalSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGlobalSettings");

            var request = InstantiateClassGenerator.Execute<UpdateGlobalSettingsRequest>();
            var marshaller = new UpdateGlobalSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateGlobalSettings", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdatePhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePhoneNumber");

            var request = InstantiateClassGenerator.Execute<UpdatePhoneNumberRequest>();
            var marshaller = new UpdatePhoneNumberRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdatePhoneNumber", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdatePhoneNumberResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdatePhoneNumberSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePhoneNumberSettings");

            var request = InstantiateClassGenerator.Execute<UpdatePhoneNumberSettingsRequest>();
            var marshaller = new UpdatePhoneNumberSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdatePhoneNumberSettings", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateRoomMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRoom");

            var request = InstantiateClassGenerator.Execute<UpdateRoomRequest>();
            var marshaller = new UpdateRoomRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRoom", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateRoomResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRoomResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateRoomMembershipMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRoomMembership");

            var request = InstantiateClassGenerator.Execute<UpdateRoomMembershipRequest>();
            var marshaller = new UpdateRoomMembershipRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRoomMembership", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateRoomMembershipResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRoomMembershipResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateUserMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateUser");

            var request = InstantiateClassGenerator.Execute<UpdateUserRequest>();
            var marshaller = new UpdateUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateUserSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateUserSettings");

            var request = InstantiateClassGenerator.Execute<UpdateUserSettingsRequest>();
            var marshaller = new UpdateUserSettingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateUserSettings", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateVoiceConnectorMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateVoiceConnector");

            var request = InstantiateClassGenerator.Execute<UpdateVoiceConnectorRequest>();
            var marshaller = new UpdateVoiceConnectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateVoiceConnector", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateVoiceConnectorResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chime")]
        public void UpdateVoiceConnectorGroupMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateVoiceConnectorGroup");

            var request = InstantiateClassGenerator.Execute<UpdateVoiceConnectorGroupRequest>();
            var marshaller = new UpdateVoiceConnectorGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateVoiceConnectorGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateVoiceConnectorGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}