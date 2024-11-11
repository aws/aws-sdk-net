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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCapacityTask Request Marshaller
    /// </summary>       
    public class StartCapacityTaskRequestMarshaller : IMarshaller<IRequest, StartCapacityTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartCapacityTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartCapacityTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetOutpostIdentifier())
                throw new AmazonOutpostsException("Request object does not have required field OutpostIdentifier set");
            request.AddPathResource("{OutpostId}", StringUtils.FromString(publicRequest.OutpostIdentifier));
            request.ResourcePath = "/outposts/{OutpostId}/capacity";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetInstancePools())
                {
                    context.Writer.WritePropertyName("InstancePools");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstancePoolsListValue in publicRequest.InstancePools)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InstanceTypeCapacityMarshaller.Instance;
                        marshaller.Marshall(publicRequestInstancePoolsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInstancesToExclude())
                {
                    context.Writer.WritePropertyName("InstancesToExclude");
                    context.Writer.WriteObjectStart();

                    var marshaller = InstancesToExcludeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InstancesToExclude, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOrderId())
                {
                    context.Writer.WritePropertyName("OrderId");
                    context.Writer.Write(publicRequest.OrderId);
                }

                if(publicRequest.IsSetTaskActionOnBlockingInstances())
                {
                    context.Writer.WritePropertyName("TaskActionOnBlockingInstances");
                    context.Writer.Write(publicRequest.TaskActionOnBlockingInstances);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartCapacityTaskRequestMarshaller _instance = new StartCapacityTaskRequestMarshaller();        

        internal static StartCapacityTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartCapacityTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}