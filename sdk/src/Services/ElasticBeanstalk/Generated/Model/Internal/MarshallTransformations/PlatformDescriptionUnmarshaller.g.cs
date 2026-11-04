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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PlatformDescription Object
    /// </summary>
    public partial class PlatformDescriptionUnmarshaller : IXmlUnmarshaller<PlatformDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public PlatformDescription Unmarshall(XmlUnmarshallerContext context)
        {
            PlatformDescription unmarshalledObject = new PlatformDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CustomAmiList/member", targetDepth))
                    {
                        if (unmarshalledObject.CustomAmiList == null)
                        {
                            unmarshalledObject.CustomAmiList = new List<CustomAmi>();
                        }
                        var unmarshaller = CustomAmiUnmarshaller.Instance;
                        unmarshalledObject.CustomAmiList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.DateCreated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.DateUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DefaultAmiList/member", targetDepth))
                    {
                        if (unmarshalledObject.DefaultAmiList == null)
                        {
                            unmarshalledObject.DefaultAmiList = new List<DefaultAmi>();
                        }
                        var unmarshaller = DefaultAmiUnmarshaller.Instance;
                        unmarshalledObject.DefaultAmiList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Frameworks/member", targetDepth))
                    {
                        if (unmarshalledObject.Frameworks == null)
                        {
                            unmarshalledObject.Frameworks = new List<PlatformFramework>();
                        }
                        var unmarshaller = PlatformFrameworkUnmarshaller.Instance;
                        unmarshalledObject.Frameworks.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Maintainer", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Maintainer = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OperatingSystemName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OperatingSystemName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OperatingSystemVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OperatingSystemVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformBranchLifecycleState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformBranchLifecycleState = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformBranchName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformBranchName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformCategory", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformCategory = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformLifecycleState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformLifecycleState = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PlatformVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ProgrammingLanguages/member", targetDepth))
                    {
                        if (unmarshalledObject.ProgrammingLanguages == null)
                        {
                            unmarshalledObject.ProgrammingLanguages = new List<PlatformProgrammingLanguage>();
                        }
                        var unmarshaller = PlatformProgrammingLanguageUnmarshaller.Instance;
                        unmarshalledObject.ProgrammingLanguages.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SolutionStackName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SupportedAddonList/member", targetDepth))
                    {
                        if (unmarshalledObject.SupportedAddonList == null)
                        {
                            unmarshalledObject.SupportedAddonList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SupportedAddonList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("SupportedTierList/member", targetDepth))
                    {
                        if (unmarshalledObject.SupportedTierList == null)
                        {
                            unmarshalledObject.SupportedTierList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SupportedTierList.Add(unmarshaller.Unmarshall(context));
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

        private static PlatformDescriptionUnmarshaller _instance = new PlatformDescriptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PlatformDescriptionUnmarshaller Instance => _instance;
    }
}
