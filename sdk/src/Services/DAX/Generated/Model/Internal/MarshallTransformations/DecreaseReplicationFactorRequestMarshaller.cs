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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DAX.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DAX.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DecreaseReplicationFactor Request Marshaller
    /// </summary>       
    public class DecreaseReplicationFactorRequestMarshaller : IMarshaller<IRequest, DecreaseReplicationFactorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DecreaseReplicationFactorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DecreaseReplicationFactorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DAX");
            string target = "AmazonDAXV3.DecreaseReplicationFactor";
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
                if(publicRequest.IsSetAvailabilityZones())
                {
                    context.Writer.WritePropertyName("AvailabilityZones");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAvailabilityZonesListValue in publicRequest.AvailabilityZones)
                    {
                            context.Writer.Write(publicRequestAvailabilityZonesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("ClusterName");
                    context.Writer.Write(publicRequest.ClusterName);
                }

                if(publicRequest.IsSetNewReplicationFactor())
                {
                    context.Writer.WritePropertyName("NewReplicationFactor");
                    context.Writer.Write(publicRequest.NewReplicationFactor);
                }

                if(publicRequest.IsSetNodeIdsToRemove())
                {
                    context.Writer.WritePropertyName("NodeIdsToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNodeIdsToRemoveListValue in publicRequest.NodeIdsToRemove)
                    {
                            context.Writer.Write(publicRequestNodeIdsToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DecreaseReplicationFactorRequestMarshaller _instance = new DecreaseReplicationFactorRequestMarshaller();        

        internal static DecreaseReplicationFactorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DecreaseReplicationFactorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}