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
    /// Response Unmarshaller for MacSystemIntegrityProtectionConfiguration Object
    /// </summary>  
    public class MacSystemIntegrityProtectionConfigurationUnmarshaller : IXmlUnmarshaller<MacSystemIntegrityProtectionConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MacSystemIntegrityProtectionConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            MacSystemIntegrityProtectionConfiguration unmarshalledObject = new MacSystemIntegrityProtectionConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("appleInternal", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AppleInternal = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("baseSystem", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BaseSystem = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("debuggingRestrictions", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DebuggingRestrictions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dTraceRestrictions", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DTraceRestrictions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("filesystemProtections", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FilesystemProtections = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kextSigning", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KextSigning = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("nvramProtections", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NvramProtections = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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

        private static MacSystemIntegrityProtectionConfigurationUnmarshaller _instance = new MacSystemIntegrityProtectionConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MacSystemIntegrityProtectionConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}