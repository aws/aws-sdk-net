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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.AccessAnalyzer;
using Amazon.AccessAnalyzer.Model;
using Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class AccessAnalyzerMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("accessanalyzer");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void CreateAnalyzerMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAnalyzer");

            var request = InstantiateClassGenerator.Execute<CreateAnalyzerRequest>();
            var marshaller = new CreateAnalyzerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAnalyzer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateAnalyzerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateAnalyzerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void CreateArchiveRuleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateArchiveRule");

            var request = InstantiateClassGenerator.Execute<CreateArchiveRuleRequest>();
            var marshaller = new CreateArchiveRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateArchiveRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void DeleteAnalyzerMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAnalyzer");

            var request = InstantiateClassGenerator.Execute<DeleteAnalyzerRequest>();
            var marshaller = new DeleteAnalyzerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAnalyzer", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void DeleteArchiveRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteArchiveRule");

            var request = InstantiateClassGenerator.Execute<DeleteArchiveRuleRequest>();
            var marshaller = new DeleteArchiveRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteArchiveRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void GetAnalyzedResourceMarshallTest()
        {
            var operation = service_model.FindOperation("GetAnalyzedResource");

            var request = InstantiateClassGenerator.Execute<GetAnalyzedResourceRequest>();
            var marshaller = new GetAnalyzedResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAnalyzedResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAnalyzedResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAnalyzedResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void GetAnalyzerMarshallTest()
        {
            var operation = service_model.FindOperation("GetAnalyzer");

            var request = InstantiateClassGenerator.Execute<GetAnalyzerRequest>();
            var marshaller = new GetAnalyzerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAnalyzer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAnalyzerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAnalyzerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void GetArchiveRuleMarshallTest()
        {
            var operation = service_model.FindOperation("GetArchiveRule");

            var request = InstantiateClassGenerator.Execute<GetArchiveRuleRequest>();
            var marshaller = new GetArchiveRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetArchiveRule", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetArchiveRuleResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetArchiveRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void GetFindingMarshallTest()
        {
            var operation = service_model.FindOperation("GetFinding");

            var request = InstantiateClassGenerator.Execute<GetFindingRequest>();
            var marshaller = new GetFindingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFinding", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetFindingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFindingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void ListAnalyzedResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAnalyzedResources");

            var request = InstantiateClassGenerator.Execute<ListAnalyzedResourcesRequest>();
            var marshaller = new ListAnalyzedResourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAnalyzedResources", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAnalyzedResourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAnalyzedResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void ListAnalyzersMarshallTest()
        {
            var operation = service_model.FindOperation("ListAnalyzers");

            var request = InstantiateClassGenerator.Execute<ListAnalyzersRequest>();
            var marshaller = new ListAnalyzersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAnalyzers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAnalyzersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAnalyzersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void ListArchiveRulesMarshallTest()
        {
            var operation = service_model.FindOperation("ListArchiveRules");

            var request = InstantiateClassGenerator.Execute<ListArchiveRulesRequest>();
            var marshaller = new ListArchiveRulesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListArchiveRules", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListArchiveRulesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListArchiveRulesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void ListFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("ListFindings");

            var request = InstantiateClassGenerator.Execute<ListFindingsRequest>();
            var marshaller = new ListFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListFindings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListFindingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void StartResourceScanMarshallTest()
        {
            var operation = service_model.FindOperation("StartResourceScan");

            var request = InstantiateClassGenerator.Execute<StartResourceScanRequest>();
            var marshaller = new StartResourceScanRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartResourceScan", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void TagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TagResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TagResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void UntagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UntagResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UntagResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void UpdateArchiveRuleMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateArchiveRule");

            var request = InstantiateClassGenerator.Execute<UpdateArchiveRuleRequest>();
            var marshaller = new UpdateArchiveRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateArchiveRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AccessAnalyzer")]
        public void UpdateFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFindings");

            var request = InstantiateClassGenerator.Execute<UpdateFindingsRequest>();
            var marshaller = new UpdateFindingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateFindings", request, internalRequest, service_model);            

        }

            }
}