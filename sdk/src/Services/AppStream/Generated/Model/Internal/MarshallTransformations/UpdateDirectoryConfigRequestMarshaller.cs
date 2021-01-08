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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDirectoryConfig Request Marshaller
    /// </summary>       
    public class UpdateDirectoryConfigRequestMarshaller : IMarshaller<IRequest, UpdateDirectoryConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDirectoryConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDirectoryConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.UpdateDirectoryConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDirectoryName())
                {
                    context.Writer.WritePropertyName("DirectoryName");
                    context.Writer.Write(publicRequest.DirectoryName);
                }

                if(publicRequest.IsSetOrganizationalUnitDistinguishedNames())
                {
                    context.Writer.WritePropertyName("OrganizationalUnitDistinguishedNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOrganizationalUnitDistinguishedNamesListValue in publicRequest.OrganizationalUnitDistinguishedNames)
                    {
                            context.Writer.Write(publicRequestOrganizationalUnitDistinguishedNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServiceAccountCredentials())
                {
                    context.Writer.WritePropertyName("ServiceAccountCredentials");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceAccountCredentialsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServiceAccountCredentials, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDirectoryConfigRequestMarshaller _instance = new UpdateDirectoryConfigRequestMarshaller();        

        internal static UpdateDirectoryConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDirectoryConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}