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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Elasticsearch;
using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ElasticsearchMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("es-2015-01-01.normal.json", "");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void AddTagsMarshallTest()
        {
            var operation = service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AddTags", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void CreateElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("CreateElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<CreateElasticsearchDomainRequest>();
            var marshaller = new CreateElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DeleteElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<DeleteElasticsearchDomainRequest>();
            var marshaller = new DeleteElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchDomainRequest>();
            var marshaller = new DescribeElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchDomainConfigMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchDomainConfig");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchDomainConfigRequest>();
            var marshaller = new DescribeElasticsearchDomainConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeElasticsearchDomainConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchDomainConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchDomainsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchDomains");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchDomainsRequest>();
            var marshaller = new DescribeElasticsearchDomainsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeElasticsearchDomains", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchDomainsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListDomainNamesMarshallTest()
        {
            var operation = service_model.FindOperation("ListDomainNames");

            var request = InstantiateClassGenerator.Execute<ListDomainNamesRequest>();
            var marshaller = new ListDomainNamesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListDomainNames", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDomainNamesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListTagsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListTags", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void RemoveTagsMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RemoveTags", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void UpdateElasticsearchDomainConfigMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateElasticsearchDomainConfig");

            var request = InstantiateClassGenerator.Execute<UpdateElasticsearchDomainConfigRequest>();
            var marshaller = new UpdateElasticsearchDomainConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateElasticsearchDomainConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateElasticsearchDomainConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}