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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricData Request Marshaller
    /// </summary>       
    public class PutMetricDataRequestMarshaller : IMarshaller<IRequest, PutMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.gzip);
            string target = "GraniteServiceVersion20100801.PutMetricData";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEntityMetricData())
                {
                    context.Writer.WritePropertyName("EntityMetricData");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEntityMetricDataListValue in publicRequest.EntityMetricData)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EntityMetricDataMarshaller.Instance;
                        marshaller.Marshall(publicRequestEntityMetricDataListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricData())
                {
                    context.Writer.WritePropertyName("MetricData");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricDataListValue in publicRequest.MetricData)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricDatumMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricDataListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNamespace())
                {
                    context.Writer.WritePropertyName("Namespace");
                    context.Writer.Write(publicRequest.Namespace);
                }

                if(publicRequest.IsSetStrictEntityValidation())
                {
                    context.Writer.WritePropertyName("StrictEntityValidation");
                    context.Writer.Write(publicRequest.StrictEntityValidation);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutMetricDataRequestMarshaller _instance = new PutMetricDataRequestMarshaller();        

        internal static PutMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}