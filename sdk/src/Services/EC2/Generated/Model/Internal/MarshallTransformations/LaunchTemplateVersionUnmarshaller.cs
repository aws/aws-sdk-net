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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchTemplateVersion Object
    /// </summary>  
    public class LaunchTemplateVersionUnmarshaller : IUnmarshaller<LaunchTemplateVersion, XmlUnmarshallerContext>, IUnmarshaller<LaunchTemplateVersion, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchTemplateVersion Unmarshall(XmlUnmarshallerContext context)
        {
            LaunchTemplateVersion unmarshalledObject = new LaunchTemplateVersion();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("createdBy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("createTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("defaultVersion", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.DefaultVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("launchTemplateData", targetDepth))
                    {
                        var unmarshaller = ResponseLaunchTemplateDataUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplateData = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("launchTemplateId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplateId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("launchTemplateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("versionDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VersionDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("versionNumber", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.VersionNumber = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchTemplateVersion Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static LaunchTemplateVersionUnmarshaller _instance = new LaunchTemplateVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchTemplateVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}