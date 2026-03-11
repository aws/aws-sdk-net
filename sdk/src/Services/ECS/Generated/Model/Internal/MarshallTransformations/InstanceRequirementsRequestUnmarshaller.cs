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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceRequirementsRequest Object
    /// </summary>  
    public class InstanceRequirementsRequestUnmarshaller : IJsonUnmarshaller<InstanceRequirementsRequest, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceRequirementsRequest Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InstanceRequirementsRequest unmarshalledObject = new InstanceRequirementsRequest();
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
                    var unmarshaller = AcceleratorCountRequestUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("acceleratorManufacturers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorManufacturers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("acceleratorNames", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorNames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("acceleratorTotalMemoryMiB", targetDepth))
                {
                    var unmarshaller = AcceleratorTotalMemoryMiBRequestUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorTotalMemoryMiB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("acceleratorTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("allowedInstanceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedInstanceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bareMetal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BareMetal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baselineEbsBandwidthMbps", targetDepth))
                {
                    var unmarshaller = BaselineEbsBandwidthMbpsRequestUnmarshaller.Instance;
                    unmarshalledObject.BaselineEbsBandwidthMbps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("burstablePerformance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BurstablePerformance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpuManufacturers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CpuManufacturers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("excludedInstanceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExcludedInstanceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceGenerations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceGenerations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localStorage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalStorage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localStorageTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LocalStorageTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxSpotPriceAsPercentageOfOptimalOnDemandPrice", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryGiBPerVCpu", targetDepth))
                {
                    var unmarshaller = MemoryGiBPerVCpuRequestUnmarshaller.Instance;
                    unmarshalledObject.MemoryGiBPerVCpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryMiB", targetDepth))
                {
                    var unmarshaller = MemoryMiBRequestUnmarshaller.Instance;
                    unmarshalledObject.MemoryMiB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkBandwidthGbps", targetDepth))
                {
                    var unmarshaller = NetworkBandwidthGbpsRequestUnmarshaller.Instance;
                    unmarshalledObject.NetworkBandwidthGbps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkInterfaceCount", targetDepth))
                {
                    var unmarshaller = NetworkInterfaceCountRequestUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterfaceCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("onDemandMaxPricePercentageOverLowestPrice", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.OnDemandMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requireHibernateSupport", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RequireHibernateSupport = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("spotMaxPricePercentageOverLowestPrice", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SpotMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalLocalStorageGB", targetDepth))
                {
                    var unmarshaller = TotalLocalStorageGBRequestUnmarshaller.Instance;
                    unmarshalledObject.TotalLocalStorageGB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vCpuCount", targetDepth))
                {
                    var unmarshaller = VCpuCountRangeRequestUnmarshaller.Instance;
                    unmarshalledObject.VCpuCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceRequirementsRequestUnmarshaller _instance = new InstanceRequirementsRequestUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRequirementsRequestUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}