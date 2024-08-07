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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IAMRolesAnywhere.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IAMRolesAnywhere.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProfile Request Marshaller
    /// </summary>       
    public class CreateProfileRequestMarshaller : IMarshaller<IRequest, CreateProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IAMRolesAnywhere");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/profiles";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAcceptRoleSessionName())
                {
                    context.Writer.WritePropertyName("acceptRoleSessionName");
                    context.Writer.Write(publicRequest.AcceptRoleSessionName);
                }

                if(publicRequest.IsSetDurationSeconds())
                {
                    context.Writer.WritePropertyName("durationSeconds");
                    context.Writer.Write(publicRequest.DurationSeconds);
                }

                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

                if(publicRequest.IsSetManagedPolicyArns())
                {
                    context.Writer.WritePropertyName("managedPolicyArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestManagedPolicyArnsListValue in publicRequest.ManagedPolicyArns)
                    {
                            context.Writer.Write(publicRequestManagedPolicyArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRequireInstanceProperties())
                {
                    context.Writer.WritePropertyName("requireInstanceProperties");
                    context.Writer.Write(publicRequest.RequireInstanceProperties);
                }

                if(publicRequest.IsSetRoleArns())
                {
                    context.Writer.WritePropertyName("roleArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRoleArnsListValue in publicRequest.RoleArns)
                    {
                            context.Writer.Write(publicRequestRoleArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSessionPolicy())
                {
                    context.Writer.WritePropertyName("sessionPolicy");
                    context.Writer.Write(publicRequest.SessionPolicy);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
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
        private static CreateProfileRequestMarshaller _instance = new CreateProfileRequestMarshaller();        

        internal static CreateProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}