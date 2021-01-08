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
using ThirdParty.Json.LitJson;

namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssessmentEvidenceFolder Object
    /// </summary>  
    public class AssessmentEvidenceFolderUnmarshaller : IUnmarshaller<AssessmentEvidenceFolder, XmlUnmarshallerContext>, IUnmarshaller<AssessmentEvidenceFolder, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssessmentEvidenceFolder IUnmarshaller<AssessmentEvidenceFolder, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssessmentEvidenceFolder Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssessmentEvidenceFolder unmarshalledObject = new AssessmentEvidenceFolder();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("assessmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assessmentReportSelectionCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AssessmentReportSelectionCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("author", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Author = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("controlId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ControlId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("controlName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ControlName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("controlSetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ControlSetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("date", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Date = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceAwsServiceSourceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceAwsServiceSourceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceByTypeComplianceCheckCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceByTypeComplianceCheckCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceByTypeComplianceCheckIssuesCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceByTypeComplianceCheckIssuesCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceByTypeConfigurationDataCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceByTypeConfigurationDataCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceByTypeManualCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceByTypeManualCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceByTypeUserActivityCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceByTypeUserActivityCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidenceResourcesIncludedCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvidenceResourcesIncludedCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalEvidence", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalEvidence = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssessmentEvidenceFolderUnmarshaller _instance = new AssessmentEvidenceFolderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssessmentEvidenceFolderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}