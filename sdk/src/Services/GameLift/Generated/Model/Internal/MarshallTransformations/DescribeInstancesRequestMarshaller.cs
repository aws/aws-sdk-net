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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeInstances Request Marshaller
    /// </summary>       
    public class DescribeInstancesRequestMarshaller : IMarshaller<IRequest, DescribeInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeInstancesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/DescribeInstances";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetFleetId())
                {
                    context.Writer.WriteTextString("FleetId");
                    context.Writer.WriteTextString(publicRequest.FleetId);
                }
                if (publicRequest.IsSetInstanceId())
                {
                    context.Writer.WriteTextString("InstanceId");
                    context.Writer.WriteTextString(publicRequest.InstanceId);
                }
                if (publicRequest.IsSetLimit())
                {
                    context.Writer.WriteTextString("Limit");
                    context.Writer.WriteInt32(publicRequest.Limit.Value);
                }
                if (publicRequest.IsSetLocation())
                {
                    context.Writer.WriteTextString("Location");
                    context.Writer.WriteTextString(publicRequest.Location);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static DescribeInstancesRequestMarshaller _instance = new DescribeInstancesRequestMarshaller();        

        internal static DescribeInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}