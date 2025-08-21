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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLiftStreams.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLiftStreams.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStreamGroup Request Marshaller
    /// </summary>       
    public class UpdateStreamGroupRequestMarshaller : IMarshaller<IRequest, UpdateStreamGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStreamGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStreamGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLiftStreams");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonGameLiftStreamsException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/streamgroups/{Identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefaultApplicationIdentifier())
                {
                    context.Writer.WritePropertyName("DefaultApplicationIdentifier");
                    context.Writer.Write(publicRequest.DefaultApplicationIdentifier);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLocationConfigurations())
                {
                    context.Writer.WritePropertyName("LocationConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLocationConfigurationsListValue in publicRequest.LocationConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LocationConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestLocationConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateStreamGroupRequestMarshaller _instance = new UpdateStreamGroupRequestMarshaller();        

        internal static UpdateStreamGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStreamGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}