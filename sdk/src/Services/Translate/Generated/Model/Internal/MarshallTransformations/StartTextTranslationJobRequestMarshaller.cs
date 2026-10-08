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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Translate.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Translate.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartTextTranslationJob Request Marshaller
    /// </summary>       
    public class StartTextTranslationJobRequestMarshaller : IMarshaller<IRequest, StartTextTranslationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTextTranslationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartTextTranslationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Translate");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/AWSShineFrontendService_20170701/operation/StartTextTranslationJob";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else if (!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WriteTextString("DataAccessRoleArn");
                    context.Writer.WriteTextString(publicRequest.DataAccessRoleArn);
                }
                if (publicRequest.IsSetInputDataConfig())
                {
                    context.Writer.WriteTextString("InputDataConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = InputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputDataConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetJobName())
                {
                    context.Writer.WriteTextString("JobName");
                    context.Writer.WriteTextString(publicRequest.JobName);
                }
                if (publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WriteTextString("OutputDataConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetParallelDataNames())
                {
                    context.Writer.WriteTextString("ParallelDataNames");
                    context.Writer.WriteStartArray(publicRequest.ParallelDataNames.Count);
                    foreach(var publicRequestParallelDataNamesListValue in publicRequest.ParallelDataNames)
                    {
                            context.Writer.WriteTextString(publicRequestParallelDataNamesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSettings())
                {
                    context.Writer.WriteTextString("Settings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TranslationSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSourceLanguageCode())
                {
                    context.Writer.WriteTextString("SourceLanguageCode");
                    context.Writer.WriteTextString(publicRequest.SourceLanguageCode);
                }
                if (publicRequest.IsSetTargetLanguageCodes())
                {
                    context.Writer.WriteTextString("TargetLanguageCodes");
                    context.Writer.WriteStartArray(publicRequest.TargetLanguageCodes.Count);
                    foreach(var publicRequestTargetLanguageCodesListValue in publicRequest.TargetLanguageCodes)
                    {
                            context.Writer.WriteTextString(publicRequestTargetLanguageCodesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTerminologyNames())
                {
                    context.Writer.WriteTextString("TerminologyNames");
                    context.Writer.WriteStartArray(publicRequest.TerminologyNames.Count);
                    foreach(var publicRequestTerminologyNamesListValue in publicRequest.TerminologyNames)
                    {
                            context.Writer.WriteTextString(publicRequestTerminologyNamesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static StartTextTranslationJobRequestMarshaller _instance = new StartTextTranslationJobRequestMarshaller();        

        internal static StartTextTranslationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartTextTranslationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}