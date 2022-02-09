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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSiteRackPhysicalProperties Request Marshaller
    /// </summary>       
    public class UpdateSiteRackPhysicalPropertiesRequestMarshaller : IMarshaller<IRequest, UpdateSiteRackPhysicalPropertiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSiteRackPhysicalPropertiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSiteRackPhysicalPropertiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetSiteId())
                throw new AmazonOutpostsException("Request object does not have required field SiteId set");
            request.AddPathResource("{SiteId}", StringUtils.FromString(publicRequest.SiteId));
            request.ResourcePath = "/sites/{SiteId}/rackPhysicalProperties";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFiberOpticCableType())
                {
                    context.Writer.WritePropertyName("FiberOpticCableType");
                    context.Writer.Write(publicRequest.FiberOpticCableType);
                }

                if(publicRequest.IsSetMaximumSupportedWeightLbs())
                {
                    context.Writer.WritePropertyName("MaximumSupportedWeightLbs");
                    context.Writer.Write(publicRequest.MaximumSupportedWeightLbs);
                }

                if(publicRequest.IsSetOpticalStandard())
                {
                    context.Writer.WritePropertyName("OpticalStandard");
                    context.Writer.Write(publicRequest.OpticalStandard);
                }

                if(publicRequest.IsSetPowerConnector())
                {
                    context.Writer.WritePropertyName("PowerConnector");
                    context.Writer.Write(publicRequest.PowerConnector);
                }

                if(publicRequest.IsSetPowerDrawKva())
                {
                    context.Writer.WritePropertyName("PowerDrawKva");
                    context.Writer.Write(publicRequest.PowerDrawKva);
                }

                if(publicRequest.IsSetPowerFeedDrop())
                {
                    context.Writer.WritePropertyName("PowerFeedDrop");
                    context.Writer.Write(publicRequest.PowerFeedDrop);
                }

                if(publicRequest.IsSetPowerPhase())
                {
                    context.Writer.WritePropertyName("PowerPhase");
                    context.Writer.Write(publicRequest.PowerPhase);
                }

                if(publicRequest.IsSetUplinkCount())
                {
                    context.Writer.WritePropertyName("UplinkCount");
                    context.Writer.Write(publicRequest.UplinkCount);
                }

                if(publicRequest.IsSetUplinkGbps())
                {
                    context.Writer.WritePropertyName("UplinkGbps");
                    context.Writer.Write(publicRequest.UplinkGbps);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSiteRackPhysicalPropertiesRequestMarshaller _instance = new UpdateSiteRackPhysicalPropertiesRequestMarshaller();        

        internal static UpdateSiteRackPhysicalPropertiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSiteRackPhysicalPropertiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}