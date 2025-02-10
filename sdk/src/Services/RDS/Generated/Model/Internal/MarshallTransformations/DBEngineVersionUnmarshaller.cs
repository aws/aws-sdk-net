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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
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
                    if (context.TestExpression("CreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomDBEngineVersionManifest", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CustomDBEngineVersionManifest = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DatabaseInstallationFilesS3BucketName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DatabaseInstallationFilesS3BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DatabaseInstallationFilesS3Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DatabaseInstallationFilesS3Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBEngineDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineMediaType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBEngineMediaType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineVersionArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBEngineVersionArn = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("DefaultCharacterSet", targetDepth))
                    {
                        var unmarshaller = CharacterSetUnmarshaller.Instance;
                        unmarshalledObject.DefaultCharacterSet = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("Image", targetDepth))
                    {
                        var unmarshaller = CustomDBEngineVersionAMIUnmarshaller.Instance;
                        unmarshalledObject.Image = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KMSKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KMSKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MajorEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MajorEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServerlessV2FeaturesSupport", targetDepth))
                    {
                        var unmarshaller = ServerlessV2FeaturesSupportUnmarshaller.Instance;
                        unmarshalledObject.ServerlessV2FeaturesSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("SupportedCharacterSets/CharacterSet", targetDepth))
                    {
                        var unmarshaller = CharacterSetUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedCharacterSets == null)
                        {
                            unmarshalledObject.SupportedCharacterSets = new List<CharacterSet>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedCharacterSets.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedEngineModes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedEngineModes == null)
                        {
                            unmarshalledObject.SupportedEngineModes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedEngineModes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedFeatureNames/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedFeatureNames == null)
                        {
                            unmarshalledObject.SupportedFeatureNames = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedFeatureNames.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedNcharCharacterSets/CharacterSet", targetDepth))
                    {
                        var unmarshaller = CharacterSetUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedNcharCharacterSets == null)
                        {
                            unmarshalledObject.SupportedNcharCharacterSets = new List<CharacterSet>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedNcharCharacterSets.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedTimezones/Timezone", targetDepth))
                    {
                        var unmarshaller = TimezoneUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedTimezones == null)
                        {
                            unmarshalledObject.SupportedTimezones = new List<Timezone>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedTimezones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportsBabelfish", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsBabelfish = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsCertificateRotationWithoutRestart", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsCertificateRotationWithoutRestart = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsGlobalDatabases", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsGlobalDatabases = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsIntegrations", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsIntegrations = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLimitlessDatabase", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsLimitlessDatabase = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLocalWriteForwarding", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsLocalWriteForwarding = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLogExportsToCloudwatchLogs", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsLogExportsToCloudwatchLogs = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsParallelQuery", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsParallelQuery = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsReadReplica", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsReadReplica = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TagList/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.TagList == null)
                        {
                            unmarshalledObject.TagList = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TagList.Add(item);
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