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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartPlanExecution Request Marshaller
    /// </summary>       
    public class StartPlanExecutionRequestMarshaller : IMarshaller<IRequest, StartPlanExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartPlanExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartPlanExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ARCRegionswitch");
            string target = "ArcRegionSwitch.StartPlanExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAction())
                {
                    context.Writer.WritePropertyName("action");
                    context.Writer.Write(publicRequest.Action);
                }

                if(publicRequest.IsSetComment())
                {
                    context.Writer.WritePropertyName("comment");
                    context.Writer.Write(publicRequest.Comment);
                }

                if(publicRequest.IsSetLatestVersion())
                {
                    context.Writer.WritePropertyName("latestVersion");
                    context.Writer.Write(publicRequest.LatestVersion);
                }

                if(publicRequest.IsSetMode())
                {
                    context.Writer.WritePropertyName("mode");
                    context.Writer.Write(publicRequest.Mode);
                }

                if(publicRequest.IsSetPlanArn())
                {
                    context.Writer.WritePropertyName("planArn");
                    context.Writer.Write(publicRequest.PlanArn);
                }

                if(publicRequest.IsSetTargetRegion())
                {
                    context.Writer.WritePropertyName("targetRegion");
                    context.Writer.Write(publicRequest.TargetRegion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartPlanExecutionRequestMarshaller _instance = new StartPlanExecutionRequestMarshaller();        

        internal static StartPlanExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartPlanExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}