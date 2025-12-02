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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListLogGroups Request Marshaller
    /// </summary>       
    public class ListLogGroupsRequestMarshaller : IMarshaller<IRequest, ListLogGroupsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListLogGroupsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListLogGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.ListLogGroups";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountIdentifiers())
                {
                    context.Writer.WritePropertyName("accountIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountIdentifiersListValue in publicRequest.AccountIdentifiers)
                    {
                            context.Writer.Write(publicRequestAccountIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDataSources())
                {
                    context.Writer.WritePropertyName("dataSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDataSourcesListValue in publicRequest.DataSources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DataSourceFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestDataSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFieldIndexNames())
                {
                    context.Writer.WritePropertyName("fieldIndexNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFieldIndexNamesListValue in publicRequest.FieldIndexNames)
                    {
                            context.Writer.Write(publicRequestFieldIndexNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIncludeLinkedAccounts())
                {
                    context.Writer.WritePropertyName("includeLinkedAccounts");
                    context.Writer.Write(publicRequest.IncludeLinkedAccounts);
                }

                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetLogGroupClass())
                {
                    context.Writer.WritePropertyName("logGroupClass");
                    context.Writer.Write(publicRequest.LogGroupClass);
                }

                if(publicRequest.IsSetLogGroupNamePattern())
                {
                    context.Writer.WritePropertyName("logGroupNamePattern");
                    context.Writer.Write(publicRequest.LogGroupNamePattern);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListLogGroupsRequestMarshaller _instance = new ListLogGroupsRequestMarshaller();        

        internal static ListLogGroupsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListLogGroupsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}