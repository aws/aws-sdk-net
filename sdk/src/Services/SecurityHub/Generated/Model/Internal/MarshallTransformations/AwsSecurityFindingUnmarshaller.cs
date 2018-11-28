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
    /// Response Unmarshaller for AwsSecurityFinding Object
    /// </summary>  
    public class AwsSecurityFindingUnmarshaller : IUnmarshaller<AwsSecurityFinding, XmlUnmarshallerContext>, IUnmarshaller<AwsSecurityFinding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsSecurityFinding IUnmarshaller<AwsSecurityFinding, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsSecurityFinding Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsSecurityFinding unmarshalledObject = new AwsSecurityFinding();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AwsAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Compliance", targetDepth))
                {
                    var unmarshaller = ComplianceUnmarshaller.Instance;
                    unmarshalledObject.Compliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Criticality", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Criticality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstObservedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirstObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeneratorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GeneratorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastObservedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Malware", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Malware, MalwareUnmarshaller>(MalwareUnmarshaller.Instance);
                    unmarshalledObject.Malware = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Network", targetDepth))
                {
                    var unmarshaller = NetworkUnmarshaller.Instance;
                    unmarshalledObject.Network = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Note", targetDepth))
                {
                    var unmarshaller = NoteUnmarshaller.Instance;
                    unmarshalledObject.Note = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Process", targetDepth))
                {
                    var unmarshaller = ProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.Process = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductFields", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.ProductFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedFindings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RelatedFinding, RelatedFindingUnmarshaller>(RelatedFindingUnmarshaller.Instance);
                    unmarshalledObject.RelatedFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Remediation", targetDepth))
                {
                    var unmarshaller = RemediationUnmarshaller.Instance;
                    unmarshalledObject.Remediation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Resources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Resource, ResourceUnmarshaller>(ResourceUnmarshaller.Instance);
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Severity", targetDepth))
                {
                    var unmarshaller = SeverityUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicators", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ThreatIntelIndicator, ThreatIntelIndicatorUnmarshaller>(ThreatIntelIndicatorUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicators = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Types", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Types = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserDefinedFields", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.UserDefinedFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerificationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VerificationState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkflowState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkflowState = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsSecurityFindingUnmarshaller _instance = new AwsSecurityFindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsSecurityFindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}