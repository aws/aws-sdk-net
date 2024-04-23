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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartVariantImportJob Request Marshaller
    /// </summary>       
    public class StartVariantImportJobRequestMarshaller : IMarshaller<IRequest, StartVariantImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartVariantImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartVariantImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/import/variant";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnnotationFields())
                {
                    context.Writer.WritePropertyName("annotationFields");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAnnotationFieldsKvp in publicRequest.AnnotationFields)
                    {
                        context.Writer.WritePropertyName(publicRequestAnnotationFieldsKvp.Key);
                        var publicRequestAnnotationFieldsValue = publicRequestAnnotationFieldsKvp.Value;

                            context.Writer.Write(publicRequestAnnotationFieldsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDestinationName())
                {
                    context.Writer.WritePropertyName("destinationName");
                    context.Writer.Write(publicRequest.DestinationName);
                }

                if(publicRequest.IsSetItems())
                {
                    context.Writer.WritePropertyName("items");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestItemsListValue in publicRequest.Items)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = VariantImportItemSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestItemsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetRunLeftNormalization())
                {
                    context.Writer.WritePropertyName("runLeftNormalization");
                    context.Writer.Write(publicRequest.RunLeftNormalization);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"analytics-";

            return request;
        }
        private static StartVariantImportJobRequestMarshaller _instance = new StartVariantImportJobRequestMarshaller();        

        internal static StartVariantImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartVariantImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618