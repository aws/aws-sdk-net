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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudSearch_2011_02_01;
using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class CloudSearch_2011_02_01_MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudsearch-2011-02-01.normal.json", "cloudsearch-2011-02-01-customizations.json");
        

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
        public void DefineRankExpressionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineRankExpression");

            var request = InstantiateClassGenerator.Execute<DefineRankExpressionRequest>();
            var marshaller = new DefineRankExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DefineRankExpressionResponseUnmarshaller.Instance.Unmarshall(context)
                as DefineRankExpressionResponse;   
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
        public void DeleteRankExpressionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRankExpression");

            var request = InstantiateClassGenerator.Execute<DeleteRankExpressionRequest>();
            var marshaller = new DeleteRankExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteRankExpressionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteRankExpressionResponse;   
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
        public void DescribeDefaultSearchFieldMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDefaultSearchField");

            var request = InstantiateClassGenerator.Execute<DescribeDefaultSearchFieldRequest>();
            var marshaller = new DescribeDefaultSearchFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDefaultSearchFieldResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDefaultSearchFieldResponse;   
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
        public void DescribeRankExpressionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRankExpressions");

            var request = InstantiateClassGenerator.Execute<DescribeRankExpressionsRequest>();
            var marshaller = new DescribeRankExpressionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeRankExpressionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRankExpressionsResponse;   
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
        public void DescribeStemmingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStemmingOptions");

            var request = InstantiateClassGenerator.Execute<DescribeStemmingOptionsRequest>();
            var marshaller = new DescribeStemmingOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStemmingOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStemmingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeStopwordOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStopwordOptions");

            var request = InstantiateClassGenerator.Execute<DescribeStopwordOptionsRequest>();
            var marshaller = new DescribeStopwordOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeStopwordOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStopwordOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeSynonymOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSynonymOptions");

            var request = InstantiateClassGenerator.Execute<DescribeSynonymOptionsRequest>();
            var marshaller = new DescribeSynonymOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSynonymOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSynonymOptionsResponse;   
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
        public void UpdateDefaultSearchFieldMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDefaultSearchField");

            var request = InstantiateClassGenerator.Execute<UpdateDefaultSearchFieldRequest>();
            var marshaller = new UpdateDefaultSearchFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateDefaultSearchFieldResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateDefaultSearchFieldResponse;   
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

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateStemmingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStemmingOptions");

            var request = InstantiateClassGenerator.Execute<UpdateStemmingOptionsRequest>();
            var marshaller = new UpdateStemmingOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateStemmingOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateStemmingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateStopwordOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStopwordOptions");

            var request = InstantiateClassGenerator.Execute<UpdateStopwordOptionsRequest>();
            var marshaller = new UpdateStopwordOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateStopwordOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateStopwordOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateSynonymOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSynonymOptions");

            var request = InstantiateClassGenerator.Execute<UpdateSynonymOptionsRequest>();
            var marshaller = new UpdateSynonymOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateSynonymOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateSynonymOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}