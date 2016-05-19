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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;
using Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ElasticBeanstalkMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("elasticbeanstalk-2010-12-01.normal.json", "elasticbeanstalk.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void AbortEnvironmentUpdateMarshallTest()
        {
            var operation = service_model.FindOperation("AbortEnvironmentUpdate");

            var request = InstantiateClassGenerator.Execute<AbortEnvironmentUpdateRequest>();
            var marshaller = new AbortEnvironmentUpdateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void ApplyEnvironmentManagedActionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplyEnvironmentManagedAction");

            var request = InstantiateClassGenerator.Execute<ApplyEnvironmentManagedActionRequest>();
            var marshaller = new ApplyEnvironmentManagedActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance.Unmarshall(context)
                as ApplyEnvironmentManagedActionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void CheckDNSAvailabilityMarshallTest()
        {
            var operation = service_model.FindOperation("CheckDNSAvailability");

            var request = InstantiateClassGenerator.Execute<CheckDNSAvailabilityRequest>();
            var marshaller = new CheckDNSAvailabilityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CheckDNSAvailabilityResponseUnmarshaller.Instance.Unmarshall(context)
                as CheckDNSAvailabilityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void ComposeEnvironmentsMarshallTest()
        {
            var operation = service_model.FindOperation("ComposeEnvironments");

            var request = InstantiateClassGenerator.Execute<ComposeEnvironmentsRequest>();
            var marshaller = new ComposeEnvironmentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ComposeEnvironmentsResponseUnmarshaller.Instance.Unmarshall(context)
                as ComposeEnvironmentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void CreateApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateApplication");

            var request = InstantiateClassGenerator.Execute<CreateApplicationRequest>();
            var marshaller = new CreateApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateApplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateApplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void CreateApplicationVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateApplicationVersion");

            var request = InstantiateClassGenerator.Execute<CreateApplicationVersionRequest>();
            var marshaller = new CreateApplicationVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateApplicationVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateApplicationVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void CreateConfigurationTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateConfigurationTemplate");

            var request = InstantiateClassGenerator.Execute<CreateConfigurationTemplateRequest>();
            var marshaller = new CreateConfigurationTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateConfigurationTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateConfigurationTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void CreateEnvironmentMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEnvironment");

            var request = InstantiateClassGenerator.Execute<CreateEnvironmentRequest>();
            var marshaller = new CreateEnvironmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateEnvironmentResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateEnvironmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void CreateStorageLocationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStorageLocation");

            var request = InstantiateClassGenerator.Execute<CreateStorageLocationRequest>();
            var marshaller = new CreateStorageLocationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateStorageLocationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateStorageLocationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DeleteApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteApplication");

            var request = InstantiateClassGenerator.Execute<DeleteApplicationRequest>();
            var marshaller = new DeleteApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DeleteApplicationVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteApplicationVersion");

            var request = InstantiateClassGenerator.Execute<DeleteApplicationVersionRequest>();
            var marshaller = new DeleteApplicationVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DeleteConfigurationTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConfigurationTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteConfigurationTemplateRequest>();
            var marshaller = new DeleteConfigurationTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DeleteEnvironmentConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEnvironmentConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteEnvironmentConfigurationRequest>();
            var marshaller = new DeleteEnvironmentConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeApplicationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeApplications");

            var request = InstantiateClassGenerator.Execute<DescribeApplicationsRequest>();
            var marshaller = new DescribeApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeApplicationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeApplicationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeApplicationVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeApplicationVersions");

            var request = InstantiateClassGenerator.Execute<DescribeApplicationVersionsRequest>();
            var marshaller = new DescribeApplicationVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeApplicationVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeApplicationVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeConfigurationOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeConfigurationOptions");

            var request = InstantiateClassGenerator.Execute<DescribeConfigurationOptionsRequest>();
            var marshaller = new DescribeConfigurationOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeConfigurationOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeConfigurationOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeConfigurationSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeConfigurationSettings");

            var request = InstantiateClassGenerator.Execute<DescribeConfigurationSettingsRequest>();
            var marshaller = new DescribeConfigurationSettingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeConfigurationSettingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeConfigurationSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentHealthMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEnvironmentHealth");

            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentHealthRequest>();
            var marshaller = new DescribeEnvironmentHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEnvironmentHealthResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEnvironmentHealthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentManagedActionHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEnvironmentManagedActionHistory");

            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionHistoryRequest>();
            var marshaller = new DescribeEnvironmentManagedActionHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEnvironmentManagedActionHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentManagedActionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEnvironmentManagedActions");

            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionsRequest>();
            var marshaller = new DescribeEnvironmentManagedActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEnvironmentManagedActionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEnvironmentResources");

            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentResourcesRequest>();
            var marshaller = new DescribeEnvironmentResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEnvironmentResourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEnvironmentResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEnvironments");

            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentsRequest>();
            var marshaller = new DescribeEnvironmentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEnvironmentsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEnvironmentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEventsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEvents");

            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();
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
        [TestCategory("ElasticBeanstalk")]
        public void DescribeInstancesHealthMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstancesHealth");

            var request = InstantiateClassGenerator.Execute<DescribeInstancesHealthRequest>();
            var marshaller = new DescribeInstancesHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeInstancesHealthResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstancesHealthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void ListAvailableSolutionStacksMarshallTest()
        {
            var operation = service_model.FindOperation("ListAvailableSolutionStacks");

            var request = InstantiateClassGenerator.Execute<ListAvailableSolutionStacksRequest>();
            var marshaller = new ListAvailableSolutionStacksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAvailableSolutionStacksResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAvailableSolutionStacksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void RebuildEnvironmentMarshallTest()
        {
            var operation = service_model.FindOperation("RebuildEnvironment");

            var request = InstantiateClassGenerator.Execute<RebuildEnvironmentRequest>();
            var marshaller = new RebuildEnvironmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void RequestEnvironmentInfoMarshallTest()
        {
            var operation = service_model.FindOperation("RequestEnvironmentInfo");

            var request = InstantiateClassGenerator.Execute<RequestEnvironmentInfoRequest>();
            var marshaller = new RequestEnvironmentInfoRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void RestartAppServerMarshallTest()
        {
            var operation = service_model.FindOperation("RestartAppServer");

            var request = InstantiateClassGenerator.Execute<RestartAppServerRequest>();
            var marshaller = new RestartAppServerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void RetrieveEnvironmentInfoMarshallTest()
        {
            var operation = service_model.FindOperation("RetrieveEnvironmentInfo");

            var request = InstantiateClassGenerator.Execute<RetrieveEnvironmentInfoRequest>();
            var marshaller = new RetrieveEnvironmentInfoRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RetrieveEnvironmentInfoResponseUnmarshaller.Instance.Unmarshall(context)
                as RetrieveEnvironmentInfoResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void SwapEnvironmentCNAMEsMarshallTest()
        {
            var operation = service_model.FindOperation("SwapEnvironmentCNAMEs");

            var request = InstantiateClassGenerator.Execute<SwapEnvironmentCNAMEsRequest>();
            var marshaller = new SwapEnvironmentCNAMEsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void TerminateEnvironmentMarshallTest()
        {
            var operation = service_model.FindOperation("TerminateEnvironment");

            var request = InstantiateClassGenerator.Execute<TerminateEnvironmentRequest>();
            var marshaller = new TerminateEnvironmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = TerminateEnvironmentResponseUnmarshaller.Instance.Unmarshall(context)
                as TerminateEnvironmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void UpdateApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateApplication");

            var request = InstantiateClassGenerator.Execute<UpdateApplicationRequest>();
            var marshaller = new UpdateApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateApplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateApplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void UpdateApplicationVersionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateApplicationVersion");

            var request = InstantiateClassGenerator.Execute<UpdateApplicationVersionRequest>();
            var marshaller = new UpdateApplicationVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateApplicationVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateApplicationVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void UpdateConfigurationTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateConfigurationTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateConfigurationTemplateRequest>();
            var marshaller = new UpdateConfigurationTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateConfigurationTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateConfigurationTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void UpdateEnvironmentMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateEnvironment");

            var request = InstantiateClassGenerator.Execute<UpdateEnvironmentRequest>();
            var marshaller = new UpdateEnvironmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateEnvironmentResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateEnvironmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticBeanstalk")]
        public void ValidateConfigurationSettingsMarshallTest()
        {
            var operation = service_model.FindOperation("ValidateConfigurationSettings");

            var request = InstantiateClassGenerator.Execute<ValidateConfigurationSettingsRequest>();
            var marshaller = new ValidateConfigurationSettingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ValidateConfigurationSettingsResponseUnmarshaller.Instance.Unmarshall(context)
                as ValidateConfigurationSettingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}