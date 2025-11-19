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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRouterInput Request Marshaller
    /// </summary>       
    public class CreateRouterInputRequestMarshaller : IMarshaller<IRequest, CreateRouterInputRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRouterInputRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRouterInputRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/routerInput";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouterInputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaintenanceConfiguration())
                {
                    context.Writer.WritePropertyName("maintenanceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MaintenanceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaintenanceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaximumBitrate())
                {
                    context.Writer.WritePropertyName("maximumBitrate");
                    context.Writer.Write(publicRequest.MaximumBitrate);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRegionName())
                {
                    context.Writer.WritePropertyName("regionName");
                    context.Writer.Write(publicRequest.RegionName);
                }

                if(publicRequest.IsSetRoutingScope())
                {
                    context.Writer.WritePropertyName("routingScope");
                    context.Writer.Write(publicRequest.RoutingScope);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTier())
                {
                    context.Writer.WritePropertyName("tier");
                    context.Writer.Write(publicRequest.Tier);
                }

                if(publicRequest.IsSetTransitEncryption())
                {
                    context.Writer.WritePropertyName("transitEncryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = RouterInputTransitEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TransitEncryption, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRouterInputRequestMarshaller _instance = new CreateRouterInputRequestMarshaller();        

        internal static CreateRouterInputRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRouterInputRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}