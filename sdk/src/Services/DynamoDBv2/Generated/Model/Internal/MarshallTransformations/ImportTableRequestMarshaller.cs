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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportTable Request Marshaller
    /// </summary>       
    public class ImportTableRequestMarshaller : IMarshaller<IRequest, ImportTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.ImportTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetInputCompressionType())
                {
                    context.Writer.WritePropertyName("InputCompressionType");
                    context.Writer.Write(publicRequest.InputCompressionType);
                }

                if(publicRequest.IsSetInputFormat())
                {
                    context.Writer.WritePropertyName("InputFormat");
                    context.Writer.Write(publicRequest.InputFormat);
                }

                if(publicRequest.IsSetInputFormatOptions())
                {
                    context.Writer.WritePropertyName("InputFormatOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputFormatOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputFormatOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetS3BucketSource())
                {
                    context.Writer.WritePropertyName("S3BucketSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3BucketSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3BucketSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTableCreationParameters())
                {
                    context.Writer.WritePropertyName("TableCreationParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = TableCreationParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TableCreationParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ImportTableRequestMarshaller _instance = new ImportTableRequestMarshaller();        

        internal static ImportTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}