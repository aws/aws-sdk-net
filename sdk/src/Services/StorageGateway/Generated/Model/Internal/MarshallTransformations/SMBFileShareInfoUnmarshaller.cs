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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SMBFileShareInfo Object
    /// </summary>  
    public class SMBFileShareInfoUnmarshaller : IUnmarshaller<SMBFileShareInfo, XmlUnmarshallerContext>, IUnmarshaller<SMBFileShareInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SMBFileShareInfo IUnmarshaller<SMBFileShareInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SMBFileShareInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SMBFileShareInfo unmarshalledObject = new SMBFileShareInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessBasedEnumeration", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AccessBasedEnumeration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdminUserList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AdminUserList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuditDestinationARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuditDestinationARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Authentication", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Authentication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CacheAttributes", targetDepth))
                {
                    var unmarshaller = CacheAttributesUnmarshaller.Instance;
                    unmarshalledObject.CacheAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CaseSensitivity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaseSensitivity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultStorageClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultStorageClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileShareARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileShareARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileShareId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileShareId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileShareName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileShareName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileShareStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileShareStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GuessMIMETypeEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.GuessMIMETypeEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvalidUserList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InvalidUserList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KMSEncrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.KMSEncrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KMSKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KMSKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocationARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocationARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotificationPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotificationPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ObjectACL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObjectACL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Path", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Path = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReadOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequesterPays", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequesterPays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SMBACLEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SMBACLEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidUserList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ValidUserList = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SMBFileShareInfoUnmarshaller _instance = new SMBFileShareInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SMBFileShareInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}