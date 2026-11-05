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
    /// Response Unmarshaller for Option Object
    /// </summary>
    public partial class OptionUnmarshaller : IXmlUnmarshaller<Option, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Option Unmarshall(XmlUnmarshallerContext context)
        {
            Option unmarshalledObject = new Option();
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
                    if (context.TestExpression("DBSecurityGroupMemberships/DBSecurityGroup", targetDepth))
                    {
                        if (unmarshalledObject.DBSecurityGroupMemberships == null)
                        {
                            unmarshalledObject.DBSecurityGroupMemberships = new List<DBSecurityGroupMembership>();
                        }
                        var unmarshaller = DBSecurityGroupMembershipUnmarshaller.Instance;
                        unmarshalledObject.DBSecurityGroupMemberships.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OptionDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OptionName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OptionSettings/OptionSetting", targetDepth))
                    {
                        if (unmarshalledObject.OptionSettings == null)
                        {
                            unmarshalledObject.OptionSettings = new List<OptionSetting>();
                        }
                        var unmarshaller = OptionSettingUnmarshaller.Instance;
                        unmarshalledObject.OptionSettings.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OptionVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionVersion = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("VpcSecurityGroupMemberships/VpcSecurityGroupMembership", targetDepth))
                    {
                        if (unmarshalledObject.VpcSecurityGroupMemberships == null)
                        {
                            unmarshalledObject.VpcSecurityGroupMemberships = new List<VpcSecurityGroupMembership>();
                        }
                        var unmarshaller = VpcSecurityGroupMembershipUnmarshaller.Instance;
                        unmarshalledObject.VpcSecurityGroupMemberships.Add(unmarshaller.Unmarshall(context));
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

        private static OptionUnmarshaller _instance = new OptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OptionUnmarshaller Instance => _instance;
    }
}
