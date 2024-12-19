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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
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
                    if (context.TestExpression("AcceleratorCount", targetDepth))
                    {
                        var unmarshaller = AcceleratorCountRequestUnmarshaller.Instance;
                        unmarshalledObject.AcceleratorCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AcceleratorManufacturers/member", targetDepth))
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
                    if (context.TestExpression("AcceleratorNames/member", targetDepth))
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
                    if (context.TestExpression("AcceleratorTotalMemoryMiB", targetDepth))
                    {
                        var unmarshaller = AcceleratorTotalMemoryMiBRequestUnmarshaller.Instance;
                        unmarshalledObject.AcceleratorTotalMemoryMiB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AcceleratorTypes/member", targetDepth))
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
                    if (context.TestExpression("AllowedInstanceTypes/member", targetDepth))
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
                    if (context.TestExpression("BareMetal", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BareMetal = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BaselineEbsBandwidthMbps", targetDepth))
                    {
                        var unmarshaller = BaselineEbsBandwidthMbpsRequestUnmarshaller.Instance;
                        unmarshalledObject.BaselineEbsBandwidthMbps = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BurstablePerformance", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BurstablePerformance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CpuManufacturers/member", targetDepth))
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
                    if (context.TestExpression("ExcludedInstanceTypes/member", targetDepth))
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
                    if (context.TestExpression("InstanceGenerations/member", targetDepth))
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
                    if (context.TestExpression("LocalStorage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LocalStorage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LocalStorageTypes/member", targetDepth))
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
                    if (context.TestExpression("MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MemoryGiBPerVCpu", targetDepth))
                    {
                        var unmarshaller = MemoryGiBPerVCpuRequestUnmarshaller.Instance;
                        unmarshalledObject.MemoryGiBPerVCpu = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MemoryMiB", targetDepth))
                    {
                        var unmarshaller = MemoryMiBRequestUnmarshaller.Instance;
                        unmarshalledObject.MemoryMiB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NetworkBandwidthGbps", targetDepth))
                    {
                        var unmarshaller = NetworkBandwidthGbpsRequestUnmarshaller.Instance;
                        unmarshalledObject.NetworkBandwidthGbps = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NetworkInterfaceCount", targetDepth))
                    {
                        var unmarshaller = NetworkInterfaceCountRequestUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OnDemandMaxPricePercentageOverLowestPrice", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.OnDemandMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequireHibernateSupport", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequireHibernateSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SpotMaxPricePercentageOverLowestPrice", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SpotMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalLocalStorageGB", targetDepth))
                    {
                        var unmarshaller = TotalLocalStorageGBRequestUnmarshaller.Instance;
                        unmarshalledObject.TotalLocalStorageGB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VCpuCount", targetDepth))
                    {
                        var unmarshaller = VCpuCountRequestUnmarshaller.Instance;
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