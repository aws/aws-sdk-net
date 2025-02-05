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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvidently.Model;
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
namespace Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFeature Request Marshaller
    /// </summary>       
    public class UpdateFeatureRequestMarshaller : IMarshaller<IRequest, UpdateFeatureRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFeatureRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFeatureRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvidently");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-02-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetFeature())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Feature set");
            request.AddPathResource("{feature}", StringUtils.FromString(publicRequest.Feature));
            if (!publicRequest.IsSetProject())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Project set");
            request.AddPathResource("{project}", StringUtils.FromString(publicRequest.Project));
            request.ResourcePath = "/projects/{project}/features/{feature}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAddOrUpdateVariations())
            {
                context.Writer.WritePropertyName("addOrUpdateVariations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddOrUpdateVariationsListValue in publicRequest.AddOrUpdateVariations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VariationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestAddOrUpdateVariationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDefaultVariation())
            {
                context.Writer.WritePropertyName("defaultVariation");
                context.Writer.WriteStringValue(publicRequest.DefaultVariation);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEntityOverrides())
            {
                context.Writer.WritePropertyName("entityOverrides");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEntityOverridesKvp in publicRequest.EntityOverrides)
                {
                    context.Writer.WritePropertyName(publicRequestEntityOverridesKvp.Key);
                    var publicRequestEntityOverridesValue = publicRequestEntityOverridesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEntityOverridesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEvaluationStrategy())
            {
                context.Writer.WritePropertyName("evaluationStrategy");
                context.Writer.WriteStringValue(publicRequest.EvaluationStrategy);
            }

            if(publicRequest.IsSetRemoveVariations())
            {
                context.Writer.WritePropertyName("removeVariations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRemoveVariationsListValue in publicRequest.RemoveVariations)
                {
                        context.Writer.WriteStringValue(publicRequestRemoveVariationsListValue);
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
            


            return request;
        }
        private static UpdateFeatureRequestMarshaller _instance = new UpdateFeatureRequestMarshaller();        

        internal static UpdateFeatureRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFeatureRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}