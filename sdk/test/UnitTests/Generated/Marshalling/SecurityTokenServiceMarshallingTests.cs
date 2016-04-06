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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class SecurityTokenServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("sts-2011-06-15.normal.json", "sts.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void AssumeRoleMarshallTest()
        {
            var operation = service_model.FindOperation("AssumeRole");

            var request = InstantiateClassGenerator.Execute<AssumeRoleRequest>();
            var marshaller = new AssumeRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AssumeRoleResponseUnmarshaller.Instance.Unmarshall(context)
                as AssumeRoleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void AssumeRoleWithSAMLMarshallTest()
        {
            var operation = service_model.FindOperation("AssumeRoleWithSAML");

            var request = InstantiateClassGenerator.Execute<AssumeRoleWithSAMLRequest>();
            var marshaller = new AssumeRoleWithSAMLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AssumeRoleWithSAMLResponseUnmarshaller.Instance.Unmarshall(context)
                as AssumeRoleWithSAMLResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void AssumeRoleWithWebIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("AssumeRoleWithWebIdentity");

            var request = InstantiateClassGenerator.Execute<AssumeRoleWithWebIdentityRequest>();
            var marshaller = new AssumeRoleWithWebIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance.Unmarshall(context)
                as AssumeRoleWithWebIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void DecodeAuthorizationMessageMarshallTest()
        {
            var operation = service_model.FindOperation("DecodeAuthorizationMessage");

            var request = InstantiateClassGenerator.Execute<DecodeAuthorizationMessageRequest>();
            var marshaller = new DecodeAuthorizationMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DecodeAuthorizationMessageResponseUnmarshaller.Instance.Unmarshall(context)
                as DecodeAuthorizationMessageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void GetCallerIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("GetCallerIdentity");

            var request = InstantiateClassGenerator.Execute<GetCallerIdentityRequest>();
            var marshaller = new GetCallerIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetCallerIdentityResponseUnmarshaller.Instance.Unmarshall(context)
                as GetCallerIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void GetFederationTokenMarshallTest()
        {
            var operation = service_model.FindOperation("GetFederationToken");

            var request = InstantiateClassGenerator.Execute<GetFederationTokenRequest>();
            var marshaller = new GetFederationTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetFederationTokenResponseUnmarshaller.Instance.Unmarshall(context)
                as GetFederationTokenResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SecurityTokenService")]
        public void GetSessionTokenMarshallTest()
        {
            var operation = service_model.FindOperation("GetSessionToken");

            var request = InstantiateClassGenerator.Execute<GetSessionTokenRequest>();
            var marshaller = new GetSessionTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSessionTokenResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSessionTokenResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}