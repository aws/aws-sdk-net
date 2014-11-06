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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Route53;
using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class Route53MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("route53-2013-04-01.normal.json", "route53-.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void AssociateVPCWithHostedZoneMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateVPCWithHostedZone");

            var request = InstantiateClassGenerator.Execute<AssociateVPCWithHostedZoneRequest>();
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AssociateVPCWithHostedZone", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociateVPCWithHostedZoneResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ChangeResourceRecordSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeResourceRecordSets");

            var request = InstantiateClassGenerator.Execute<ChangeResourceRecordSetsRequest>();
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ChangeResourceRecordSets", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ChangeResourceRecordSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ChangeTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeTagsForResource");

            var request = InstantiateClassGenerator.Execute<ChangeTagsForResourceRequest>();
            var marshaller = new ChangeTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ChangeTagsForResource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ChangeTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void CreateHealthCheckMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHealthCheck");

            var request = InstantiateClassGenerator.Execute<CreateHealthCheckRequest>();
            var marshaller = new CreateHealthCheckRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateHealthCheck", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateHealthCheckResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void CreateHostedZoneMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHostedZone");

            var request = InstantiateClassGenerator.Execute<CreateHostedZoneRequest>();
            var marshaller = new CreateHostedZoneRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateHostedZone", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateHostedZoneResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void CreateReusableDelegationSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReusableDelegationSet");

            var request = InstantiateClassGenerator.Execute<CreateReusableDelegationSetRequest>();
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateReusableDelegationSet", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateReusableDelegationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void DeleteHealthCheckMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHealthCheck");

            var request = InstantiateClassGenerator.Execute<DeleteHealthCheckRequest>();
            var marshaller = new DeleteHealthCheckRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteHealthCheck", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteHealthCheckResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void DeleteHostedZoneMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHostedZone");

            var request = InstantiateClassGenerator.Execute<DeleteHostedZoneRequest>();
            var marshaller = new DeleteHostedZoneRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteHostedZone", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteHostedZoneResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void DeleteReusableDelegationSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteReusableDelegationSet");

            var request = InstantiateClassGenerator.Execute<DeleteReusableDelegationSetRequest>();
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteReusableDelegationSet", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteReusableDelegationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void DisassociateVPCFromHostedZoneMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateVPCFromHostedZone");

            var request = InstantiateClassGenerator.Execute<DisassociateVPCFromHostedZoneRequest>();
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DisassociateVPCFromHostedZone", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociateVPCFromHostedZoneResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetChangeMarshallTest()
        {
            var operation = service_model.FindOperation("GetChange");

            var request = InstantiateClassGenerator.Execute<GetChangeRequest>();
            var marshaller = new GetChangeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetChange", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetChangeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetChangeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetCheckerIpRangesMarshallTest()
        {
            var operation = service_model.FindOperation("GetCheckerIpRanges");

            var request = InstantiateClassGenerator.Execute<GetCheckerIpRangesRequest>();
            var marshaller = new GetCheckerIpRangesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetCheckerIpRanges", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCheckerIpRangesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetGeoLocationMarshallTest()
        {
            var operation = service_model.FindOperation("GetGeoLocation");

            var request = InstantiateClassGenerator.Execute<GetGeoLocationRequest>();
            var marshaller = new GetGeoLocationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetGeoLocation", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetGeoLocationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetHealthCheckMarshallTest()
        {
            var operation = service_model.FindOperation("GetHealthCheck");

            var request = InstantiateClassGenerator.Execute<GetHealthCheckRequest>();
            var marshaller = new GetHealthCheckRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetHealthCheck", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetHealthCheckResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetHealthCheckCountMarshallTest()
        {
            var operation = service_model.FindOperation("GetHealthCheckCount");

            var request = InstantiateClassGenerator.Execute<GetHealthCheckCountRequest>();
            var marshaller = new GetHealthCheckCountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetHealthCheckCount", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetHealthCheckCountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetHealthCheckLastFailureReasonMarshallTest()
        {
            var operation = service_model.FindOperation("GetHealthCheckLastFailureReason");

            var request = InstantiateClassGenerator.Execute<GetHealthCheckLastFailureReasonRequest>();
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetHealthCheckLastFailureReason", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetHealthCheckLastFailureReasonResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetHealthCheckStatusMarshallTest()
        {
            var operation = service_model.FindOperation("GetHealthCheckStatus");

            var request = InstantiateClassGenerator.Execute<GetHealthCheckStatusRequest>();
            var marshaller = new GetHealthCheckStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetHealthCheckStatus", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetHealthCheckStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetHostedZoneMarshallTest()
        {
            var operation = service_model.FindOperation("GetHostedZone");

            var request = InstantiateClassGenerator.Execute<GetHostedZoneRequest>();
            var marshaller = new GetHostedZoneRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetHostedZone", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetHostedZoneResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void GetReusableDelegationSetMarshallTest()
        {
            var operation = service_model.FindOperation("GetReusableDelegationSet");

            var request = InstantiateClassGenerator.Execute<GetReusableDelegationSetRequest>();
            var marshaller = new GetReusableDelegationSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetReusableDelegationSet", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetReusableDelegationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListGeoLocationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListGeoLocations");

            var request = InstantiateClassGenerator.Execute<ListGeoLocationsRequest>();
            var marshaller = new ListGeoLocationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListGeoLocations", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListGeoLocationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListHealthChecksMarshallTest()
        {
            var operation = service_model.FindOperation("ListHealthChecks");

            var request = InstantiateClassGenerator.Execute<ListHealthChecksRequest>();
            var marshaller = new ListHealthChecksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListHealthChecks", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListHealthChecksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListHostedZonesMarshallTest()
        {
            var operation = service_model.FindOperation("ListHostedZones");

            var request = InstantiateClassGenerator.Execute<ListHostedZonesRequest>();
            var marshaller = new ListHostedZonesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListHostedZones", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListHostedZonesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListResourceRecordSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListResourceRecordSets");

            var request = InstantiateClassGenerator.Execute<ListResourceRecordSetsRequest>();
            var marshaller = new ListResourceRecordSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListResourceRecordSets", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListResourceRecordSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListReusableDelegationSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListReusableDelegationSets");

            var request = InstantiateClassGenerator.Execute<ListReusableDelegationSetsRequest>();
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListReusableDelegationSets", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListReusableDelegationSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void ListTagsForResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResources");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourcesRequest>();
            var marshaller = new ListTagsForResourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListTagsForResources", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsForResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("Route53")]
        public void UpdateHealthCheckMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateHealthCheck");

            var request = InstantiateClassGenerator.Execute<UpdateHealthCheckRequest>();
            var marshaller = new UpdateHealthCheckRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateHealthCheck", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateHealthCheckResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

            }
}