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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFleetAttributes Request Marshaller
    /// </summary>       
    public class UpdateFleetAttributesRequestMarshaller : IMarshaller<IRequest, UpdateFleetAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFleetAttributesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFleetAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.UpdateFleetAttributes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnywhereConfiguration())
                {
                    context.Writer.WritePropertyName("AnywhereConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnywhereConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnywhereConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFleetId())
                {
                    context.Writer.WritePropertyName("FleetId");
                    context.Writer.Write(publicRequest.FleetId);
                }

                if(publicRequest.IsSetMetricGroups())
                {
                    context.Writer.WritePropertyName("MetricGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricGroupsListValue in publicRequest.MetricGroups)
                    {
                            context.Writer.Write(publicRequestMetricGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNewGameSessionProtectionPolicy())
                {
                    context.Writer.WritePropertyName("NewGameSessionProtectionPolicy");
                    context.Writer.Write(publicRequest.NewGameSessionProtectionPolicy);
                }

                if(publicRequest.IsSetResourceCreationLimitPolicy())
                {
                    context.Writer.WritePropertyName("ResourceCreationLimitPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceCreationLimitPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceCreationLimitPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFleetAttributesRequestMarshaller _instance = new UpdateFleetAttributesRequestMarshaller();        

        internal static UpdateFleetAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFleetAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}