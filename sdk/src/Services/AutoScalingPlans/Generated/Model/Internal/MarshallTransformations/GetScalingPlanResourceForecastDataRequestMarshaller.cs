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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetForecastDataType())
            {
                context.Writer.WritePropertyName("ForecastDataType");
                context.Writer.WriteStringValue(publicRequest.ForecastDataType);
            }

            if(publicRequest.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteStringValue(publicRequest.ResourceId);
            }

            if(publicRequest.IsSetScalableDimension())
            {
                context.Writer.WritePropertyName("ScalableDimension");
                context.Writer.WriteStringValue(publicRequest.ScalableDimension);
            }

            if(publicRequest.IsSetScalingPlanName())
            {
                context.Writer.WritePropertyName("ScalingPlanName");
                context.Writer.WriteStringValue(publicRequest.ScalingPlanName);
            }

            if(publicRequest.IsSetScalingPlanVersion())
            {
                context.Writer.WritePropertyName("ScalingPlanVersion");
                context.Writer.WriteNumberValue(publicRequest.ScalingPlanVersion.Value);
            }

            if(publicRequest.IsSetServiceNamespace())
            {
                context.Writer.WritePropertyName("ServiceNamespace");
                context.Writer.WriteStringValue(publicRequest.ServiceNamespace);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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