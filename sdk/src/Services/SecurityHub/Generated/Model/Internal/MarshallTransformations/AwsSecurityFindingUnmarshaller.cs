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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsSecurityFinding Object
    /// </summary>  
    public class AwsSecurityFindingUnmarshaller : IJsonUnmarshaller<AwsSecurityFinding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsSecurityFinding Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsSecurityFinding unmarshalledObject = new AwsSecurityFinding();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Action", targetDepth))
                {
                    var unmarshaller = ActionUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAccountName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsAccountName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CompanyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompanyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Compliance", targetDepth))
                {
                    var unmarshaller = ComplianceUnmarshaller.Instance;
                    unmarshalledObject.Compliance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Criticality", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Criticality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Detection", targetDepth))
                {
                    var unmarshaller = DetectionUnmarshaller.Instance;
                    unmarshalledObject.Detection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFields", targetDepth))
                {
                    var unmarshaller = FindingProviderFieldsUnmarshaller.Instance;
                    unmarshalledObject.FindingProviderFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirstObservedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirstObservedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GeneratorDetails", targetDepth))
                {
                    var unmarshaller = GeneratorDetailsUnmarshaller.Instance;
                    unmarshalledObject.GeneratorDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GeneratorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GeneratorId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastObservedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Malware", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Malware, MalwareUnmarshaller>(MalwareUnmarshaller.Instance);
                    unmarshalledObject.Malware = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Network", targetDepth))
                {
                    var unmarshaller = NetworkUnmarshaller.Instance;
                    unmarshalledObject.Network = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkPath", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<NetworkPathComponent, NetworkPathComponentUnmarshaller>(NetworkPathComponentUnmarshaller.Instance);
                    unmarshalledObject.NetworkPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Note", targetDepth))
                {
                    var unmarshaller = NoteUnmarshaller.Instance;
                    unmarshalledObject.Note = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PatchSummary", targetDepth))
                {
                    var unmarshaller = PatchSummaryUnmarshaller.Instance;
                    unmarshalledObject.PatchSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Process", targetDepth))
                {
                    var unmarshaller = ProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.Process = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProcessedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProductArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProductFields", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.ProductFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProductName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecordState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedFindings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RelatedFinding, RelatedFindingUnmarshaller>(RelatedFindingUnmarshaller.Instance);
                    unmarshalledObject.RelatedFindings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Remediation", targetDepth))
                {
                    var unmarshaller = RemediationUnmarshaller.Instance;
                    unmarshalledObject.Remediation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Resources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Resource, ResourceUnmarshaller>(ResourceUnmarshaller.Instance);
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sample", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Sample = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SchemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Severity", targetDepth))
                {
                    var unmarshaller = SeverityUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicators", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ThreatIntelIndicator, ThreatIntelIndicatorUnmarshaller>(ThreatIntelIndicatorUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicators = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Threats", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Threat, ThreatUnmarshaller>(ThreatUnmarshaller.Instance);
                    unmarshalledObject.Threats = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Types", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Types = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UserDefinedFields", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.UserDefinedFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VerificationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VerificationState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Vulnerabilities", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Vulnerability, VulnerabilityUnmarshaller>(VulnerabilityUnmarshaller.Instance);
                    unmarshalledObject.Vulnerabilities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Workflow", targetDepth))
                {
                    var unmarshaller = WorkflowUnmarshaller.Instance;
                    unmarshalledObject.Workflow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkflowState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkflowState = unmarshaller.Unmarshall(context, ref reader);
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