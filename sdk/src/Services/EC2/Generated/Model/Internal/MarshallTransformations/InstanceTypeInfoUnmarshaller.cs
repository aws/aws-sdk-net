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
    /// Response Unmarshaller for InstanceTypeInfo Object
    /// </summary>  
    public class InstanceTypeInfoUnmarshaller : IXmlUnmarshaller<InstanceTypeInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceTypeInfo Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceTypeInfo unmarshalledObject = new InstanceTypeInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("autoRecoverySupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AutoRecoverySupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("bareMetal", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.BareMetal = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("burstablePerformanceSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.BurstablePerformanceSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("currentGeneration", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.CurrentGeneration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dedicatedHostsSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DedicatedHostsSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ebsInfo", targetDepth))
                    {
                        var unmarshaller = EbsInfoUnmarshaller.Instance;
                        unmarshalledObject.EbsInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fpgaInfo", targetDepth))
                    {
                        var unmarshaller = FpgaInfoUnmarshaller.Instance;
                        unmarshalledObject.FpgaInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("freeTierEligible", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.FreeTierEligible = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("gpuInfo", targetDepth))
                    {
                        var unmarshaller = GpuInfoUnmarshaller.Instance;
                        unmarshalledObject.GpuInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hibernationSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.HibernationSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hypervisor", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Hypervisor = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("inferenceAcceleratorInfo", targetDepth))
                    {
                        var unmarshaller = InferenceAcceleratorInfoUnmarshaller.Instance;
                        unmarshalledObject.InferenceAcceleratorInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceStorageInfo", targetDepth))
                    {
                        var unmarshaller = InstanceStorageInfoUnmarshaller.Instance;
                        unmarshalledObject.InstanceStorageInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceStorageSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.InstanceStorageSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("mediaAcceleratorInfo", targetDepth))
                    {
                        var unmarshaller = MediaAcceleratorInfoUnmarshaller.Instance;
                        unmarshalledObject.MediaAcceleratorInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("memoryInfo", targetDepth))
                    {
                        var unmarshaller = MemoryInfoUnmarshaller.Instance;
                        unmarshalledObject.MemoryInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInfo", targetDepth))
                    {
                        var unmarshaller = NetworkInfoUnmarshaller.Instance;
                        unmarshalledObject.NetworkInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("neuronInfo", targetDepth))
                    {
                        var unmarshaller = NeuronInfoUnmarshaller.Instance;
                        unmarshalledObject.NeuronInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("nitroEnclavesSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NitroEnclavesSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("nitroTpmInfo", targetDepth))
                    {
                        var unmarshaller = NitroTpmInfoUnmarshaller.Instance;
                        unmarshalledObject.NitroTpmInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("nitroTpmSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NitroTpmSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phcSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PhcSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("placementGroupInfo", targetDepth))
                    {
                        var unmarshaller = PlacementGroupInfoUnmarshaller.Instance;
                        unmarshalledObject.PlacementGroupInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("processorInfo", targetDepth))
                    {
                        var unmarshaller = ProcessorInfoUnmarshaller.Instance;
                        unmarshalledObject.ProcessorInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("supportedBootModes/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedBootModes == null)
                        {
                            unmarshalledObject.SupportedBootModes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedBootModes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("supportedRootDeviceTypes/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedRootDeviceTypes == null)
                        {
                            unmarshalledObject.SupportedRootDeviceTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedRootDeviceTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("supportedUsageClasses/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedUsageClasses == null)
                        {
                            unmarshalledObject.SupportedUsageClasses = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedUsageClasses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("supportedVirtualizationTypes/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedVirtualizationTypes == null)
                        {
                            unmarshalledObject.SupportedVirtualizationTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedVirtualizationTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("vCpuInfo", targetDepth))
                    {
                        var unmarshaller = VCpuInfoUnmarshaller.Instance;
                        unmarshalledObject.VCpuInfo = unmarshaller.Unmarshall(context);
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

        private static InstanceTypeInfoUnmarshaller _instance = new InstanceTypeInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceTypeInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}