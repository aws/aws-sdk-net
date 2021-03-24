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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideoArchivedMedia.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisVideoArchivedMedia.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDASHStreamingSessionURL Request Marshaller
    /// </summary>       
    public class GetDASHStreamingSessionURLRequestMarshaller : IMarshaller<IRequest, GetDASHStreamingSessionURLRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDASHStreamingSessionURLRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDASHStreamingSessionURLRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisVideoArchivedMedia");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/getDASHStreamingSessionURL";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDASHFragmentSelector())
                {
                    context.Writer.WritePropertyName("DASHFragmentSelector");
                    context.Writer.WriteObjectStart();

                    var marshaller = DASHFragmentSelectorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DASHFragmentSelector, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDisplayFragmentNumber())
                {
                    context.Writer.WritePropertyName("DisplayFragmentNumber");
                    context.Writer.Write(publicRequest.DisplayFragmentNumber);
                }

                if(publicRequest.IsSetDisplayFragmentTimestamp())
                {
                    context.Writer.WritePropertyName("DisplayFragmentTimestamp");
                    context.Writer.Write(publicRequest.DisplayFragmentTimestamp);
                }

                if(publicRequest.IsSetExpires())
                {
                    context.Writer.WritePropertyName("Expires");
                    context.Writer.Write(publicRequest.Expires);
                }

                if(publicRequest.IsSetMaxManifestFragmentResults())
                {
                    context.Writer.WritePropertyName("MaxManifestFragmentResults");
                    context.Writer.Write(publicRequest.MaxManifestFragmentResults);
                }

                if(publicRequest.IsSetPlaybackMode())
                {
                    context.Writer.WritePropertyName("PlaybackMode");
                    context.Writer.Write(publicRequest.PlaybackMode);
                }

                if(publicRequest.IsSetStreamARN())
                {
                    context.Writer.WritePropertyName("StreamARN");
                    context.Writer.Write(publicRequest.StreamARN);
                }

                if(publicRequest.IsSetStreamName())
                {
                    context.Writer.WritePropertyName("StreamName");
                    context.Writer.Write(publicRequest.StreamName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetDASHStreamingSessionURLRequestMarshaller _instance = new GetDASHStreamingSessionURLRequestMarshaller();        

        internal static GetDASHStreamingSessionURLRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDASHStreamingSessionURLRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}