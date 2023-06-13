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
    /// Response Unmarshaller for AutomationRulesFindingFilters Object
    /// </summary>  
    public class AutomationRulesFindingFiltersUnmarshaller : IUnmarshaller<AutomationRulesFindingFilters, XmlUnmarshallerContext>, IUnmarshaller<AutomationRulesFindingFilters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomationRulesFindingFilters IUnmarshaller<AutomationRulesFindingFilters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AutomationRulesFindingFilters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AutomationRulesFindingFilters unmarshalledObject = new AutomationRulesFindingFilters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AwsAccountId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompanyName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.CompanyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComplianceAssociatedStandardsId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceAssociatedStandardsId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComplianceSecurityControlId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceSecurityControlId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComplianceStatus", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Criticality", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.Criticality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstObservedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.FirstObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeneratorId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.GeneratorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastObservedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoteText", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NoteText = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoteUpdatedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.NoteUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoteUpdatedBy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NoteUpdatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordState", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RecordState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedFindingsId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RelatedFindingsId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedFindingsProductArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RelatedFindingsProductArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceDetailsOther", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceDetailsOther = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourcePartition", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourcePartition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceRegion", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SeverityLabel", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceUrl", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.SourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserDefinedFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.UserDefinedFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerificationState", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VerificationState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkflowStatus", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.WorkflowStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AutomationRulesFindingFiltersUnmarshaller _instance = new AutomationRulesFindingFiltersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomationRulesFindingFiltersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}