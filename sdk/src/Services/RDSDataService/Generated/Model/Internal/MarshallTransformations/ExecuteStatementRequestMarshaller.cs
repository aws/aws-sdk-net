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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDSDataService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/Execute";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContinueAfterTimeout())
                {
                    context.Writer.WritePropertyName("continueAfterTimeout");
                    context.Writer.Write(publicRequest.ContinueAfterTimeout);
                }

                if(publicRequest.IsSetDatabase())
                {
                    context.Writer.WritePropertyName("database");
                    context.Writer.Write(publicRequest.Database);
                }

                if(publicRequest.IsSetIncludeResultMetadata())
                {
                    context.Writer.WritePropertyName("includeResultMetadata");
                    context.Writer.Write(publicRequest.IncludeResultMetadata);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("parameters");
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

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("resourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
                }

                if(publicRequest.IsSetSchema())
                {
                    context.Writer.WritePropertyName("schema");
                    context.Writer.Write(publicRequest.Schema);
                }

                if(publicRequest.IsSetSecretArn())
                {
                    context.Writer.WritePropertyName("secretArn");
                    context.Writer.Write(publicRequest.SecretArn);
                }

                if(publicRequest.IsSetSql())
                {
                    context.Writer.WritePropertyName("sql");
                    context.Writer.Write(publicRequest.Sql);
                }

                if(publicRequest.IsSetTransactionId())
                {
                    context.Writer.WritePropertyName("transactionId");
                    context.Writer.Write(publicRequest.TransactionId);
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