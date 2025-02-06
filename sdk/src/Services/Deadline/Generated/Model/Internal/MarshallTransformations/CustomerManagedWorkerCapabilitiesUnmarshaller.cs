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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomerManagedWorkerCapabilities Object
    /// </summary>  
    public class CustomerManagedWorkerCapabilitiesUnmarshaller : IJsonUnmarshaller<CustomerManagedWorkerCapabilities, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CustomerManagedWorkerCapabilities Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CustomerManagedWorkerCapabilities unmarshalledObject = new CustomerManagedWorkerCapabilities();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("acceleratorCount", targetDepth))
                {
                    var unmarshaller = AcceleratorCountRangeUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("acceleratorTotalMemoryMiB", targetDepth))
                {
                    var unmarshaller = AcceleratorTotalMemoryMiBRangeUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorTotalMemoryMiB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("acceleratorTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpuArchitectureType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CpuArchitectureType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("customAmounts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FleetAmountCapability, FleetAmountCapabilityUnmarshaller>(FleetAmountCapabilityUnmarshaller.Instance);
                    unmarshalledObject.CustomAmounts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("customAttributes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FleetAttributeCapability, FleetAttributeCapabilityUnmarshaller>(FleetAttributeCapabilityUnmarshaller.Instance);
                    unmarshalledObject.CustomAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryMiB", targetDepth))
                {
                    var unmarshaller = MemoryMiBRangeUnmarshaller.Instance;
                    unmarshalledObject.MemoryMiB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("osFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OsFamily = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vCpuCount", targetDepth))
                {
                    var unmarshaller = VCpuCountRangeUnmarshaller.Instance;
                    unmarshalledObject.VCpuCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CustomerManagedWorkerCapabilitiesUnmarshaller _instance = new CustomerManagedWorkerCapabilitiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomerManagedWorkerCapabilitiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}