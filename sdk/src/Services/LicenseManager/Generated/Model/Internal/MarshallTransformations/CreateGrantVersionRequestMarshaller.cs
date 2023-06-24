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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGrantVersion Request Marshaller
    /// </summary>       
    public class CreateGrantVersionRequestMarshaller : IMarshaller<IRequest, CreateGrantVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGrantVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGrantVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CreateGrantVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowedOperations())
                {
                    context.Writer.WritePropertyName("AllowedOperations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAllowedOperationsListValue in publicRequest.AllowedOperations)
                    {
                            context.Writer.Write(publicRequestAllowedOperationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetGrantArn())
                {
                    context.Writer.WritePropertyName("GrantArn");
                    context.Writer.Write(publicRequest.GrantArn);
                }

                if(publicRequest.IsSetGrantName())
                {
                    context.Writer.WritePropertyName("GrantName");
                    context.Writer.Write(publicRequest.GrantName);
                }

                if(publicRequest.IsSetOptions())
                {
                    context.Writer.WritePropertyName("Options");
                    context.Writer.WriteObjectStart();

                    var marshaller = OptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Options, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceVersion())
                {
                    context.Writer.WritePropertyName("SourceVersion");
                    context.Writer.Write(publicRequest.SourceVersion);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetStatusReason())
                {
                    context.Writer.WritePropertyName("StatusReason");
                    context.Writer.Write(publicRequest.StatusReason);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGrantVersionRequestMarshaller _instance = new CreateGrantVersionRequestMarshaller();        

        internal static CreateGrantVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGrantVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}