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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAssetBundleImportJob Request Marshaller
    /// </summary>       
    public class StartAssetBundleImportJobRequestMarshaller : IMarshaller<IRequest, StartAssetBundleImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAssetBundleImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartAssetBundleImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/accounts/{AwsAccountId}/asset-bundle-import-jobs/import";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssetBundleImportJobId())
            {
                context.Writer.WritePropertyName("AssetBundleImportJobId");
                context.Writer.WriteStringValue(publicRequest.AssetBundleImportJobId);
            }

            if(publicRequest.IsSetAssetBundleImportSource())
            {
                context.Writer.WritePropertyName("AssetBundleImportSource");
                context.Writer.WriteStartObject();

                var marshaller = AssetBundleImportSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.AssetBundleImportSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFailureAction())
            {
                context.Writer.WritePropertyName("FailureAction");
                context.Writer.WriteStringValue(publicRequest.FailureAction);
            }

            if(publicRequest.IsSetOverrideParameters())
            {
                context.Writer.WritePropertyName("OverrideParameters");
                context.Writer.WriteStartObject();

                var marshaller = AssetBundleImportJobOverrideParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverrideParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverridePermissions())
            {
                context.Writer.WritePropertyName("OverridePermissions");
                context.Writer.WriteStartObject();

                var marshaller = AssetBundleImportJobOverridePermissionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverridePermissions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverrideTags())
            {
                context.Writer.WritePropertyName("OverrideTags");
                context.Writer.WriteStartObject();

                var marshaller = AssetBundleImportJobOverrideTagsMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverrideTags, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverrideValidationStrategy())
            {
                context.Writer.WritePropertyName("OverrideValidationStrategy");
                context.Writer.WriteStartObject();

                var marshaller = AssetBundleImportJobOverrideValidationStrategyMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverrideValidationStrategy, context);

                context.Writer.WriteEndObject();
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
        private static StartAssetBundleImportJobRequestMarshaller _instance = new StartAssetBundleImportJobRequestMarshaller();        

        internal static StartAssetBundleImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartAssetBundleImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}