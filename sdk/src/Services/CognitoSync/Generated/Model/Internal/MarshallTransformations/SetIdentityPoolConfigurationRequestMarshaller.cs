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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoSync.Model;
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
namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetIdentityPoolConfiguration Request Marshaller
    /// </summary>       
    public class SetIdentityPoolConfigurationRequestMarshaller : IMarshaller<IRequest, SetIdentityPoolConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetIdentityPoolConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetIdentityPoolConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetIdentityPoolId())
                throw new AmazonCognitoSyncException("Request object does not have required field IdentityPoolId set");
            request.AddPathResource("{IdentityPoolId}", StringUtils.FromString(publicRequest.IdentityPoolId));
            request.ResourcePath = "/identitypools/{IdentityPoolId}/configuration";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCognitoStreams())
            {
                context.Writer.WritePropertyName("CognitoStreams");
                context.Writer.WriteStartObject();

                var marshaller = CognitoStreamsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CognitoStreams, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPushSync())
            {
                context.Writer.WritePropertyName("PushSync");
                context.Writer.WriteStartObject();

                var marshaller = PushSyncMarshaller.Instance;
                marshaller.Marshall(publicRequest.PushSync, context);

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
        private static SetIdentityPoolConfigurationRequestMarshaller _instance = new SetIdentityPoolConfigurationRequestMarshaller();        

        internal static SetIdentityPoolConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetIdentityPoolConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}