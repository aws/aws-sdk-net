/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddResourcePermissions Request Marshaller
    /// </summary>       
    public class AddResourcePermissionsRequestMarshaller : IMarshaller<IRequest, AddResourcePermissionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddResourcePermissionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddResourcePermissionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/api/v1/resources/{ResourceId}/permissions";
            if (!publicRequest.IsSetResourceId())
                throw new AmazonWorkDocsException("Request object does not have required field ResourceId set");
            uriResourcePath = uriResourcePath.Replace("{ResourceId}", StringUtils.FromString(publicRequest.ResourceId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetNotificationOptions())
                {
                    context.Writer.WritePropertyName("NotificationOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPrincipals())
                {
                    context.Writer.WritePropertyName("Principals");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPrincipalsListValue in publicRequest.Principals)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SharePrincipalMarshaller.Instance;
                        marshaller.Marshall(publicRequestPrincipalsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;

            return request;
        }
        private static AddResourcePermissionsRequestMarshaller _instance = new AddResourcePermissionsRequestMarshaller();        

        internal static AddResourcePermissionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddResourcePermissionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}