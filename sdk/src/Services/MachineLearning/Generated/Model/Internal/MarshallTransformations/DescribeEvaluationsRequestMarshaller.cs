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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEvaluations Request Marshaller
    /// </summary>       
    public class DescribeEvaluationsRequestMarshaller : IMarshaller<IRequest, DescribeEvaluationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEvaluationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeEvaluationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MachineLearning");
            string target = "AmazonML_20141212.DescribeEvaluations";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-12-12";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEQ())
                {
                    context.Writer.WritePropertyName("EQ");
                    context.Writer.Write(publicRequest.EQ);
                }

                if(publicRequest.IsSetFilterVariable())
                {
                    context.Writer.WritePropertyName("FilterVariable");
                    context.Writer.Write(publicRequest.FilterVariable);
                }

                if(publicRequest.IsSetGE())
                {
                    context.Writer.WritePropertyName("GE");
                    context.Writer.Write(publicRequest.GE);
                }

                if(publicRequest.IsSetGT())
                {
                    context.Writer.WritePropertyName("GT");
                    context.Writer.Write(publicRequest.GT);
                }

                if(publicRequest.IsSetLE())
                {
                    context.Writer.WritePropertyName("LE");
                    context.Writer.Write(publicRequest.LE);
                }

                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("Limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetLT())
                {
                    context.Writer.WritePropertyName("LT");
                    context.Writer.Write(publicRequest.LT);
                }

                if(publicRequest.IsSetNE())
                {
                    context.Writer.WritePropertyName("NE");
                    context.Writer.Write(publicRequest.NE);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPrefix())
                {
                    context.Writer.WritePropertyName("Prefix");
                    context.Writer.Write(publicRequest.Prefix);
                }

                if(publicRequest.IsSetSortOrder())
                {
                    context.Writer.WritePropertyName("SortOrder");
                    context.Writer.Write(publicRequest.SortOrder);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeEvaluationsRequestMarshaller _instance = new DescribeEvaluationsRequestMarshaller();        

        internal static DescribeEvaluationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeEvaluationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}