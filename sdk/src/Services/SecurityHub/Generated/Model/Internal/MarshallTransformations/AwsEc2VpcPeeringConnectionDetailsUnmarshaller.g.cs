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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SecurityHub.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2VpcPeeringConnectionDetails Object
    /// </summary>
    public partial class AwsEc2VpcPeeringConnectionDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2VpcPeeringConnectionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2VpcPeeringConnectionDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AwsEc2VpcPeeringConnectionDetails();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccepterVpcInfo", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpcPeeringConnectionVpcInfoDetailsUnmarshaller.Instance;
                    unmarshalledObject.AccepterVpcInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExpirationTime", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpirationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RequesterVpcInfo", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpcPeeringConnectionVpcInfoDetailsUnmarshaller.Instance;
                    unmarshalledObject.RequesterVpcInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Status", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpcPeeringConnectionStatusDetailsUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VpcPeeringConnectionId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcPeeringConnectionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AwsEc2VpcPeeringConnectionDetailsUnmarshaller _instance = new AwsEc2VpcPeeringConnectionDetailsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AwsEc2VpcPeeringConnectionDetailsUnmarshaller Instance => _instance;
    }
}
