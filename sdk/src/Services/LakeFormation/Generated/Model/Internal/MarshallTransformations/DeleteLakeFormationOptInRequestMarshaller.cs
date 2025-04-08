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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
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
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteLakeFormationOptIn Request Marshaller
    /// </summary>       
    public class DeleteLakeFormationOptInRequestMarshaller : IMarshaller<IRequest, DeleteLakeFormationOptInRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLakeFormationOptInRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLakeFormationOptInRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/DeleteLakeFormationOptIn";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCondition())
            {
                context.Writer.WritePropertyName("Condition");
                context.Writer.WriteStartObject();

                var marshaller = ConditionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Condition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("Principal");
                context.Writer.WriteStartObject();

                var marshaller = DataLakePrincipalMarshaller.Instance;
                marshaller.Marshall(publicRequest.Principal, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResource())
            {
<<<<<<< HEAD
                context.Writer.WritePropertyName("Resource");
                context.Writer.WriteStartObject();

                var marshaller = ResourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Resource, context);

                context.Writer.WriteEndObject();
||||||| Commit version number update changes
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetPrincipal())
                {
                    context.Writer.WritePropertyName("Principal");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Principal, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResource())
                {
                    context.Writer.WritePropertyName("Resource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Resource, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
=======
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCondition())
                {
                    context.Writer.WritePropertyName("Condition");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Condition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPrincipal())
                {
                    context.Writer.WritePropertyName("Principal");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Principal, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResource())
                {
                    context.Writer.WritePropertyName("Resource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Resource, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
>>>>>>> b6da6ace600c307cc9bd6dbf99b06a9d2b81da7e
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
        private static DeleteLakeFormationOptInRequestMarshaller _instance = new DeleteLakeFormationOptInRequestMarshaller();        

        internal static DeleteLakeFormationOptInRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLakeFormationOptInRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}