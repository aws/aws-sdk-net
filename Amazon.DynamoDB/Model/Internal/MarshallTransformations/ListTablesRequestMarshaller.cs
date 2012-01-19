/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Tables Request Marshaller
    /// </summary>       
    internal class ListTablesRequestMarshaller : IMarshaller<IRequest<ListTablesRequest>, ListTablesRequest> 
    {
        public IRequest<ListTablesRequest> Marshall(ListTablesRequest listTablesRequest) 
        {

            IRequest<ListTablesRequest> request = new DefaultRequest<ListTablesRequest>(listTablesRequest, "AmazonDynamoDB");
            string target = "DynamoDB_20111205.ListTables";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (listTablesRequest != null && listTablesRequest.IsSetExclusiveStartTableName()) 
                {
                    writer.WritePropertyName("ExclusiveStartTableName");
                    writer.Write(listTablesRequest.ExclusiveStartTableName);
                }
                if (listTablesRequest != null && listTablesRequest.IsSetLimit()) 
                {
                    writer.WritePropertyName("Limit");
                    writer.Write(listTablesRequest.Limit);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
