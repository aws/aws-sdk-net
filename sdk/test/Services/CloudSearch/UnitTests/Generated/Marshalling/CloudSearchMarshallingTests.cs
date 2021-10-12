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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudsearch");
        
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
        public void BuildSuggesters_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BuildSuggesters");

            var request = InstantiateClassGenerator.Execute<BuildSuggestersRequest>();
            var marshaller = new BuildSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BuildSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void BuildSuggesters_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BuildSuggesters");

            var request = InstantiateClassGenerator.Execute<BuildSuggestersRequest>();
            var marshaller = new BuildSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BuildSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void BuildSuggesters_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BuildSuggesters");

            var request = InstantiateClassGenerator.Execute<BuildSuggestersRequest>();
            var marshaller = new BuildSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BuildSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void BuildSuggesters_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BuildSuggesters");

            var request = InstantiateClassGenerator.Execute<BuildSuggestersRequest>();
            var marshaller = new BuildSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BuildSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void CreateDomain_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomain");

            var request = InstantiateClassGenerator.Execute<CreateDomainRequest>();
            var marshaller = new CreateDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void CreateDomain_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomain");

            var request = InstantiateClassGenerator.Execute<CreateDomainRequest>();
            var marshaller = new CreateDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void CreateDomain_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomain");

            var request = InstantiateClassGenerator.Execute<CreateDomainRequest>();
            var marshaller = new CreateDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void CreateDomain_ResourceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomain");

            var request = InstantiateClassGenerator.Execute<CreateDomainRequest>();
            var marshaller = new CreateDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void CreateDomain_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomain");

            var request = InstantiateClassGenerator.Execute<CreateDomainRequest>();
            var marshaller = new CreateDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DefineAnalysisScheme_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineAnalysisScheme_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineAnalysisScheme_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineAnalysisScheme_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineAnalysisScheme_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineAnalysisScheme_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DefineAnalysisSchemeRequest>();
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DefineExpression_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineExpression_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineExpression_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineExpression_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineExpression_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineExpression_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineExpression");

            var request = InstantiateClassGenerator.Execute<DefineExpressionRequest>();
            var marshaller = new DefineExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DefineIndexField_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineIndexField_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineIndexField_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineIndexField_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineIndexField_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineIndexField_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineIndexField");

            var request = InstantiateClassGenerator.Execute<DefineIndexFieldRequest>();
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DefineSuggester_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineSuggester_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineSuggester_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineSuggester_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineSuggester_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DefineSuggester_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DefineSuggester");

            var request = InstantiateClassGenerator.Execute<DefineSuggesterRequest>();
            var marshaller = new DefineSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DefineSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteAnalysisScheme_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DeleteAnalysisSchemeRequest>();
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteAnalysisScheme_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DeleteAnalysisSchemeRequest>();
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteAnalysisScheme_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DeleteAnalysisSchemeRequest>();
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteAnalysisScheme_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DeleteAnalysisSchemeRequest>();
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteAnalysisScheme_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalysisScheme");

            var request = InstantiateClassGenerator.Execute<DeleteAnalysisSchemeRequest>();
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteAnalysisSchemeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteDomain_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDomain");

            var request = InstantiateClassGenerator.Execute<DeleteDomainRequest>();
            var marshaller = new DeleteDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteDomain_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDomain");

            var request = InstantiateClassGenerator.Execute<DeleteDomainRequest>();
            var marshaller = new DeleteDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDomainResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteExpression_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteExpression");

            var request = InstantiateClassGenerator.Execute<DeleteExpressionRequest>();
            var marshaller = new DeleteExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteExpression_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteExpression");

            var request = InstantiateClassGenerator.Execute<DeleteExpressionRequest>();
            var marshaller = new DeleteExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteExpression_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteExpression");

            var request = InstantiateClassGenerator.Execute<DeleteExpressionRequest>();
            var marshaller = new DeleteExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteExpression_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteExpression");

            var request = InstantiateClassGenerator.Execute<DeleteExpressionRequest>();
            var marshaller = new DeleteExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteExpression_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteExpression");

            var request = InstantiateClassGenerator.Execute<DeleteExpressionRequest>();
            var marshaller = new DeleteExpressionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteExpressionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteIndexField_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIndexField");

            var request = InstantiateClassGenerator.Execute<DeleteIndexFieldRequest>();
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteIndexField_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIndexField");

            var request = InstantiateClassGenerator.Execute<DeleteIndexFieldRequest>();
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteIndexField_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIndexField");

            var request = InstantiateClassGenerator.Execute<DeleteIndexFieldRequest>();
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteIndexField_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIndexField");

            var request = InstantiateClassGenerator.Execute<DeleteIndexFieldRequest>();
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteIndexField_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIndexField");

            var request = InstantiateClassGenerator.Execute<DeleteIndexFieldRequest>();
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteIndexFieldResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteSuggester_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuggester");

            var request = InstantiateClassGenerator.Execute<DeleteSuggesterRequest>();
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteSuggester_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuggester");

            var request = InstantiateClassGenerator.Execute<DeleteSuggesterRequest>();
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteSuggester_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuggester");

            var request = InstantiateClassGenerator.Execute<DeleteSuggesterRequest>();
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteSuggester_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuggester");

            var request = InstantiateClassGenerator.Execute<DeleteSuggesterRequest>();
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DeleteSuggester_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuggester");

            var request = InstantiateClassGenerator.Execute<DeleteSuggesterRequest>();
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteSuggesterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeAnalysisSchemes_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAnalysisSchemes");

            var request = InstantiateClassGenerator.Execute<DescribeAnalysisSchemesRequest>();
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAnalysisSchemesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAnalysisSchemes_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAnalysisSchemes");

            var request = InstantiateClassGenerator.Execute<DescribeAnalysisSchemesRequest>();
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAnalysisSchemesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAnalysisSchemes_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAnalysisSchemes");

            var request = InstantiateClassGenerator.Execute<DescribeAnalysisSchemesRequest>();
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAnalysisSchemesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeAvailabilityOptions_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAvailabilityOptions_DisabledOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DisabledOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAvailabilityOptions_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAvailabilityOptions_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAvailabilityOptions_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeAvailabilityOptions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityOptionsRequest>();
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainEndpointOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDomainEndpointOptionsRequest>();
            var marshaller = new DescribeDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDomainEndpointOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainEndpointOptions_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDomainEndpointOptionsRequest>();
            var marshaller = new DescribeDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainEndpointOptions_DisabledOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDomainEndpointOptionsRequest>();
            var marshaller = new DescribeDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DisabledOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainEndpointOptions_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDomainEndpointOptionsRequest>();
            var marshaller = new DescribeDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainEndpointOptions_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDomainEndpointOptionsRequest>();
            var marshaller = new DescribeDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomainEndpointOptions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDomainEndpointOptionsRequest>();
            var marshaller = new DescribeDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeDomains_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomains");

            var request = InstantiateClassGenerator.Execute<DescribeDomainsRequest>();
            var marshaller = new DescribeDomainsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeDomains_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDomains");

            var request = InstantiateClassGenerator.Execute<DescribeDomainsRequest>();
            var marshaller = new DescribeDomainsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDomainsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeExpressions_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExpressions");

            var request = InstantiateClassGenerator.Execute<DescribeExpressionsRequest>();
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeExpressionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeExpressions_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExpressions");

            var request = InstantiateClassGenerator.Execute<DescribeExpressionsRequest>();
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeExpressionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeExpressions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExpressions");

            var request = InstantiateClassGenerator.Execute<DescribeExpressionsRequest>();
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeExpressionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeIndexFields_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIndexFields");

            var request = InstantiateClassGenerator.Execute<DescribeIndexFieldsRequest>();
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeIndexFieldsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeIndexFields_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIndexFields");

            var request = InstantiateClassGenerator.Execute<DescribeIndexFieldsRequest>();
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeIndexFieldsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeIndexFields_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIndexFields");

            var request = InstantiateClassGenerator.Execute<DescribeIndexFieldsRequest>();
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeIndexFieldsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeScalingParameters_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScalingParameters");

            var request = InstantiateClassGenerator.Execute<DescribeScalingParametersRequest>();
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeScalingParameters_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScalingParameters");

            var request = InstantiateClassGenerator.Execute<DescribeScalingParametersRequest>();
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeScalingParameters_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScalingParameters");

            var request = InstantiateClassGenerator.Execute<DescribeScalingParametersRequest>();
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeServiceAccessPolicies_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeServiceAccessPoliciesRequest>();
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeServiceAccessPolicies_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeServiceAccessPoliciesRequest>();
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeServiceAccessPolicies_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeServiceAccessPoliciesRequest>();
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DescribeSuggesters_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSuggesters");

            var request = InstantiateClassGenerator.Execute<DescribeSuggestersRequest>();
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeSuggesters_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSuggesters");

            var request = InstantiateClassGenerator.Execute<DescribeSuggestersRequest>();
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void DescribeSuggesters_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSuggesters");

            var request = InstantiateClassGenerator.Execute<DescribeSuggestersRequest>();
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeSuggestersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void IndexDocuments_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("IndexDocuments");

            var request = InstantiateClassGenerator.Execute<IndexDocumentsRequest>();
            var marshaller = new IndexDocumentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = IndexDocumentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void IndexDocuments_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("IndexDocuments");

            var request = InstantiateClassGenerator.Execute<IndexDocumentsRequest>();
            var marshaller = new IndexDocumentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = IndexDocumentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void IndexDocuments_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("IndexDocuments");

            var request = InstantiateClassGenerator.Execute<IndexDocumentsRequest>();
            var marshaller = new IndexDocumentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = IndexDocumentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void IndexDocuments_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("IndexDocuments");

            var request = InstantiateClassGenerator.Execute<IndexDocumentsRequest>();
            var marshaller = new IndexDocumentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = IndexDocumentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void ListDomainNames_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDomainNames");

            var request = InstantiateClassGenerator.Execute<ListDomainNamesRequest>();
            var marshaller = new ListDomainNamesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListDomainNamesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void UpdateAvailabilityOptions_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptions_DisabledOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DisabledOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptions_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptions_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptions_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateAvailabilityOptions_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAvailabilityOptions");

            var request = InstantiateClassGenerator.Execute<UpdateAvailabilityOptionsRequest>();
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateAvailabilityOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateDomainEndpointOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_DisabledOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DisabledOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateDomainEndpointOptions_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainEndpointOptions");

            var request = InstantiateClassGenerator.Execute<UpdateDomainEndpointOptionsRequest>();
            var marshaller = new UpdateDomainEndpointOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void UpdateScalingParameters_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateScalingParameters_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateScalingParameters_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateScalingParameters_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateScalingParameters_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateScalingParameters_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateScalingParameters");

            var request = InstantiateClassGenerator.Execute<UpdateScalingParametersRequest>();
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateScalingParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void UpdateServiceAccessPolicies_BaseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BaseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateServiceAccessPolicies_InternalExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateServiceAccessPolicies_InvalidTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTypeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateServiceAccessPolicies_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateServiceAccessPolicies_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudSearch")]
        public void UpdateServiceAccessPolicies_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateServiceAccessPolicies");

            var request = InstantiateClassGenerator.Execute<UpdateServiceAccessPoliciesRequest>();
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}