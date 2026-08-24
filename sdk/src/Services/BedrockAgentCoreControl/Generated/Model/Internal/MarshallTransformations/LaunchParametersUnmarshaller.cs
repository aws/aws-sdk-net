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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchParameters Object
    /// </summary>  
    public class LaunchParametersUnmarshaller : IJsonUnmarshaller<LaunchParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public LaunchParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            LaunchParameters unmarshalledObject = new LaunchParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("capacityReservationSpecification", targetDepth, ref reader))
                {
                    var unmarshaller = CapacityReservationSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservationSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ephemeralVolumes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<EphemeralBlockDeviceMapping, EphemeralBlockDeviceMappingUnmarshaller>(EphemeralBlockDeviceMappingUnmarshaller.Instance);
                    unmarshalledObject.EphemeralVolumes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceProfileArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceProfileArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceRequirements", targetDepth, ref reader))
                {
                    var unmarshaller = InstanceRequirementsUnmarshaller.Instance;
                    unmarshalledObject.InstanceRequirements = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenseSpecifications", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<LicenseSpecification, LicenseSpecificationUnmarshaller>(LicenseSpecificationUnmarshaller.Instance);
                    unmarshalledObject.LicenseSpecifications = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("monitoring", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Monitoring = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("operatingSystem", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperatingSystem = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("propagatedTags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.PropagatedTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sshKeyName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SshKeyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LaunchParametersUnmarshaller _instance = new LaunchParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}