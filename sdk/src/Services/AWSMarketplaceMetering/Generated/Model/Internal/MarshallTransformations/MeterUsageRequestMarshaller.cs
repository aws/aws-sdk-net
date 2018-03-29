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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSMarketplaceMetering.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSMarketplaceMetering.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MeterUsage Request Marshaller
    /// </summary>       
    public class MeterUsageRequestMarshaller : IMarshaller<IRequest, MeterUsageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((MeterUsageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(MeterUsageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSMarketplaceMetering");
            string target = "AWSMPMeteringService.MeterUsage";
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
                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetProductCode())
                {
                    context.Writer.WritePropertyName("ProductCode");
                    context.Writer.Write(publicRequest.ProductCode);
                }

                if(publicRequest.IsSetTimestamp())
                {
                    context.Writer.WritePropertyName("Timestamp");
                    context.Writer.Write(publicRequest.Timestamp);
                }

                if(publicRequest.IsSetUsageDimension())
                {
                    context.Writer.WritePropertyName("UsageDimension");
                    context.Writer.Write(publicRequest.UsageDimension);
                }

                if(publicRequest.IsSetUsageQuantity())
                {
                    context.Writer.WritePropertyName("UsageQuantity");
                    context.Writer.Write(publicRequest.UsageQuantity);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static MeterUsageRequestMarshaller _instance = new MeterUsageRequestMarshaller();        

        internal static MeterUsageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MeterUsageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}