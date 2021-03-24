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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QLDBSession.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QLDBSession.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendCommand Request Marshaller
    /// </summary>       
    public class SendCommandRequestMarshaller : IMarshaller<IRequest, SendCommandRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendCommandRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendCommandRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QLDBSession");
            string target = "QLDBSession.SendCommand";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-11";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAbortTransaction())
                {
                    context.Writer.WritePropertyName("AbortTransaction");
                    context.Writer.WriteObjectStart();

                    var marshaller = AbortTransactionRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AbortTransaction, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCommitTransaction())
                {
                    context.Writer.WritePropertyName("CommitTransaction");
                    context.Writer.WriteObjectStart();

                    var marshaller = CommitTransactionRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CommitTransaction, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndSession())
                {
                    context.Writer.WritePropertyName("EndSession");
                    context.Writer.WriteObjectStart();

                    var marshaller = EndSessionRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EndSession, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecuteStatement())
                {
                    context.Writer.WritePropertyName("ExecuteStatement");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExecuteStatementRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExecuteStatement, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFetchPage())
                {
                    context.Writer.WritePropertyName("FetchPage");
                    context.Writer.WriteObjectStart();

                    var marshaller = FetchPageRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FetchPage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSessionToken())
                {
                    context.Writer.WritePropertyName("SessionToken");
                    context.Writer.Write(publicRequest.SessionToken);
                }

                if(publicRequest.IsSetStartSession())
                {
                    context.Writer.WritePropertyName("StartSession");
                    context.Writer.WriteObjectStart();

                    var marshaller = StartSessionRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StartSession, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartTransaction())
                {
                    context.Writer.WritePropertyName("StartTransaction");
                    context.Writer.WriteObjectStart();

                    var marshaller = StartTransactionRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StartTransaction, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendCommandRequestMarshaller _instance = new SendCommandRequestMarshaller();        

        internal static SendCommandRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendCommandRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}