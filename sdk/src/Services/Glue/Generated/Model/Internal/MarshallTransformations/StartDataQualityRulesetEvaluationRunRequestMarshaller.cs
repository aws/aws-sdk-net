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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDataQualityRulesetEvaluationRun Request Marshaller
    /// </summary>       
    public class StartDataQualityRulesetEvaluationRunRequestMarshaller : IMarshaller<IRequest, StartDataQualityRulesetEvaluationRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDataQualityRulesetEvaluationRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDataQualityRulesetEvaluationRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.StartDataQualityRulesetEvaluationRun";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if(publicRequest.IsSetAdditionalDataSources())
            {
                context.Writer.WritePropertyName("AdditionalDataSources");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAdditionalDataSourcesKvp in publicRequest.AdditionalDataSources)
                {
                    context.Writer.WritePropertyName(publicRequestAdditionalDataSourcesKvp.Key);
                    var publicRequestAdditionalDataSourcesValue = publicRequestAdditionalDataSourcesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdditionalDataSourcesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAdditionalRunOptions())
            {
                context.Writer.WritePropertyName("AdditionalRunOptions");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityEvaluationRunAdditionalRunOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdditionalRunOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(publicRequest.NumberOfWorkers.Value);
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetRulesetNames())
            {
                context.Writer.WritePropertyName("RulesetNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRulesetNamesListValue in publicRequest.RulesetNames)
                {
                        context.Writer.WriteStringValue(publicRequestRulesetNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(publicRequest.Timeout.Value);
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
        private static StartDataQualityRulesetEvaluationRunRequestMarshaller _instance = new StartDataQualityRulesetEvaluationRunRequestMarshaller();        

        internal static StartDataQualityRulesetEvaluationRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDataQualityRulesetEvaluationRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}