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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTable Request Marshaller
    /// </summary>       
    public class UpdateTableRequestMarshaller : IMarshaller<IRequest, UpdateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Keyspaces");
            string target = "KeyspacesService.UpdateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddColumns())
                {
                    context.Writer.WritePropertyName("addColumns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddColumnsListValue in publicRequest.AddColumns)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ColumnDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddColumnsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCapacitySpecification())
                {
                    context.Writer.WritePropertyName("capacitySpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = CapacitySpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapacitySpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientSideTimestamps())
                {
                    context.Writer.WritePropertyName("clientSideTimestamps");
                    context.Writer.WriteObjectStart();

                    var marshaller = ClientSideTimestampsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ClientSideTimestamps, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultTimeToLive())
                {
                    context.Writer.WritePropertyName("defaultTimeToLive");
                    context.Writer.Write(publicRequest.DefaultTimeToLive);
                }

                if(publicRequest.IsSetEncryptionSpecification())
                {
                    context.Writer.WritePropertyName("encryptionSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKeyspaceName())
                {
                    context.Writer.WritePropertyName("keyspaceName");
                    context.Writer.Write(publicRequest.KeyspaceName);
                }

                if(publicRequest.IsSetPointInTimeRecovery())
                {
                    context.Writer.WritePropertyName("pointInTimeRecovery");
                    context.Writer.WriteObjectStart();

                    var marshaller = PointInTimeRecoveryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PointInTimeRecovery, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTableName())
                {
                    context.Writer.WritePropertyName("tableName");
                    context.Writer.Write(publicRequest.TableName);
                }

                if(publicRequest.IsSetTtl())
                {
                    context.Writer.WritePropertyName("ttl");
                    context.Writer.WriteObjectStart();

                    var marshaller = TimeToLiveMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ttl, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateTableRequestMarshaller _instance = new UpdateTableRequestMarshaller();        

        internal static UpdateTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}