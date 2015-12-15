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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class IdentityManagementServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iam-2010-05-08.normal.json", "iam.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void AddClientIDToOpenIDConnectProviderMarshallTest()
        {
            var operation = service_model.FindOperation("AddClientIDToOpenIDConnectProvider");

            var request = InstantiateClassGenerator.Execute<AddClientIDToOpenIDConnectProviderRequest>();
            var marshaller = new AddClientIDToOpenIDConnectProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void AddRoleToInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToInstanceProfile");

            var request = InstantiateClassGenerator.Execute<AddRoleToInstanceProfileRequest>();
            var marshaller = new AddRoleToInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void AddUserToGroupMarshallTest()
        {
            var operation = service_model.FindOperation("AddUserToGroup");

            var request = InstantiateClassGenerator.Execute<AddUserToGroupRequest>();
            var marshaller = new AddUserToGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void AttachGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("AttachGroupPolicy");

            var request = InstantiateClassGenerator.Execute<AttachGroupPolicyRequest>();
            var marshaller = new AttachGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void AttachRolePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("AttachRolePolicy");

            var request = InstantiateClassGenerator.Execute<AttachRolePolicyRequest>();
            var marshaller = new AttachRolePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void AttachUserPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("AttachUserPolicy");

            var request = InstantiateClassGenerator.Execute<AttachUserPolicyRequest>();
            var marshaller = new AttachUserPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ChangePasswordMarshallTest()
        {
            var operation = service_model.FindOperation("ChangePassword");

            var request = InstantiateClassGenerator.Execute<ChangePasswordRequest>();
            var marshaller = new ChangePasswordRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateAccessKeyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAccessKey");

            var request = InstantiateClassGenerator.Execute<CreateAccessKeyRequest>();
            var marshaller = new CreateAccessKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateAccessKeyResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateAccessKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateAccountAliasMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAccountAlias");

            var request = InstantiateClassGenerator.Execute<CreateAccountAliasRequest>();
            var marshaller = new CreateAccountAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGroup");

            var request = InstantiateClassGenerator.Execute<CreateGroupRequest>();
            var marshaller = new CreateGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInstanceProfile");

            var request = InstantiateClassGenerator.Execute<CreateInstanceProfileRequest>();
            var marshaller = new CreateInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateInstanceProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateInstanceProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateLoginProfileMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoginProfile");

            var request = InstantiateClassGenerator.Execute<CreateLoginProfileRequest>();
            var marshaller = new CreateLoginProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateLoginProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLoginProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateOpenIDConnectProviderMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOpenIDConnectProvider");

            var request = InstantiateClassGenerator.Execute<CreateOpenIDConnectProviderRequest>();
            var marshaller = new CreateOpenIDConnectProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateOpenIDConnectProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateOpenIDConnectProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreatePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePolicy");

            var request = InstantiateClassGenerator.Execute<CreatePolicyRequest>();
            var marshaller = new CreatePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreatePolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as CreatePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreatePolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePolicyVersion");

            var request = InstantiateClassGenerator.Execute<CreatePolicyVersionRequest>();
            var marshaller = new CreatePolicyVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreatePolicyVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreatePolicyVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateRoleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRole");

            var request = InstantiateClassGenerator.Execute<CreateRoleRequest>();
            var marshaller = new CreateRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateRoleResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateRoleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateSAMLProviderMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSAMLProvider");

            var request = InstantiateClassGenerator.Execute<CreateSAMLProviderRequest>();
            var marshaller = new CreateSAMLProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateSAMLProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSAMLProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateUserMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUser");

            var request = InstantiateClassGenerator.Execute<CreateUserRequest>();
            var marshaller = new CreateUserRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateUserResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void CreateVirtualMFADeviceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVirtualMFADevice");

            var request = InstantiateClassGenerator.Execute<CreateVirtualMFADeviceRequest>();
            var marshaller = new CreateVirtualMFADeviceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateVirtualMFADeviceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVirtualMFADeviceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeactivateMFADeviceMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateMFADevice");

            var request = InstantiateClassGenerator.Execute<DeactivateMFADeviceRequest>();
            var marshaller = new DeactivateMFADeviceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteAccessKeyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccessKey");

            var request = InstantiateClassGenerator.Execute<DeleteAccessKeyRequest>();
            var marshaller = new DeleteAccessKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteAccountAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccountAlias");

            var request = InstantiateClassGenerator.Execute<DeleteAccountAliasRequest>();
            var marshaller = new DeleteAccountAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteAccountPasswordPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccountPasswordPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteAccountPasswordPolicyRequest>();
            var marshaller = new DeleteAccountPasswordPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGroup");

            var request = InstantiateClassGenerator.Execute<DeleteGroupRequest>();
            var marshaller = new DeleteGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGroupPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteGroupPolicyRequest>();
            var marshaller = new DeleteGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteInstanceProfile");

            var request = InstantiateClassGenerator.Execute<DeleteInstanceProfileRequest>();
            var marshaller = new DeleteInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteLoginProfileMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoginProfile");

            var request = InstantiateClassGenerator.Execute<DeleteLoginProfileRequest>();
            var marshaller = new DeleteLoginProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteOpenIDConnectProviderMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOpenIDConnectProvider");

            var request = InstantiateClassGenerator.Execute<DeleteOpenIDConnectProviderRequest>();
            var marshaller = new DeleteOpenIDConnectProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeletePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePolicy");

            var request = InstantiateClassGenerator.Execute<DeletePolicyRequest>();
            var marshaller = new DeletePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeletePolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePolicyVersion");

            var request = InstantiateClassGenerator.Execute<DeletePolicyVersionRequest>();
            var marshaller = new DeletePolicyVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteRoleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRole");

            var request = InstantiateClassGenerator.Execute<DeleteRoleRequest>();
            var marshaller = new DeleteRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteRolePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRolePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteRolePolicyRequest>();
            var marshaller = new DeleteRolePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteSAMLProviderMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSAMLProvider");

            var request = InstantiateClassGenerator.Execute<DeleteSAMLProviderRequest>();
            var marshaller = new DeleteSAMLProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteServerCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteServerCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteServerCertificateRequest>();
            var marshaller = new DeleteServerCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteSigningCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSigningCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteSigningCertificateRequest>();
            var marshaller = new DeleteSigningCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteSSHPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<DeleteSSHPublicKeyRequest>();
            var marshaller = new DeleteSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteUserMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUser");

            var request = InstantiateClassGenerator.Execute<DeleteUserRequest>();
            var marshaller = new DeleteUserRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteUserPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUserPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteUserPolicyRequest>();
            var marshaller = new DeleteUserPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DeleteVirtualMFADeviceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVirtualMFADevice");

            var request = InstantiateClassGenerator.Execute<DeleteVirtualMFADeviceRequest>();
            var marshaller = new DeleteVirtualMFADeviceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DetachGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DetachGroupPolicy");

            var request = InstantiateClassGenerator.Execute<DetachGroupPolicyRequest>();
            var marshaller = new DetachGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DetachRolePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DetachRolePolicy");

            var request = InstantiateClassGenerator.Execute<DetachRolePolicyRequest>();
            var marshaller = new DetachRolePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void DetachUserPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DetachUserPolicy");

            var request = InstantiateClassGenerator.Execute<DetachUserPolicyRequest>();
            var marshaller = new DetachUserPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void EnableMFADeviceMarshallTest()
        {
            var operation = service_model.FindOperation("EnableMFADevice");

            var request = InstantiateClassGenerator.Execute<EnableMFADeviceRequest>();
            var marshaller = new EnableMFADeviceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GenerateCredentialReportMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateCredentialReport");

            var request = InstantiateClassGenerator.Execute<GenerateCredentialReportRequest>();
            var marshaller = new GenerateCredentialReportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GenerateCredentialReportResponseUnmarshaller.Instance.Unmarshall(context)
                as GenerateCredentialReportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetAccessKeyLastUsedMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessKeyLastUsed");

            var request = InstantiateClassGenerator.Execute<GetAccessKeyLastUsedRequest>();
            var marshaller = new GetAccessKeyLastUsedRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetAccessKeyLastUsedResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAccessKeyLastUsedResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetAccountAuthorizationDetailsMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountAuthorizationDetails");

            var request = InstantiateClassGenerator.Execute<GetAccountAuthorizationDetailsRequest>();
            var marshaller = new GetAccountAuthorizationDetailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAccountAuthorizationDetailsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetAccountPasswordPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountPasswordPolicy");

            var request = InstantiateClassGenerator.Execute<GetAccountPasswordPolicyRequest>();
            var marshaller = new GetAccountPasswordPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetAccountPasswordPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAccountPasswordPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetAccountSummaryMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountSummary");

            var request = InstantiateClassGenerator.Execute<GetAccountSummaryRequest>();
            var marshaller = new GetAccountSummaryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetAccountSummaryResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAccountSummaryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetContextKeysForCustomPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetContextKeysForCustomPolicy");

            var request = InstantiateClassGenerator.Execute<GetContextKeysForCustomPolicyRequest>();
            var marshaller = new GetContextKeysForCustomPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetContextKeysForCustomPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetContextKeysForPrincipalPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetContextKeysForPrincipalPolicy");

            var request = InstantiateClassGenerator.Execute<GetContextKeysForPrincipalPolicyRequest>();
            var marshaller = new GetContextKeysForPrincipalPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetContextKeysForPrincipalPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetCredentialReportMarshallTest()
        {
            var operation = service_model.FindOperation("GetCredentialReport");

            var request = InstantiateClassGenerator.Execute<GetCredentialReportRequest>();
            var marshaller = new GetCredentialReportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetCredentialReportResponseUnmarshaller.Instance.Unmarshall(context)
                as GetCredentialReportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("GetGroup");

            var request = InstantiateClassGenerator.Execute<GetGroupRequest>();
            var marshaller = new GetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as GetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetGroupPolicy");

            var request = InstantiateClassGenerator.Execute<GetGroupPolicyRequest>();
            var marshaller = new GetGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetGroupPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetGroupPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("GetInstanceProfile");

            var request = InstantiateClassGenerator.Execute<GetInstanceProfileRequest>();
            var marshaller = new GetInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetInstanceProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as GetInstanceProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetLoginProfileMarshallTest()
        {
            var operation = service_model.FindOperation("GetLoginProfile");

            var request = InstantiateClassGenerator.Execute<GetLoginProfileRequest>();
            var marshaller = new GetLoginProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetLoginProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as GetLoginProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetOpenIDConnectProviderMarshallTest()
        {
            var operation = service_model.FindOperation("GetOpenIDConnectProvider");

            var request = InstantiateClassGenerator.Execute<GetOpenIDConnectProviderRequest>();
            var marshaller = new GetOpenIDConnectProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetOpenIDConnectProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as GetOpenIDConnectProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetPolicy");

            var request = InstantiateClassGenerator.Execute<GetPolicyRequest>();
            var marshaller = new GetPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetPolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPolicyVersion");

            var request = InstantiateClassGenerator.Execute<GetPolicyVersionRequest>();
            var marshaller = new GetPolicyVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetPolicyVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as GetPolicyVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetRoleMarshallTest()
        {
            var operation = service_model.FindOperation("GetRole");

            var request = InstantiateClassGenerator.Execute<GetRoleRequest>();
            var marshaller = new GetRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetRoleResponseUnmarshaller.Instance.Unmarshall(context)
                as GetRoleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetRolePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetRolePolicy");

            var request = InstantiateClassGenerator.Execute<GetRolePolicyRequest>();
            var marshaller = new GetRolePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetRolePolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetRolePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetSAMLProviderMarshallTest()
        {
            var operation = service_model.FindOperation("GetSAMLProvider");

            var request = InstantiateClassGenerator.Execute<GetSAMLProviderRequest>();
            var marshaller = new GetSAMLProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSAMLProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSAMLProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetServerCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("GetServerCertificate");

            var request = InstantiateClassGenerator.Execute<GetServerCertificateRequest>();
            var marshaller = new GetServerCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetServerCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as GetServerCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetSSHPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("GetSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<GetSSHPublicKeyRequest>();
            var marshaller = new GetSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSSHPublicKeyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSSHPublicKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetUserMarshallTest()
        {
            var operation = service_model.FindOperation("GetUser");

            var request = InstantiateClassGenerator.Execute<GetUserRequest>();
            var marshaller = new GetUserRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetUserResponseUnmarshaller.Instance.Unmarshall(context)
                as GetUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void GetUserPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetUserPolicy");

            var request = InstantiateClassGenerator.Execute<GetUserPolicyRequest>();
            var marshaller = new GetUserPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetUserPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetUserPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListAccessKeysMarshallTest()
        {
            var operation = service_model.FindOperation("ListAccessKeys");

            var request = InstantiateClassGenerator.Execute<ListAccessKeysRequest>();
            var marshaller = new ListAccessKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAccessKeysResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAccessKeysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListAccountAliasesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAccountAliases");

            var request = InstantiateClassGenerator.Execute<ListAccountAliasesRequest>();
            var marshaller = new ListAccountAliasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAccountAliasesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAccountAliasesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListAttachedGroupPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttachedGroupPolicies");

            var request = InstantiateClassGenerator.Execute<ListAttachedGroupPoliciesRequest>();
            var marshaller = new ListAttachedGroupPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAttachedGroupPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAttachedGroupPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListAttachedRolePoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttachedRolePolicies");

            var request = InstantiateClassGenerator.Execute<ListAttachedRolePoliciesRequest>();
            var marshaller = new ListAttachedRolePoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAttachedRolePoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAttachedRolePoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListAttachedUserPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttachedUserPolicies");

            var request = InstantiateClassGenerator.Execute<ListAttachedUserPoliciesRequest>();
            var marshaller = new ListAttachedUserPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAttachedUserPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAttachedUserPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListEntitiesForPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("ListEntitiesForPolicy");

            var request = InstantiateClassGenerator.Execute<ListEntitiesForPolicyRequest>();
            var marshaller = new ListEntitiesForPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListEntitiesForPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as ListEntitiesForPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListGroupPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListGroupPolicies");

            var request = InstantiateClassGenerator.Execute<ListGroupPoliciesRequest>();
            var marshaller = new ListGroupPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListGroupPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListGroupPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("ListGroups");

            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();
            var marshaller = new ListGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListGroupsForUserMarshallTest()
        {
            var operation = service_model.FindOperation("ListGroupsForUser");

            var request = InstantiateClassGenerator.Execute<ListGroupsForUserRequest>();
            var marshaller = new ListGroupsForUserRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListGroupsForUserResponseUnmarshaller.Instance.Unmarshall(context)
                as ListGroupsForUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListInstanceProfilesMarshallTest()
        {
            var operation = service_model.FindOperation("ListInstanceProfiles");

            var request = InstantiateClassGenerator.Execute<ListInstanceProfilesRequest>();
            var marshaller = new ListInstanceProfilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListInstanceProfilesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListInstanceProfilesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListInstanceProfilesForRoleMarshallTest()
        {
            var operation = service_model.FindOperation("ListInstanceProfilesForRole");

            var request = InstantiateClassGenerator.Execute<ListInstanceProfilesForRoleRequest>();
            var marshaller = new ListInstanceProfilesForRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListInstanceProfilesForRoleResponseUnmarshaller.Instance.Unmarshall(context)
                as ListInstanceProfilesForRoleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListMFADevicesMarshallTest()
        {
            var operation = service_model.FindOperation("ListMFADevices");

            var request = InstantiateClassGenerator.Execute<ListMFADevicesRequest>();
            var marshaller = new ListMFADevicesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListMFADevicesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListMFADevicesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListOpenIDConnectProvidersMarshallTest()
        {
            var operation = service_model.FindOperation("ListOpenIDConnectProviders");

            var request = InstantiateClassGenerator.Execute<ListOpenIDConnectProvidersRequest>();
            var marshaller = new ListOpenIDConnectProvidersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListOpenIDConnectProvidersResponseUnmarshaller.Instance.Unmarshall(context)
                as ListOpenIDConnectProvidersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListPolicies");

            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();
            var marshaller = new ListPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListPolicyVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListPolicyVersions");

            var request = InstantiateClassGenerator.Execute<ListPolicyVersionsRequest>();
            var marshaller = new ListPolicyVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListPolicyVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListPolicyVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListRolePoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListRolePolicies");

            var request = InstantiateClassGenerator.Execute<ListRolePoliciesRequest>();
            var marshaller = new ListRolePoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListRolePoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListRolePoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListRolesMarshallTest()
        {
            var operation = service_model.FindOperation("ListRoles");

            var request = InstantiateClassGenerator.Execute<ListRolesRequest>();
            var marshaller = new ListRolesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListRolesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListRolesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListSAMLProvidersMarshallTest()
        {
            var operation = service_model.FindOperation("ListSAMLProviders");

            var request = InstantiateClassGenerator.Execute<ListSAMLProvidersRequest>();
            var marshaller = new ListSAMLProvidersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListSAMLProvidersResponseUnmarshaller.Instance.Unmarshall(context)
                as ListSAMLProvidersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListServerCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListServerCertificates");

            var request = InstantiateClassGenerator.Execute<ListServerCertificatesRequest>();
            var marshaller = new ListServerCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListServerCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListServerCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListSigningCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListSigningCertificates");

            var request = InstantiateClassGenerator.Execute<ListSigningCertificatesRequest>();
            var marshaller = new ListSigningCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListSigningCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListSigningCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListSSHPublicKeysMarshallTest()
        {
            var operation = service_model.FindOperation("ListSSHPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListSSHPublicKeysRequest>();
            var marshaller = new ListSSHPublicKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListSSHPublicKeysResponseUnmarshaller.Instance.Unmarshall(context)
                as ListSSHPublicKeysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListUserPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListUserPolicies");

            var request = InstantiateClassGenerator.Execute<ListUserPoliciesRequest>();
            var marshaller = new ListUserPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListUserPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListUserPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListUsersMarshallTest()
        {
            var operation = service_model.FindOperation("ListUsers");

            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();
            var marshaller = new ListUsersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListUsersResponseUnmarshaller.Instance.Unmarshall(context)
                as ListUsersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ListVirtualMFADevicesMarshallTest()
        {
            var operation = service_model.FindOperation("ListVirtualMFADevices");

            var request = InstantiateClassGenerator.Execute<ListVirtualMFADevicesRequest>();
            var marshaller = new ListVirtualMFADevicesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListVirtualMFADevicesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListVirtualMFADevicesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void PutGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutGroupPolicy");

            var request = InstantiateClassGenerator.Execute<PutGroupPolicyRequest>();
            var marshaller = new PutGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void PutRolePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutRolePolicy");

            var request = InstantiateClassGenerator.Execute<PutRolePolicyRequest>();
            var marshaller = new PutRolePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void PutUserPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutUserPolicy");

            var request = InstantiateClassGenerator.Execute<PutUserPolicyRequest>();
            var marshaller = new PutUserPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void RemoveClientIDFromOpenIDConnectProviderMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveClientIDFromOpenIDConnectProvider");

            var request = InstantiateClassGenerator.Execute<RemoveClientIDFromOpenIDConnectProviderRequest>();
            var marshaller = new RemoveClientIDFromOpenIDConnectProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void RemoveRoleFromInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromInstanceProfile");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromInstanceProfileRequest>();
            var marshaller = new RemoveRoleFromInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void RemoveUserFromGroupMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveUserFromGroup");

            var request = InstantiateClassGenerator.Execute<RemoveUserFromGroupRequest>();
            var marshaller = new RemoveUserFromGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void ResyncMFADeviceMarshallTest()
        {
            var operation = service_model.FindOperation("ResyncMFADevice");

            var request = InstantiateClassGenerator.Execute<ResyncMFADeviceRequest>();
            var marshaller = new ResyncMFADeviceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void SetDefaultPolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("SetDefaultPolicyVersion");

            var request = InstantiateClassGenerator.Execute<SetDefaultPolicyVersionRequest>();
            var marshaller = new SetDefaultPolicyVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void SimulateCustomPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("SimulateCustomPolicy");

            var request = InstantiateClassGenerator.Execute<SimulateCustomPolicyRequest>();
            var marshaller = new SimulateCustomPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SimulateCustomPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as SimulateCustomPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void SimulatePrincipalPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("SimulatePrincipalPolicy");

            var request = InstantiateClassGenerator.Execute<SimulatePrincipalPolicyRequest>();
            var marshaller = new SimulatePrincipalPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SimulatePrincipalPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as SimulatePrincipalPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateAccessKeyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccessKey");

            var request = InstantiateClassGenerator.Execute<UpdateAccessKeyRequest>();
            var marshaller = new UpdateAccessKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateAccountPasswordPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountPasswordPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateAccountPasswordPolicyRequest>();
            var marshaller = new UpdateAccountPasswordPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateAssumeRolePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAssumeRolePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateAssumeRolePolicyRequest>();
            var marshaller = new UpdateAssumeRolePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateGroupMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGroup");

            var request = InstantiateClassGenerator.Execute<UpdateGroupRequest>();
            var marshaller = new UpdateGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateLoginProfileMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateLoginProfile");

            var request = InstantiateClassGenerator.Execute<UpdateLoginProfileRequest>();
            var marshaller = new UpdateLoginProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateOpenIDConnectProviderThumbprintMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOpenIDConnectProviderThumbprint");

            var request = InstantiateClassGenerator.Execute<UpdateOpenIDConnectProviderThumbprintRequest>();
            var marshaller = new UpdateOpenIDConnectProviderThumbprintRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateSAMLProviderMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSAMLProvider");

            var request = InstantiateClassGenerator.Execute<UpdateSAMLProviderRequest>();
            var marshaller = new UpdateSAMLProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateSAMLProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateSAMLProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateServerCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServerCertificate");

            var request = InstantiateClassGenerator.Execute<UpdateServerCertificateRequest>();
            var marshaller = new UpdateServerCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateSigningCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSigningCertificate");

            var request = InstantiateClassGenerator.Execute<UpdateSigningCertificateRequest>();
            var marshaller = new UpdateSigningCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateSSHPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<UpdateSSHPublicKeyRequest>();
            var marshaller = new UpdateSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UpdateUserMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateUser");

            var request = InstantiateClassGenerator.Execute<UpdateUserRequest>();
            var marshaller = new UpdateUserRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UploadServerCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UploadServerCertificate");

            var request = InstantiateClassGenerator.Execute<UploadServerCertificateRequest>();
            var marshaller = new UploadServerCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UploadServerCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as UploadServerCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UploadSigningCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UploadSigningCertificate");

            var request = InstantiateClassGenerator.Execute<UploadSigningCertificateRequest>();
            var marshaller = new UploadSigningCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UploadSigningCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as UploadSigningCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("IdentityManagementService")]
        public void UploadSSHPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("UploadSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<UploadSSHPublicKeyRequest>();
            var marshaller = new UploadSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UploadSSHPublicKeyResponseUnmarshaller.Instance.Unmarshall(context)
                as UploadSSHPublicKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}