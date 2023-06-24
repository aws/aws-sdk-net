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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OracleSettings Object
    /// </summary>  
    public class OracleSettingsUnmarshaller : IUnmarshaller<OracleSettings, XmlUnmarshallerContext>, IUnmarshaller<OracleSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OracleSettings IUnmarshaller<OracleSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OracleSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OracleSettings unmarshalledObject = new OracleSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessAlternateDirectly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AccessAlternateDirectly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdditionalArchivedLogDestId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AdditionalArchivedLogDestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddSupplementalLogging", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AddSupplementalLogging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllowSelectNestedTables", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowSelectNestedTables = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ArchivedLogDestId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ArchivedLogDestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ArchivedLogsOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ArchivedLogsOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AsmPassword", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AsmPassword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AsmServer", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AsmServer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AsmUser", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AsmUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CharLengthSemantics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CharLengthSemantics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConvertTimestampWithZoneToUTC", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ConvertTimestampWithZoneToUTC = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectPathNoLog", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DirectPathNoLog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectPathParallelLoad", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DirectPathParallelLoad = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableHomogenousTablespace", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableHomogenousTablespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtraArchivedLogDestIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.ExtraArchivedLogDestIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailTasksOnLobTruncation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FailTasksOnLobTruncation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberDatatypeScale", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberDatatypeScale = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OraclePathPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OraclePathPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParallelAsmReadThreads", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ParallelAsmReadThreads = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Password", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Password = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadAheadBlocks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ReadAheadBlocks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadTableSpaceName", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReadTableSpaceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplacePathPrefix", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReplacePathPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RetryInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretsManagerAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerAccessRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretsManagerOracleAsmAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerOracleAsmAccessRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretsManagerOracleAsmSecretId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerOracleAsmSecretId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretsManagerSecretId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerSecretId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityDbEncryption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityDbEncryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityDbEncryptionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityDbEncryptionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpatialDataOptionToGeoJsonFunctionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpatialDataOptionToGeoJsonFunctionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StandbyDelayTime", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StandbyDelayTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrimSpaceInChar", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TrimSpaceInChar = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAlternateFolderForOnline", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseAlternateFolderForOnline = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseBFile", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseBFile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseDirectPathFullLoad", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseDirectPathFullLoad = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseLogminerReader", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseLogminerReader = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsePathPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UsePathPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Username", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Username = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OracleSettingsUnmarshaller _instance = new OracleSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OracleSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}