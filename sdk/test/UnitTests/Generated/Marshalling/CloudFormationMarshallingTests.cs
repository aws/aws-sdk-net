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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class CloudFormationMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudformation-2010-05-15.normal.json", "cloudformation.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void CancelUpdateStackMarshallTest()
        {
            var operation = service_model.FindOperation("CancelUpdateStack");

            var request = InstantiateClassGenerator.Execute<CancelUpdateStackRequest>();
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void ContinueUpdateRollbackMarshallTest()
        {
            var operation = service_model.FindOperation("ContinueUpdateRollback");

            var request = InstantiateClassGenerator.Execute<ContinueUpdateRollbackRequest>();
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
        public void CreateChangeSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChangeSet");

            var request = InstantiateClassGenerator.Execute<CreateChangeSetRequest>();
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
        public void CreateStackMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStack");

            var request = InstantiateClassGenerator.Execute<CreateStackRequest>();
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
        public void DeleteChangeSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChangeSet");

            var request = InstantiateClassGenerator.Execute<DeleteChangeSetRequest>();
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
        public void DeleteStackMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStack");

            var request = InstantiateClassGenerator.Execute<DeleteStackRequest>();
            var marshaller = new DeleteStackRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void DescribeAccountLimitsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAccountLimits");

            var request = InstantiateClassGenerator.Execute<DescribeAccountLimitsRequest>();
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

            var request = InstantiateClassGenerator.Execute<DescribeChangeSetRequest>();
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
        public void DescribeStackEventsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackEvents");

            var request = InstantiateClassGenerator.Execute<DescribeStackEventsRequest>();
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
        public void DescribeStackResourceMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackResource");

            var request = InstantiateClassGenerator.Execute<DescribeStackResourceRequest>();
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
        public void DescribeStackResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStackResources");

            var request = InstantiateClassGenerator.Execute<DescribeStackResourcesRequest>();
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

            var request = InstantiateClassGenerator.Execute<DescribeStacksRequest>();
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
        public void EstimateTemplateCostMarshallTest()
        {
            var operation = service_model.FindOperation("EstimateTemplateCost");

            var request = InstantiateClassGenerator.Execute<EstimateTemplateCostRequest>();
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

            var request = InstantiateClassGenerator.Execute<ExecuteChangeSetRequest>();
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
        public void GetStackPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetStackPolicy");

            var request = InstantiateClassGenerator.Execute<GetStackPolicyRequest>();
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

            var request = InstantiateClassGenerator.Execute<GetTemplateRequest>();
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
        public void GetTemplateSummaryMarshallTest()
        {
            var operation = service_model.FindOperation("GetTemplateSummary");

            var request = InstantiateClassGenerator.Execute<GetTemplateSummaryRequest>();
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
        public void ListChangeSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListChangeSets");

            var request = InstantiateClassGenerator.Execute<ListChangeSetsRequest>();
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
        public void ListStackResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListStackResources");

            var request = InstantiateClassGenerator.Execute<ListStackResourcesRequest>();
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

            var request = InstantiateClassGenerator.Execute<ListStacksRequest>();
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
        public void SetStackPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("SetStackPolicy");

            var request = InstantiateClassGenerator.Execute<SetStackPolicyRequest>();
            var marshaller = new SetStackPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void SignalResourceMarshallTest()
        {
            var operation = service_model.FindOperation("SignalResource");

            var request = InstantiateClassGenerator.Execute<SignalResourceRequest>();
            var marshaller = new SignalResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudFormation")]
        public void UpdateStackMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStack");

            var request = InstantiateClassGenerator.Execute<UpdateStackRequest>();
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
        public void ValidateTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("ValidateTemplate");

            var request = InstantiateClassGenerator.Execute<ValidateTemplateRequest>();
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