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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamInfluxDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDbCluster Request Marshaller
    /// </summary>       
    public class UpdateDbClusterRequestMarshaller : IMarshaller<IRequest, UpdateDbClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDbClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDbClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamInfluxDB");
            string target = "AmazonTimestreamInfluxDB.UpdateDbCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDbClusterId())
                {
                    context.Writer.WritePropertyName("dbClusterId");
                    context.Writer.Write(publicRequest.DbClusterId);
                }

                if(publicRequest.IsSetDbInstanceType())
                {
                    context.Writer.WritePropertyName("dbInstanceType");
                    context.Writer.Write(publicRequest.DbInstanceType);
                }

                if(publicRequest.IsSetDbParameterGroupIdentifier())
                {
                    context.Writer.WritePropertyName("dbParameterGroupIdentifier");
                    context.Writer.Write(publicRequest.DbParameterGroupIdentifier);
                }

                if(publicRequest.IsSetFailoverMode())
                {
                    context.Writer.WritePropertyName("failoverMode");
                    context.Writer.Write(publicRequest.FailoverMode);
                }

                if(publicRequest.IsSetLogDeliveryConfiguration())
                {
                    context.Writer.WritePropertyName("logDeliveryConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogDeliveryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogDeliveryConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPort())
                {
                    context.Writer.WritePropertyName("port");
                    context.Writer.Write(publicRequest.Port);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDbClusterRequestMarshaller _instance = new UpdateDbClusterRequestMarshaller();        

        internal static UpdateDbClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDbClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}