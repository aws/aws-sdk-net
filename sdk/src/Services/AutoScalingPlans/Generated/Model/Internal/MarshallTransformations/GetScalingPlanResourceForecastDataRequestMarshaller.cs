/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// GetScalingPlanResourceForecastData Request Marshaller
    /// </summary>       
    public class GetScalingPlanResourceForecastDataRequestMarshaller : IMarshaller<IRequest, GetScalingPlanResourceForecastDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetScalingPlanResourceForecastDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetScalingPlanResourceForecastDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScalingPlans");
            string target = "AnyScaleScalingPlannerFrontendService.GetScalingPlanResourceForecastData";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("EndTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetForecastDataType())
                {
                    context.Writer.WritePropertyName("ForecastDataType");
                    context.Writer.Write(publicRequest.ForecastDataType);
                }

                if(publicRequest.IsSetResourceId())
                {
                    context.Writer.WritePropertyName("ResourceId");
                    context.Writer.Write(publicRequest.ResourceId);
                }

                if(publicRequest.IsSetScalableDimension())
                {
                    context.Writer.WritePropertyName("ScalableDimension");
                    context.Writer.Write(publicRequest.ScalableDimension);
                }

                if(publicRequest.IsSetScalingPlanName())
                {
                    context.Writer.WritePropertyName("ScalingPlanName");
                    context.Writer.Write(publicRequest.ScalingPlanName);
                }

                if(publicRequest.IsSetScalingPlanVersion())
                {
                    context.Writer.WritePropertyName("ScalingPlanVersion");
                    context.Writer.Write(publicRequest.ScalingPlanVersion);
                }

                if(publicRequest.IsSetServiceNamespace())
                {
                    context.Writer.WritePropertyName("ServiceNamespace");
                    context.Writer.Write(publicRequest.ServiceNamespace);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("StartTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetScalingPlanResourceForecastDataRequestMarshaller _instance = new GetScalingPlanResourceForecastDataRequestMarshaller();        

        internal static GetScalingPlanResourceForecastDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetScalingPlanResourceForecastDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}