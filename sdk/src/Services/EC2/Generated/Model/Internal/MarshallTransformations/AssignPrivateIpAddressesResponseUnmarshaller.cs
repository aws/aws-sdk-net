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
using System.Net;
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
    /// Response Unmarshaller for AssignPrivateIpAddresses operation
    /// </summary>  
    public class AssignPrivateIpAddressesResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            AssignPrivateIpAddressesResponse response = new AssignPrivateIpAddressesResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("assignedIpv4PrefixSet/item", targetDepth))
                    {
                        var unmarshaller = Ipv4PrefixSpecificationUnmarshaller.Instance;
                        if (response.AssignedIpv4Prefixes == null)
                        {
                            response.AssignedIpv4Prefixes = new List<Ipv4PrefixSpecification>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.AssignedIpv4Prefixes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("assignedPrivateIpAddressesSet/item", targetDepth))
                    {
                        var unmarshaller = AssignedPrivateIpAddressUnmarshaller.Instance;
                        if (response.AssignedPrivateIpAddresses == null)
                        {
                            response.AssignedPrivateIpAddresses = new List<AssignedPrivateIpAddress>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.AssignedPrivateIpAddresses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static AssignPrivateIpAddressesResponseUnmarshaller _instance = new AssignPrivateIpAddressesResponseUnmarshaller();        

        internal static AssignPrivateIpAddressesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssignPrivateIpAddressesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}