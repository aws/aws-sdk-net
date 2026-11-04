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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OptionGroupOption Object
    /// </summary>
    public partial class OptionGroupOptionUnmarshaller : IXmlUnmarshaller<OptionGroupOption, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public OptionGroupOption Unmarshall(XmlUnmarshallerContext context)
        {
            OptionGroupOption unmarshalledObject = new OptionGroupOption();
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
                    if (context.TestExpression("CopyableCrossAccount", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.CopyableCrossAccount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DefaultPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultPort = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("EngineName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("MajorEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MajorEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("MinimumRequiredMinorEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MinimumRequiredMinorEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OptionGroupOptionSettings/OptionGroupOptionSetting", targetDepth))
                    {
                        if (unmarshalledObject.OptionGroupOptionSettings == null)
                        {
                            unmarshalledObject.OptionGroupOptionSettings = new List<OptionGroupOptionSetting>();
                        }
                        var unmarshaller = OptionGroupOptionSettingUnmarshaller.Instance;
                        unmarshalledObject.OptionGroupOptionSettings.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OptionGroupOptionVersions/OptionVersion", targetDepth))
                    {
                        if (unmarshalledObject.OptionGroupOptionVersions == null)
                        {
                            unmarshalledObject.OptionGroupOptionVersions = new List<OptionVersion>();
                        }
                        var unmarshaller = OptionVersionUnmarshaller.Instance;
                        unmarshalledObject.OptionGroupOptionVersions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OptionsConflictsWith/OptionConflictName", targetDepth))
                    {
                        if (unmarshalledObject.OptionsConflictsWith == null)
                        {
                            unmarshalledObject.OptionsConflictsWith = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionsConflictsWith.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OptionsDependedOn/OptionName", targetDepth))
                    {
                        if (unmarshalledObject.OptionsDependedOn == null)
                        {
                            unmarshalledObject.OptionsDependedOn = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionsDependedOn.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Permanent", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Permanent = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Persistent", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Persistent = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PortRequired", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.PortRequired = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RequiresAutoMinorEngineVersionUpgrade", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequiresAutoMinorEngineVersionUpgrade = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SupportsOptionVersionDowngrade", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsOptionVersionDowngrade = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("VpcOnly", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.VpcOnly = unmarshaller.Unmarshall(context);
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

        private static OptionGroupOptionUnmarshaller _instance = new OptionGroupOptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OptionGroupOptionUnmarshaller Instance => _instance;
    }
}
