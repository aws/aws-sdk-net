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

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestRole Request Marshaller
    /// </summary>       
    public class TestRoleRequestMarshaller : IMarshaller<IRequest, TestRoleRequest> 
    {
        public IRequest Marshall(TestRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2012-09-25/roleTests";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetInputBucket())
                {
                    writer.WritePropertyName("InputBucket");
                    writer.Write(publicRequest.InputBucket);
                }

                if(publicRequest.IsSetOutputBucket())
                {
                    writer.WritePropertyName("OutputBucket");
                    writer.Write(publicRequest.OutputBucket);
                }

                if(publicRequest.IsSetRole())
                {
                    writer.WritePropertyName("Role");
                    writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetTopics())
                {
                    writer.WritePropertyName("Topics");
                    writer.WriteArrayStart();
                    foreach(var publicRequestTopicsListValue in publicRequest.Topics)
                    {
                        writer.Write(publicRequestTopicsListValue);
                    }
                    writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}