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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartRxNormInferenceJob Request Marshaller
    /// </summary>
    public partial class StartRxNormInferenceJobRequestMarshaller : IMarshaller<IRequest, StartRxNormInferenceJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartRxNormInferenceJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartRxNormInferenceJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComprehendMedical");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/ComprehendMedical_20181030/operation/StartRxNormInferenceJob";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WriteTextString("ClientRequestToken");
                    context.Writer.WriteTextString(publicRequest.ClientRequestToken);
                }
                else
                {
                    context.Writer.WriteTextString("ClientRequestToken");
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
                if (publicRequest.IsSetKMSKey())
                {
                    context.Writer.WriteTextString("KMSKey");
                    context.Writer.WriteTextString(publicRequest.KMSKey);
                }
                if (publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WriteTextString("LanguageCode");
                    context.Writer.WriteTextString(publicRequest.LanguageCode);
                }
                if (publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WriteTextString("OutputDataConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
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

        private static readonly StartRxNormInferenceJobRequestMarshaller _instance = new();

        internal static StartRxNormInferenceJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartRxNormInferenceJobRequestMarshaller Instance => _instance;
    }
}
