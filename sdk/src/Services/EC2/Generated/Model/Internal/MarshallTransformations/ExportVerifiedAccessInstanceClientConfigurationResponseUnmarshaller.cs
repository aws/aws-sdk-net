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
    /// Response Unmarshaller for ExportVerifiedAccessInstanceClientConfiguration operation
    /// </summary>  
    public class ExportVerifiedAccessInstanceClientConfigurationResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ExportVerifiedAccessInstanceClientConfigurationResponse response = new ExportVerifiedAccessInstanceClientConfigurationResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("deviceTrustProviderSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.DeviceTrustProviders == null)
                        {
                            response.DeviceTrustProviders = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.DeviceTrustProviders.Add(item);
                        continue;
                    }
                    if (context.TestExpression("openVpnConfigurationSet/item", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessInstanceOpenVpnClientConfigurationUnmarshaller.Instance;
                        if (response.OpenVpnConfigurations == null)
                        {
                            response.OpenVpnConfigurations = new List<VerifiedAccessInstanceOpenVpnClientConfiguration>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.OpenVpnConfigurations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("region", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Region = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("userTrustProvider", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessInstanceUserTrustProviderClientConfigurationUnmarshaller.Instance;
                        response.UserTrustProvider = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("verifiedAccessInstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.VerifiedAccessInstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("version", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Version = unmarshaller.Unmarshall(context);
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
        private static ExportVerifiedAccessInstanceClientConfigurationResponseUnmarshaller _instance = new ExportVerifiedAccessInstanceClientConfigurationResponseUnmarshaller();        

        internal static ExportVerifiedAccessInstanceClientConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportVerifiedAccessInstanceClientConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}