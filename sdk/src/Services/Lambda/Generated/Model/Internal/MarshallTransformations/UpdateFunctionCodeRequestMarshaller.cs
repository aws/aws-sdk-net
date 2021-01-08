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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFunctionCode Request Marshaller
    /// </summary>       
    public class UpdateFunctionCodeRequestMarshaller : IMarshaller<IRequest, UpdateFunctionCodeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFunctionCodeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFunctionCodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFunctionName())
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));
            request.ResourcePath = "/2015-03-31/functions/{FunctionName}/code";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetImageUri())
                {
                    context.Writer.WritePropertyName("ImageUri");
                    context.Writer.Write(publicRequest.ImageUri);
                }

                if(publicRequest.IsSetPublish())
                {
                    context.Writer.WritePropertyName("Publish");
                    context.Writer.Write(publicRequest.Publish);
                }

                if(publicRequest.IsSetRevisionId())
                {
                    context.Writer.WritePropertyName("RevisionId");
                    context.Writer.Write(publicRequest.RevisionId);
                }

                if(publicRequest.IsSetS3Bucket())
                {
                    context.Writer.WritePropertyName("S3Bucket");
                    context.Writer.Write(publicRequest.S3Bucket);
                }

                if(publicRequest.IsSetS3Key())
                {
                    context.Writer.WritePropertyName("S3Key");
                    context.Writer.Write(publicRequest.S3Key);
                }

                if(publicRequest.IsSetS3ObjectVersion())
                {
                    context.Writer.WritePropertyName("S3ObjectVersion");
                    context.Writer.Write(publicRequest.S3ObjectVersion);
                }

                if(publicRequest.IsSetZipFile())
                {
                    context.Writer.WritePropertyName("ZipFile");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.ZipFile));
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFunctionCodeRequestMarshaller _instance = new UpdateFunctionCodeRequestMarshaller();        

        internal static UpdateFunctionCodeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFunctionCodeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}