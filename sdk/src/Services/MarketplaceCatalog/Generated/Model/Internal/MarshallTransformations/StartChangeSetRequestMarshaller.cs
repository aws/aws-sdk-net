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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
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
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartChangeSet Request Marshaller
    /// </summary>       
    public class StartChangeSetRequestMarshaller : IMarshaller<IRequest, StartChangeSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartChangeSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartChangeSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceCatalog");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/StartChangeSet";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetChangeSet())
            {
                context.Writer.WritePropertyName("ChangeSet");
                context.Writer.WriteStartArray();
                foreach(var publicRequestChangeSetListValue in publicRequest.ChangeSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ChangeMarshaller.Instance;
                    marshaller.Marshall(publicRequestChangeSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetChangeSetName())
            {
                context.Writer.WritePropertyName("ChangeSetName");
                context.Writer.WriteStringValue(publicRequest.ChangeSetName);
            }

            if(publicRequest.IsSetChangeSetTags())
            {
                context.Writer.WritePropertyName("ChangeSetTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestChangeSetTagsListValue in publicRequest.ChangeSetTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestChangeSetTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetIntent())
            {
                context.Writer.WritePropertyName("Intent");
                context.Writer.WriteStringValue(publicRequest.Intent);
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
        private static StartChangeSetRequestMarshaller _instance = new StartChangeSetRequestMarshaller();        

        internal static StartChangeSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartChangeSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}