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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
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
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListServiceLevelObjectives Request Marshaller
    /// </summary>       
    public class ListServiceLevelObjectivesRequestMarshaller : IMarshaller<IRequest, ListServiceLevelObjectivesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListServiceLevelObjectivesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListServiceLevelObjectivesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetIncludeLinkedAccounts())
                request.Parameters.Add("IncludeLinkedAccounts", StringUtils.FromBool(publicRequest.IncludeLinkedAccounts));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOperationName())
                request.Parameters.Add("OperationName", StringUtils.FromString(publicRequest.OperationName));
            
            if (publicRequest.IsSetSloOwnerAwsAccountId())
                request.Parameters.Add("SloOwnerAwsAccountId", StringUtils.FromString(publicRequest.SloOwnerAwsAccountId));
            request.ResourcePath = "/slos";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDependencyConfig())
            {
                context.Writer.WritePropertyName("DependencyConfig");
                context.Writer.WriteStartObject();

                var marshaller = DependencyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DependencyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKeyAttributes())
            {
                context.Writer.WritePropertyName("KeyAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestKeyAttributesKvp in publicRequest.KeyAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestKeyAttributesKvp.Key);
                    var publicRequestKeyAttributesValue = publicRequestKeyAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestKeyAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMetricSourceTypes())
            {
                context.Writer.WritePropertyName("MetricSourceTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricSourceTypesListValue in publicRequest.MetricSourceTypes)
                {
                        context.Writer.WriteStringValue(publicRequestMetricSourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static ListServiceLevelObjectivesRequestMarshaller _instance = new ListServiceLevelObjectivesRequestMarshaller();        

        internal static ListServiceLevelObjectivesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListServiceLevelObjectivesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}