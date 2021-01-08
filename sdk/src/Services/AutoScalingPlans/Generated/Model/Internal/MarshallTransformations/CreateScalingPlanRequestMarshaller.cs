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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScalingPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateScalingPlan Request Marshaller
    /// </summary>       
    public class CreateScalingPlanRequestMarshaller : IMarshaller<IRequest, CreateScalingPlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateScalingPlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateScalingPlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScalingPlans");
            string target = "AnyScaleScalingPlannerFrontendService.CreateScalingPlan";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-06";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationSource())
                {
                    context.Writer.WritePropertyName("ApplicationSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ApplicationSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetScalingInstructions())
                {
                    context.Writer.WritePropertyName("ScalingInstructions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestScalingInstructionsListValue in publicRequest.ScalingInstructions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ScalingInstructionMarshaller.Instance;
                        marshaller.Marshall(publicRequestScalingInstructionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetScalingPlanName())
                {
                    context.Writer.WritePropertyName("ScalingPlanName");
                    context.Writer.Write(publicRequest.ScalingPlanName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateScalingPlanRequestMarshaller _instance = new CreateScalingPlanRequestMarshaller();        

        internal static CreateScalingPlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateScalingPlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}