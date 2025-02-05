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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2VpnConnectionOptionsTunnelOptionsDetails Object
    /// </summary>  
    public class AwsEc2VpnConnectionOptionsTunnelOptionsDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2VpnConnectionOptionsTunnelOptionsDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2VpnConnectionOptionsTunnelOptionsDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2VpnConnectionOptionsTunnelOptionsDetails unmarshalledObject = new AwsEc2VpnConnectionOptionsTunnelOptionsDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DpdTimeoutSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DpdTimeoutSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IkeVersions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IkeVersions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutsideIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutsideIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase1DhGroupNumbers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Phase1DhGroupNumbers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase1EncryptionAlgorithms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Phase1EncryptionAlgorithms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase1IntegrityAlgorithms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Phase1IntegrityAlgorithms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase1LifetimeSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Phase1LifetimeSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase2DhGroupNumbers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Phase2DhGroupNumbers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase2EncryptionAlgorithms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Phase2EncryptionAlgorithms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase2IntegrityAlgorithms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Phase2IntegrityAlgorithms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phase2LifetimeSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Phase2LifetimeSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PreSharedKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreSharedKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RekeyFuzzPercentage", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RekeyFuzzPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RekeyMarginTimeSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RekeyMarginTimeSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplayWindowSize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ReplayWindowSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TunnelInsideCidr", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TunnelInsideCidr = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEc2VpnConnectionOptionsTunnelOptionsDetailsUnmarshaller _instance = new AwsEc2VpnConnectionOptionsTunnelOptionsDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2VpnConnectionOptionsTunnelOptionsDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}