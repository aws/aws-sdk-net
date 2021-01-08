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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudSearchDomain;
using Amazon.CloudSearchDomain.Model;
using Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class CloudSearchDomainMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudsearchdomain");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CloudSearchDomain")]
        public void SearchMarshallTest()
        {
            var operation = service_model.FindOperation("Search");

            var request = InstantiateClassGenerator.Execute<SearchRequest>();
            var marshaller = new SearchRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("Search", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SearchResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SearchResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CloudSearchDomain")]
        public void Search_SearchExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("Search");

            var request = InstantiateClassGenerator.Execute<SearchRequest>();
            var marshaller = new SearchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("Search", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SearchException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","SearchException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SearchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CloudSearchDomain")]
        public void SuggestMarshallTest()
        {
            var operation = service_model.FindOperation("Suggest");

            var request = InstantiateClassGenerator.Execute<SuggestRequest>();
            var marshaller = new SuggestRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("Suggest", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SuggestResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SuggestResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CloudSearchDomain")]
        public void Suggest_SearchExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("Suggest");

            var request = InstantiateClassGenerator.Execute<SuggestRequest>();
            var marshaller = new SuggestRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("Suggest", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SearchException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","SearchException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SuggestResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CloudSearchDomain")]
        public void UploadDocumentsMarshallTest()
        {
            var operation = service_model.FindOperation("UploadDocuments");

            var request = InstantiateClassGenerator.Execute<UploadDocumentsRequest>();
            var marshaller = new UploadDocumentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UploadDocuments", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UploadDocumentsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UploadDocumentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CloudSearchDomain")]
        public void UploadDocuments_DocumentServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UploadDocuments");

            var request = InstantiateClassGenerator.Execute<UploadDocumentsRequest>();
            var marshaller = new UploadDocumentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UploadDocuments", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DocumentServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","DocumentServiceException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UploadDocumentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}