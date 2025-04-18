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

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PremigrationAssessmentStatus Object
    /// </summary>  
    public class PremigrationAssessmentStatusUnmarshaller : IUnmarshaller<PremigrationAssessmentStatus, XmlUnmarshallerContext>, IUnmarshaller<PremigrationAssessmentStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PremigrationAssessmentStatus IUnmarshaller<PremigrationAssessmentStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PremigrationAssessmentStatus Unmarshall(JsonUnmarshallerContext context)
        {
            PremigrationAssessmentStatus unmarshalledObject = new PremigrationAssessmentStatus();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssessmentProgress", targetDepth))
                {
                    var unmarshaller = ReplicationTaskAssessmentRunProgressUnmarshaller.Instance;
                    unmarshalledObject.AssessmentProgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailOnAssessmentFailure", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FailOnAssessmentFailure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastFailureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastFailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PremigrationAssessmentRunArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PremigrationAssessmentRunArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PremigrationAssessmentRunCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.PremigrationAssessmentRunCreationDate = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("ResultStatistic", targetDepth))
                {
                    var unmarshaller = ReplicationTaskAssessmentRunResultStatisticUnmarshaller.Instance;
                    unmarshalledObject.ResultStatistic = unmarshaller.Unmarshall(context);
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


        private static PremigrationAssessmentStatusUnmarshaller _instance = new PremigrationAssessmentStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PremigrationAssessmentStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}