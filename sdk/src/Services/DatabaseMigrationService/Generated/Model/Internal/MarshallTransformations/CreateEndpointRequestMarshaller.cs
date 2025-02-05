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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEndpoint Request Marshaller
    /// </summary>       
    public class CreateEndpointRequestMarshaller : IMarshaller<IRequest, CreateEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("CertificateArn");
                context.Writer.WriteStringValue(publicRequest.CertificateArn);
            }

            if(publicRequest.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(publicRequest.DatabaseName);
            }

            if(publicRequest.IsSetDmsTransferSettings())
            {
                context.Writer.WritePropertyName("DmsTransferSettings");
                context.Writer.WriteStartObject();

                var marshaller = DmsTransferSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DmsTransferSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDocDbSettings())
            {
                context.Writer.WritePropertyName("DocDbSettings");
                context.Writer.WriteStartObject();

                var marshaller = DocDbSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DocDbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDynamoDbSettings())
            {
                context.Writer.WritePropertyName("DynamoDbSettings");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDbSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DynamoDbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetElasticsearchSettings())
            {
                context.Writer.WritePropertyName("ElasticsearchSettings");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ElasticsearchSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEndpointIdentifier())
            {
                context.Writer.WritePropertyName("EndpointIdentifier");
                context.Writer.WriteStringValue(publicRequest.EndpointIdentifier);
            }

            if(publicRequest.IsSetEndpointType())
            {
                context.Writer.WritePropertyName("EndpointType");
                context.Writer.WriteStringValue(publicRequest.EndpointType);
            }

            if(publicRequest.IsSetEngineName())
            {
                context.Writer.WritePropertyName("EngineName");
                context.Writer.WriteStringValue(publicRequest.EngineName);
            }

            if(publicRequest.IsSetExternalTableDefinition())
            {
                context.Writer.WritePropertyName("ExternalTableDefinition");
                context.Writer.WriteStringValue(publicRequest.ExternalTableDefinition);
            }

            if(publicRequest.IsSetExtraConnectionAttributes())
            {
                context.Writer.WritePropertyName("ExtraConnectionAttributes");
                context.Writer.WriteStringValue(publicRequest.ExtraConnectionAttributes);
            }

            if(publicRequest.IsSetGcpMySQLSettings())
            {
                context.Writer.WritePropertyName("GcpMySQLSettings");
                context.Writer.WriteStartObject();

                var marshaller = GcpMySQLSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.GcpMySQLSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIBMDb2Settings())
            {
                context.Writer.WritePropertyName("IBMDb2Settings");
                context.Writer.WriteStartObject();

                var marshaller = IBMDb2SettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.IBMDb2Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKafkaSettings())
            {
                context.Writer.WritePropertyName("KafkaSettings");
                context.Writer.WriteStartObject();

                var marshaller = KafkaSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.KafkaSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKinesisSettings())
            {
                context.Writer.WritePropertyName("KinesisSettings");
                context.Writer.WriteStartObject();

                var marshaller = KinesisSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.KinesisSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetMicrosoftSQLServerSettings())
            {
                context.Writer.WritePropertyName("MicrosoftSQLServerSettings");
                context.Writer.WriteStartObject();

                var marshaller = MicrosoftSQLServerSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.MicrosoftSQLServerSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMongoDbSettings())
            {
                context.Writer.WritePropertyName("MongoDbSettings");
                context.Writer.WriteStartObject();

                var marshaller = MongoDbSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.MongoDbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMySQLSettings())
            {
                context.Writer.WritePropertyName("MySQLSettings");
                context.Writer.WriteStartObject();

                var marshaller = MySQLSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.MySQLSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNeptuneSettings())
            {
                context.Writer.WritePropertyName("NeptuneSettings");
                context.Writer.WriteStartObject();

                var marshaller = NeptuneSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.NeptuneSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOracleSettings())
            {
                context.Writer.WritePropertyName("OracleSettings");
                context.Writer.WriteStartObject();

                var marshaller = OracleSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.OracleSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(publicRequest.Password);
            }

            if(publicRequest.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(publicRequest.Port.Value);
            }

            if(publicRequest.IsSetPostgreSQLSettings())
            {
                context.Writer.WritePropertyName("PostgreSQLSettings");
                context.Writer.WriteStartObject();

                var marshaller = PostgreSQLSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PostgreSQLSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRedisSettings())
            {
                context.Writer.WritePropertyName("RedisSettings");
                context.Writer.WriteStartObject();

                var marshaller = RedisSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.RedisSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRedshiftSettings())
            {
                context.Writer.WritePropertyName("RedshiftSettings");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.RedshiftSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceIdentifier())
            {
                context.Writer.WritePropertyName("ResourceIdentifier");
                context.Writer.WriteStringValue(publicRequest.ResourceIdentifier);
            }

            if(publicRequest.IsSetS3Settings())
            {
                context.Writer.WritePropertyName("S3Settings");
                context.Writer.WriteStartObject();

                var marshaller = S3SettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.WriteStringValue(publicRequest.ServerName);
            }

            if(publicRequest.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceAccessRoleArn);
            }

            if(publicRequest.IsSetSslMode())
            {
                context.Writer.WritePropertyName("SslMode");
                context.Writer.WriteStringValue(publicRequest.SslMode);
            }

            if(publicRequest.IsSetSybaseSettings())
            {
                context.Writer.WritePropertyName("SybaseSettings");
                context.Writer.WriteStartObject();

                var marshaller = SybaseSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SybaseSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimestreamSettings())
            {
                context.Writer.WritePropertyName("TimestreamSettings");
                context.Writer.WriteStartObject();

                var marshaller = TimestreamSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimestreamSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(publicRequest.Username);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateEndpointRequestMarshaller _instance = new CreateEndpointRequestMarshaller();        

        internal static CreateEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}