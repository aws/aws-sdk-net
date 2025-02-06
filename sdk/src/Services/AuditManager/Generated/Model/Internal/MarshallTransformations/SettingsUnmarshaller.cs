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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Settings Object
    /// </summary>  
    public class SettingsUnmarshaller : IJsonUnmarshaller<Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Settings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Settings unmarshalledObject = new Settings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("defaultAssessmentReportsDestination", targetDepth))
                {
                    var unmarshaller = AssessmentReportsDestinationUnmarshaller.Instance;
                    unmarshalledObject.DefaultAssessmentReportsDestination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("defaultExportDestination", targetDepth))
                {
                    var unmarshaller = DefaultExportDestinationUnmarshaller.Instance;
                    unmarshalledObject.DefaultExportDestination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("defaultProcessOwners", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Role, RoleUnmarshaller>(RoleUnmarshaller.Instance);
                    unmarshalledObject.DefaultProcessOwners = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deregistrationPolicy", targetDepth))
                {
                    var unmarshaller = DeregistrationPolicyUnmarshaller.Instance;
                    unmarshalledObject.DeregistrationPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("evidenceFinderEnablement", targetDepth))
                {
                    var unmarshaller = EvidenceFinderEnablementUnmarshaller.Instance;
                    unmarshalledObject.EvidenceFinderEnablement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isAwsOrgEnabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsAwsOrgEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kmsKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("snsTopic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnsTopic = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SettingsUnmarshaller _instance = new SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}