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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartResourceStateUpdate Request Marshaller
    /// </summary>       
    public class StartResourceStateUpdateRequestMarshaller : IMarshaller<IRequest, StartResourceStateUpdateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartResourceStateUpdateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartResourceStateUpdateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/StartResourceStateUpdate";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetExclusionRules())
                {
                    context.Writer.WritePropertyName("exclusionRules");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceStateUpdateExclusionRulesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExclusionRules, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecutionRole())
                {
                    context.Writer.WritePropertyName("executionRole");
                    context.Writer.Write(publicRequest.ExecutionRole);
                }

                if(publicRequest.IsSetIncludeResources())
                {
                    context.Writer.WritePropertyName("includeResources");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceStateUpdateIncludeResourcesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IncludeResources, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("resourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("state");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceStateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.State, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpdateAt())
                {
                    context.Writer.WritePropertyName("updateAt");
                    context.Writer.Write(publicRequest.UpdateAt);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartResourceStateUpdateRequestMarshaller _instance = new StartResourceStateUpdateRequestMarshaller();        

        internal static StartResourceStateUpdateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartResourceStateUpdateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}