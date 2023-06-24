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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDevEndpoint Request Marshaller
    /// </summary>       
    public class CreateDevEndpointRequestMarshaller : IMarshaller<IRequest, CreateDevEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDevEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDevEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateDevEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArguments())
                {
                    context.Writer.WritePropertyName("Arguments");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestArgumentsKvp in publicRequest.Arguments)
                    {
                        context.Writer.WritePropertyName(publicRequestArgumentsKvp.Key);
                        var publicRequestArgumentsValue = publicRequestArgumentsKvp.Value;

                            context.Writer.Write(publicRequestArgumentsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndpointName())
                {
                    context.Writer.WritePropertyName("EndpointName");
                    context.Writer.Write(publicRequest.EndpointName);
                }

                if(publicRequest.IsSetExtraJarsS3Path())
                {
                    context.Writer.WritePropertyName("ExtraJarsS3Path");
                    context.Writer.Write(publicRequest.ExtraJarsS3Path);
                }

                if(publicRequest.IsSetExtraPythonLibsS3Path())
                {
                    context.Writer.WritePropertyName("ExtraPythonLibsS3Path");
                    context.Writer.Write(publicRequest.ExtraPythonLibsS3Path);
                }

                if(publicRequest.IsSetGlueVersion())
                {
                    context.Writer.WritePropertyName("GlueVersion");
                    context.Writer.Write(publicRequest.GlueVersion);
                }

                if(publicRequest.IsSetNumberOfNodes())
                {
                    context.Writer.WritePropertyName("NumberOfNodes");
                    context.Writer.Write(publicRequest.NumberOfNodes);
                }

                if(publicRequest.IsSetNumberOfWorkers())
                {
                    context.Writer.WritePropertyName("NumberOfWorkers");
                    context.Writer.Write(publicRequest.NumberOfWorkers);
                }

                if(publicRequest.IsSetPublicKey())
                {
                    context.Writer.WritePropertyName("PublicKey");
                    context.Writer.Write(publicRequest.PublicKey);
                }

                if(publicRequest.IsSetPublicKeys())
                {
                    context.Writer.WritePropertyName("PublicKeys");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPublicKeysListValue in publicRequest.PublicKeys)
                    {
                            context.Writer.Write(publicRequestPublicKeysListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSecurityConfiguration())
                {
                    context.Writer.WritePropertyName("SecurityConfiguration");
                    context.Writer.Write(publicRequest.SecurityConfiguration);
                }

                if(publicRequest.IsSetSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("SecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubnetId())
                {
                    context.Writer.WritePropertyName("SubnetId");
                    context.Writer.Write(publicRequest.SubnetId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkerType())
                {
                    context.Writer.WritePropertyName("WorkerType");
                    context.Writer.Write(publicRequest.WorkerType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDevEndpointRequestMarshaller _instance = new CreateDevEndpointRequestMarshaller();        

        internal static CreateDevEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDevEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}