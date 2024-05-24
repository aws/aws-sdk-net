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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsCloudFrontDistributionOriginCustomOriginConfig Object
    /// </summary>  
    public class AwsCloudFrontDistributionOriginCustomOriginConfigUnmarshaller : IUnmarshaller<AwsCloudFrontDistributionOriginCustomOriginConfig, XmlUnmarshallerContext>, IUnmarshaller<AwsCloudFrontDistributionOriginCustomOriginConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsCloudFrontDistributionOriginCustomOriginConfig IUnmarshaller<AwsCloudFrontDistributionOriginCustomOriginConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsCloudFrontDistributionOriginCustomOriginConfig Unmarshall(JsonUnmarshallerContext context)
        {
            AwsCloudFrontDistributionOriginCustomOriginConfig unmarshalledObject = new AwsCloudFrontDistributionOriginCustomOriginConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("HttpPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HttpPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpsPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HttpsPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginKeepaliveTimeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.OriginKeepaliveTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginProtocolPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginProtocolPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginReadTimeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.OriginReadTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginSslProtocols", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionOriginSslProtocolsUnmarshaller.Instance;
                    unmarshalledObject.OriginSslProtocols = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsCloudFrontDistributionOriginCustomOriginConfigUnmarshaller _instance = new AwsCloudFrontDistributionOriginCustomOriginConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsCloudFrontDistributionOriginCustomOriginConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}