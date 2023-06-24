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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftDataAPIService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RedshiftDataAPIService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExecuteStatement Request Marshaller
    /// </summary>       
    public class ExecuteStatementRequestMarshaller : IMarshaller<IRequest, ExecuteStatementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExecuteStatementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExecuteStatementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RedshiftDataAPIService");
            string target = "RedshiftData.ExecuteStatement";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetClusterIdentifier())
                {
                    context.Writer.WritePropertyName("ClusterIdentifier");
                    context.Writer.Write(publicRequest.ClusterIdentifier);
                }

                if(publicRequest.IsSetDatabase())
                {
                    context.Writer.WritePropertyName("Database");
                    context.Writer.Write(publicRequest.Database);
                }

                if(publicRequest.IsSetDbUser())
                {
                    context.Writer.WritePropertyName("DbUser");
                    context.Writer.Write(publicRequest.DbUser);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestParametersListValue in publicRequest.Parameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SqlParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSecretArn())
                {
                    context.Writer.WritePropertyName("SecretArn");
                    context.Writer.Write(publicRequest.SecretArn);
                }

                if(publicRequest.IsSetSql())
                {
                    context.Writer.WritePropertyName("Sql");
                    context.Writer.Write(publicRequest.Sql);
                }

                if(publicRequest.IsSetStatementName())
                {
                    context.Writer.WritePropertyName("StatementName");
                    context.Writer.Write(publicRequest.StatementName);
                }

                if(publicRequest.IsSetWithEvent())
                {
                    context.Writer.WritePropertyName("WithEvent");
                    context.Writer.Write(publicRequest.WithEvent);
                }

                if(publicRequest.IsSetWorkgroupName())
                {
                    context.Writer.WritePropertyName("WorkgroupName");
                    context.Writer.Write(publicRequest.WorkgroupName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ExecuteStatementRequestMarshaller _instance = new ExecuteStatementRequestMarshaller();        

        internal static ExecuteStatementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExecuteStatementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}