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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SavingsPlans;
using Amazon.SavingsPlans.Model;
using Amazon.SavingsPlans.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class SavingsPlansMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("savingsplans");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SavingsPlans")]
        public void CreateSavingsPlanMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSavingsPlan");

            var request = InstantiateClassGenerator.Execute<CreateSavingsPlanRequest>();
            var marshaller = new CreateSavingsPlanRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateSavingsPlan", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateSavingsPlanResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateSavingsPlanResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SavingsPlans")]
        public void DescribeSavingsPlanRatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSavingsPlanRates");

            var request = InstantiateClassGenerator.Execute<DescribeSavingsPlanRatesRequest>();
            var marshaller = new DescribeSavingsPlanRatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSavingsPlanRates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeSavingsPlanRatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeSavingsPlanRatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SavingsPlans")]
        public void DescribeSavingsPlansMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSavingsPlans");

            var request = InstantiateClassGenerator.Execute<DescribeSavingsPlansRequest>();
            var marshaller = new DescribeSavingsPlansRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSavingsPlans", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeSavingsPlansResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeSavingsPlansResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SavingsPlans")]
        public void DescribeSavingsPlansOfferingRatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSavingsPlansOfferingRates");

            var request = InstantiateClassGenerator.Execute<DescribeSavingsPlansOfferingRatesRequest>();
            var marshaller = new DescribeSavingsPlansOfferingRatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSavingsPlansOfferingRates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeSavingsPlansOfferingRatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeSavingsPlansOfferingRatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SavingsPlans")]
        public void DescribeSavingsPlansOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSavingsPlansOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeSavingsPlansOfferingsRequest>();
            var marshaller = new DescribeSavingsPlansOfferingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSavingsPlansOfferings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeSavingsPlansOfferingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeSavingsPlansOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SavingsPlans")]
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
        [TestCategory("SavingsPlans")]
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
        [TestCategory("SavingsPlans")]
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

            }
}