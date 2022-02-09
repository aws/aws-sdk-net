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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateUserSettings Request Marshaller
    /// </summary>       
    public class UpdateUserSettingsRequestMarshaller : IMarshaller<IRequest, UpdateUserSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateUserSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateUserSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesWeb");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-08";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetUserSettingsArn())
                throw new AmazonWorkSpacesWebException("Request object does not have required field UserSettingsArn set");
            request.AddPathResource("{userSettingsArn+}", StringUtils.FromString(publicRequest.UserSettingsArn.TrimStart('/')));
            request.ResourcePath = "/userSettings/{userSettingsArn+}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCopyAllowed())
                {
                    context.Writer.WritePropertyName("copyAllowed");
                    context.Writer.Write(publicRequest.CopyAllowed);
                }

                if(publicRequest.IsSetDownloadAllowed())
                {
                    context.Writer.WritePropertyName("downloadAllowed");
                    context.Writer.Write(publicRequest.DownloadAllowed);
                }

                if(publicRequest.IsSetPasteAllowed())
                {
                    context.Writer.WritePropertyName("pasteAllowed");
                    context.Writer.Write(publicRequest.PasteAllowed);
                }

                if(publicRequest.IsSetPrintAllowed())
                {
                    context.Writer.WritePropertyName("printAllowed");
                    context.Writer.Write(publicRequest.PrintAllowed);
                }

                if(publicRequest.IsSetUploadAllowed())
                {
                    context.Writer.WritePropertyName("uploadAllowed");
                    context.Writer.Write(publicRequest.UploadAllowed);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateUserSettingsRequestMarshaller _instance = new UpdateUserSettingsRequestMarshaller();        

        internal static UpdateUserSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateUserSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}