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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTracker Request Marshaller
    /// </summary>       
    public class UpdateTrackerRequestMarshaller : IMarshaller<IRequest, UpdateTrackerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrackerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTrackerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetTrackerName())
                throw new AmazonLocationServiceException("Request object does not have required field TrackerName set");
            request.AddPathResource("{TrackerName}", StringUtils.FromString(publicRequest.TrackerName));
            request.ResourcePath = "/tracking/v0/trackers/{TrackerName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEventBridgeEnabled())
            {
                context.Writer.WritePropertyName("EventBridgeEnabled");
                context.Writer.WriteBooleanValue(publicRequest.EventBridgeEnabled.Value);
            }

            if(publicRequest.IsSetKmsKeyEnableGeospatialQueries())
            {
                context.Writer.WritePropertyName("KmsKeyEnableGeospatialQueries");
                context.Writer.WriteBooleanValue(publicRequest.KmsKeyEnableGeospatialQueries.Value);
            }

            if(publicRequest.IsSetPositionFiltering())
            {
                context.Writer.WritePropertyName("PositionFiltering");
                context.Writer.WriteStringValue(publicRequest.PositionFiltering);
            }

            if(publicRequest.IsSetPricingPlan())
            {
                context.Writer.WritePropertyName("PricingPlan");
                context.Writer.WriteStringValue(publicRequest.PricingPlan);
            }

            if(publicRequest.IsSetPricingPlanDataSource())
            {
                context.Writer.WritePropertyName("PricingPlanDataSource");
                context.Writer.WriteStringValue(publicRequest.PricingPlanDataSource);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"cp.tracking.";

            return request;
        }
        private static UpdateTrackerRequestMarshaller _instance = new UpdateTrackerRequestMarshaller();        

        internal static UpdateTrackerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTrackerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}