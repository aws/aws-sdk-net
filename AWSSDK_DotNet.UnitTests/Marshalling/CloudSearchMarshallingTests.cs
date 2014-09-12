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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudSearch;
using Amazon.CloudSearch.Model;
using Amazon.CloudSearch.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class CloudSearchMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudsearch-2013-01-01.normal.json", "cloudsearch-.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void BuildSuggestersMarshallTest()
        {
            var operation = service_model.FindOperation("BuildSuggesters");

            var request = InstantiateClassGenerator.Execute<BuildSuggestersRequest>();
            var marshaller = new BuildSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = BuildSuggestersResponseUnmarshaller.Instance.Unmarshall(context)
                as BuildSuggestersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void CreateDomainMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomain");

            var request = InstantiateClassGenerator.Execute<CreateDomainRequest>();
            var marshaller = new CreateDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineAnalysisSchemeMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.Unmarshall(context)
                as DefineAnalysisSchemeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineExpressionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DefineExpressionResponseUnmarshaller.Instance.Unmarshall(context)
                as DefineExpressionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineIndexFieldMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.Unmarshall(context)
                as DefineIndexFieldResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineSuggesterMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DefineSuggesterResponseUnmarshaller.Instance.Unmarshall(context)
                as DefineSuggesterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteAnalysisSchemeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DeleteAnalysisSchemeRequest>();
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteAnalysisSchemeResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteAnalysisSchemeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDomain");

            var request = InstantiateClassGenerator.Execute<DeleteDomainRequest>();
            var marshaller = new DeleteDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteExpressionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteExpression");

            var request = InstantiateClassGenerator.Execute<DeleteExpressionRequest>();
            var marshaller = new DeleteExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteExpressionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteExpressionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteIndexFieldMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIndexField");

            var request = InstantiateClassGenerator.Execute<DeleteIndexFieldRequest>();
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteIndexFieldResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIndexFieldResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteSuggesterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuggester");

            var request = InstantiateClassGenerator.Execute<DeleteSuggesterRequest>();
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteSuggesterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteSuggesterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAnalysisSchemesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAnalysisSchemes");

            var request = InstantiateClassGenerator.Execute<DescribeAnalysisSchemesRequest>();
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAnalysisSchemesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAnalysisSchemesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAvailabilityOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAvailabilityOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomains");

            var request = InstantiateClassGenerator.Execute<DescribeDomainsRequest>();
            var marshaller = new DescribeDomainsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDomainsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDomainsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeExpressionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExpressions");

            var request = InstantiateClassGenerator.Execute<DescribeExpressionsRequest>();
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeExpressionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeExpressionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeIndexFieldsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIndexFields");

            var request = InstantiateClassGenerator.Execute<DescribeIndexFieldsRequest>();
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeIndexFieldsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIndexFieldsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeScalingParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScalingParameters");

            var request = InstantiateClassGenerator.Execute<DescribeScalingParametersRequest>();
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeScalingParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScalingParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeServiceAccessPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeServiceAccessPoliciesRequest>();
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeServiceAccessPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeSuggestersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSuggesters");

            var request = InstantiateClassGenerator.Execute<DescribeSuggestersRequest>();
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSuggestersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSuggestersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void IndexDocumentsMarshallTest()
        {
            var operation = service_model.FindOperation("IndexDocuments");

            var request = InstantiateClassGenerator.Execute<IndexDocumentsRequest>();
            var marshaller = new IndexDocumentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = IndexDocumentsResponseUnmarshaller.Instance.Unmarshall(context)
                as IndexDocumentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void ListDomainNamesMarshallTest()
        {
            var operation = service_model.FindOperation("ListDomainNames");

            var request = InstantiateClassGenerator.Execute<ListDomainNamesRequest>();
            var marshaller = new ListDomainNamesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListDomainNamesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListDomainNamesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateAvailabilityOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateScalingParametersMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateScalingParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateServiceAccessPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateServiceAccessPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}