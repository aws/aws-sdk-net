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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTieringConfiguration Request Marshaller
    /// </summary>       
    public class CreateTieringConfigurationRequestMarshaller : IMarshaller<IRequest, CreateTieringConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTieringConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTieringConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/tiering-configurations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCreatorRequestId())
                {
                    context.Writer.WritePropertyName("CreatorRequestId");
                    context.Writer.Write(publicRequest.CreatorRequestId);
                }

                else if(!(publicRequest.IsSetCreatorRequestId()))
                {
                    context.Writer.WritePropertyName("CreatorRequestId");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetTieringConfiguration())
                {
                    context.Writer.WritePropertyName("TieringConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = TieringConfigurationInputForCreateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TieringConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTieringConfigurationTags())
                {
                    context.Writer.WritePropertyName("TieringConfigurationTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTieringConfigurationTagsKvp in publicRequest.TieringConfigurationTags)
                    {
                        context.Writer.WritePropertyName(publicRequestTieringConfigurationTagsKvp.Key);
                        var publicRequestTieringConfigurationTagsValue = publicRequestTieringConfigurationTagsKvp.Value;

                            context.Writer.Write(publicRequestTieringConfigurationTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTieringConfigurationRequestMarshaller _instance = new CreateTieringConfigurationRequestMarshaller();        

        internal static CreateTieringConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTieringConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}