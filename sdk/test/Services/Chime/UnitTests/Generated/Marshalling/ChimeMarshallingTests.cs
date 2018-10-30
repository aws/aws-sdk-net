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

            }
}