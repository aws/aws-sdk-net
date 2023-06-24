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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCheckDetails Request Marshaller
    /// </summary>       
    public class ListCheckDetailsRequestMarshaller : IMarshaller<IRequest, ListCheckDetailsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCheckDetailsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCheckDetailsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetWorkloadId())
                throw new AmazonWellArchitectedException("Request object does not have required field WorkloadId set");
            request.AddPathResource("{WorkloadId}", StringUtils.FromString(publicRequest.WorkloadId));
            request.ResourcePath = "/workloads/{WorkloadId}/checks";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChoiceId())
                {
                    context.Writer.WritePropertyName("ChoiceId");
                    context.Writer.Write(publicRequest.ChoiceId);
                }

                if(publicRequest.IsSetLensArn())
                {
                    context.Writer.WritePropertyName("LensArn");
                    context.Writer.Write(publicRequest.LensArn);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPillarId())
                {
                    context.Writer.WritePropertyName("PillarId");
                    context.Writer.Write(publicRequest.PillarId);
                }

                if(publicRequest.IsSetQuestionId())
                {
                    context.Writer.WritePropertyName("QuestionId");
                    context.Writer.Write(publicRequest.QuestionId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListCheckDetailsRequestMarshaller _instance = new ListCheckDetailsRequestMarshaller();        

        internal static ListCheckDetailsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCheckDetailsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}