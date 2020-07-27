/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for ReplicationTaskAssessmentRun Object
    /// </summary>  
    public class ReplicationTaskAssessmentRunUnmarshaller : IUnmarshaller<ReplicationTaskAssessmentRun, XmlUnmarshallerContext>, IUnmarshaller<ReplicationTaskAssessmentRun, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReplicationTaskAssessmentRun IUnmarshaller<ReplicationTaskAssessmentRun, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReplicationTaskAssessmentRun Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReplicationTaskAssessmentRun unmarshalledObject = new ReplicationTaskAssessmentRun();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssessmentProgress", targetDepth))
                {
                    var unmarshaller = ReplicationTaskAssessmentRunProgressUnmarshaller.Instance;
                    unmarshalledObject.AssessmentProgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssessmentRunName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentRunName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastFailureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastFailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskAssessmentRunArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskAssessmentRunArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskAssessmentRunCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskAssessmentRunCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultEncryptionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultEncryptionMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultKmsKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultKmsKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultLocationBucket", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultLocationBucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultLocationFolder", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultLocationFolder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceAccessRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReplicationTaskAssessmentRunUnmarshaller _instance = new ReplicationTaskAssessmentRunUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationTaskAssessmentRunUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}