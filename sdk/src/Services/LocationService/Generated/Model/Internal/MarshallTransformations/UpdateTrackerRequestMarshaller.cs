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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEventBridgeEnabled())
                {
                    context.Writer.WritePropertyName("EventBridgeEnabled");
                    context.Writer.Write(publicRequest.EventBridgeEnabled);
                }

                if(publicRequest.IsSetPositionFiltering())
                {
                    context.Writer.WritePropertyName("PositionFiltering");
                    context.Writer.Write(publicRequest.PositionFiltering);
                }

                if(publicRequest.IsSetPricingPlan())
                {
                    context.Writer.WritePropertyName("PricingPlan");
                    context.Writer.Write(publicRequest.PricingPlan);
                }

                if(publicRequest.IsSetPricingPlanDataSource())
                {
                    context.Writer.WritePropertyName("PricingPlanDataSource");
                    context.Writer.Write(publicRequest.PricingPlanDataSource);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"tracking.";

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