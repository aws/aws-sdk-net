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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MedicalImaging.Model;
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
namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopyImageSet Request Marshaller
    /// </summary>       
    public class CopyImageSetRequestMarshaller : IMarshaller<IRequest, CopyImageSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyImageSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyImageSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MedicalImaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatastoreId())
                throw new AmazonMedicalImagingException("Request object does not have required field DatastoreId set");
            request.AddPathResource("{datastoreId}", StringUtils.FromString(publicRequest.DatastoreId));
            if (!publicRequest.IsSetSourceImageSetId())
                throw new AmazonMedicalImagingException("Request object does not have required field SourceImageSetId set");
            request.AddPathResource("{sourceImageSetId}", StringUtils.FromString(publicRequest.SourceImageSetId));
            
            if (publicRequest.IsSetForce())
                request.Parameters.Add("force", StringUtils.FromBool(publicRequest.Force));
            request.ResourcePath = "/datastore/{datastoreId}/imageSet/{sourceImageSetId}/copyImageSet";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            var context = new JsonMarshallerContext(request, writer);
            context.Writer.WriteStartObject();

            var marshaller = CopyImageSetInformationMarshaller.Instance;
            marshaller.Marshall(publicRequest.CopyImageSetInformation, context);

            context.Writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;
            
            request.HostPrefix = $"runtime-";

            return request;
        }
        private static CopyImageSetRequestMarshaller _instance = new CopyImageSetRequestMarshaller();        

        internal static CopyImageSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyImageSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}