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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.QueryProtocol;
using Amazon.QueryProtocol.Model;
using Amazon.QueryProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class QueryProtocolMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("query-tests-client");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void DatetimeOffsetsMarshallTest()
        {
            var operation = service_model.FindOperation("DatetimeOffsets");

            var request = InstantiateClassGenerator.Execute<DatetimeOffsetsRequest>(operation);
            var marshaller = new DatetimeOffsetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DatetimeOffsetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DatetimeOffsetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void EmptyInputAndEmptyOutputMarshallTest()
        {
            var operation = service_model.FindOperation("EmptyInputAndEmptyOutput");

            var request = InstantiateClassGenerator.Execute<EmptyInputAndEmptyOutputRequest>(operation);
            var marshaller = new EmptyInputAndEmptyOutputRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance.Unmarshall(context)
                as EmptyInputAndEmptyOutputResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void EndpointOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointOperation");

            var request = InstantiateClassGenerator.Execute<EndpointOperationRequest>(operation);
            var marshaller = new EndpointOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void EndpointWithHostLabelOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointWithHostLabelOperation");

            var request = InstantiateClassGenerator.Execute<EndpointWithHostLabelOperationRequest>(operation);
            var marshaller = new EndpointWithHostLabelOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void FlattenedXmlMapMarshallTest()
        {
            var operation = service_model.FindOperation("FlattenedXmlMap");

            var request = InstantiateClassGenerator.Execute<FlattenedXmlMapRequest>(operation);
            var marshaller = new FlattenedXmlMapRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FlattenedXmlMapResponseUnmarshaller.Instance.Unmarshall(context)
                as FlattenedXmlMapResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void FlattenedXmlMapWithXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("FlattenedXmlMapWithXmlName");

            var request = InstantiateClassGenerator.Execute<FlattenedXmlMapWithXmlNameRequest>(operation);
            var marshaller = new FlattenedXmlMapWithXmlNameRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance.Unmarshall(context)
                as FlattenedXmlMapWithXmlNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void FlattenedXmlMapWithXmlNamespaceMarshallTest()
        {
            var operation = service_model.FindOperation("FlattenedXmlMapWithXmlNamespace");

            var request = InstantiateClassGenerator.Execute<FlattenedXmlMapWithXmlNamespaceRequest>(operation);
            var marshaller = new FlattenedXmlMapWithXmlNamespaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance.Unmarshall(context)
                as FlattenedXmlMapWithXmlNamespaceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void FractionalSecondsMarshallTest()
        {
            var operation = service_model.FindOperation("FractionalSeconds");

            var request = InstantiateClassGenerator.Execute<FractionalSecondsRequest>(operation);
            var marshaller = new FractionalSecondsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FractionalSecondsResponseUnmarshaller.Instance.Unmarshall(context)
                as FractionalSecondsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void GreetingWithErrorsMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.Unmarshall(context)
                as GreetingWithErrorsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void GreetingWithErrors_ComplexErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ComplexErrorException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void GreetingWithErrors_CustomCodeErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomCodeErrorException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void GreetingWithErrors_InvalidGreetingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGreetingException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void HostWithPathOperationMarshallTest()
        {
            var operation = service_model.FindOperation("HostWithPathOperation");

            var request = InstantiateClassGenerator.Execute<HostWithPathOperationRequest>(operation);
            var marshaller = new HostWithPathOperationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void IgnoresWrappingXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("IgnoresWrappingXmlName");

            var request = InstantiateClassGenerator.Execute<IgnoresWrappingXmlNameRequest>(operation);
            var marshaller = new IgnoresWrappingXmlNameRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = IgnoresWrappingXmlNameResponseUnmarshaller.Instance.Unmarshall(context)
                as IgnoresWrappingXmlNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void NoInputAndNoOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndNoOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndNoOutputRequest>(operation);
            var marshaller = new NoInputAndNoOutputRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void NoInputAndOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndOutputRequest>(operation);
            var marshaller = new NoInputAndOutputRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = NoInputAndOutputResponseUnmarshaller.Instance.Unmarshall(context)
                as NoInputAndOutputResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void PutWithContentEncodingMarshallTest()
        {
            var operation = service_model.FindOperation("PutWithContentEncoding");

            var request = InstantiateClassGenerator.Execute<PutWithContentEncodingRequest>(operation);
            var marshaller = new PutWithContentEncodingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void QueryIdempotencyTokenAutoFillMarshallTest()
        {
            var operation = service_model.FindOperation("QueryIdempotencyTokenAutoFill");

            var request = InstantiateClassGenerator.Execute<QueryIdempotencyTokenAutoFillRequest>(operation);
            var marshaller = new QueryIdempotencyTokenAutoFillRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void QueryListsMarshallTest()
        {
            var operation = service_model.FindOperation("QueryLists");

            var request = InstantiateClassGenerator.Execute<QueryListsRequest>(operation);
            var marshaller = new QueryListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void QueryMapsMarshallTest()
        {
            var operation = service_model.FindOperation("QueryMaps");

            var request = InstantiateClassGenerator.Execute<QueryMapsRequest>(operation);
            var marshaller = new QueryMapsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void QueryTimestampsMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTimestamps");

            var request = InstantiateClassGenerator.Execute<QueryTimestampsRequest>(operation);
            var marshaller = new QueryTimestampsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void RecursiveXmlShapesMarshallTest()
        {
            var operation = service_model.FindOperation("RecursiveXmlShapes");

            var request = InstantiateClassGenerator.Execute<RecursiveXmlShapesRequest>(operation);
            var marshaller = new RecursiveXmlShapesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RecursiveXmlShapesResponseUnmarshaller.Instance.Unmarshall(context)
                as RecursiveXmlShapesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void SimpleInputParamsMarshallTest()
        {
            var operation = service_model.FindOperation("SimpleInputParams");

            var request = InstantiateClassGenerator.Execute<SimpleInputParamsRequest>(operation);
            var marshaller = new SimpleInputParamsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void SimpleScalarXmlPropertiesMarshallTest()
        {
            var operation = service_model.FindOperation("SimpleScalarXmlProperties");

            var request = InstantiateClassGenerator.Execute<SimpleScalarXmlPropertiesRequest>(operation);
            var marshaller = new SimpleScalarXmlPropertiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SimpleScalarXmlPropertiesResponseUnmarshaller.Instance.Unmarshall(context)
                as SimpleScalarXmlPropertiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlBlobs");

            var request = InstantiateClassGenerator.Execute<XmlBlobsRequest>(operation);
            var marshaller = new XmlBlobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlBlobsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlBlobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlEmptyBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyBlobs");

            var request = InstantiateClassGenerator.Execute<XmlEmptyBlobsRequest>(operation);
            var marshaller = new XmlEmptyBlobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlEmptyBlobsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEmptyBlobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlEmptyListsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyLists");

            var request = InstantiateClassGenerator.Execute<XmlEmptyListsRequest>(operation);
            var marshaller = new XmlEmptyListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlEmptyListsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEmptyListsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlEmptyMapsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyMaps");

            var request = InstantiateClassGenerator.Execute<XmlEmptyMapsRequest>(operation);
            var marshaller = new XmlEmptyMapsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlEmptyMapsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEmptyMapsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEnums");

            var request = InstantiateClassGenerator.Execute<XmlEnumsRequest>(operation);
            var marshaller = new XmlEnumsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlEnumsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEnumsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlIntEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlIntEnums");

            var request = InstantiateClassGenerator.Execute<XmlIntEnumsRequest>(operation);
            var marshaller = new XmlIntEnumsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlIntEnumsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlIntEnumsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlListsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlLists");

            var request = InstantiateClassGenerator.Execute<XmlListsRequest>(operation);
            var marshaller = new XmlListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlListsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlListsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlMapsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlMaps");

            var request = InstantiateClassGenerator.Execute<XmlMapsRequest>(operation);
            var marshaller = new XmlMapsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlMapsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlMapsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlMapsXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("XmlMapsXmlName");

            var request = InstantiateClassGenerator.Execute<XmlMapsXmlNameRequest>(operation);
            var marshaller = new XmlMapsXmlNameRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlMapsXmlNameResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlMapsXmlNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlNamespacesMarshallTest()
        {
            var operation = service_model.FindOperation("XmlNamespaces");

            var request = InstantiateClassGenerator.Execute<XmlNamespacesRequest>(operation);
            var marshaller = new XmlNamespacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlNamespacesResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlNamespacesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("QueryProtocol")]
        public void XmlTimestampsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlTimestamps");

            var request = InstantiateClassGenerator.Execute<XmlTimestampsRequest>(operation);
            var marshaller = new XmlTimestampsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = XmlTimestampsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlTimestampsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }
    }
}