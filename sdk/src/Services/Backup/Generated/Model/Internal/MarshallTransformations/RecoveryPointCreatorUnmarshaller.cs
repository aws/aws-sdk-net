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
    /// Response Unmarshaller for RecoveryPointCreator Object
    /// </summary>  
    public class RecoveryPointCreatorUnmarshaller : IUnmarshaller<RecoveryPointCreator, XmlUnmarshallerContext>, IUnmarshaller<RecoveryPointCreator, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecoveryPointCreator IUnmarshaller<RecoveryPointCreator, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecoveryPointCreator Unmarshall(JsonUnmarshallerContext context)
        {
            RecoveryPointCreator unmarshalledObject = new RecoveryPointCreator();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackupPlanArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupPlanArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupPlanId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupPlanId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupPlanName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupPlanName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupPlanVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupPlanVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupRuleCron", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupRuleCron = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupRuleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupRuleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupRuleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupRuleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupRuleTimezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupRuleTimezone = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RecoveryPointCreatorUnmarshaller _instance = new RecoveryPointCreatorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecoveryPointCreatorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}