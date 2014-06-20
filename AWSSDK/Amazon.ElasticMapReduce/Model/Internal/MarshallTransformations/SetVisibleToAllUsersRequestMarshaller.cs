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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetVisibleToAllUsers Request Marshaller
    /// </summary>       
    public class SetVisibleToAllUsersRequestMarshaller : IMarshaller<IRequest, SetVisibleToAllUsersRequest> 
    {
        public IRequest Marshall(SetVisibleToAllUsersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.SetVisibleToAllUsers";
            request.Headers["X-Amz-Target"] = target;

            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest != null && publicRequest.IsSetJobFlowIds() && publicRequest.JobFlowIds.Count > 0)
                {
                    writer.WritePropertyName("JobFlowIds");
                    writer.WriteArrayStart();
                    foreach(var publicRequestJobFlowIdsListValue in publicRequest.JobFlowIds)
                    {
                        writer.Write(publicRequestJobFlowIdsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetVisibleToAllUsers())
                {
                    writer.WritePropertyName("VisibleToAllUsers");
                    writer.Write(publicRequest.VisibleToAllUsers);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            return request;
        }


    }
}