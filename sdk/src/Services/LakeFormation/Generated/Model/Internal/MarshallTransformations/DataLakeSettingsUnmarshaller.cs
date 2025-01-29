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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataLakeSettings Object
    /// </summary>  
    public class DataLakeSettingsUnmarshaller : IJsonUnmarshaller<DataLakeSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataLakeSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataLakeSettings unmarshalledObject = new DataLakeSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AllowExternalDataFiltering", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AllowExternalDataFiltering = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AllowFullTableExternalDataAccess", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AllowFullTableExternalDataAccess = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AuthorizedSessionTagValueList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AuthorizedSessionTagValueList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateDatabaseDefaultPermissions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PrincipalPermissions, PrincipalPermissionsUnmarshaller>(PrincipalPermissionsUnmarshaller.Instance);
                    unmarshalledObject.CreateDatabaseDefaultPermissions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateTableDefaultPermissions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PrincipalPermissions, PrincipalPermissionsUnmarshaller>(PrincipalPermissionsUnmarshaller.Instance);
                    unmarshalledObject.CreateTableDefaultPermissions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataLakeAdmins", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataLakePrincipal, DataLakePrincipalUnmarshaller>(DataLakePrincipalUnmarshaller.Instance);
                    unmarshalledObject.DataLakeAdmins = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExternalDataFilteringAllowList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataLakePrincipal, DataLakePrincipalUnmarshaller>(DataLakePrincipalUnmarshaller.Instance);
                    unmarshalledObject.ExternalDataFilteringAllowList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReadOnlyAdmins", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataLakePrincipal, DataLakePrincipalUnmarshaller>(DataLakePrincipalUnmarshaller.Instance);
                    unmarshalledObject.ReadOnlyAdmins = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrustedResourceOwners", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TrustedResourceOwners = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataLakeSettingsUnmarshaller _instance = new DataLakeSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataLakeSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}