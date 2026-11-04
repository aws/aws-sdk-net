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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RedshiftIdcApplication Object
    /// </summary>
    public partial class RedshiftIdcApplicationUnmarshaller : IXmlUnmarshaller<RedshiftIdcApplication, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RedshiftIdcApplication Unmarshall(XmlUnmarshallerContext context)
        {
            RedshiftIdcApplication unmarshalledObject = new RedshiftIdcApplication();
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
                    if (context.TestExpression("ApplicationType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ApplicationType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("AuthorizedTokenIssuerList/member", targetDepth))
                    {
                        if (unmarshalledObject.AuthorizedTokenIssuerList == null)
                        {
                            unmarshalledObject.AuthorizedTokenIssuerList = new List<AuthorizedTokenIssuer>();
                        }
                        var unmarshaller = AuthorizedTokenIssuerUnmarshaller.Instance;
                        unmarshalledObject.AuthorizedTokenIssuerList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("IamRoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IamRoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IdcDisplayName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcDisplayName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IdcInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IdcManagedApplicationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcManagedApplicationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IdcOnboardStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcOnboardStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IdentityNamespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdentityNamespace = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RedshiftIdcApplicationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RedshiftIdcApplicationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RedshiftIdcApplicationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RedshiftIdcApplicationName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ServiceIntegrations/member", targetDepth))
                    {
                        if (unmarshalledObject.ServiceIntegrations == null)
                        {
                            unmarshalledObject.ServiceIntegrations = new List<ServiceIntegrationsUnion>();
                        }
                        var unmarshaller = ServiceIntegrationsUnionUnmarshaller.Instance;
                        unmarshalledObject.ServiceIntegrations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("SsoTagKeys/TagKey", targetDepth))
                    {
                        if (unmarshalledObject.SsoTagKeys == null)
                        {
                            unmarshalledObject.SsoTagKeys = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SsoTagKeys.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Tags/Tag", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
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

        private static RedshiftIdcApplicationUnmarshaller _instance = new RedshiftIdcApplicationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RedshiftIdcApplicationUnmarshaller Instance => _instance;
    }
}
