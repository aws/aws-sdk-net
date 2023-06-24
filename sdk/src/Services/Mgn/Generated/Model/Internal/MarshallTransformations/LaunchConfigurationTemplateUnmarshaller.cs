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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchConfigurationTemplate Object
    /// </summary>  
    public class LaunchConfigurationTemplateUnmarshaller : IUnmarshaller<LaunchConfigurationTemplate, XmlUnmarshallerContext>, IUnmarshaller<LaunchConfigurationTemplate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LaunchConfigurationTemplate IUnmarshaller<LaunchConfigurationTemplate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchConfigurationTemplate Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LaunchConfigurationTemplate unmarshalledObject = new LaunchConfigurationTemplate();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("associatePublicIpAddress", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bootMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("copyPrivateIp", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyPrivateIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("copyTags", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2LaunchTemplateID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2LaunchTemplateID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableMapAutoTagging", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableMapAutoTagging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("largeVolumeConf", targetDepth))
                {
                    var unmarshaller = LaunchTemplateDiskConfUnmarshaller.Instance;
                    unmarshalledObject.LargeVolumeConf = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchConfigurationTemplateID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchConfigurationTemplateID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchDisposition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchDisposition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("licensing", targetDepth))
                {
                    var unmarshaller = LicensingUnmarshaller.Instance;
                    unmarshalledObject.Licensing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapAutoTaggingMpeID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MapAutoTaggingMpeID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("postLaunchActions", targetDepth))
                {
                    var unmarshaller = PostLaunchActionsUnmarshaller.Instance;
                    unmarshalledObject.PostLaunchActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("smallVolumeConf", targetDepth))
                {
                    var unmarshaller = LaunchTemplateDiskConfUnmarshaller.Instance;
                    unmarshalledObject.SmallVolumeConf = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("smallVolumeMaxSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SmallVolumeMaxSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetInstanceTypeRightSizingMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetInstanceTypeRightSizingMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LaunchConfigurationTemplateUnmarshaller _instance = new LaunchConfigurationTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchConfigurationTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}