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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWebhook Request Marshaller
    /// </summary>       
    public class UpdateWebhookRequestMarshaller : IMarshaller<IRequest, UpdateWebhookRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWebhookRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateWebhookRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.UpdateWebhook";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBranchFilter())
                {
                    context.Writer.WritePropertyName("branchFilter");
                    context.Writer.Write(publicRequest.BranchFilter);
                }

                if(publicRequest.IsSetBuildType())
                {
                    context.Writer.WritePropertyName("buildType");
                    context.Writer.Write(publicRequest.BuildType);
                }

                if(publicRequest.IsSetFilterGroups())
                {
                    context.Writer.WritePropertyName("filterGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFilterGroupsListValue in publicRequest.FilterGroups)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestFilterGroupsListValueListValue in publicRequestFilterGroupsListValue)
                        {
                            context.Writer.WriteObjectStart();

                            var marshaller = WebhookFilterMarshaller.Instance;
                            marshaller.Marshall(publicRequestFilterGroupsListValueListValue, context);

                            context.Writer.WriteObjectEnd();
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProjectName())
                {
                    context.Writer.WritePropertyName("projectName");
                    context.Writer.Write(publicRequest.ProjectName);
                }

                if(publicRequest.IsSetRotateSecret())
                {
                    context.Writer.WritePropertyName("rotateSecret");
                    context.Writer.Write(publicRequest.RotateSecret);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateWebhookRequestMarshaller _instance = new UpdateWebhookRequestMarshaller();        

        internal static UpdateWebhookRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateWebhookRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}