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

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataInstanceRequirementsDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataInstanceRequirementsDetailsUnmarshaller : IUnmarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2LaunchTemplateDataInstanceRequirementsDetails IUnmarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2LaunchTemplateDataInstanceRequirementsDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2LaunchTemplateDataInstanceRequirementsDetails unmarshalledObject = new AwsEc2LaunchTemplateDataInstanceRequirementsDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AcceleratorCount", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetailsUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AcceleratorManufacturers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorManufacturers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AcceleratorNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AcceleratorTotalMemoryMiB", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorTotalMemoryMiBDetailsUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorTotalMemoryMiB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AcceleratorTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AcceleratorTypes = unmarshaller.Unmarshall(context);
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
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsBaselineEbsBandwidthMbpsDetailsUnmarshaller.Instance;
                    unmarshalledObject.BaselineEbsBandwidthMbps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BurstablePerformance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BurstablePerformance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CpuManufacturers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CpuManufacturers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExcludedInstanceTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExcludedInstanceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceGenerations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceGenerations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalStorage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalStorageTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LocalStorageTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MemoryGiBPerVCpu", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsUnmarshaller.Instance;
                    unmarshalledObject.MemoryGiBPerVCpu = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MemoryMiB", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsMemoryMiBDetailsUnmarshaller.Instance;
                    unmarshalledObject.MemoryMiB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkInterfaceCount", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsNetworkInterfaceCountDetailsUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterfaceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OnDemandMaxPricePercentageOverLowestPrice", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.OnDemandMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireHibernateSupport", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireHibernateSupport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpotMaxPricePercentageOverLowestPrice", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SpotMaxPricePercentageOverLowestPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalLocalStorageGB", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsTotalLocalStorageGBDetailsUnmarshaller.Instance;
                    unmarshalledObject.TotalLocalStorageGB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VCpuCount", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsVCpuCountDetailsUnmarshaller.Instance;
                    unmarshalledObject.VCpuCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataInstanceRequirementsDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataInstanceRequirementsDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataInstanceRequirementsDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}