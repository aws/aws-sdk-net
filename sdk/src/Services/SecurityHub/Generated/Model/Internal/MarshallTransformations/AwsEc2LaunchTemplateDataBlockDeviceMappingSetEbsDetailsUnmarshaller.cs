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
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetailsUnmarshaller : IUnmarshaller<AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails IUnmarshaller<AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails unmarshalledObject = new AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeleteOnTermination", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeleteOnTermination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Encrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Encrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Iops", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Iops = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Throughput", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Throughput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VolumeSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}