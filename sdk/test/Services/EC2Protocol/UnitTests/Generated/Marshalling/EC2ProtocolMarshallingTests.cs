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
 * Do not modify this file. This file is generated from the ec2-protocol-2020-01-08.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2Protocol;
using Amazon.EC2Protocol.Model;
using Amazon.EC2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;
using ServiceClientGenerator.Generators.SourceFiles;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class EC2ProtocolMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("ec2-tests-client");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void DatetimeOffsetsMarshallTest()
        {
            var operation = service_model.FindOperation("DatetimeOffsets");

            var request = InstantiateClassGenerator.Execute<DatetimeOffsetsRequest>(operation);
            var marshaller = new DatetimeOffsetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DatetimeOffsetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DatetimeOffsetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void EmptyInputAndEmptyOutputMarshallTest()
        {
            var operation = service_model.FindOperation("EmptyInputAndEmptyOutput");

            var request = InstantiateClassGenerator.Execute<EmptyInputAndEmptyOutputRequest>(operation);
            var marshaller = new EmptyInputAndEmptyOutputRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance.Unmarshall(context)
                as EmptyInputAndEmptyOutputResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
        public void FractionalSecondsMarshallTest()
        {
            var operation = service_model.FindOperation("FractionalSeconds");

            var request = InstantiateClassGenerator.Execute<FractionalSecondsRequest>(operation);
            var marshaller = new FractionalSecondsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = FractionalSecondsResponseUnmarshaller.Instance.Unmarshall(context)
                as FractionalSecondsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void GreetingWithErrorsMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.Unmarshall(context)
                as GreetingWithErrorsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
        public void IgnoresWrappingXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("IgnoresWrappingXmlName");

            var request = InstantiateClassGenerator.Execute<IgnoresWrappingXmlNameRequest>(operation);
            var marshaller = new IgnoresWrappingXmlNameRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = IgnoresWrappingXmlNameResponseUnmarshaller.Instance.Unmarshall(context)
                as IgnoresWrappingXmlNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void NoInputAndOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndOutputRequest>(operation);
            var marshaller = new NoInputAndOutputRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = NoInputAndOutputResponseUnmarshaller.Instance.Unmarshall(context)
                as NoInputAndOutputResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
        public void RecursiveXmlShapesMarshallTest()
        {
            var operation = service_model.FindOperation("RecursiveXmlShapes");

            var request = InstantiateClassGenerator.Execute<RecursiveXmlShapesRequest>(operation);
            var marshaller = new RecursiveXmlShapesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RecursiveXmlShapesResponseUnmarshaller.Instance.Unmarshall(context)
                as RecursiveXmlShapesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
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
        [TestCategory("EC2Protocol")]
        public void SimpleScalarXmlPropertiesMarshallTest()
        {
            var operation = service_model.FindOperation("SimpleScalarXmlProperties");

            var request = InstantiateClassGenerator.Execute<SimpleScalarXmlPropertiesRequest>(operation);
            var marshaller = new SimpleScalarXmlPropertiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = SimpleScalarXmlPropertiesResponseUnmarshaller.Instance.Unmarshall(context)
                as SimpleScalarXmlPropertiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlBlobs");

            var request = InstantiateClassGenerator.Execute<XmlBlobsRequest>(operation);
            var marshaller = new XmlBlobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlBlobsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlBlobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlEmptyBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyBlobs");

            var request = InstantiateClassGenerator.Execute<XmlEmptyBlobsRequest>(operation);
            var marshaller = new XmlEmptyBlobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlEmptyBlobsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEmptyBlobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlEmptyListsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyLists");

            var request = InstantiateClassGenerator.Execute<XmlEmptyListsRequest>(operation);
            var marshaller = new XmlEmptyListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlEmptyListsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEmptyListsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEnums");

            var request = InstantiateClassGenerator.Execute<XmlEnumsRequest>(operation);
            var marshaller = new XmlEnumsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlEnumsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlEnumsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlIntEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlIntEnums");

            var request = InstantiateClassGenerator.Execute<XmlIntEnumsRequest>(operation);
            var marshaller = new XmlIntEnumsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlIntEnumsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlIntEnumsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlListsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlLists");

            var request = InstantiateClassGenerator.Execute<XmlListsRequest>(operation);
            var marshaller = new XmlListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlListsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlListsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlNamespacesMarshallTest()
        {
            var operation = service_model.FindOperation("XmlNamespaces");

            var request = InstantiateClassGenerator.Execute<XmlNamespacesRequest>(operation);
            var marshaller = new XmlNamespacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlNamespacesResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlNamespacesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2Protocol")]
        public void XmlTimestampsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlTimestamps");

            var request = InstantiateClassGenerator.Execute<XmlTimestampsRequest>(operation);
            var marshaller = new XmlTimestampsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = XmlTimestampsResponseUnmarshaller.Instance.Unmarshall(context)
                as XmlTimestampsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}