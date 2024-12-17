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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IndexedRecoveryPoint Object
    /// </summary>  
    public class IndexedRecoveryPointUnmarshaller : IUnmarshaller<IndexedRecoveryPoint, XmlUnmarshallerContext>, IUnmarshaller<IndexedRecoveryPoint, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IndexedRecoveryPoint IUnmarshaller<IndexedRecoveryPoint, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IndexedRecoveryPoint Unmarshall(JsonUnmarshallerContext context)
        {
            IndexedRecoveryPoint unmarshalledObject = new IndexedRecoveryPoint();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackupCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.BackupCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupVaultArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupVaultArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IamRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.IndexCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecoveryPointArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecoveryPointArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IndexedRecoveryPointUnmarshaller _instance = new IndexedRecoveryPointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IndexedRecoveryPointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}