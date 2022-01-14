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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeCodeCoverages Request Marshaller
    /// </summary>       
    public class DescribeCodeCoveragesRequestMarshaller : IMarshaller<IRequest, DescribeCodeCoveragesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeCodeCoveragesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeCodeCoveragesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.DescribeCodeCoverages";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxLineCoveragePercentage())
                {
                    context.Writer.WritePropertyName("maxLineCoveragePercentage");
                    context.Writer.Write(publicRequest.MaxLineCoveragePercentage);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetMinLineCoveragePercentage())
                {
                    context.Writer.WritePropertyName("minLineCoveragePercentage");
                    context.Writer.Write(publicRequest.MinLineCoveragePercentage);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetReportArn())
                {
                    context.Writer.WritePropertyName("reportArn");
                    context.Writer.Write(publicRequest.ReportArn);
                }

                if(publicRequest.IsSetSortBy())
                {
                    context.Writer.WritePropertyName("sortBy");
                    context.Writer.Write(publicRequest.SortBy);
                }

                if(publicRequest.IsSetSortOrder())
                {
                    context.Writer.WritePropertyName("sortOrder");
                    context.Writer.Write(publicRequest.SortOrder);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeCodeCoveragesRequestMarshaller _instance = new DescribeCodeCoveragesRequestMarshaller();        

        internal static DescribeCodeCoveragesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeCodeCoveragesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}