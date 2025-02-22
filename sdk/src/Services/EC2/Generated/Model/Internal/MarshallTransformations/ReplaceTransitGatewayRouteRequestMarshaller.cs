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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplaceTransitGatewayRoute Request Marshaller
    /// </summary>       
    public class ReplaceTransitGatewayRouteRequestMarshaller : IMarshaller<IRequest, ReplaceTransitGatewayRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceTransitGatewayRouteRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReplaceTransitGatewayRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ReplaceTransitGatewayRoute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBlackhole())
                {
                    request.Parameters.Add("Blackhole", StringUtils.FromBool(publicRequest.Blackhole));
                }
                if(publicRequest.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetTransitGatewayAttachmentId())
                {
                    request.Parameters.Add("TransitGatewayAttachmentId", StringUtils.FromString(publicRequest.TransitGatewayAttachmentId));
                }
                if(publicRequest.IsSetTransitGatewayRouteTableId())
                {
                    request.Parameters.Add("TransitGatewayRouteTableId", StringUtils.FromString(publicRequest.TransitGatewayRouteTableId));
                }
            }
            return request;
        }
                    private static ReplaceTransitGatewayRouteRequestMarshaller _instance = new ReplaceTransitGatewayRouteRequestMarshaller();        

        internal static ReplaceTransitGatewayRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplaceTransitGatewayRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}