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
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSMarketplaceCommerceAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSMarketplaceCommerceAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GenerateDataSet Request Marshaller
    /// </summary>       
    public class GenerateDataSetRequestMarshaller : IMarshaller<IRequest, GenerateDataSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GenerateDataSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GenerateDataSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSMarketplaceCommerceAnalytics");
            string target = "MarketplaceCommerceAnalytics20150701.GenerateDataSet";
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
                if(publicRequest.IsSetCustomerDefinedValues())
                {
                    context.Writer.WritePropertyName("customerDefinedValues");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestCustomerDefinedValuesKvp in publicRequest.CustomerDefinedValues)
                    {
                        context.Writer.WritePropertyName(publicRequestCustomerDefinedValuesKvp.Key);
                        var publicRequestCustomerDefinedValuesValue = publicRequestCustomerDefinedValuesKvp.Value;

                            context.Writer.Write(publicRequestCustomerDefinedValuesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataSetPublicationDate())
                {
                    context.Writer.WritePropertyName("dataSetPublicationDate");
                    context.Writer.Write(publicRequest.DataSetPublicationDate);
                }

                if(publicRequest.IsSetDataSetType())
                {
                    context.Writer.WritePropertyName("dataSetType");
                    context.Writer.Write(publicRequest.DataSetType);
                }

                if(publicRequest.IsSetDestinationS3BucketName())
                {
                    context.Writer.WritePropertyName("destinationS3BucketName");
                    context.Writer.Write(publicRequest.DestinationS3BucketName);
                }

                if(publicRequest.IsSetDestinationS3Prefix())
                {
                    context.Writer.WritePropertyName("destinationS3Prefix");
                    context.Writer.Write(publicRequest.DestinationS3Prefix);
                }

                if(publicRequest.IsSetRoleNameArn())
                {
                    context.Writer.WritePropertyName("roleNameArn");
                    context.Writer.Write(publicRequest.RoleNameArn);
                }

                if(publicRequest.IsSetSnsTopicArn())
                {
                    context.Writer.WritePropertyName("snsTopicArn");
                    context.Writer.Write(publicRequest.SnsTopicArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GenerateDataSetRequestMarshaller _instance = new GenerateDataSetRequestMarshaller();        

        internal static GenerateDataSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GenerateDataSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}