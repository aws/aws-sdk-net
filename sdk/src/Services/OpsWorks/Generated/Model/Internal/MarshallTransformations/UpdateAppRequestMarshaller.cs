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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApp Request Marshaller
    /// </summary>       
    public class UpdateAppRequestMarshaller : IMarshaller<IRequest, UpdateAppRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAppRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateApp";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppId())
                {
                    context.Writer.WritePropertyName("AppId");
                    context.Writer.Write(publicRequest.AppId);
                }

                if(publicRequest.IsSetAppSource())
                {
                    context.Writer.WritePropertyName("AppSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AppSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("Attributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataSources())
                {
                    context.Writer.WritePropertyName("DataSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDataSourcesListValue in publicRequest.DataSources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DataSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestDataSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDomains())
                {
                    context.Writer.WritePropertyName("Domains");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDomainsListValue in publicRequest.Domains)
                    {
                            context.Writer.Write(publicRequestDomainsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEnableSsl())
                {
                    context.Writer.WritePropertyName("EnableSsl");
                    context.Writer.Write(publicRequest.EnableSsl);
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("Environment");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEnvironmentListValue in publicRequest.Environment)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EnvironmentVariableMarshaller.Instance;
                        marshaller.Marshall(publicRequestEnvironmentListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSslConfiguration())
                {
                    context.Writer.WritePropertyName("SslConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = SslConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SslConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAppRequestMarshaller _instance = new UpdateAppRequestMarshaller();        

        internal static UpdateAppRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAppRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}