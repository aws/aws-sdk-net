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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteReplicator Request Marshaller
    /// </summary>       
    public class DeleteReplicatorRequestMarshaller : IMarshaller<IRequest, DeleteReplicatorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteReplicatorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteReplicatorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kafka");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetReplicatorArn())
                throw new AmazonKafkaException("Request object does not have required field ReplicatorArn set");
            request.AddPathResource("{replicatorArn}", StringUtils.FromString(publicRequest.ReplicatorArn));
            
            if (publicRequest.IsSetCurrentVersion())
                request.Parameters.Add("currentVersion", StringUtils.FromString(publicRequest.CurrentVersion));
            request.ResourcePath = "/replication/v1/replicators/{replicatorArn}";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteReplicatorRequestMarshaller _instance = new DeleteReplicatorRequestMarshaller();        

        internal static DeleteReplicatorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteReplicatorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}