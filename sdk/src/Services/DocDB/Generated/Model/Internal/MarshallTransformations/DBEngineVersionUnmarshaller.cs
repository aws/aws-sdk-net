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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBEngineVersion Object
    /// </summary>  
    public class DBEngineVersionUnmarshaller : IXmlUnmarshaller<DBEngineVersion, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBEngineVersion Unmarshall(XmlUnmarshallerContext context)
        {
            DBEngineVersion unmarshalledObject = new DBEngineVersion();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBEngineDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBEngineDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineVersionDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBEngineVersionDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBParameterGroupFamily", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBParameterGroupFamily = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExportableLogTypes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ExportableLogTypes == null)
                        {
                            unmarshalledObject.ExportableLogTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ExportableLogTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ServerlessV2FeaturesSupport", targetDepth))
                    {
                        var unmarshaller = ServerlessV2FeaturesSupportUnmarshaller.Instance;
                        unmarshalledObject.ServerlessV2FeaturesSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportedCACertificateIdentifiers/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedCACertificateIdentifiers == null)
                        {
                            unmarshalledObject.SupportedCACertificateIdentifiers = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedCACertificateIdentifiers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportsCertificateRotationWithoutRestart", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsCertificateRotationWithoutRestart = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLogExportsToCloudwatchLogs", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsLogExportsToCloudwatchLogs = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ValidUpgradeTarget/UpgradeTarget", targetDepth))
                    {
                        var unmarshaller = UpgradeTargetUnmarshaller.Instance;
                        if (unmarshalledObject.ValidUpgradeTarget == null)
                        {
                            unmarshalledObject.ValidUpgradeTarget = new List<UpgradeTarget>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ValidUpgradeTarget.Add(item);
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

        private static DBEngineVersionUnmarshaller _instance = new DBEngineVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBEngineVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}