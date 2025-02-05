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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RedshiftSettings Object
    /// </summary>  
    public class RedshiftSettingsUnmarshaller : IJsonUnmarshaller<RedshiftSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RedshiftSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RedshiftSettings unmarshalledObject = new RedshiftSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AcceptAnyDate", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AcceptAnyDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AfterConnectScript", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterConnectScript = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketFolder", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketFolder = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CaseSensitiveNames", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CaseSensitiveNames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CompUpdate", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CompUpdate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectionTimeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ConnectionTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DateFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmptyAsNull", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EmptyAsNull = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EncryptionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExplicitIds", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ExplicitIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FileTransferUploadStreams", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FileTransferUploadStreams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LoadTimeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.LoadTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MapBooleanAsBoolean", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.MapBooleanAsBoolean = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxFileSize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxFileSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Password", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Password = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Port", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RemoveQuotes", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RemoveQuotes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplaceChars", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplaceChars = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplaceInvalidChars", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplaceInvalidChars = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecretsManagerAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerAccessRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecretsManagerSecretId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerSecretId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServerSideEncryptionKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerSideEncryptionKmsKeyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceAccessRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrimBlanks", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.TrimBlanks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TruncateColumns", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.TruncateColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Username", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Username = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WriteBufferSize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WriteBufferSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RedshiftSettingsUnmarshaller _instance = new RedshiftSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RedshiftSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}