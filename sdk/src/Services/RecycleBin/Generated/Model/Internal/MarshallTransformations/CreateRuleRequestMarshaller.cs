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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RecycleBin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RecycleBin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRule Request Marshaller
    /// </summary>       
    public class CreateRuleRequestMarshaller : IMarshaller<IRequest, CreateRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RecycleBin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/rules";
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

                if(publicRequest.IsSetLockConfiguration())
                {
                    context.Writer.WritePropertyName("LockConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LockConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LockConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceTags())
                {
                    context.Writer.WritePropertyName("ResourceTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceTagsListValue in publicRequest.ResourceTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourceTagMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourceTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceType())
                {
                    context.Writer.WritePropertyName("ResourceType");
                    context.Writer.Write(publicRequest.ResourceType);
                }

                if(publicRequest.IsSetRetentionPeriod())
                {
                    context.Writer.WritePropertyName("RetentionPeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetentionPeriodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetentionPeriod, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateRuleRequestMarshaller _instance = new CreateRuleRequestMarshaller();        

        internal static CreateRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}