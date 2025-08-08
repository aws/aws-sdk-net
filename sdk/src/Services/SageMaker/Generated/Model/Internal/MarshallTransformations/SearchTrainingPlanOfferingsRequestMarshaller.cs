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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchTrainingPlanOfferings Request Marshaller
    /// </summary>       
    public class SearchTrainingPlanOfferingsRequestMarshaller : IMarshaller<IRequest, SearchTrainingPlanOfferingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchTrainingPlanOfferingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchTrainingPlanOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.SearchTrainingPlanOfferings";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDurationHours())
                {
                    context.Writer.WritePropertyName("DurationHours");
                    context.Writer.Write(publicRequest.DurationHours);
                }

                if(publicRequest.IsSetEndTimeBefore())
                {
                    context.Writer.WritePropertyName("EndTimeBefore");
                    context.Writer.Write(publicRequest.EndTimeBefore);
                }

                if(publicRequest.IsSetInstanceCount())
                {
                    context.Writer.WritePropertyName("InstanceCount");
                    context.Writer.Write(publicRequest.InstanceCount);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    context.Writer.WritePropertyName("InstanceType");
                    context.Writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetStartTimeAfter())
                {
                    context.Writer.WritePropertyName("StartTimeAfter");
                    context.Writer.Write(publicRequest.StartTimeAfter);
                }

                if(publicRequest.IsSetTargetResources())
                {
                    context.Writer.WritePropertyName("TargetResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetResourcesListValue in publicRequest.TargetResources)
                    {
                            context.Writer.Write(publicRequestTargetResourcesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUltraServerCount())
                {
                    context.Writer.WritePropertyName("UltraServerCount");
                    context.Writer.Write(publicRequest.UltraServerCount);
                }

                if(publicRequest.IsSetUltraServerType())
                {
                    context.Writer.WritePropertyName("UltraServerType");
                    context.Writer.Write(publicRequest.UltraServerType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SearchTrainingPlanOfferingsRequestMarshaller _instance = new SearchTrainingPlanOfferingsRequestMarshaller();        

        internal static SearchTrainingPlanOfferingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchTrainingPlanOfferingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}