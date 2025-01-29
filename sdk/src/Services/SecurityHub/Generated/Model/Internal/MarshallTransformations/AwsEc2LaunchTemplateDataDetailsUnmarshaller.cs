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
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2LaunchTemplateDataDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2LaunchTemplateDataDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2LaunchTemplateDataDetails unmarshalledObject = new AwsEc2LaunchTemplateDataDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BlockDeviceMappingSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetails, AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetailsUnmarshaller>(AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetailsUnmarshaller.Instance);
                    unmarshalledObject.BlockDeviceMappingSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CapacityReservationSpecification", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetailsUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservationSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CpuOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataCpuOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.CpuOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreditSpecification", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataCreditSpecificationDetailsUnmarshaller.Instance;
                    unmarshalledObject.CreditSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DisableApiStop", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableApiStop = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DisableApiTermination", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableApiTermination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EbsOptimized", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ElasticGpuSpecificationSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetails, AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetailsUnmarshaller>(AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetailsUnmarshaller.Instance);
                    unmarshalledObject.ElasticGpuSpecificationSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ElasticInferenceAcceleratorSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetails, AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetailsUnmarshaller>(AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetailsUnmarshaller.Instance);
                    unmarshalledObject.ElasticInferenceAcceleratorSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnclaveOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataEnclaveOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.EnclaveOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HibernationOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataHibernationOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.HibernationOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IamInstanceProfile", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataIamInstanceProfileDetailsUnmarshaller.Instance;
                    unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceInitiatedShutdownBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceInitiatedShutdownBehavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceMarketOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceMarketOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.InstanceMarketOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceRequirements", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataInstanceRequirementsDetailsUnmarshaller.Instance;
                    unmarshalledObject.InstanceRequirements = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KernelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KernelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KeyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LicenseSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataLicenseSetDetails, AwsEc2LaunchTemplateDataLicenseSetDetailsUnmarshaller>(AwsEc2LaunchTemplateDataLicenseSetDetailsUnmarshaller.Instance);
                    unmarshalledObject.LicenseSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaintenanceOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataMaintenanceOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MetadataOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataMetadataOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.MetadataOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Monitoring", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataMonitoringDetailsUnmarshaller.Instance;
                    unmarshalledObject.Monitoring = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkInterfaceSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails, AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsUnmarshaller>(AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsUnmarshaller.Instance);
                    unmarshalledObject.NetworkInterfaceSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Placement", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataPlacementDetailsUnmarshaller.Instance;
                    unmarshalledObject.Placement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivateDnsNameOptions", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.PrivateDnsNameOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RamDiskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RamDiskId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecurityGroupIdSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupIdSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecurityGroupSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UserData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserData = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}