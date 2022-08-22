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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsBackupBackupPlanRuleDetails Object
    /// </summary>  
    public class AwsBackupBackupPlanRuleDetailsUnmarshaller : IUnmarshaller<AwsBackupBackupPlanRuleDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsBackupBackupPlanRuleDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsBackupBackupPlanRuleDetails IUnmarshaller<AwsBackupBackupPlanRuleDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsBackupBackupPlanRuleDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsBackupBackupPlanRuleDetails unmarshalledObject = new AwsBackupBackupPlanRuleDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CompletionWindowMinutes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.CompletionWindowMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CopyActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsBackupBackupPlanRuleCopyActionsDetails, AwsBackupBackupPlanRuleCopyActionsDetailsUnmarshaller>(AwsBackupBackupPlanRuleCopyActionsDetailsUnmarshaller.Instance);
                    unmarshalledObject.CopyActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableContinuousBackup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableContinuousBackup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Lifecycle", targetDepth))
                {
                    var unmarshaller = AwsBackupBackupPlanLifecycleDetailsUnmarshaller.Instance;
                    unmarshalledObject.Lifecycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartWindowMinutes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StartWindowMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetBackupVault", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetBackupVault = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsBackupBackupPlanRuleDetailsUnmarshaller _instance = new AwsBackupBackupPlanRuleDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsBackupBackupPlanRuleDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}