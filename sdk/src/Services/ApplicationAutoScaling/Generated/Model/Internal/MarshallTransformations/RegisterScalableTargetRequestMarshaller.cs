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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterScalableTarget Request Marshaller
    /// </summary>       
    public class RegisterScalableTargetRequestMarshaller : IMarshaller<IRequest, RegisterScalableTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterScalableTargetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterScalableTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationAutoScaling");
            string target = "AnyScaleFrontendService.RegisterScalableTarget";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-02-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxCapacity())
                {
                    context.Writer.WritePropertyName("MaxCapacity");
                    context.Writer.Write(publicRequest.MaxCapacity);
                }

                if(publicRequest.IsSetMinCapacity())
                {
                    context.Writer.WritePropertyName("MinCapacity");
                    context.Writer.Write(publicRequest.MinCapacity);
                }

                if(publicRequest.IsSetResourceId())
                {
                    context.Writer.WritePropertyName("ResourceId");
                    context.Writer.Write(publicRequest.ResourceId);
                }

                if(publicRequest.IsSetRoleARN())
                {
                    context.Writer.WritePropertyName("RoleARN");
                    context.Writer.Write(publicRequest.RoleARN);
                }

                if(publicRequest.IsSetScalableDimension())
                {
                    context.Writer.WritePropertyName("ScalableDimension");
                    context.Writer.Write(publicRequest.ScalableDimension);
                }

                if(publicRequest.IsSetServiceNamespace())
                {
                    context.Writer.WritePropertyName("ServiceNamespace");
                    context.Writer.Write(publicRequest.ServiceNamespace);
                }

                if(publicRequest.IsSetSuspendedState())
                {
                    context.Writer.WritePropertyName("SuspendedState");
                    context.Writer.WriteObjectStart();

                    var marshaller = SuspendedStateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SuspendedState, context);

                    context.Writer.WriteObjectEnd();
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterScalableTargetRequestMarshaller _instance = new RegisterScalableTargetRequestMarshaller();        

        internal static RegisterScalableTargetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterScalableTargetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}