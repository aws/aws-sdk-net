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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
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
namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAlert Request Marshaller
    /// </summary>       
    public class UpdateAlertRequestMarshaller : IMarshaller<IRequest, UpdateAlertRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAlertRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAlertRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutMetrics");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateAlert";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStartObject();

                var marshaller = ActionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Action, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAlertArn())
            {
                context.Writer.WritePropertyName("AlertArn");
                context.Writer.WriteStringValue(publicRequest.AlertArn);
            }

            if(publicRequest.IsSetAlertDescription())
            {
                context.Writer.WritePropertyName("AlertDescription");
                context.Writer.WriteStringValue(publicRequest.AlertDescription);
            }

            if(publicRequest.IsSetAlertFilters())
            {
                context.Writer.WritePropertyName("AlertFilters");
                context.Writer.WriteStartObject();

                var marshaller = AlertFiltersMarshaller.Instance;
                marshaller.Marshall(publicRequest.AlertFilters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAlertSensitivityThreshold())
            {
                context.Writer.WritePropertyName("AlertSensitivityThreshold");
                context.Writer.WriteNumberValue(publicRequest.AlertSensitivityThreshold.Value);
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
        private static UpdateAlertRequestMarshaller _instance = new UpdateAlertRequestMarshaller();        

        internal static UpdateAlertRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAlertRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}