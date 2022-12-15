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
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsUnmarshaller : IUnmarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails IUnmarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails unmarshalledObject = new AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Max", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Max = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Min", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Min = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}