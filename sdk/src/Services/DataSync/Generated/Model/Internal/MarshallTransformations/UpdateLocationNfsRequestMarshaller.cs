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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLocationNfs Request Marshaller
    /// </summary>       
    public class UpdateLocationNfsRequestMarshaller : IMarshaller<IRequest, UpdateLocationNfsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationNfsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLocationNfsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.UpdateLocationNfs";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLocationArn())
                {
                    context.Writer.WritePropertyName("LocationArn");
                    context.Writer.Write(publicRequest.LocationArn);
                }

                if(publicRequest.IsSetMountOptions())
                {
                    context.Writer.WritePropertyName("MountOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = NfsMountOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MountOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOnPremConfig())
                {
                    context.Writer.WritePropertyName("OnPremConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OnPremConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnPremConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServerHostname())
                {
                    context.Writer.WritePropertyName("ServerHostname");
                    context.Writer.Write(publicRequest.ServerHostname);
                }

                if(publicRequest.IsSetSubdirectory())
                {
                    context.Writer.WritePropertyName("Subdirectory");
                    context.Writer.Write(publicRequest.Subdirectory);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLocationNfsRequestMarshaller _instance = new UpdateLocationNfsRequestMarshaller();        

        internal static UpdateLocationNfsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLocationNfsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}