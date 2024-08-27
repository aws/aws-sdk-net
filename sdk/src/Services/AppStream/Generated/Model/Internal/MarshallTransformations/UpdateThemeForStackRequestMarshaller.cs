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

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateThemeForStack Request Marshaller
    /// </summary>       
    public class UpdateThemeForStackRequestMarshaller : IMarshaller<IRequest, UpdateThemeForStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateThemeForStackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateThemeForStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.UpdateThemeForStack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributesToDelete())
                {
                    context.Writer.WritePropertyName("AttributesToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                    {
                            context.Writer.Write(publicRequestAttributesToDeleteListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFaviconS3Location())
                {
                    context.Writer.WritePropertyName("FaviconS3Location");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FaviconS3Location, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFooterLinks())
                {
                    context.Writer.WritePropertyName("FooterLinks");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFooterLinksListValue in publicRequest.FooterLinks)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ThemeFooterLinkMarshaller.Instance;
                        marshaller.Marshall(publicRequestFooterLinksListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOrganizationLogoS3Location())
                {
                    context.Writer.WritePropertyName("OrganizationLogoS3Location");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OrganizationLogoS3Location, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStackName())
                {
                    context.Writer.WritePropertyName("StackName");
                    context.Writer.Write(publicRequest.StackName);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("State");
                    context.Writer.Write(publicRequest.State);
                }

                if(publicRequest.IsSetThemeStyling())
                {
                    context.Writer.WritePropertyName("ThemeStyling");
                    context.Writer.Write(publicRequest.ThemeStyling);
                }

                if(publicRequest.IsSetTitleText())
                {
                    context.Writer.WritePropertyName("TitleText");
                    context.Writer.Write(publicRequest.TitleText);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateThemeForStackRequestMarshaller _instance = new UpdateThemeForStackRequestMarshaller();        

        internal static UpdateThemeForStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateThemeForStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}