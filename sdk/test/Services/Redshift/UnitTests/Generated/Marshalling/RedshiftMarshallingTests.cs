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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Redshift;
using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class RedshiftMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("redshift");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchangeMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptReservedNodeExchangeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_InvalidReservedNodeStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidReservedNodeStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_ReservedNodeAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_ReservedNodeAlreadyMigratedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyMigratedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AcceptReservedNodeExchange_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedNodeExchange");

            var request = InstantiateClassGenerator.Execute<AcceptReservedNodeExchangeRequest>(operation);
            var marshaller = new AcceptReservedNodeExchangeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AcceptReservedNodeExchangeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AddPartnerMarshallTest()
        {
            var operation = service_model.FindOperation("AddPartner");

            var request = InstantiateClassGenerator.Execute<AddPartnerRequest>(operation);
            var marshaller = new AddPartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AddPartnerResponseUnmarshaller.Instance.Unmarshall(context)
                as AddPartnerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AddPartner_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPartner");

            var request = InstantiateClassGenerator.Execute<AddPartnerRequest>(operation);
            var marshaller = new AddPartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddPartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AddPartner_PartnerNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPartner");

            var request = InstantiateClassGenerator.Execute<AddPartnerRequest>(operation);
            var marshaller = new AddPartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PartnerNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddPartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AddPartner_UnauthorizedPartnerIntegrationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPartner");

            var request = InstantiateClassGenerator.Execute<AddPartnerRequest>(operation);
            var marshaller = new AddPartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedPartnerIntegrationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddPartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AddPartner_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPartner");

            var request = InstantiateClassGenerator.Execute<AddPartnerRequest>(operation);
            var marshaller = new AddPartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddPartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AssociateDataShareConsumerMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateDataShareConsumer");

            var request = InstantiateClassGenerator.Execute<AssociateDataShareConsumerRequest>(operation);
            var marshaller = new AssociateDataShareConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AssociateDataShareConsumerResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateDataShareConsumerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AssociateDataShareConsumer_InvalidDataShareExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateDataShareConsumer");

            var request = InstantiateClassGenerator.Execute<AssociateDataShareConsumerRequest>(operation);
            var marshaller = new AssociateDataShareConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDataShareException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AssociateDataShareConsumerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AssociateDataShareConsumer_InvalidNamespaceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateDataShareConsumer");

            var request = InstantiateClassGenerator.Execute<AssociateDataShareConsumerRequest>(operation);
            var marshaller = new AssociateDataShareConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNamespaceException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AssociateDataShareConsumerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeClusterSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeClusterSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeClusterSecurityGroupIngress_AuthorizationAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeClusterSecurityGroupIngress_AuthorizationQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeClusterSecurityGroupIngress_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeClusterSecurityGroupIngress_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeDataShareMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDataShare");

            var request = InstantiateClassGenerator.Execute<AuthorizeDataShareRequest>(operation);
            var marshaller = new AuthorizeDataShareRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeDataShareResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeDataShareResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeDataShare_InvalidDataShareExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDataShare");

            var request = InstantiateClassGenerator.Execute<AuthorizeDataShareRequest>(operation);
            var marshaller = new AuthorizeDataShareRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDataShareException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeDataShareResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccessMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeEndpointAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccess_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccess_EndpointAuthorizationAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointAuthorizationAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccess_EndpointAuthorizationsPerClusterLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointAuthorizationsPerClusterLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccess_InvalidAuthorizationStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAuthorizationStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccess_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeEndpointAccess_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeEndpointAccessRequest>(operation);
            var marshaller = new AuthorizeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccessMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeSnapshotAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_AuthorizationAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_AuthorizationQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccess_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>(operation);
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void BatchDeleteClusterSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<BatchDeleteClusterSnapshotsRequest>(operation);
            var marshaller = new BatchDeleteClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as BatchDeleteClusterSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void BatchDeleteClusterSnapshots_BatchDeleteRequestSizeExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<BatchDeleteClusterSnapshotsRequest>(operation);
            var marshaller = new BatchDeleteClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchDeleteRequestSizeExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void BatchModifyClusterSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchModifyClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<BatchModifyClusterSnapshotsRequest>(operation);
            var marshaller = new BatchModifyClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as BatchModifyClusterSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void BatchModifyClusterSnapshots_BatchModifyClusterSnapshotsLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchModifyClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<BatchModifyClusterSnapshotsRequest>(operation);
            var marshaller = new BatchModifyClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchModifyClusterSnapshotsLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void BatchModifyClusterSnapshots_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchModifyClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<BatchModifyClusterSnapshotsRequest>(operation);
            var marshaller = new BatchModifyClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CancelResizeMarshallTest()
        {
            var operation = service_model.FindOperation("CancelResize");

            var request = InstantiateClassGenerator.Execute<CancelResizeRequest>(operation);
            var marshaller = new CancelResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CancelResizeResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelResizeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CancelResize_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelResize");

            var request = InstantiateClassGenerator.Execute<CancelResizeRequest>(operation);
            var marshaller = new CancelResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CancelResize_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelResize");

            var request = InstantiateClassGenerator.Execute<CancelResizeRequest>(operation);
            var marshaller = new CancelResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CancelResize_ResizeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelResize");

            var request = InstantiateClassGenerator.Execute<CancelResizeRequest>(operation);
            var marshaller = new CancelResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResizeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CancelResize_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelResize");

            var request = InstantiateClassGenerator.Execute<CancelResizeRequest>(operation);
            var marshaller = new CancelResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshot_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshot_ClusterSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshot_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshot_ClusterSnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshot_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshot_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>(operation);
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateAuthenticationProfileMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<CreateAuthenticationProfileRequest>(operation);
            var marshaller = new CreateAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateAuthenticationProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateAuthenticationProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateAuthenticationProfile_AuthenticationProfileAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<CreateAuthenticationProfileRequest>(operation);
            var marshaller = new CreateAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthenticationProfileAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateAuthenticationProfile_AuthenticationProfileQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<CreateAuthenticationProfileRequest>(operation);
            var marshaller = new CreateAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthenticationProfileQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateAuthenticationProfile_InvalidAuthenticationProfileRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<CreateAuthenticationProfileRequest>(operation);
            var marshaller = new CreateAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAuthenticationProfileRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_ClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_ClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_ClusterSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_HsmClientCertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_HsmConfigurationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InsufficientClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidClusterSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidClusterTrackExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterTrackException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidElasticIpExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidElasticIpException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_Ipv6CidrBlockNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("Ipv6CidrBlockNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_NumberOfNodesPerClusterLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesPerClusterLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_NumberOfNodesQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_RedshiftIdcApplicationNotExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("RedshiftIdcApplicationNotExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_SnapshotScheduleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCluster_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>(operation);
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterParameterGroupRequest>(operation);
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterParameterGroup_ClusterParameterGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterParameterGroupRequest>(operation);
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterParameterGroup_ClusterParameterGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterParameterGroupRequest>(operation);
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterParameterGroup_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterParameterGroupRequest>(operation);
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterParameterGroup_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterParameterGroupRequest>(operation);
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSecurityGroupRequest>(operation);
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterSecurityGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterSecurityGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSecurityGroup_ClusterSecurityGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSecurityGroupRequest>(operation);
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSecurityGroup_ClusterSecurityGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSecurityGroupRequest>(operation);
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSecurityGroup_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSecurityGroupRequest>(operation);
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSecurityGroup_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSecurityGroupRequest>(operation);
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_ClusterSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_ClusterSnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshot_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>(operation);
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_ClusterSubnetGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_ClusterSubnetGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_ClusterSubnetQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroup_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>(operation);
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCustomDomainAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<CreateCustomDomainAssociationRequest>(operation);
            var marshaller = new CreateCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateCustomDomainAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCustomDomainAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCustomDomainAssociation_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<CreateCustomDomainAssociationRequest>(operation);
            var marshaller = new CreateCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCustomDomainAssociation_CustomCnameAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<CreateCustomDomainAssociationRequest>(operation);
            var marshaller = new CreateCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomCnameAssociationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateCustomDomainAssociation_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<CreateCustomDomainAssociationRequest>(operation);
            var marshaller = new CreateCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccessMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateEndpointAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_AccessToClusterDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessToClusterDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_ClusterSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_EndpointAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_EndpointsPerAuthorizationLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointsPerAuthorizationLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_EndpointsPerClusterLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointsPerClusterLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEndpointAccess_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEndpointAccess");

            var request = InstantiateClassGenerator.Execute<CreateEndpointAccessRequest>(operation);
            var marshaller = new CreateEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_EventSubscriptionQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventSubscriptionQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SNSInvalidTopicExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSInvalidTopicException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SNSNoAuthorizationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSNoAuthorizationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SNSTopicArnNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSTopicArnNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SubscriptionAlreadyExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionAlreadyExistException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SubscriptionCategoryNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionCategoryNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SubscriptionEventIdNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionEventIdNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_SubscriptionSeverityNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionSeverityNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateEventSubscription_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>(operation);
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<CreateHsmClientCertificateRequest>(operation);
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateHsmClientCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateHsmClientCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmClientCertificate_HsmClientCertificateAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<CreateHsmClientCertificateRequest>(operation);
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmClientCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmClientCertificate_HsmClientCertificateQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<CreateHsmClientCertificateRequest>(operation);
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmClientCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmClientCertificate_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<CreateHsmClientCertificateRequest>(operation);
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmClientCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmClientCertificate_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<CreateHsmClientCertificateRequest>(operation);
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmClientCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateHsmConfigurationRequest>(operation);
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateHsmConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateHsmConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmConfiguration_HsmConfigurationAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateHsmConfigurationRequest>(operation);
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmConfiguration_HsmConfigurationQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateHsmConfigurationRequest>(operation);
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmConfiguration_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateHsmConfigurationRequest>(operation);
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmConfiguration_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateHsmConfigurationRequest>(operation);
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateHsmConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateRedshiftIdcApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<CreateRedshiftIdcApplicationRequest>(operation);
            var marshaller = new CreateRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateRedshiftIdcApplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateRedshiftIdcApplication_DependentServiceAccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<CreateRedshiftIdcApplicationRequest>(operation);
            var marshaller = new CreateRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceAccessDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateRedshiftIdcApplication_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<CreateRedshiftIdcApplicationRequest>(operation);
            var marshaller = new CreateRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateRedshiftIdcApplication_RedshiftIdcApplicationAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<CreateRedshiftIdcApplicationRequest>(operation);
            var marshaller = new CreateRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("RedshiftIdcApplicationAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateRedshiftIdcApplication_RedshiftIdcApplicationQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<CreateRedshiftIdcApplicationRequest>(operation);
            var marshaller = new CreateRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("RedshiftIdcApplicationQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateRedshiftIdcApplication_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<CreateRedshiftIdcApplicationRequest>(operation);
            var marshaller = new CreateRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledActionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateScheduledActionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_InvalidScheduledActionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidScheduledActionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_InvalidScheduleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidScheduleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_ScheduledActionAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_ScheduledActionQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_ScheduledActionTypeUnsupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionTypeUnsupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateScheduledAction_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateScheduledAction");

            var request = InstantiateClassGenerator.Execute<CreateScheduledActionRequest>(operation);
            var marshaller = new CreateScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrantMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSnapshotCopyGrantResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrant_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrant_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrant_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrant_SnapshotCopyGrantAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyGrantAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrant_SnapshotCopyGrantQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyGrantQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrant_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>(operation);
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotScheduleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSnapshotScheduleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotSchedule_InvalidScheduleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidScheduleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotSchedule_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotSchedule_ScheduleDefinitionTypeUnsupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduleDefinitionTypeUnsupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotSchedule_SnapshotScheduleAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotSchedule_SnapshotScheduleQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotSchedule_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotScheduleRequest>(operation);
            var marshaller = new CreateSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateTagsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>(operation);
            var marshaller = new CreateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateTags_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>(operation);
            var marshaller = new CreateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateTags_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>(operation);
            var marshaller = new CreateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateTags_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>(operation);
            var marshaller = new CreateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateTags_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>(operation);
            var marshaller = new CreateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimitMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateUsageLimitResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_InvalidUsageLimitExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidUsageLimitException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateUsageLimit_UsageLimitAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUsageLimit");

            var request = InstantiateClassGenerator.Execute<CreateUsageLimitRequest>(operation);
            var marshaller = new CreateUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UsageLimitAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeauthorizeDataShareMarshallTest()
        {
            var operation = service_model.FindOperation("DeauthorizeDataShare");

            var request = InstantiateClassGenerator.Execute<DeauthorizeDataShareRequest>(operation);
            var marshaller = new DeauthorizeDataShareRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeauthorizeDataShareResponseUnmarshaller.Instance.Unmarshall(context)
                as DeauthorizeDataShareResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeauthorizeDataShare_InvalidDataShareExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeauthorizeDataShare");

            var request = InstantiateClassGenerator.Execute<DeauthorizeDataShareRequest>(operation);
            var marshaller = new DeauthorizeDataShareRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDataShareException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeauthorizeDataShareResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteAuthenticationProfileMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<DeleteAuthenticationProfileRequest>(operation);
            var marshaller = new DeleteAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteAuthenticationProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteAuthenticationProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteAuthenticationProfile_AuthenticationProfileNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<DeleteAuthenticationProfileRequest>(operation);
            var marshaller = new DeleteAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthenticationProfileNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteAuthenticationProfile_InvalidAuthenticationProfileRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<DeleteAuthenticationProfileRequest>(operation);
            var marshaller = new DeleteAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAuthenticationProfileRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>(operation);
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCluster_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>(operation);
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCluster_ClusterSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>(operation);
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCluster_ClusterSnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>(operation);
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCluster_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>(operation);
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCluster_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>(operation);
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterParameterGroupRequest>(operation);
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterParameterGroup_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterParameterGroupRequest>(operation);
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterParameterGroup_InvalidClusterParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterParameterGroupRequest>(operation);
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSecurityGroupRequest>(operation);
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSecurityGroup_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSecurityGroupRequest>(operation);
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSecurityGroup_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSecurityGroupRequest>(operation);
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSnapshotRequest>(operation);
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSnapshot_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSnapshotRequest>(operation);
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSnapshot_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSnapshotRequest>(operation);
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSubnetGroupRequest>(operation);
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSubnetGroup_ClusterSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSubnetGroupRequest>(operation);
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSubnetGroup_InvalidClusterSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSubnetGroupRequest>(operation);
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSubnetGroup_InvalidClusterSubnetStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSubnetGroupRequest>(operation);
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSubnetStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCustomDomainAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDomainAssociationRequest>(operation);
            var marshaller = new DeleteCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCustomDomainAssociation_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDomainAssociationRequest>(operation);
            var marshaller = new DeleteCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCustomDomainAssociation_CustomCnameAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDomainAssociationRequest>(operation);
            var marshaller = new DeleteCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomCnameAssociationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCustomDomainAssociation_CustomDomainAssociationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDomainAssociationRequest>(operation);
            var marshaller = new DeleteCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDomainAssociationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteCustomDomainAssociation_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDomainAssociationRequest>(operation);
            var marshaller = new DeleteCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEndpointAccessMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointAccessRequest>(operation);
            var marshaller = new DeleteEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteEndpointAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteEndpointAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEndpointAccess_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointAccessRequest>(operation);
            var marshaller = new DeleteEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEndpointAccess_EndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointAccessRequest>(operation);
            var marshaller = new DeleteEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEndpointAccess_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointAccessRequest>(operation);
            var marshaller = new DeleteEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEndpointAccess_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointAccessRequest>(operation);
            var marshaller = new DeleteEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEndpointAccess_InvalidEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointAccessRequest>(operation);
            var marshaller = new DeleteEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>(operation);
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEventSubscription_InvalidSubscriptionStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>(operation);
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubscriptionStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEventSubscription_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>(operation);
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteHsmClientCertificateRequest>(operation);
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmClientCertificate_HsmClientCertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteHsmClientCertificateRequest>(operation);
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteHsmClientCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmClientCertificate_InvalidHsmClientCertificateStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteHsmClientCertificateRequest>(operation);
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHsmClientCertificateStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteHsmClientCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteHsmConfigurationRequest>(operation);
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmConfiguration_HsmConfigurationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteHsmConfigurationRequest>(operation);
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteHsmConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmConfiguration_InvalidHsmConfigurationStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteHsmConfigurationRequest>(operation);
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHsmConfigurationStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteHsmConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeletePartnerMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePartner");

            var request = InstantiateClassGenerator.Execute<DeletePartnerRequest>(operation);
            var marshaller = new DeletePartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeletePartnerResponseUnmarshaller.Instance.Unmarshall(context)
                as DeletePartnerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeletePartner_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePartner");

            var request = InstantiateClassGenerator.Execute<DeletePartnerRequest>(operation);
            var marshaller = new DeletePartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeletePartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeletePartner_PartnerNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePartner");

            var request = InstantiateClassGenerator.Execute<DeletePartnerRequest>(operation);
            var marshaller = new DeletePartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PartnerNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeletePartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeletePartner_UnauthorizedPartnerIntegrationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePartner");

            var request = InstantiateClassGenerator.Execute<DeletePartnerRequest>(operation);
            var marshaller = new DeletePartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedPartnerIntegrationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeletePartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeletePartner_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePartner");

            var request = InstantiateClassGenerator.Execute<DeletePartnerRequest>(operation);
            var marshaller = new DeletePartnerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeletePartnerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteRedshiftIdcApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<DeleteRedshiftIdcApplicationRequest>(operation);
            var marshaller = new DeleteRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteRedshiftIdcApplication_DependentServiceAccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<DeleteRedshiftIdcApplicationRequest>(operation);
            var marshaller = new DeleteRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceAccessDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteRedshiftIdcApplication_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<DeleteRedshiftIdcApplicationRequest>(operation);
            var marshaller = new DeleteRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteRedshiftIdcApplication_RedshiftIdcApplicationNotExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<DeleteRedshiftIdcApplicationRequest>(operation);
            var marshaller = new DeleteRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("RedshiftIdcApplicationNotExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteRedshiftIdcApplication_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<DeleteRedshiftIdcApplicationRequest>(operation);
            var marshaller = new DeleteRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteResourcePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>(operation);
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteResourcePolicy_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>(operation);
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteResourcePolicy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>(operation);
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteScheduledActionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteScheduledAction");

            var request = InstantiateClassGenerator.Execute<DeleteScheduledActionRequest>(operation);
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteScheduledAction_ScheduledActionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteScheduledAction");

            var request = InstantiateClassGenerator.Execute<DeleteScheduledActionRequest>(operation);
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteScheduledAction_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteScheduledAction");

            var request = InstantiateClassGenerator.Execute<DeleteScheduledActionRequest>(operation);
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotCopyGrantMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotCopyGrantRequest>(operation);
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotCopyGrant_InvalidSnapshotCopyGrantStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotCopyGrantRequest>(operation);
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSnapshotCopyGrantStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotCopyGrant_SnapshotCopyGrantNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotCopyGrantRequest>(operation);
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyGrantNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotScheduleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotScheduleRequest>(operation);
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotSchedule_InvalidClusterSnapshotScheduleStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotScheduleRequest>(operation);
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotScheduleStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotSchedule_SnapshotScheduleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotScheduleRequest>(operation);
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTags");

            var request = InstantiateClassGenerator.Execute<DeleteTagsRequest>(operation);
            var marshaller = new DeleteTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteTags_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTags");

            var request = InstantiateClassGenerator.Execute<DeleteTagsRequest>(operation);
            var marshaller = new DeleteTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteTags_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTags");

            var request = InstantiateClassGenerator.Execute<DeleteTagsRequest>(operation);
            var marshaller = new DeleteTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteUsageLimitMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUsageLimit");

            var request = InstantiateClassGenerator.Execute<DeleteUsageLimitRequest>(operation);
            var marshaller = new DeleteUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteUsageLimit_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUsageLimit");

            var request = InstantiateClassGenerator.Execute<DeleteUsageLimitRequest>(operation);
            var marshaller = new DeleteUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteUsageLimit_UsageLimitNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUsageLimit");

            var request = InstantiateClassGenerator.Execute<DeleteUsageLimitRequest>(operation);
            var marshaller = new DeleteUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UsageLimitNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeAccountAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAccountAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeAccountAttributesRequest>(operation);
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAccountAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAccountAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeAuthenticationProfilesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAuthenticationProfiles");

            var request = InstantiateClassGenerator.Execute<DescribeAuthenticationProfilesRequest>(operation);
            var marshaller = new DescribeAuthenticationProfilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAuthenticationProfilesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAuthenticationProfilesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeAuthenticationProfiles_AuthenticationProfileNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAuthenticationProfiles");

            var request = InstantiateClassGenerator.Execute<DescribeAuthenticationProfilesRequest>(operation);
            var marshaller = new DescribeAuthenticationProfilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthenticationProfileNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAuthenticationProfilesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeAuthenticationProfiles_InvalidAuthenticationProfileRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAuthenticationProfiles");

            var request = InstantiateClassGenerator.Execute<DescribeAuthenticationProfilesRequest>(operation);
            var marshaller = new DescribeAuthenticationProfilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAuthenticationProfileRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAuthenticationProfilesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterDbRevisionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterDbRevisions");

            var request = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsRequest>(operation);
            var marshaller = new DescribeClusterDbRevisionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterDbRevisionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterDbRevisionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterDbRevisions_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterDbRevisions");

            var request = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsRequest>(operation);
            var marshaller = new DescribeClusterDbRevisionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterDbRevisionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterDbRevisions_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterDbRevisions");

            var request = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsRequest>(operation);
            var marshaller = new DescribeClusterDbRevisionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterDbRevisionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsRequest>(operation);
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParameterGroups_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsRequest>(operation);
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterParameterGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParameterGroups_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsRequest>(operation);
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterParameterGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParametersRequest>(operation);
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParameters_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParametersRequest>(operation);
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClustersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusters");

            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>(operation);
            var marshaller = new DescribeClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClustersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusters_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusters");

            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>(operation);
            var marshaller = new DescribeClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClustersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusters_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusters");

            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>(operation);
            var marshaller = new DescribeClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClustersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsRequest>(operation);
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSecurityGroups_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsRequest>(operation);
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSecurityGroups_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsRequest>(operation);
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>(operation);
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshots_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>(operation);
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshots_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>(operation);
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshots_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>(operation);
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshots_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>(operation);
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSubnetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsRequest>(operation);
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterSubnetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSubnetGroups_ClusterSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsRequest>(operation);
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSubnetGroups_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsRequest>(operation);
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterTracksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterTracks");

            var request = InstantiateClassGenerator.Execute<DescribeClusterTracksRequest>(operation);
            var marshaller = new DescribeClusterTracksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterTracksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterTracksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterTracks_InvalidClusterTrackExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterTracks");

            var request = InstantiateClassGenerator.Execute<DescribeClusterTracksRequest>(operation);
            var marshaller = new DescribeClusterTracksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterTrackException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterTracksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterTracks_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterTracks");

            var request = InstantiateClassGenerator.Execute<DescribeClusterTracksRequest>(operation);
            var marshaller = new DescribeClusterTracksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeClusterTracksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterVersions");

            var request = InstantiateClassGenerator.Execute<DescribeClusterVersionsRequest>(operation);
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeCustomDomainAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCustomDomainAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeCustomDomainAssociationsRequest>(operation);
            var marshaller = new DescribeCustomDomainAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCustomDomainAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCustomDomainAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeCustomDomainAssociations_CustomDomainAssociationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCustomDomainAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeCustomDomainAssociationsRequest>(operation);
            var marshaller = new DescribeCustomDomainAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDomainAssociationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeCustomDomainAssociationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeCustomDomainAssociations_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCustomDomainAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeCustomDomainAssociationsRequest>(operation);
            var marshaller = new DescribeCustomDomainAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeCustomDomainAssociationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDataSharesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataShares");

            var request = InstantiateClassGenerator.Execute<DescribeDataSharesRequest>(operation);
            var marshaller = new DescribeDataSharesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDataSharesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDataSharesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDataShares_InvalidDataShareExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataShares");

            var request = InstantiateClassGenerator.Execute<DescribeDataSharesRequest>(operation);
            var marshaller = new DescribeDataSharesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDataShareException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDataSharesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDataSharesForConsumerMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataSharesForConsumer");

            var request = InstantiateClassGenerator.Execute<DescribeDataSharesForConsumerRequest>(operation);
            var marshaller = new DescribeDataSharesForConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDataSharesForConsumerResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDataSharesForConsumerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDataSharesForConsumer_InvalidNamespaceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataSharesForConsumer");

            var request = InstantiateClassGenerator.Execute<DescribeDataSharesForConsumerRequest>(operation);
            var marshaller = new DescribeDataSharesForConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNamespaceException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDataSharesForConsumerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDataSharesForProducerMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataSharesForProducer");

            var request = InstantiateClassGenerator.Execute<DescribeDataSharesForProducerRequest>(operation);
            var marshaller = new DescribeDataSharesForProducerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDataSharesForProducerResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDataSharesForProducerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDataSharesForProducer_InvalidNamespaceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataSharesForProducer");

            var request = InstantiateClassGenerator.Execute<DescribeDataSharesForProducerRequest>(operation);
            var marshaller = new DescribeDataSharesForProducerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNamespaceException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDataSharesForProducerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDefaultClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDefaultClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersRequest>(operation);
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDefaultClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDefaultClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAccessMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAccessRequest>(operation);
            var marshaller = new DescribeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEndpointAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEndpointAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAccess_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAccessRequest>(operation);
            var marshaller = new DescribeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAccess_EndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAccessRequest>(operation);
            var marshaller = new DescribeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAccess_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAccessRequest>(operation);
            var marshaller = new DescribeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAuthorizationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAuthorization");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAuthorizationRequest>(operation);
            var marshaller = new DescribeEndpointAuthorizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEndpointAuthorizationResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEndpointAuthorizationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAuthorization_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAuthorization");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAuthorizationRequest>(operation);
            var marshaller = new DescribeEndpointAuthorizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEndpointAuthorizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEndpointAuthorization_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpointAuthorization");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointAuthorizationRequest>(operation);
            var marshaller = new DescribeEndpointAuthorizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEndpointAuthorizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEventCategoriesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventCategories");

            var request = InstantiateClassGenerator.Execute<DescribeEventCategoriesRequest>(operation);
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventCategoriesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventCategoriesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEventsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEvents");

            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>(operation);
            var marshaller = new DescribeEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEventSubscriptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>(operation);
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventSubscriptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventSubscriptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEventSubscriptions_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>(operation);
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEventSubscriptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeEventSubscriptions_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>(operation);
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEventSubscriptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmClientCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmClientCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesRequest>(operation);
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeHsmClientCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHsmClientCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmClientCertificates_HsmClientCertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmClientCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesRequest>(operation);
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeHsmClientCertificatesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmClientCertificates_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmClientCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesRequest>(operation);
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeHsmClientCertificatesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsRequest>(operation);
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeHsmConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHsmConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmConfigurations_HsmConfigurationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsRequest>(operation);
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeHsmConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmConfigurations_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsRequest>(operation);
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeHsmConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeInboundIntegrationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInboundIntegrations");

            var request = InstantiateClassGenerator.Execute<DescribeInboundIntegrationsRequest>(operation);
            var marshaller = new DescribeInboundIntegrationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeInboundIntegrationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInboundIntegrationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeInboundIntegrations_IntegrationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInboundIntegrations");

            var request = InstantiateClassGenerator.Execute<DescribeInboundIntegrationsRequest>(operation);
            var marshaller = new DescribeInboundIntegrationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("IntegrationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeInboundIntegrationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeInboundIntegrations_InvalidNamespaceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInboundIntegrations");

            var request = InstantiateClassGenerator.Execute<DescribeInboundIntegrationsRequest>(operation);
            var marshaller = new DescribeInboundIntegrationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNamespaceException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeInboundIntegrationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeInboundIntegrations_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInboundIntegrations");

            var request = InstantiateClassGenerator.Execute<DescribeInboundIntegrationsRequest>(operation);
            var marshaller = new DescribeInboundIntegrationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeInboundIntegrationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeLoggingStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoggingStatus");

            var request = InstantiateClassGenerator.Execute<DescribeLoggingStatusRequest>(operation);
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLoggingStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoggingStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeLoggingStatus_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoggingStatus");

            var request = InstantiateClassGenerator.Execute<DescribeLoggingStatusRequest>(operation);
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoggingStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeLoggingStatus_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoggingStatus");

            var request = InstantiateClassGenerator.Execute<DescribeLoggingStatusRequest>(operation);
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoggingStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNodeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>(operation);
            var marshaller = new DescribeNodeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNodeConfigurationOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptions_AccessToSnapshotDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNodeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>(operation);
            var marshaller = new DescribeNodeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessToSnapshotDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptions_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNodeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>(operation);
            var marshaller = new DescribeNodeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptions_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNodeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>(operation);
            var marshaller = new DescribeNodeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptions_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNodeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>(operation);
            var marshaller = new DescribeNodeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptions_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNodeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>(operation);
            var marshaller = new DescribeNodeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeOrderableClusterOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrderableClusterOptions");

            var request = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsRequest>(operation);
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOrderableClusterOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribePartnersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePartners");

            var request = InstantiateClassGenerator.Execute<DescribePartnersRequest>(operation);
            var marshaller = new DescribePartnersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribePartnersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePartnersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribePartners_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePartners");

            var request = InstantiateClassGenerator.Execute<DescribePartnersRequest>(operation);
            var marshaller = new DescribePartnersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribePartnersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribePartners_UnauthorizedPartnerIntegrationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePartners");

            var request = InstantiateClassGenerator.Execute<DescribePartnersRequest>(operation);
            var marshaller = new DescribePartnersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedPartnerIntegrationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribePartnersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribePartners_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePartners");

            var request = InstantiateClassGenerator.Execute<DescribePartnersRequest>(operation);
            var marshaller = new DescribePartnersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribePartnersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeRedshiftIdcApplicationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRedshiftIdcApplications");

            var request = InstantiateClassGenerator.Execute<DescribeRedshiftIdcApplicationsRequest>(operation);
            var marshaller = new DescribeRedshiftIdcApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRedshiftIdcApplicationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeRedshiftIdcApplications_DependentServiceAccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRedshiftIdcApplications");

            var request = InstantiateClassGenerator.Execute<DescribeRedshiftIdcApplicationsRequest>(operation);
            var marshaller = new DescribeRedshiftIdcApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceAccessDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeRedshiftIdcApplications_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRedshiftIdcApplications");

            var request = InstantiateClassGenerator.Execute<DescribeRedshiftIdcApplicationsRequest>(operation);
            var marshaller = new DescribeRedshiftIdcApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeRedshiftIdcApplications_RedshiftIdcApplicationNotExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRedshiftIdcApplications");

            var request = InstantiateClassGenerator.Execute<DescribeRedshiftIdcApplicationsRequest>(operation);
            var marshaller = new DescribeRedshiftIdcApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("RedshiftIdcApplicationNotExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeRedshiftIdcApplications_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRedshiftIdcApplications");

            var request = InstantiateClassGenerator.Execute<DescribeRedshiftIdcApplicationsRequest>(operation);
            var marshaller = new DescribeRedshiftIdcApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeRedshiftIdcApplicationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeExchangeStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeExchangeStatus");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeExchangeStatusRequest>(operation);
            var marshaller = new DescribeReservedNodeExchangeStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedNodeExchangeStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeExchangeStatus_ReservedNodeExchangeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeExchangeStatus");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeExchangeStatusRequest>(operation);
            var marshaller = new DescribeReservedNodeExchangeStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeExchangeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeExchangeStatus_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeExchangeStatus");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeExchangeStatusRequest>(operation);
            var marshaller = new DescribeReservedNodeExchangeStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeExchangeStatus_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeExchangeStatus");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeExchangeStatusRequest>(operation);
            var marshaller = new DescribeReservedNodeExchangeStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>(operation);
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedNodeOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeOfferings_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>(operation);
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeOfferings_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>(operation);
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeOfferings_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>(operation);
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodes");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodesRequest>(operation);
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedNodesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedNodesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodes_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodes");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodesRequest>(operation);
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodes_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodes");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodesRequest>(operation);
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedNodesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeResizeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResize");

            var request = InstantiateClassGenerator.Execute<DescribeResizeRequest>(operation);
            var marshaller = new DescribeResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeResizeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeResizeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeResize_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResize");

            var request = InstantiateClassGenerator.Execute<DescribeResizeRequest>(operation);
            var marshaller = new DescribeResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeResize_ResizeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResize");

            var request = InstantiateClassGenerator.Execute<DescribeResizeRequest>(operation);
            var marshaller = new DescribeResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResizeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeResize_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResize");

            var request = InstantiateClassGenerator.Execute<DescribeResizeRequest>(operation);
            var marshaller = new DescribeResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeResizeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeScheduledActionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledActions");

            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>(operation);
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeScheduledActionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScheduledActionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeScheduledActions_ScheduledActionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledActions");

            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>(operation);
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeScheduledActionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeScheduledActions_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledActions");

            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>(operation);
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeScheduledActionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotCopyGrantsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotCopyGrants");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsRequest>(operation);
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotCopyGrantsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotCopyGrants_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotCopyGrants");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsRequest>(operation);
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotCopyGrants_SnapshotCopyGrantNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotCopyGrants");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsRequest>(operation);
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyGrantNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotSchedulesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotSchedules");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotSchedulesRequest>(operation);
            var marshaller = new DescribeSnapshotSchedulesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSnapshotSchedulesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotSchedulesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeStorageMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStorage");

            var request = InstantiateClassGenerator.Execute<DescribeStorageRequest>(operation);
            var marshaller = new DescribeStorageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStorageResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStorageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTableRestoreStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableRestoreStatus");

            var request = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusRequest>(operation);
            var marshaller = new DescribeTableRestoreStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTableRestoreStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTableRestoreStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTableRestoreStatus_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableRestoreStatus");

            var request = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusRequest>(operation);
            var marshaller = new DescribeTableRestoreStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTableRestoreStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTableRestoreStatus_TableRestoreNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableRestoreStatus");

            var request = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusRequest>(operation);
            var marshaller = new DescribeTableRestoreStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TableRestoreNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTableRestoreStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>(operation);
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTags_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>(operation);
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTags_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>(operation);
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeUsageLimitsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeUsageLimits");

            var request = InstantiateClassGenerator.Execute<DescribeUsageLimitsRequest>(operation);
            var marshaller = new DescribeUsageLimitsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeUsageLimitsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeUsageLimitsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeUsageLimits_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeUsageLimits");

            var request = InstantiateClassGenerator.Execute<DescribeUsageLimitsRequest>(operation);
            var marshaller = new DescribeUsageLimitsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeUsageLimitsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeUsageLimits_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeUsageLimits");

            var request = InstantiateClassGenerator.Execute<DescribeUsageLimitsRequest>(operation);
            var marshaller = new DescribeUsageLimitsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeUsageLimitsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableLoggingMarshallTest()
        {
            var operation = service_model.FindOperation("DisableLogging");

            var request = InstantiateClassGenerator.Execute<DisableLoggingRequest>(operation);
            var marshaller = new DisableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DisableLoggingResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableLoggingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableLogging_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableLogging");

            var request = InstantiateClassGenerator.Execute<DisableLoggingRequest>(operation);
            var marshaller = new DisableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableLogging_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableLogging");

            var request = InstantiateClassGenerator.Execute<DisableLoggingRequest>(operation);
            var marshaller = new DisableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableLogging_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableLogging");

            var request = InstantiateClassGenerator.Execute<DisableLoggingRequest>(operation);
            var marshaller = new DisableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopyMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>(operation);
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableSnapshotCopyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopy_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>(operation);
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopy_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>(operation);
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopy_SnapshotCopyAlreadyDisabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>(operation);
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyAlreadyDisabledException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopy_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>(operation);
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>(operation);
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisassociateDataShareConsumerMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateDataShareConsumer");

            var request = InstantiateClassGenerator.Execute<DisassociateDataShareConsumerRequest>(operation);
            var marshaller = new DisassociateDataShareConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DisassociateDataShareConsumerResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateDataShareConsumerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisassociateDataShareConsumer_InvalidDataShareExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateDataShareConsumer");

            var request = InstantiateClassGenerator.Execute<DisassociateDataShareConsumerRequest>(operation);
            var marshaller = new DisassociateDataShareConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDataShareException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisassociateDataShareConsumerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisassociateDataShareConsumer_InvalidNamespaceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateDataShareConsumer");

            var request = InstantiateClassGenerator.Execute<DisassociateDataShareConsumerRequest>(operation);
            var marshaller = new DisassociateDataShareConsumerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNamespaceException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisassociateDataShareConsumerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLoggingMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EnableLoggingResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableLoggingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_BucketNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BucketNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_InsufficientS3BucketPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientS3BucketPolicyException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_InvalidS3BucketNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_InvalidS3KeyPrefixExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3KeyPrefixException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLogging_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>(operation);
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopyMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableSnapshotCopyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_CopyToRegionDisabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CopyToRegionDisabledException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_IncompatibleOrderableOptionsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("IncompatibleOrderableOptionsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_SnapshotCopyAlreadyEnabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyAlreadyEnabledException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_SnapshotCopyGrantNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyGrantNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopy_UnknownSnapshotCopyRegionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>(operation);
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnknownSnapshotCopyRegionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void FailoverPrimaryComputeMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverPrimaryCompute");

            var request = InstantiateClassGenerator.Execute<FailoverPrimaryComputeRequest>(operation);
            var marshaller = new FailoverPrimaryComputeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FailoverPrimaryComputeResponseUnmarshaller.Instance.Unmarshall(context)
                as FailoverPrimaryComputeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void FailoverPrimaryCompute_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverPrimaryCompute");

            var request = InstantiateClassGenerator.Execute<FailoverPrimaryComputeRequest>(operation);
            var marshaller = new FailoverPrimaryComputeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverPrimaryComputeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void FailoverPrimaryCompute_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverPrimaryCompute");

            var request = InstantiateClassGenerator.Execute<FailoverPrimaryComputeRequest>(operation);
            var marshaller = new FailoverPrimaryComputeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverPrimaryComputeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void FailoverPrimaryCompute_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverPrimaryCompute");

            var request = InstantiateClassGenerator.Execute<FailoverPrimaryComputeRequest>(operation);
            var marshaller = new FailoverPrimaryComputeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverPrimaryComputeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void FailoverPrimaryCompute_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverPrimaryCompute");

            var request = InstantiateClassGenerator.Execute<FailoverPrimaryComputeRequest>(operation);
            var marshaller = new FailoverPrimaryComputeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverPrimaryComputeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetClusterCredentialsMarshallTest()
        {
            var operation = service_model.FindOperation("GetClusterCredentials");

            var request = InstantiateClassGenerator.Execute<GetClusterCredentialsRequest>(operation);
            var marshaller = new GetClusterCredentialsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetClusterCredentialsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetClusterCredentialsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetClusterCredentials_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetClusterCredentials");

            var request = InstantiateClassGenerator.Execute<GetClusterCredentialsRequest>(operation);
            var marshaller = new GetClusterCredentialsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetClusterCredentialsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetClusterCredentials_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetClusterCredentials");

            var request = InstantiateClassGenerator.Execute<GetClusterCredentialsRequest>(operation);
            var marshaller = new GetClusterCredentialsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetClusterCredentialsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetClusterCredentialsWithIAMMarshallTest()
        {
            var operation = service_model.FindOperation("GetClusterCredentialsWithIAM");

            var request = InstantiateClassGenerator.Execute<GetClusterCredentialsWithIAMRequest>(operation);
            var marshaller = new GetClusterCredentialsWithIAMRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance.Unmarshall(context)
                as GetClusterCredentialsWithIAMResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetClusterCredentialsWithIAM_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetClusterCredentialsWithIAM");

            var request = InstantiateClassGenerator.Execute<GetClusterCredentialsWithIAMRequest>(operation);
            var marshaller = new GetClusterCredentialsWithIAMRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetClusterCredentialsWithIAM_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetClusterCredentialsWithIAM");

            var request = InstantiateClassGenerator.Execute<GetClusterCredentialsWithIAMRequest>(operation);
            var marshaller = new GetClusterCredentialsWithIAMRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetReservedNodeExchangeConfigurationOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_InvalidReservedNodeStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidReservedNodeStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_ReservedNodeAlreadyMigratedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyMigratedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeConfigurationOptions_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeConfigurationOptionsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetReservedNodeExchangeOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferings_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferings_InvalidReservedNodeStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidReservedNodeStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferings_ReservedNodeAlreadyMigratedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyMigratedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferings_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferings_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferings_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedNodeExchangeOfferings");

            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>(operation);
            var marshaller = new GetReservedNodeExchangeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetResourcePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>(operation);
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetResourcePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetResourcePolicy_InvalidPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>(operation);
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPolicyException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetResourcePolicy_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>(operation);
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void GetResourcePolicy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>(operation);
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ListRecommendationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListRecommendationsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListRecommendationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ListRecommendations_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ListRecommendations_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAquaConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAquaConfiguration");

            var request = InstantiateClassGenerator.Execute<ModifyAquaConfigurationRequest>(operation);
            var marshaller = new ModifyAquaConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyAquaConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyAquaConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAquaConfiguration_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAquaConfiguration");

            var request = InstantiateClassGenerator.Execute<ModifyAquaConfigurationRequest>(operation);
            var marshaller = new ModifyAquaConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyAquaConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAquaConfiguration_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAquaConfiguration");

            var request = InstantiateClassGenerator.Execute<ModifyAquaConfigurationRequest>(operation);
            var marshaller = new ModifyAquaConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyAquaConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAquaConfiguration_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAquaConfiguration");

            var request = InstantiateClassGenerator.Execute<ModifyAquaConfigurationRequest>(operation);
            var marshaller = new ModifyAquaConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyAquaConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAuthenticationProfileMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<ModifyAuthenticationProfileRequest>(operation);
            var marshaller = new ModifyAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyAuthenticationProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyAuthenticationProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAuthenticationProfile_AuthenticationProfileNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<ModifyAuthenticationProfileRequest>(operation);
            var marshaller = new ModifyAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthenticationProfileNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAuthenticationProfile_AuthenticationProfileQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<ModifyAuthenticationProfileRequest>(operation);
            var marshaller = new ModifyAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthenticationProfileQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyAuthenticationProfile_InvalidAuthenticationProfileRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAuthenticationProfile");

            var request = InstantiateClassGenerator.Execute<ModifyAuthenticationProfileRequest>(operation);
            var marshaller = new ModifyAuthenticationProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAuthenticationProfileRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyAuthenticationProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_ClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_CustomCnameAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomCnameAssociationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_HsmClientCertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_HsmConfigurationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_InsufficientClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_InvalidClusterTrackExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterTrackException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_InvalidElasticIpExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidElasticIpException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_Ipv6CidrBlockNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("Ipv6CidrBlockNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_NumberOfNodesPerClusterLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesPerClusterLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_NumberOfNodesQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_TableLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TableLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCluster_UnsupportedOptionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>(operation);
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOptionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterDbRevisionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterDbRevision");

            var request = InstantiateClassGenerator.Execute<ModifyClusterDbRevisionRequest>(operation);
            var marshaller = new ModifyClusterDbRevisionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterDbRevisionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterDbRevisionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterDbRevision_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterDbRevision");

            var request = InstantiateClassGenerator.Execute<ModifyClusterDbRevisionRequest>(operation);
            var marshaller = new ModifyClusterDbRevisionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterDbRevisionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterDbRevision_ClusterOnLatestRevisionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterDbRevision");

            var request = InstantiateClassGenerator.Execute<ModifyClusterDbRevisionRequest>(operation);
            var marshaller = new ModifyClusterDbRevisionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterOnLatestRevisionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterDbRevisionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterDbRevision_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterDbRevision");

            var request = InstantiateClassGenerator.Execute<ModifyClusterDbRevisionRequest>(operation);
            var marshaller = new ModifyClusterDbRevisionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterDbRevisionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterDbRevision_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterDbRevision");

            var request = InstantiateClassGenerator.Execute<ModifyClusterDbRevisionRequest>(operation);
            var marshaller = new ModifyClusterDbRevisionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterDbRevisionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterIamRolesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterIamRoles");

            var request = InstantiateClassGenerator.Execute<ModifyClusterIamRolesRequest>(operation);
            var marshaller = new ModifyClusterIamRolesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterIamRolesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterIamRolesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterIamRoles_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterIamRoles");

            var request = InstantiateClassGenerator.Execute<ModifyClusterIamRolesRequest>(operation);
            var marshaller = new ModifyClusterIamRolesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterIamRolesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterIamRoles_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterIamRoles");

            var request = InstantiateClassGenerator.Execute<ModifyClusterIamRolesRequest>(operation);
            var marshaller = new ModifyClusterIamRolesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterIamRolesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterMaintenanceMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterMaintenance");

            var request = InstantiateClassGenerator.Execute<ModifyClusterMaintenanceRequest>(operation);
            var marshaller = new ModifyClusterMaintenanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterMaintenanceResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterMaintenanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterMaintenance_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterMaintenance");

            var request = InstantiateClassGenerator.Execute<ModifyClusterMaintenanceRequest>(operation);
            var marshaller = new ModifyClusterMaintenanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterMaintenanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterMaintenance_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterMaintenance");

            var request = InstantiateClassGenerator.Execute<ModifyClusterMaintenanceRequest>(operation);
            var marshaller = new ModifyClusterMaintenanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterMaintenanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterParameterGroupRequest>(operation);
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterParameterGroup_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterParameterGroupRequest>(operation);
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterParameterGroup_InvalidClusterParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterParameterGroupRequest>(operation);
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotRequest>(operation);
            var marshaller = new ModifyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshot_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotRequest>(operation);
            var marshaller = new ModifyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshot_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotRequest>(operation);
            var marshaller = new ModifyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshot_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotRequest>(operation);
            var marshaller = new ModifyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshotScheduleMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotScheduleRequest>(operation);
            var marshaller = new ModifyClusterSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshotSchedule_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotScheduleRequest>(operation);
            var marshaller = new ModifyClusterSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshotSchedule_InvalidClusterSnapshotScheduleStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotScheduleRequest>(operation);
            var marshaller = new ModifyClusterSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotScheduleStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSnapshotSchedule_SnapshotScheduleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSnapshotScheduleRequest>(operation);
            var marshaller = new ModifyClusterSnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroup_ClusterSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroup_ClusterSubnetQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroup_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroup_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroup_SubnetAlreadyInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubnetAlreadyInUseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroup_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>(operation);
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCustomDomainAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDomainAssociationRequest>(operation);
            var marshaller = new ModifyCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCustomDomainAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCustomDomainAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCustomDomainAssociation_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDomainAssociationRequest>(operation);
            var marshaller = new ModifyCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCustomDomainAssociation_CustomCnameAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDomainAssociationRequest>(operation);
            var marshaller = new ModifyCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomCnameAssociationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCustomDomainAssociation_CustomDomainAssociationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDomainAssociationRequest>(operation);
            var marshaller = new ModifyCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDomainAssociationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyCustomDomainAssociation_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDomainAssociation");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDomainAssociationRequest>(operation);
            var marshaller = new ModifyCustomDomainAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCustomDomainAssociationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccessMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyEndpointAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccess_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccess_EndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccess_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccess_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccess_InvalidEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEndpointAccess_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEndpointAccess");

            var request = InstantiateClassGenerator.Execute<ModifyEndpointAccessRequest>(operation);
            var marshaller = new ModifyEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_InvalidSubscriptionStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubscriptionStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SNSInvalidTopicExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSInvalidTopicException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SNSNoAuthorizationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSNoAuthorizationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SNSTopicArnNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSTopicArnNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SubscriptionCategoryNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionCategoryNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SubscriptionEventIdNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionEventIdNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyEventSubscription_SubscriptionSeverityNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>(operation);
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionSeverityNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyRedshiftIdcApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<ModifyRedshiftIdcApplicationRequest>(operation);
            var marshaller = new ModifyRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyRedshiftIdcApplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyRedshiftIdcApplication_DependentServiceAccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<ModifyRedshiftIdcApplicationRequest>(operation);
            var marshaller = new ModifyRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceAccessDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyRedshiftIdcApplication_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<ModifyRedshiftIdcApplicationRequest>(operation);
            var marshaller = new ModifyRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyRedshiftIdcApplication_RedshiftIdcApplicationNotExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<ModifyRedshiftIdcApplicationRequest>(operation);
            var marshaller = new ModifyRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("RedshiftIdcApplicationNotExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyRedshiftIdcApplication_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyRedshiftIdcApplication");

            var request = InstantiateClassGenerator.Execute<ModifyRedshiftIdcApplicationRequest>(operation);
            var marshaller = new ModifyRedshiftIdcApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyRedshiftIdcApplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledActionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyScheduledActionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_InvalidScheduledActionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidScheduledActionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_InvalidScheduleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidScheduleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_ScheduledActionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_ScheduledActionTypeUnsupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ScheduledActionTypeUnsupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyScheduledAction_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyScheduledAction");

            var request = InstantiateClassGenerator.Execute<ModifyScheduledActionRequest>(operation);
            var marshaller = new ModifyScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyScheduledActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriodMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>(operation);
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifySnapshotCopyRetentionPeriodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriod_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>(operation);
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriod_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>(operation);
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriod_InvalidRetentionPeriodExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>(operation);
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRetentionPeriodException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriod_SnapshotCopyDisabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>(operation);
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotCopyDisabledException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriod_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>(operation);
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotScheduleMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotScheduleRequest>(operation);
            var marshaller = new ModifySnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifySnapshotScheduleResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifySnapshotScheduleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotSchedule_InvalidScheduleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotScheduleRequest>(operation);
            var marshaller = new ModifySnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidScheduleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotSchedule_SnapshotScheduleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotScheduleRequest>(operation);
            var marshaller = new ModifySnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifySnapshotSchedule_SnapshotScheduleUpdateInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotSchedule");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotScheduleRequest>(operation);
            var marshaller = new ModifySnapshotScheduleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleUpdateInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifySnapshotScheduleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyUsageLimitMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyUsageLimit");

            var request = InstantiateClassGenerator.Execute<ModifyUsageLimitRequest>(operation);
            var marshaller = new ModifyUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyUsageLimitResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyUsageLimitResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyUsageLimit_InvalidUsageLimitExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyUsageLimit");

            var request = InstantiateClassGenerator.Execute<ModifyUsageLimitRequest>(operation);
            var marshaller = new ModifyUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidUsageLimitException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyUsageLimit_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyUsageLimit");

            var request = InstantiateClassGenerator.Execute<ModifyUsageLimitRequest>(operation);
            var marshaller = new ModifyUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyUsageLimit_UsageLimitNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyUsageLimit");

            var request = InstantiateClassGenerator.Execute<ModifyUsageLimitRequest>(operation);
            var marshaller = new ModifyUsageLimitRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UsageLimitNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyUsageLimitResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PauseClusterMarshallTest()
        {
            var operation = service_model.FindOperation("PauseCluster");

            var request = InstantiateClassGenerator.Execute<PauseClusterRequest>(operation);
            var marshaller = new PauseClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PauseClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as PauseClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PauseCluster_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PauseCluster");

            var request = InstantiateClassGenerator.Execute<PauseClusterRequest>(operation);
            var marshaller = new PauseClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PauseClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PauseCluster_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PauseCluster");

            var request = InstantiateClassGenerator.Execute<PauseClusterRequest>(operation);
            var marshaller = new PauseClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PauseClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PauseCluster_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PauseCluster");

            var request = InstantiateClassGenerator.Execute<PauseClusterRequest>(operation);
            var marshaller = new PauseClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PauseClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PurchaseReservedNodeOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedNodeOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedNodeOfferingRequest>(operation);
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseReservedNodeOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PurchaseReservedNodeOffering_ReservedNodeAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedNodeOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedNodeOfferingRequest>(operation);
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PurchaseReservedNodeOffering_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedNodeOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedNodeOfferingRequest>(operation);
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PurchaseReservedNodeOffering_ReservedNodeQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedNodeOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedNodeOfferingRequest>(operation);
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PurchaseReservedNodeOffering_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedNodeOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedNodeOfferingRequest>(operation);
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PutResourcePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>(operation);
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as PutResourcePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PutResourcePolicy_ConflictPolicyUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>(operation);
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictPolicyUpdateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PutResourcePolicy_InvalidPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>(operation);
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPolicyException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PutResourcePolicy_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>(operation);
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PutResourcePolicy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>(operation);
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RebootClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RebootCluster");

            var request = InstantiateClassGenerator.Execute<RebootClusterRequest>(operation);
            var marshaller = new RebootClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RebootClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as RebootClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RebootCluster_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootCluster");

            var request = InstantiateClassGenerator.Execute<RebootClusterRequest>(operation);
            var marshaller = new RebootClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RebootCluster_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootCluster");

            var request = InstantiateClassGenerator.Execute<RebootClusterRequest>(operation);
            var marshaller = new RebootClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RejectDataShareMarshallTest()
        {
            var operation = service_model.FindOperation("RejectDataShare");

            var request = InstantiateClassGenerator.Execute<RejectDataShareRequest>(operation);
            var marshaller = new RejectDataShareRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RejectDataShareResponseUnmarshaller.Instance.Unmarshall(context)
                as RejectDataShareResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RejectDataShare_InvalidDataShareExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RejectDataShare");

            var request = InstantiateClassGenerator.Execute<RejectDataShareRequest>(operation);
            var marshaller = new RejectDataShareRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDataShareException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RejectDataShareResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResetClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetClusterParameterGroupRequest>(operation);
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResetClusterParameterGroup_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResetClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetClusterParameterGroupRequest>(operation);
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResetClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResetClusterParameterGroup_InvalidClusterParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResetClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetClusterParameterGroupRequest>(operation);
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResetClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResizeClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ResizeClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_InsufficientClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_InvalidReservedNodeStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidReservedNodeStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_NumberOfNodesPerClusterLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesPerClusterLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_NumberOfNodesQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_ReservedNodeAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_ReservedNodeAlreadyMigratedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyMigratedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResizeCluster_UnsupportedOptionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResizeCluster");

            var request = InstantiateClassGenerator.Execute<ResizeClusterRequest>(operation);
            var marshaller = new ResizeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOptionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResizeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreFromClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_AccessToSnapshotDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessToSnapshotDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ClusterSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_DependentServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceUnavailableException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_HsmClientCertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmClientCertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_HsmConfigurationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("HsmConfigurationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InsufficientClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidClusterSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidClusterTrackExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterTrackException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidElasticIpExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidElasticIpException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidReservedNodeStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidReservedNodeStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidRestoreExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRestoreException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidTagExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_Ipv6CidrBlockNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("Ipv6CidrBlockNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_NumberOfNodesPerClusterLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesPerClusterLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_NumberOfNodesQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NumberOfNodesQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ReservedNodeAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ReservedNodeAlreadyMigratedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeAlreadyMigratedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ReservedNodeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_ReservedNodeOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedNodeOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_SnapshotScheduleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotScheduleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_TagLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_UnauthorizedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshot_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreTableFromClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_InProgressTableRestoreQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InProgressTableRestoreQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_InvalidClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_InvalidTableRestoreArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTableRestoreArgumentException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshot_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>(operation);
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResumeClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeCluster");

            var request = InstantiateClassGenerator.Execute<ResumeClusterRequest>(operation);
            var marshaller = new ResumeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResumeClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ResumeClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResumeCluster_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeCluster");

            var request = InstantiateClassGenerator.Execute<ResumeClusterRequest>(operation);
            var marshaller = new ResumeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResumeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResumeCluster_InsufficientClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeCluster");

            var request = InstantiateClassGenerator.Execute<ResumeClusterRequest>(operation);
            var marshaller = new ResumeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResumeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResumeCluster_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeCluster");

            var request = InstantiateClassGenerator.Execute<ResumeClusterRequest>(operation);
            var marshaller = new ResumeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResumeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResumeCluster_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeCluster");

            var request = InstantiateClassGenerator.Execute<ResumeClusterRequest>(operation);
            var marshaller = new ResumeClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResumeClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeClusterSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeClusterSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeClusterSecurityGroupIngress_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeClusterSecurityGroupIngress_ClusterSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeClusterSecurityGroupIngress_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeClusterSecurityGroupIngressRequest>(operation);
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccessMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeEndpointAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_EndpointAuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointAuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_EndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_InvalidAuthorizationStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAuthorizationStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_InvalidClusterSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeEndpointAccess_InvalidEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeEndpointAccess");

            var request = InstantiateClassGenerator.Execute<RevokeEndpointAccessRequest>(operation);
            var marshaller = new RevokeEndpointAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeEndpointAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeSnapshotAccessMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<RevokeSnapshotAccessRequest>(operation);
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeSnapshotAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeSnapshotAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeSnapshotAccess_AccessToSnapshotDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<RevokeSnapshotAccessRequest>(operation);
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessToSnapshotDeniedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeSnapshotAccess_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<RevokeSnapshotAccessRequest>(operation);
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeSnapshotAccess_ClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<RevokeSnapshotAccessRequest>(operation);
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeSnapshotAccess_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<RevokeSnapshotAccessRequest>(operation);
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeSnapshotAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RotateEncryptionKeyMarshallTest()
        {
            var operation = service_model.FindOperation("RotateEncryptionKey");

            var request = InstantiateClassGenerator.Execute<RotateEncryptionKeyRequest>(operation);
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RotateEncryptionKeyResponseUnmarshaller.Instance.Unmarshall(context)
                as RotateEncryptionKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RotateEncryptionKey_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RotateEncryptionKey");

            var request = InstantiateClassGenerator.Execute<RotateEncryptionKeyRequest>(operation);
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RotateEncryptionKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RotateEncryptionKey_DependentServiceRequestThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RotateEncryptionKey");

            var request = InstantiateClassGenerator.Execute<RotateEncryptionKeyRequest>(operation);
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependentServiceRequestThrottlingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RotateEncryptionKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RotateEncryptionKey_InvalidClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RotateEncryptionKey");

            var request = InstantiateClassGenerator.Execute<RotateEncryptionKeyRequest>(operation);
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RotateEncryptionKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RotateEncryptionKey_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RotateEncryptionKey");

            var request = InstantiateClassGenerator.Execute<RotateEncryptionKeyRequest>(operation);
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RotateEncryptionKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void UpdatePartnerStatusMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePartnerStatus");

            var request = InstantiateClassGenerator.Execute<UpdatePartnerStatusRequest>(operation);
            var marshaller = new UpdatePartnerStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdatePartnerStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdatePartnerStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void UpdatePartnerStatus_ClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePartnerStatus");

            var request = InstantiateClassGenerator.Execute<UpdatePartnerStatusRequest>(operation);
            var marshaller = new UpdatePartnerStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdatePartnerStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void UpdatePartnerStatus_PartnerNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePartnerStatus");

            var request = InstantiateClassGenerator.Execute<UpdatePartnerStatusRequest>(operation);
            var marshaller = new UpdatePartnerStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PartnerNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdatePartnerStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void UpdatePartnerStatus_UnauthorizedPartnerIntegrationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePartnerStatus");

            var request = InstantiateClassGenerator.Execute<UpdatePartnerStatusRequest>(operation);
            var marshaller = new UpdatePartnerStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedPartnerIntegrationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdatePartnerStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void UpdatePartnerStatus_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePartnerStatus");

            var request = InstantiateClassGenerator.Execute<UpdatePartnerStatusRequest>(operation);
            var marshaller = new UpdatePartnerStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdatePartnerStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}