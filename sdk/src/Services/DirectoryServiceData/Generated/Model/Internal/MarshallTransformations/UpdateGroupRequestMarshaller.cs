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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryServiceData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryServiceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGroup Request Marshaller
    /// </summary>       
    public class UpdateGroupRequestMarshaller : IMarshaller<IRequest, UpdateGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryServiceData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-31";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetDirectoryId())
                request.Parameters.Add("DirectoryId", StringUtils.FromString(publicRequest.DirectoryId));
            request.ResourcePath = "/Groups/UpdateGroup";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetGroupScope())
                {
                    context.Writer.WritePropertyName("GroupScope");
                    context.Writer.Write(publicRequest.GroupScope);
                }

                if(publicRequest.IsSetGroupType())
                {
                    context.Writer.WritePropertyName("GroupType");
                    context.Writer.Write(publicRequest.GroupType);
                }

                if(publicRequest.IsSetOtherAttributes())
                {
                    context.Writer.WritePropertyName("OtherAttributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestOtherAttributesKvp in publicRequest.OtherAttributes)
                    {
                        context.Writer.WritePropertyName(publicRequestOtherAttributesKvp.Key);
                        var publicRequestOtherAttributesValue = publicRequestOtherAttributesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestOtherAttributesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSAMAccountName())
                {
                    context.Writer.WritePropertyName("SAMAccountName");
                    context.Writer.Write(publicRequest.SAMAccountName);
                }

                if(publicRequest.IsSetUpdateType())
                {
                    context.Writer.WritePropertyName("UpdateType");
                    context.Writer.Write(publicRequest.UpdateType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdateGroupRequestMarshaller _instance = new UpdateGroupRequestMarshaller();        

        internal static UpdateGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}