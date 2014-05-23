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
    /// CreateApp Request Marshaller
    /// </summary>       
    public class CreateAppRequestMarshaller : IMarshaller<IRequest, CreateAppRequest> 
    {
        public IRequest Marshall(CreateAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.CreateApp";
            request.Headers["X-Amz-Target"] = target;

            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest != null && publicRequest.IsSetAppSource())
                {
                    writer.WritePropertyName("AppSource");
                    writer.WriteObjectStart();
                    if(publicRequest.AppSource != null && publicRequest.AppSource.IsSetPassword())
                    {
                        writer.WritePropertyName("Password");
                        writer.Write(publicRequest.AppSource.Password);
                    }

                    if(publicRequest.AppSource != null && publicRequest.AppSource.IsSetRevision())
                    {
                        writer.WritePropertyName("Revision");
                        writer.Write(publicRequest.AppSource.Revision);
                    }

                    if(publicRequest.AppSource != null && publicRequest.AppSource.IsSetSshKey())
                    {
                        writer.WritePropertyName("SshKey");
                        writer.Write(publicRequest.AppSource.SshKey);
                    }

                    if(publicRequest.AppSource != null && publicRequest.AppSource.IsSetType())
                    {
                        writer.WritePropertyName("Type");
                        writer.Write(publicRequest.AppSource.Type);
                    }

                    if(publicRequest.AppSource != null && publicRequest.AppSource.IsSetUrl())
                    {
                        writer.WritePropertyName("Url");
                        writer.Write(publicRequest.AppSource.Url);
                    }

                    if(publicRequest.AppSource != null && publicRequest.AppSource.IsSetUsername())
                    {
                        writer.WritePropertyName("Username");
                        writer.Write(publicRequest.AppSource.Username);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetAttributes() && publicRequest.Attributes.Count > 0)
                {
                    writer.WritePropertyName("Attributes");
                    writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        writer.Write(publicRequestAttributesValue);
                    }
                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetDataSources() && publicRequest.DataSources.Count > 0)
                {
                    writer.WritePropertyName("DataSources");
                    writer.WriteArrayStart();
                    foreach(var publicRequestDataSourcesListValue in publicRequest.DataSources)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestDataSourcesListValue != null && publicRequestDataSourcesListValue.IsSetArn())
                        {
                            writer.WritePropertyName("Arn");
                            writer.Write(publicRequestDataSourcesListValue.Arn);
                        }

                        if(publicRequestDataSourcesListValue != null && publicRequestDataSourcesListValue.IsSetDatabaseName())
                        {
                            writer.WritePropertyName("DatabaseName");
                            writer.Write(publicRequestDataSourcesListValue.DatabaseName);
                        }

                        if(publicRequestDataSourcesListValue != null && publicRequestDataSourcesListValue.IsSetType())
                        {
                            writer.WritePropertyName("Type");
                            writer.Write(publicRequestDataSourcesListValue.Type);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetDescription())
                {
                    writer.WritePropertyName("Description");
                    writer.Write(publicRequest.Description);
                }

                if(publicRequest != null && publicRequest.IsSetDomains() && publicRequest.Domains.Count > 0)
                {
                    writer.WritePropertyName("Domains");
                    writer.WriteArrayStart();
                    foreach(var publicRequestDomainsListValue in publicRequest.Domains)
                    {
                        writer.Write(publicRequestDomainsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetEnableSsl())
                {
                    writer.WritePropertyName("EnableSsl");
                    writer.Write(publicRequest.EnableSsl);
                }

                if(publicRequest != null && publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest != null && publicRequest.IsSetShortname())
                {
                    writer.WritePropertyName("Shortname");
                    writer.Write(publicRequest.Shortname);
                }

                if(publicRequest != null && publicRequest.IsSetSslConfiguration())
                {
                    writer.WritePropertyName("SslConfiguration");
                    writer.WriteObjectStart();
                    if(publicRequest.SslConfiguration != null && publicRequest.SslConfiguration.IsSetCertificate())
                    {
                        writer.WritePropertyName("Certificate");
                        writer.Write(publicRequest.SslConfiguration.Certificate);
                    }

                    if(publicRequest.SslConfiguration != null && publicRequest.SslConfiguration.IsSetChain())
                    {
                        writer.WritePropertyName("Chain");
                        writer.Write(publicRequest.SslConfiguration.Chain);
                    }

                    if(publicRequest.SslConfiguration != null && publicRequest.SslConfiguration.IsSetPrivateKey())
                    {
                        writer.WritePropertyName("PrivateKey");
                        writer.Write(publicRequest.SslConfiguration.PrivateKey);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetStackId())
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(publicRequest.StackId);
                }

                if(publicRequest != null && publicRequest.IsSetType())
                {
                    writer.WritePropertyName("Type");
                    writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            return request;
        }


    }
}