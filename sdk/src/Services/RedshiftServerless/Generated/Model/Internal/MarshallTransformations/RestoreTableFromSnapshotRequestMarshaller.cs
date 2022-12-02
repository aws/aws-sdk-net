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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RedshiftServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTableFromSnapshot Request Marshaller
    /// </summary>       
    public class RestoreTableFromSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreTableFromSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreTableFromSnapshotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreTableFromSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RedshiftServerless");
            string target = "RedshiftServerless.RestoreTableFromSnapshot";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-21";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActivateCaseSensitiveIdentifier())
                {
                    context.Writer.WritePropertyName("activateCaseSensitiveIdentifier");
                    context.Writer.Write(publicRequest.ActivateCaseSensitiveIdentifier);
                }

                if(publicRequest.IsSetNamespaceName())
                {
                    context.Writer.WritePropertyName("namespaceName");
                    context.Writer.Write(publicRequest.NamespaceName);
                }

                if(publicRequest.IsSetNewTableName())
                {
                    context.Writer.WritePropertyName("newTableName");
                    context.Writer.Write(publicRequest.NewTableName);
                }

                if(publicRequest.IsSetSnapshotName())
                {
                    context.Writer.WritePropertyName("snapshotName");
                    context.Writer.Write(publicRequest.SnapshotName);
                }

                if(publicRequest.IsSetSourceDatabaseName())
                {
                    context.Writer.WritePropertyName("sourceDatabaseName");
                    context.Writer.Write(publicRequest.SourceDatabaseName);
                }

                if(publicRequest.IsSetSourceSchemaName())
                {
                    context.Writer.WritePropertyName("sourceSchemaName");
                    context.Writer.Write(publicRequest.SourceSchemaName);
                }

                if(publicRequest.IsSetSourceTableName())
                {
                    context.Writer.WritePropertyName("sourceTableName");
                    context.Writer.Write(publicRequest.SourceTableName);
                }

                if(publicRequest.IsSetTargetDatabaseName())
                {
                    context.Writer.WritePropertyName("targetDatabaseName");
                    context.Writer.Write(publicRequest.TargetDatabaseName);
                }

                if(publicRequest.IsSetTargetSchemaName())
                {
                    context.Writer.WritePropertyName("targetSchemaName");
                    context.Writer.Write(publicRequest.TargetSchemaName);
                }

                if(publicRequest.IsSetWorkgroupName())
                {
                    context.Writer.WritePropertyName("workgroupName");
                    context.Writer.Write(publicRequest.WorkgroupName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RestoreTableFromSnapshotRequestMarshaller _instance = new RestoreTableFromSnapshotRequestMarshaller();        

        internal static RestoreTableFromSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreTableFromSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}