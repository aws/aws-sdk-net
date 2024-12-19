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
    /// Response Unmarshaller for InstanceRequirements Object
    /// </summary>  
    public class InstanceRequirementsUnmarshaller : IXmlUnmarshaller<InstanceRequirements, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceRequirements Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceRequirements unmarshalledObject = new InstanceRequirements();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("acceleratorCount", targetDepth))
                    {
                        var unmarshaller = AcceleratorCountUnmarshaller.Instance;
                        unmarshalledObject.AcceleratorCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("acceleratorManufacturerSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AcceleratorManufacturers == null)
                        {
                            unmarshalledObject.AcceleratorManufacturers = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AcceleratorManufacturers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("acceleratorNameSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AcceleratorNames == null)
                        {
                            unmarshalledObject.AcceleratorNames = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AcceleratorNames.Add(item);
                        continue;
                    }
                    if (context.TestExpression("acceleratorTotalMemoryMiB", targetDepth))
                    {
                        var unmarshaller = AcceleratorTotalMemoryMiBUnmarshaller.Instance;
                        unmarshalledObject.AcceleratorTotalMemoryMiB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("acceleratorTypeSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AcceleratorTypes == null)
                        {
                            unmarshalledObject.AcceleratorTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AcceleratorTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("allowedInstanceTypeSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AllowedInstanceTypes == null)
                        {
                            unmarshalledObject.AllowedInstanceTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AllowedInstanceTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bareMetal", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BareMetal = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("baselineEbsBandwidthMbps", targetDepth))
                    {
                        var unmarshaller = BaselineEbsBandwidthMbpsUnmarshaller.Instance;
                        unmarshalledObject.BaselineEbsBandwidthMbps = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("burstablePerformance", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BurstablePerformance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("cpuManufacturerSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.CpuManufacturers == null)
                        {
                            unmarshalledObject.CpuManufacturers = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CpuManufacturers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("excludedInstanceTypeSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ExcludedInstanceTypes == null)
                        {
                            unmarshalledObject.ExcludedInstanceTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ExcludedInstanceTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("instanceGenerationSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.InstanceGenerations == null)
                        {
                            unmarshalledObject.InstanceGenerations = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.InstanceGenerations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("localStorage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LocalStorage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("localStorageTypeSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.LocalStorageTypes == null)
                        {
                            unmarshalledObject.LocalStorageTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LocalStorageTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("maxSpotPriceAsPercentageOfOptimalOnDemandPrice", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("memoryGiBPerVCpu", targetDepth))
                    {
                        var unmarshaller = MemoryGiBPerVCpuUnmarshaller.Instance;
                        unmarshalledObject.MemoryGiBPerVCpu = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("memoryMiB", targetDepth))
                    {
                        var unmarshaller = MemoryMiBUnmarshaller.Instance;
                        unmarshalledObject.MemoryMiB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkBandwidthGbps", targetDepth))
                    {
                        var unmarshaller = NetworkBandwidthGbpsUnmarshaller.Instance;
                        unmarshalledObject.NetworkBandwidthGbps = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceCount", targetDepth))
                    {
                        var unmarshaller = NetworkInterfaceCountUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("onDemandMaxPricePercentageOverLowestPrice", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.OnDemandMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("requireHibernateSupport", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequireHibernateSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("spotMaxPricePercentageOverLowestPrice", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SpotMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("totalLocalStorageGB", targetDepth))
                    {
                        var unmarshaller = TotalLocalStorageGBUnmarshaller.Instance;
                        unmarshalledObject.TotalLocalStorageGB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vCpuCount", targetDepth))
                    {
                        var unmarshaller = VCpuCountRangeUnmarshaller.Instance;
                        unmarshalledObject.VCpuCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static InstanceRequirementsUnmarshaller _instance = new InstanceRequirementsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRequirementsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}