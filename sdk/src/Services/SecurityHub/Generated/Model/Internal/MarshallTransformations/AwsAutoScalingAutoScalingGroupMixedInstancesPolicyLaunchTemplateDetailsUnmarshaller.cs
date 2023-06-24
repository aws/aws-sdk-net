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
    /// Response Unmarshaller for AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails Object
    /// </summary>  
    public class AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetailsUnmarshaller : IUnmarshaller<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails IUnmarshaller<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails unmarshalledObject = new AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LaunchTemplateSpecification", targetDepth))
                {
                    var unmarshaller = AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationUnmarshaller.Instance;
                    unmarshalledObject.LaunchTemplateSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Overrides", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateOverridesListDetails, AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateOverridesListDetailsUnmarshaller>(AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateOverridesListDetailsUnmarshaller.Instance);
                    unmarshalledObject.Overrides = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetailsUnmarshaller _instance = new AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}