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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class CloudFormationMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudformation");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ActivateOrganizationsAccessMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<ActivateOrganizationsAccessRequest>(operation);
            var marshaller = new ActivateOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ActivateOrganizationsAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as ActivateOrganizationsAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ActivateOrganizationsAccess_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<ActivateOrganizationsAccessRequest>(operation);
            var marshaller = new ActivateOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ActivateOrganizationsAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ActivateOrganizationsAccess_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<ActivateOrganizationsAccessRequest>(operation);
            var marshaller = new ActivateOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ActivateOrganizationsAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ActivateTypeMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateType");

            var request = InstantiateClassGenerator.Execute<ActivateTypeRequest>(operation);
            var marshaller = new ActivateTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ActivateTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as ActivateTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ActivateType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateType");

            var request = InstantiateClassGenerator.Execute<ActivateTypeRequest>(operation);
            var marshaller = new ActivateTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ActivateTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ActivateType_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateType");

            var request = InstantiateClassGenerator.Execute<ActivateTypeRequest>(operation);
            var marshaller = new ActivateTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ActivateTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void BatchDescribeTypeConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDescribeTypeConfigurations");

            var request = InstantiateClassGenerator.Execute<BatchDescribeTypeConfigurationsRequest>(operation);
            var marshaller = new BatchDescribeTypeConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = BatchDescribeTypeConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as BatchDescribeTypeConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void BatchDescribeTypeConfigurations_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDescribeTypeConfigurations");

            var request = InstantiateClassGenerator.Execute<BatchDescribeTypeConfigurationsRequest>(operation);
            var marshaller = new BatchDescribeTypeConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BatchDescribeTypeConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void BatchDescribeTypeConfigurations_TypeConfigurationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDescribeTypeConfigurations");

            var request = InstantiateClassGenerator.Execute<BatchDescribeTypeConfigurationsRequest>(operation);
            var marshaller = new BatchDescribeTypeConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeConfigurationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BatchDescribeTypeConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CancelUpdateStackMarshallTest()
        {
            var operation = service_model.FindOperation("CancelUpdateStack");

            var request = InstantiateClassGenerator.Execute<CancelUpdateStackRequest>(operation);
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CancelUpdateStack_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelUpdateStack");

            var request = InstantiateClassGenerator.Execute<CancelUpdateStackRequest>(operation);
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelUpdateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ContinueUpdateRollbackMarshallTest()
        {
            var operation = service_model.FindOperation("ContinueUpdateRollback");

            var request = InstantiateClassGenerator.Execute<ContinueUpdateRollbackRequest>(operation);
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ContinueUpdateRollbackResponseUnmarshaller.Instance.Unmarshall(context)
                as ContinueUpdateRollbackResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ContinueUpdateRollback_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ContinueUpdateRollback");

            var request = InstantiateClassGenerator.Execute<ContinueUpdateRollbackRequest>(operation);
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ContinueUpdateRollbackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateChangeSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChangeSet");

            var request = InstantiateClassGenerator.Execute<CreateChangeSetRequest>(operation);
            var marshaller = new CreateChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateChangeSetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateChangeSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateChangeSet_AlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChangeSet");

            var request = InstantiateClassGenerator.Execute<CreateChangeSetRequest>(operation);
            var marshaller = new CreateChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateChangeSet_InsufficientCapabilitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChangeSet");

            var request = InstantiateClassGenerator.Execute<CreateChangeSetRequest>(operation);
            var marshaller = new CreateChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientCapabilitiesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateChangeSet_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChangeSet");

            var request = InstantiateClassGenerator.Execute<CreateChangeSetRequest>(operation);
            var marshaller = new CreateChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateGeneratedTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<CreateGeneratedTemplateRequest>(operation);
            var marshaller = new CreateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateGeneratedTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateGeneratedTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateGeneratedTemplate_AlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<CreateGeneratedTemplateRequest>(operation);
            var marshaller = new CreateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateGeneratedTemplate_ConcurrentResourcesLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<CreateGeneratedTemplateRequest>(operation);
            var marshaller = new CreateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConcurrentResourcesLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateGeneratedTemplate_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<CreateGeneratedTemplateRequest>(operation);
            var marshaller = new CreateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStack");

            var request = InstantiateClassGenerator.Execute<CreateStackRequest>(operation);
            var marshaller = new CreateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateStackResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateStackResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStack_AlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStack");

            var request = InstantiateClassGenerator.Execute<CreateStackRequest>(operation);
            var marshaller = new CreateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStack_InsufficientCapabilitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStack");

            var request = InstantiateClassGenerator.Execute<CreateStackRequest>(operation);
            var marshaller = new CreateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientCapabilitiesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStack_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStack");

            var request = InstantiateClassGenerator.Execute<CreateStackRequest>(operation);
            var marshaller = new CreateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStack_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStack");

            var request = InstantiateClassGenerator.Execute<CreateStackRequest>(operation);
            var marshaller = new CreateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateStackInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstances_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstances_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstances_OperationIdAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationIdAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstances_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstances_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackInstances_StaleRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackInstances");

            var request = InstantiateClassGenerator.Execute<CreateStackInstancesRequest>(operation);
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StaleRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackSet");

            var request = InstantiateClassGenerator.Execute<CreateStackSetRequest>(operation);
            var marshaller = new CreateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateStackSetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateStackSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackSet_CreatedButModifiedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackSet");

            var request = InstantiateClassGenerator.Execute<CreateStackSetRequest>(operation);
            var marshaller = new CreateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CreatedButModifiedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackSet_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackSet");

            var request = InstantiateClassGenerator.Execute<CreateStackSetRequest>(operation);
            var marshaller = new CreateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CreateStackSet_NameAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStackSet");

            var request = InstantiateClassGenerator.Execute<CreateStackSetRequest>(operation);
            var marshaller = new CreateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NameAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeactivateOrganizationsAccessMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<DeactivateOrganizationsAccessRequest>(operation);
            var marshaller = new DeactivateOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeactivateOrganizationsAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as DeactivateOrganizationsAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeactivateOrganizationsAccess_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<DeactivateOrganizationsAccessRequest>(operation);
            var marshaller = new DeactivateOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeactivateOrganizationsAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeactivateOrganizationsAccess_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<DeactivateOrganizationsAccessRequest>(operation);
            var marshaller = new DeactivateOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeactivateOrganizationsAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeactivateTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateType");

            var request = InstantiateClassGenerator.Execute<DeactivateTypeRequest>(operation);
            var marshaller = new DeactivateTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeactivateTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as DeactivateTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeactivateType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateType");

            var request = InstantiateClassGenerator.Execute<DeactivateTypeRequest>(operation);
            var marshaller = new DeactivateTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeactivateTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeactivateType_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateType");

            var request = InstantiateClassGenerator.Execute<DeactivateTypeRequest>(operation);
            var marshaller = new DeactivateTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeactivateTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteChangeSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChangeSet");

            var request = InstantiateClassGenerator.Execute<DeleteChangeSetRequest>(operation);
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteChangeSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteChangeSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteChangeSet_InvalidChangeSetStatusExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChangeSet");

            var request = InstantiateClassGenerator.Execute<DeleteChangeSetRequest>(operation);
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidChangeSetStatusException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteGeneratedTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteGeneratedTemplateRequest>(operation);
            var marshaller = new DeleteGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteGeneratedTemplate_ConcurrentResourcesLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteGeneratedTemplateRequest>(operation);
            var marshaller = new DeleteGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConcurrentResourcesLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteGeneratedTemplate_GeneratedTemplateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteGeneratedTemplateRequest>(operation);
            var marshaller = new DeleteGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GeneratedTemplateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStack");

            var request = InstantiateClassGenerator.Execute<DeleteStackRequest>(operation);
            var marshaller = new DeleteStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStack_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStack");

            var request = InstantiateClassGenerator.Execute<DeleteStackRequest>(operation);
            var marshaller = new DeleteStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackInstances");

            var request = InstantiateClassGenerator.Execute<DeleteStackInstancesRequest>(operation);
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteStackInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteStackInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackInstances_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackInstances");

            var request = InstantiateClassGenerator.Execute<DeleteStackInstancesRequest>(operation);
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackInstances_OperationIdAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackInstances");

            var request = InstantiateClassGenerator.Execute<DeleteStackInstancesRequest>(operation);
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationIdAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackInstances_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackInstances");

            var request = InstantiateClassGenerator.Execute<DeleteStackInstancesRequest>(operation);
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackInstances_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackInstances");

            var request = InstantiateClassGenerator.Execute<DeleteStackInstancesRequest>(operation);
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackInstances_StaleRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackInstances");

            var request = InstantiateClassGenerator.Execute<DeleteStackInstancesRequest>(operation);
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StaleRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackSet");

            var request = InstantiateClassGenerator.Execute<DeleteStackSetRequest>(operation);
            var marshaller = new DeleteStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteStackSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteStackSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackSet_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackSet");

            var request = InstantiateClassGenerator.Execute<DeleteStackSetRequest>(operation);
            var marshaller = new DeleteStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeleteStackSet_StackSetNotEmptyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStackSet");

            var request = InstantiateClassGenerator.Execute<DeleteStackSetRequest>(operation);
            var marshaller = new DeleteStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotEmptyException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeregisterTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterType");

            var request = InstantiateClassGenerator.Execute<DeregisterTypeRequest>(operation);
            var marshaller = new DeregisterTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeregisterTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeregisterType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterType");

            var request = InstantiateClassGenerator.Execute<DeregisterTypeRequest>(operation);
            var marshaller = new DeregisterTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DeregisterType_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterType");

            var request = InstantiateClassGenerator.Execute<DeregisterTypeRequest>(operation);
            var marshaller = new DeregisterTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeAccountLimitsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAccountLimits");

            var request = InstantiateClassGenerator.Execute<DescribeAccountLimitsRequest>(operation);
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAccountLimitsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAccountLimitsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeChangeSetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChangeSet");

            var request = InstantiateClassGenerator.Execute<DescribeChangeSetRequest>(operation);
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeChangeSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeChangeSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeChangeSet_ChangeSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChangeSet");

            var request = InstantiateClassGenerator.Execute<DescribeChangeSetRequest>(operation);
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChangeSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeChangeSetHooksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChangeSetHooks");

            var request = InstantiateClassGenerator.Execute<DescribeChangeSetHooksRequest>(operation);
            var marshaller = new DescribeChangeSetHooksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeChangeSetHooksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeChangeSetHooksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeChangeSetHooks_ChangeSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChangeSetHooks");

            var request = InstantiateClassGenerator.Execute<DescribeChangeSetHooksRequest>(operation);
            var marshaller = new DescribeChangeSetHooksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChangeSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeChangeSetHooksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeGeneratedTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<DescribeGeneratedTemplateRequest>(operation);
            var marshaller = new DescribeGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeGeneratedTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeGeneratedTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeGeneratedTemplate_GeneratedTemplateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<DescribeGeneratedTemplateRequest>(operation);
            var marshaller = new DescribeGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GeneratedTemplateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeOrganizationsAccessMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<DescribeOrganizationsAccessRequest>(operation);
            var marshaller = new DescribeOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOrganizationsAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOrganizationsAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeOrganizationsAccess_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<DescribeOrganizationsAccessRequest>(operation);
            var marshaller = new DescribeOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeOrganizationsAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeOrganizationsAccess_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrganizationsAccess");

            var request = InstantiateClassGenerator.Execute<DescribeOrganizationsAccessRequest>(operation);
            var marshaller = new DescribeOrganizationsAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeOrganizationsAccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribePublisherMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePublisher");

            var request = InstantiateClassGenerator.Execute<DescribePublisherRequest>(operation);
            var marshaller = new DescribePublisherRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribePublisherResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePublisherResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribePublisher_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePublisher");

            var request = InstantiateClassGenerator.Execute<DescribePublisherRequest>(operation);
            var marshaller = new DescribePublisherRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribePublisherResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeResourceScanMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResourceScan");

            var request = InstantiateClassGenerator.Execute<DescribeResourceScanRequest>(operation);
            var marshaller = new DescribeResourceScanRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeResourceScanResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeResourceScanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeResourceScan_ResourceScanNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResourceScan");

            var request = InstantiateClassGenerator.Execute<DescribeResourceScanRequest>(operation);
            var marshaller = new DescribeResourceScanRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeResourceScanResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackDriftDetectionStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackDriftDetectionStatus");

            var request = InstantiateClassGenerator.Execute<DescribeStackDriftDetectionStatusRequest>(operation);
            var marshaller = new DescribeStackDriftDetectionStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackDriftDetectionStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackEventsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackEvents");

            var request = InstantiateClassGenerator.Execute<DescribeStackEventsRequest>(operation);
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackEventsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackEventsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackInstance");

            var request = InstantiateClassGenerator.Execute<DescribeStackInstanceRequest>(operation);
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackInstance_StackInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackInstance");

            var request = InstantiateClassGenerator.Execute<DescribeStackInstanceRequest>(operation);
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeStackInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackInstance_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackInstance");

            var request = InstantiateClassGenerator.Execute<DescribeStackInstanceRequest>(operation);
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeStackInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackResourceMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackResource");

            var request = InstantiateClassGenerator.Execute<DescribeStackResourceRequest>(operation);
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackResourceResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackResourceDriftsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackResourceDrifts");

            var request = InstantiateClassGenerator.Execute<DescribeStackResourceDriftsRequest>(operation);
            var marshaller = new DescribeStackResourceDriftsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackResourceDriftsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackResourceDriftsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackResources");

            var request = InstantiateClassGenerator.Execute<DescribeStackResourcesRequest>(operation);
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackResourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStacksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStacks");

            var request = InstantiateClassGenerator.Execute<DescribeStacksRequest>(operation);
            var marshaller = new DescribeStacksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStacksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStacksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackSetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackSet");

            var request = InstantiateClassGenerator.Execute<DescribeStackSetRequest>(operation);
            var marshaller = new DescribeStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackSet_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackSet");

            var request = InstantiateClassGenerator.Execute<DescribeStackSetRequest>(operation);
            var marshaller = new DescribeStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackSetOperationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackSetOperation");

            var request = InstantiateClassGenerator.Execute<DescribeStackSetOperationRequest>(operation);
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStackSetOperationResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackSetOperationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackSetOperation_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackSetOperation");

            var request = InstantiateClassGenerator.Execute<DescribeStackSetOperationRequest>(operation);
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeStackSetOperationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeStackSetOperation_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackSetOperation");

            var request = InstantiateClassGenerator.Execute<DescribeStackSetOperationRequest>(operation);
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeStackSetOperationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeType");

            var request = InstantiateClassGenerator.Execute<DescribeTypeRequest>(operation);
            var marshaller = new DescribeTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeType");

            var request = InstantiateClassGenerator.Execute<DescribeTypeRequest>(operation);
            var marshaller = new DescribeTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeType_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeType");

            var request = InstantiateClassGenerator.Execute<DescribeTypeRequest>(operation);
            var marshaller = new DescribeTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeTypeRegistrationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTypeRegistration");

            var request = InstantiateClassGenerator.Execute<DescribeTypeRegistrationRequest>(operation);
            var marshaller = new DescribeTypeRegistrationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTypeRegistrationResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTypeRegistrationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeTypeRegistration_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTypeRegistration");

            var request = InstantiateClassGenerator.Execute<DescribeTypeRegistrationRequest>(operation);
            var marshaller = new DescribeTypeRegistrationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTypeRegistrationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DetectStackDriftMarshallTest()
        {
            var operation = service_model.FindOperation("DetectStackDrift");

            var request = InstantiateClassGenerator.Execute<DetectStackDriftRequest>(operation);
            var marshaller = new DetectStackDriftRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DetectStackDriftResponseUnmarshaller.Instance.Unmarshall(context)
                as DetectStackDriftResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DetectStackResourceDriftMarshallTest()
        {
            var operation = service_model.FindOperation("DetectStackResourceDrift");

            var request = InstantiateClassGenerator.Execute<DetectStackResourceDriftRequest>(operation);
            var marshaller = new DetectStackResourceDriftRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DetectStackResourceDriftResponseUnmarshaller.Instance.Unmarshall(context)
                as DetectStackResourceDriftResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DetectStackSetDriftMarshallTest()
        {
            var operation = service_model.FindOperation("DetectStackSetDrift");

            var request = InstantiateClassGenerator.Execute<DetectStackSetDriftRequest>(operation);
            var marshaller = new DetectStackSetDriftRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DetectStackSetDriftResponseUnmarshaller.Instance.Unmarshall(context)
                as DetectStackSetDriftResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DetectStackSetDrift_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DetectStackSetDrift");

            var request = InstantiateClassGenerator.Execute<DetectStackSetDriftRequest>(operation);
            var marshaller = new DetectStackSetDriftRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DetectStackSetDriftResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DetectStackSetDrift_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DetectStackSetDrift");

            var request = InstantiateClassGenerator.Execute<DetectStackSetDriftRequest>(operation);
            var marshaller = new DetectStackSetDriftRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DetectStackSetDriftResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DetectStackSetDrift_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DetectStackSetDrift");

            var request = InstantiateClassGenerator.Execute<DetectStackSetDriftRequest>(operation);
            var marshaller = new DetectStackSetDriftRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DetectStackSetDriftResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void EstimateTemplateCostMarshallTest()
        {
            var operation = service_model.FindOperation("EstimateTemplateCost");

            var request = InstantiateClassGenerator.Execute<EstimateTemplateCostRequest>(operation);
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EstimateTemplateCostResponseUnmarshaller.Instance.Unmarshall(context)
                as EstimateTemplateCostResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ExecuteChangeSetMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteChangeSet");

            var request = InstantiateClassGenerator.Execute<ExecuteChangeSetRequest>(operation);
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ExecuteChangeSetResponseUnmarshaller.Instance.Unmarshall(context)
                as ExecuteChangeSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ExecuteChangeSet_ChangeSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteChangeSet");

            var request = InstantiateClassGenerator.Execute<ExecuteChangeSetRequest>(operation);
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChangeSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ExecuteChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ExecuteChangeSet_InsufficientCapabilitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteChangeSet");

            var request = InstantiateClassGenerator.Execute<ExecuteChangeSetRequest>(operation);
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientCapabilitiesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ExecuteChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ExecuteChangeSet_InvalidChangeSetStatusExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteChangeSet");

            var request = InstantiateClassGenerator.Execute<ExecuteChangeSetRequest>(operation);
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidChangeSetStatusException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ExecuteChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ExecuteChangeSet_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteChangeSet");

            var request = InstantiateClassGenerator.Execute<ExecuteChangeSetRequest>(operation);
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ExecuteChangeSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetGeneratedTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<GetGeneratedTemplateRequest>(operation);
            var marshaller = new GetGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetGeneratedTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as GetGeneratedTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetGeneratedTemplate_GeneratedTemplateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<GetGeneratedTemplateRequest>(operation);
            var marshaller = new GetGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GeneratedTemplateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetStackPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetStackPolicy");

            var request = InstantiateClassGenerator.Execute<GetStackPolicyRequest>(operation);
            var marshaller = new GetStackPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetStackPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetStackPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetTemplate");

            var request = InstantiateClassGenerator.Execute<GetTemplateRequest>(operation);
            var marshaller = new GetTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetTemplate_ChangeSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetTemplate");

            var request = InstantiateClassGenerator.Execute<GetTemplateRequest>(operation);
            var marshaller = new GetTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChangeSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetTemplateSummaryMarshallTest()
        {
            var operation = service_model.FindOperation("GetTemplateSummary");

            var request = InstantiateClassGenerator.Execute<GetTemplateSummaryRequest>(operation);
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetTemplateSummaryResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTemplateSummaryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void GetTemplateSummary_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetTemplateSummary");

            var request = InstantiateClassGenerator.Execute<GetTemplateSummaryRequest>(operation);
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetTemplateSummaryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSetMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportStacksToStackSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_OperationIdAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationIdAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_StackNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ImportStacksToStackSet_StaleRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ImportStacksToStackSet");

            var request = InstantiateClassGenerator.Execute<ImportStacksToStackSetRequest>(operation);
            var marshaller = new ImportStacksToStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StaleRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ImportStacksToStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListChangeSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListChangeSets");

            var request = InstantiateClassGenerator.Execute<ListChangeSetsRequest>(operation);
            var marshaller = new ListChangeSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListChangeSetsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListChangeSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListExportsMarshallTest()
        {
            var operation = service_model.FindOperation("ListExports");

            var request = InstantiateClassGenerator.Execute<ListExportsRequest>(operation);
            var marshaller = new ListExportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListExportsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListExportsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListGeneratedTemplatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListGeneratedTemplates");

            var request = InstantiateClassGenerator.Execute<ListGeneratedTemplatesRequest>(operation);
            var marshaller = new ListGeneratedTemplatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListGeneratedTemplatesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListGeneratedTemplatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListImportsMarshallTest()
        {
            var operation = service_model.FindOperation("ListImports");

            var request = InstantiateClassGenerator.Execute<ListImportsRequest>(operation);
            var marshaller = new ListImportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListImportsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListImportsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScanRelatedResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScanRelatedResources");

            var request = InstantiateClassGenerator.Execute<ListResourceScanRelatedResourcesRequest>(operation);
            var marshaller = new ListResourceScanRelatedResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListResourceScanRelatedResourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListResourceScanRelatedResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScanRelatedResources_ResourceScanInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScanRelatedResources");

            var request = InstantiateClassGenerator.Execute<ListResourceScanRelatedResourcesRequest>(operation);
            var marshaller = new ListResourceScanRelatedResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListResourceScanRelatedResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScanRelatedResources_ResourceScanNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScanRelatedResources");

            var request = InstantiateClassGenerator.Execute<ListResourceScanRelatedResourcesRequest>(operation);
            var marshaller = new ListResourceScanRelatedResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListResourceScanRelatedResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScanResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScanResources");

            var request = InstantiateClassGenerator.Execute<ListResourceScanResourcesRequest>(operation);
            var marshaller = new ListResourceScanResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListResourceScanResourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListResourceScanResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScanResources_ResourceScanInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScanResources");

            var request = InstantiateClassGenerator.Execute<ListResourceScanResourcesRequest>(operation);
            var marshaller = new ListResourceScanResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListResourceScanResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScanResources_ResourceScanNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScanResources");

            var request = InstantiateClassGenerator.Execute<ListResourceScanResourcesRequest>(operation);
            var marshaller = new ListResourceScanResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListResourceScanResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListResourceScansMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceScans");

            var request = InstantiateClassGenerator.Execute<ListResourceScansRequest>(operation);
            var marshaller = new ListResourceScansRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListResourceScansResponseUnmarshaller.Instance.Unmarshall(context)
                as ListResourceScansResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackInstanceResourceDriftsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackInstanceResourceDrifts");

            var request = InstantiateClassGenerator.Execute<ListStackInstanceResourceDriftsRequest>(operation);
            var marshaller = new ListStackInstanceResourceDriftsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStackInstanceResourceDriftsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStackInstanceResourceDriftsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackInstanceResourceDrifts_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackInstanceResourceDrifts");

            var request = InstantiateClassGenerator.Execute<ListStackInstanceResourceDriftsRequest>(operation);
            var marshaller = new ListStackInstanceResourceDriftsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackInstanceResourceDriftsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackInstanceResourceDrifts_StackInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackInstanceResourceDrifts");

            var request = InstantiateClassGenerator.Execute<ListStackInstanceResourceDriftsRequest>(operation);
            var marshaller = new ListStackInstanceResourceDriftsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackInstanceResourceDriftsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackInstanceResourceDrifts_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackInstanceResourceDrifts");

            var request = InstantiateClassGenerator.Execute<ListStackInstanceResourceDriftsRequest>(operation);
            var marshaller = new ListStackInstanceResourceDriftsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackInstanceResourceDriftsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackInstances");

            var request = InstantiateClassGenerator.Execute<ListStackInstancesRequest>(operation);
            var marshaller = new ListStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStackInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStackInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackInstances_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackInstances");

            var request = InstantiateClassGenerator.Execute<ListStackInstancesRequest>(operation);
            var marshaller = new ListStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackResources");

            var request = InstantiateClassGenerator.Execute<ListStackResourcesRequest>(operation);
            var marshaller = new ListStackResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStackResourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStackResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStacksMarshallTest()
        {
            var operation = service_model.FindOperation("ListStacks");

            var request = InstantiateClassGenerator.Execute<ListStacksRequest>(operation);
            var marshaller = new ListStacksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStacksResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStacksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperationResultsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackSetOperationResults");

            var request = InstantiateClassGenerator.Execute<ListStackSetOperationResultsRequest>(operation);
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStackSetOperationResultsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStackSetOperationResultsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperationResults_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackSetOperationResults");

            var request = InstantiateClassGenerator.Execute<ListStackSetOperationResultsRequest>(operation);
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackSetOperationResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperationResults_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackSetOperationResults");

            var request = InstantiateClassGenerator.Execute<ListStackSetOperationResultsRequest>(operation);
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackSetOperationResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackSetOperations");

            var request = InstantiateClassGenerator.Execute<ListStackSetOperationsRequest>(operation);
            var marshaller = new ListStackSetOperationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStackSetOperationsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStackSetOperationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperations_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackSetOperations");

            var request = InstantiateClassGenerator.Execute<ListStackSetOperationsRequest>(operation);
            var marshaller = new ListStackSetOperationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListStackSetOperationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListStackSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackSets");

            var request = InstantiateClassGenerator.Execute<ListStackSetsRequest>(operation);
            var marshaller = new ListStackSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListStackSetsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStackSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListTypeRegistrationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTypeRegistrations");

            var request = InstantiateClassGenerator.Execute<ListTypeRegistrationsRequest>(operation);
            var marshaller = new ListTypeRegistrationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTypeRegistrationsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTypeRegistrationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListTypeRegistrations_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTypeRegistrations");

            var request = InstantiateClassGenerator.Execute<ListTypeRegistrationsRequest>(operation);
            var marshaller = new ListTypeRegistrationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTypeRegistrationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListTypesMarshallTest()
        {
            var operation = service_model.FindOperation("ListTypes");

            var request = InstantiateClassGenerator.Execute<ListTypesRequest>(operation);
            var marshaller = new ListTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListTypes_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTypes");

            var request = InstantiateClassGenerator.Execute<ListTypesRequest>(operation);
            var marshaller = new ListTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTypesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListTypeVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTypeVersions");

            var request = InstantiateClassGenerator.Execute<ListTypeVersionsRequest>(operation);
            var marshaller = new ListTypeVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTypeVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTypeVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ListTypeVersions_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTypeVersions");

            var request = InstantiateClassGenerator.Execute<ListTypeVersionsRequest>(operation);
            var marshaller = new ListTypeVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTypeVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void PublishTypeMarshallTest()
        {
            var operation = service_model.FindOperation("PublishType");

            var request = InstantiateClassGenerator.Execute<PublishTypeRequest>(operation);
            var marshaller = new PublishTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PublishTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as PublishTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void PublishType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PublishType");

            var request = InstantiateClassGenerator.Execute<PublishTypeRequest>(operation);
            var marshaller = new PublishTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PublishTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void PublishType_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PublishType");

            var request = InstantiateClassGenerator.Execute<PublishTypeRequest>(operation);
            var marshaller = new PublishTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PublishTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RecordHandlerProgressMarshallTest()
        {
            var operation = service_model.FindOperation("RecordHandlerProgress");

            var request = InstantiateClassGenerator.Execute<RecordHandlerProgressRequest>(operation);
            var marshaller = new RecordHandlerProgressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RecordHandlerProgressResponseUnmarshaller.Instance.Unmarshall(context)
                as RecordHandlerProgressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RecordHandlerProgress_InvalidStateTransitionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecordHandlerProgress");

            var request = InstantiateClassGenerator.Execute<RecordHandlerProgressRequest>(operation);
            var marshaller = new RecordHandlerProgressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidStateTransitionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RecordHandlerProgressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RecordHandlerProgress_OperationStatusCheckFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecordHandlerProgress");

            var request = InstantiateClassGenerator.Execute<RecordHandlerProgressRequest>(operation);
            var marshaller = new RecordHandlerProgressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationStatusCheckFailedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RecordHandlerProgressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RegisterPublisherMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterPublisher");

            var request = InstantiateClassGenerator.Execute<RegisterPublisherRequest>(operation);
            var marshaller = new RegisterPublisherRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RegisterPublisherResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterPublisherResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RegisterPublisher_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterPublisher");

            var request = InstantiateClassGenerator.Execute<RegisterPublisherRequest>(operation);
            var marshaller = new RegisterPublisherRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterPublisherResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RegisterTypeMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterType");

            var request = InstantiateClassGenerator.Execute<RegisterTypeRequest>(operation);
            var marshaller = new RegisterTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RegisterTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RegisterType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterType");

            var request = InstantiateClassGenerator.Execute<RegisterTypeRequest>(operation);
            var marshaller = new RegisterTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RollbackStackMarshallTest()
        {
            var operation = service_model.FindOperation("RollbackStack");

            var request = InstantiateClassGenerator.Execute<RollbackStackRequest>(operation);
            var marshaller = new RollbackStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RollbackStackResponseUnmarshaller.Instance.Unmarshall(context)
                as RollbackStackResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void RollbackStack_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RollbackStack");

            var request = InstantiateClassGenerator.Execute<RollbackStackRequest>(operation);
            var marshaller = new RollbackStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RollbackStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetStackPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("SetStackPolicy");

            var request = InstantiateClassGenerator.Execute<SetStackPolicyRequest>(operation);
            var marshaller = new SetStackPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetTypeConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("SetTypeConfiguration");

            var request = InstantiateClassGenerator.Execute<SetTypeConfigurationRequest>(operation);
            var marshaller = new SetTypeConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetTypeConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as SetTypeConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetTypeConfiguration_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetTypeConfiguration");

            var request = InstantiateClassGenerator.Execute<SetTypeConfigurationRequest>(operation);
            var marshaller = new SetTypeConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetTypeConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetTypeConfiguration_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetTypeConfiguration");

            var request = InstantiateClassGenerator.Execute<SetTypeConfigurationRequest>(operation);
            var marshaller = new SetTypeConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetTypeConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetTypeDefaultVersionMarshallTest()
        {
            var operation = service_model.FindOperation("SetTypeDefaultVersion");

            var request = InstantiateClassGenerator.Execute<SetTypeDefaultVersionRequest>(operation);
            var marshaller = new SetTypeDefaultVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetTypeDefaultVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as SetTypeDefaultVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetTypeDefaultVersion_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetTypeDefaultVersion");

            var request = InstantiateClassGenerator.Execute<SetTypeDefaultVersionRequest>(operation);
            var marshaller = new SetTypeDefaultVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetTypeDefaultVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SetTypeDefaultVersion_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetTypeDefaultVersion");

            var request = InstantiateClassGenerator.Execute<SetTypeDefaultVersionRequest>(operation);
            var marshaller = new SetTypeDefaultVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetTypeDefaultVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SignalResourceMarshallTest()
        {
            var operation = service_model.FindOperation("SignalResource");

            var request = InstantiateClassGenerator.Execute<SignalResourceRequest>(operation);
            var marshaller = new SignalResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StartResourceScanMarshallTest()
        {
            var operation = service_model.FindOperation("StartResourceScan");

            var request = InstantiateClassGenerator.Execute<StartResourceScanRequest>(operation);
            var marshaller = new StartResourceScanRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartResourceScanResponseUnmarshaller.Instance.Unmarshall(context)
                as StartResourceScanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StartResourceScan_ResourceScanInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartResourceScan");

            var request = InstantiateClassGenerator.Execute<StartResourceScanRequest>(operation);
            var marshaller = new StartResourceScanRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartResourceScanResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StartResourceScan_ResourceScanLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartResourceScan");

            var request = InstantiateClassGenerator.Execute<StartResourceScanRequest>(operation);
            var marshaller = new StartResourceScanRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceScanLimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartResourceScanResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StopStackSetOperationMarshallTest()
        {
            var operation = service_model.FindOperation("StopStackSetOperation");

            var request = InstantiateClassGenerator.Execute<StopStackSetOperationRequest>(operation);
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StopStackSetOperationResponseUnmarshaller.Instance.Unmarshall(context)
                as StopStackSetOperationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StopStackSetOperation_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopStackSetOperation");

            var request = InstantiateClassGenerator.Execute<StopStackSetOperationRequest>(operation);
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopStackSetOperationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StopStackSetOperation_OperationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopStackSetOperation");

            var request = InstantiateClassGenerator.Execute<StopStackSetOperationRequest>(operation);
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopStackSetOperationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void StopStackSetOperation_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopStackSetOperation");

            var request = InstantiateClassGenerator.Execute<StopStackSetOperationRequest>(operation);
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopStackSetOperationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void TestTypeMarshallTest()
        {
            var operation = service_model.FindOperation("TestType");

            var request = InstantiateClassGenerator.Execute<TestTypeRequest>(operation);
            var marshaller = new TestTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = TestTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as TestTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void TestType_CFNRegistryExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("TestType");

            var request = InstantiateClassGenerator.Execute<TestTypeRequest>(operation);
            var marshaller = new TestTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CFNRegistryException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = TestTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void TestType_TypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("TestType");

            var request = InstantiateClassGenerator.Execute<TestTypeRequest>(operation);
            var marshaller = new TestTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = TestTypeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateGeneratedTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateGeneratedTemplateRequest>(operation);
            var marshaller = new UpdateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateGeneratedTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateGeneratedTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateGeneratedTemplate_AlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateGeneratedTemplateRequest>(operation);
            var marshaller = new UpdateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateGeneratedTemplate_GeneratedTemplateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateGeneratedTemplateRequest>(operation);
            var marshaller = new UpdateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GeneratedTemplateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateGeneratedTemplate_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateGeneratedTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateGeneratedTemplateRequest>(operation);
            var marshaller = new UpdateGeneratedTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateGeneratedTemplateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStack");

            var request = InstantiateClassGenerator.Execute<UpdateStackRequest>(operation);
            var marshaller = new UpdateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateStackResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateStackResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStack_InsufficientCapabilitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStack");

            var request = InstantiateClassGenerator.Execute<UpdateStackRequest>(operation);
            var marshaller = new UpdateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientCapabilitiesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStack_TokenAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStack");

            var request = InstantiateClassGenerator.Execute<UpdateStackRequest>(operation);
            var marshaller = new UpdateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TokenAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateStackInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstances_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstances_OperationIdAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationIdAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstances_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstances_StackInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstances_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackInstances_StaleRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackInstances");

            var request = InstantiateClassGenerator.Execute<UpdateStackInstancesRequest>(operation);
            var marshaller = new UpdateStackInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StaleRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSetMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateStackSetResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateStackSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSet_InvalidOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSet_OperationIdAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationIdAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSet_OperationInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSet_StackInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSet_StackSetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StackSetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackSet_StaleRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStackSet");

            var request = InstantiateClassGenerator.Execute<UpdateStackSetRequest>(operation);
            var marshaller = new UpdateStackSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StaleRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateStackSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateTerminationProtectionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateTerminationProtection");

            var request = InstantiateClassGenerator.Execute<UpdateTerminationProtectionRequest>(operation);
            var marshaller = new UpdateTerminationProtectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateTerminationProtectionResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateTerminationProtectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ValidateTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("ValidateTemplate");

            var request = InstantiateClassGenerator.Execute<ValidateTemplateRequest>(operation);
            var marshaller = new ValidateTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ValidateTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as ValidateTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }
    }
}