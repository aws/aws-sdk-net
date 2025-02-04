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
    /// Response Unmarshaller for AllocateAddress operation
    /// </summary>  
    public class AllocateAddressResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            AllocateAddressResponse response = new AllocateAddressResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("allocationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.AllocationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("carrierIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CarrierIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("customerOwnedIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CustomerOwnedIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("customerOwnedIpv4Pool", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CustomerOwnedIpv4Pool = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("domain", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Domain = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkBorderGroup", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NetworkBorderGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("publicIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.PublicIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("publicIpv4Pool", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.PublicIpv4Pool = unmarshaller.Unmarshall(context);
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
        private static AllocateAddressResponseUnmarshaller _instance = new AllocateAddressResponseUnmarshaller();        

        internal static AllocateAddressResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AllocateAddressResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}