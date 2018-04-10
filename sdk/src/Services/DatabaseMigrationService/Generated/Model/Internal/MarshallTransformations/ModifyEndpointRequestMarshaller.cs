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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyEndpoint Request Marshaller
    /// </summary>       
    public class ModifyEndpointRequestMarshaller : IMarshaller<IRequest, ModifyEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyEndpoint";
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
                if(publicRequest.IsSetCertificateArn())
                {
                    context.Writer.WritePropertyName("CertificateArn");
                    context.Writer.Write(publicRequest.CertificateArn);
                }

                if(publicRequest.IsSetDatabaseName())
                {
                    context.Writer.WritePropertyName("DatabaseName");
                    context.Writer.Write(publicRequest.DatabaseName);
                }

                if(publicRequest.IsSetDynamoDbSettings())
                {
                    context.Writer.WritePropertyName("DynamoDbSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = DynamoDbSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DynamoDbSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndpointArn())
                {
                    context.Writer.WritePropertyName("EndpointArn");
                    context.Writer.Write(publicRequest.EndpointArn);
                }

                if(publicRequest.IsSetEndpointIdentifier())
                {
                    context.Writer.WritePropertyName("EndpointIdentifier");
                    context.Writer.Write(publicRequest.EndpointIdentifier);
                }

                if(publicRequest.IsSetEndpointType())
                {
                    context.Writer.WritePropertyName("EndpointType");
                    context.Writer.Write(publicRequest.EndpointType);
                }

                if(publicRequest.IsSetEngineName())
                {
                    context.Writer.WritePropertyName("EngineName");
                    context.Writer.Write(publicRequest.EngineName);
                }

                if(publicRequest.IsSetExternalTableDefinition())
                {
                    context.Writer.WritePropertyName("ExternalTableDefinition");
                    context.Writer.Write(publicRequest.ExternalTableDefinition);
                }

                if(publicRequest.IsSetExtraConnectionAttributes())
                {
                    context.Writer.WritePropertyName("ExtraConnectionAttributes");
                    context.Writer.Write(publicRequest.ExtraConnectionAttributes);
                }

                if(publicRequest.IsSetMongoDbSettings())
                {
                    context.Writer.WritePropertyName("MongoDbSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = MongoDbSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MongoDbSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPassword())
                {
                    context.Writer.WritePropertyName("Password");
                    context.Writer.Write(publicRequest.Password);
                }

                if(publicRequest.IsSetPort())
                {
                    context.Writer.WritePropertyName("Port");
                    context.Writer.Write(publicRequest.Port);
                }

                if(publicRequest.IsSetS3Settings())
                {
                    context.Writer.WritePropertyName("S3Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServerName())
                {
                    context.Writer.WritePropertyName("ServerName");
                    context.Writer.Write(publicRequest.ServerName);
                }

                if(publicRequest.IsSetServiceAccessRoleArn())
                {
                    context.Writer.WritePropertyName("ServiceAccessRoleArn");
                    context.Writer.Write(publicRequest.ServiceAccessRoleArn);
                }

                if(publicRequest.IsSetSslMode())
                {
                    context.Writer.WritePropertyName("SslMode");
                    context.Writer.Write(publicRequest.SslMode);
                }

                if(publicRequest.IsSetUsername())
                {
                    context.Writer.WritePropertyName("Username");
                    context.Writer.Write(publicRequest.Username);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ModifyEndpointRequestMarshaller _instance = new ModifyEndpointRequestMarshaller();        

        internal static ModifyEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}