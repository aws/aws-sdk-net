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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendCommand Request Marshaller
    /// </summary>       
    public class SendCommandRequestMarshaller : IMarshaller<IRequest, SendCommandRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendCommandRequest)input);
        }

        public IRequest Marshall(SendCommandRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.SendCommand";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComment())
                {
                    context.Writer.WritePropertyName("Comment");
                    context.Writer.Write(publicRequest.Comment);
                }

                if(publicRequest.IsSetDocumentName())
                {
                    context.Writer.WritePropertyName("DocumentName");
                    context.Writer.Write(publicRequest.DocumentName);
                }

                if(publicRequest.IsSetInstanceIds())
                {
                    context.Writer.WritePropertyName("InstanceIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceIdsListValue in publicRequest.InstanceIds)
                    {
                            context.Writer.Write(publicRequestInstanceIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutputS3BucketName())
                {
                    context.Writer.WritePropertyName("OutputS3BucketName");
                    context.Writer.Write(publicRequest.OutputS3BucketName);
                }

                if(publicRequest.IsSetOutputS3KeyPrefix())
                {
                    context.Writer.WritePropertyName("OutputS3KeyPrefix");
                    context.Writer.Write(publicRequest.OutputS3KeyPrefix);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                        {
                                context.Writer.Write(publicRequestParametersValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("TimeoutSeconds");
                    context.Writer.Write(publicRequest.TimeoutSeconds);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}