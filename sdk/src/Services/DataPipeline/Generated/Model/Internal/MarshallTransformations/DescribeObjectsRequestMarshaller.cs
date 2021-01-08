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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataPipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeObjects Request Marshaller
    /// </summary>       
    public class DescribeObjectsRequestMarshaller : IMarshaller<IRequest, DescribeObjectsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeObjectsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeObjectsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataPipeline");
            string target = "DataPipeline.DescribeObjects";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-10-29";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEvaluateExpressions())
                {
                    context.Writer.WritePropertyName("evaluateExpressions");
                    context.Writer.Write(publicRequest.EvaluateExpressions);
                }

                if(publicRequest.IsSetMarker())
                {
                    context.Writer.WritePropertyName("marker");
                    context.Writer.Write(publicRequest.Marker);
                }

                if(publicRequest.IsSetObjectIds())
                {
                    context.Writer.WritePropertyName("objectIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestObjectIdsListValue in publicRequest.ObjectIds)
                    {
                            context.Writer.Write(publicRequestObjectIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPipelineId())
                {
                    context.Writer.WritePropertyName("pipelineId");
                    context.Writer.Write(publicRequest.PipelineId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeObjectsRequestMarshaller _instance = new DescribeObjectsRequestMarshaller();        

        internal static DescribeObjectsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeObjectsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}