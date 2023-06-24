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
using ThirdParty.Json.LitJson;

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataLakeSettings Object
    /// </summary>  
    public class DataLakeSettingsUnmarshaller : IUnmarshaller<DataLakeSettings, XmlUnmarshallerContext>, IUnmarshaller<DataLakeSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataLakeSettings IUnmarshaller<DataLakeSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataLakeSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataLakeSettings unmarshalledObject = new DataLakeSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowExternalDataFiltering", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowExternalDataFiltering = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuthorizedSessionTagValueList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AuthorizedSessionTagValueList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateDatabaseDefaultPermissions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PrincipalPermissions, PrincipalPermissionsUnmarshaller>(PrincipalPermissionsUnmarshaller.Instance);
                    unmarshalledObject.CreateDatabaseDefaultPermissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateTableDefaultPermissions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PrincipalPermissions, PrincipalPermissionsUnmarshaller>(PrincipalPermissionsUnmarshaller.Instance);
                    unmarshalledObject.CreateTableDefaultPermissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataLakeAdmins", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataLakePrincipal, DataLakePrincipalUnmarshaller>(DataLakePrincipalUnmarshaller.Instance);
                    unmarshalledObject.DataLakeAdmins = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExternalDataFilteringAllowList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataLakePrincipal, DataLakePrincipalUnmarshaller>(DataLakePrincipalUnmarshaller.Instance);
                    unmarshalledObject.ExternalDataFilteringAllowList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrustedResourceOwners", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TrustedResourceOwners = unmarshaller.Unmarshall(context);
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