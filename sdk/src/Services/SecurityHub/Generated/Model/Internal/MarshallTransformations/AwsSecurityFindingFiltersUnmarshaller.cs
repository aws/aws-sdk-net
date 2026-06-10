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
    /// Response Unmarshaller for AwsSecurityFindingFilters Object
    /// </summary>  
    public class AwsSecurityFindingFiltersUnmarshaller : IJsonUnmarshaller<AwsSecurityFindingFilters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsSecurityFindingFilters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsSecurityFindingFilters unmarshalledObject = new AwsSecurityFindingFilters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AwsAccountId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAccountName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.AwsAccountName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CompanyName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.CompanyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComplianceAssociatedStandardsId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceAssociatedStandardsId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComplianceSecurityControlId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceSecurityControlId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComplianceSecurityControlParametersName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceSecurityControlParametersName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComplianceSecurityControlParametersValue", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceSecurityControlParametersValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComplianceStatus", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComplianceStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Criticality", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.Criticality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsConfidence", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsConfidence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsCriticality", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsCriticality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsRelatedFindingsId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsRelatedFindingsId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsRelatedFindingsProductArn", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsRelatedFindingsProductArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsSeverityLabel", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsSeverityLabel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsSeverityOriginal", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsSeverityOriginal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsTypes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirstObservedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.FirstObservedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GeneratorId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.GeneratorId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Keyword", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<KeywordFilter, KeywordFilterUnmarshaller>(KeywordFilterUnmarshaller.Instance);
                    unmarshalledObject.Keyword = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastObservedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MalwareName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwareName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MalwarePath", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwarePath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MalwareState", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwareState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MalwareType", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwareType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationDomain", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationDomain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationIpV4", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationIpV4 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationIpV6", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationIpV6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationPort", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkDirection", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDirection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkProtocol", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkProtocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkSourceDomain", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceDomain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkSourceIpV4", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceIpV4 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkSourceIpV6", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceIpV6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkSourceMac", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceMac = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkSourcePort", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourcePort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NoteText", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NoteText = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NoteUpdatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.NoteUpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NoteUpdatedBy", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NoteUpdatedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessLaunchedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessLaunchedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessParentPid", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessParentPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessPath", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessPid", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessTerminatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessTerminatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProductArn", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProductFields", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProductName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecommendationText", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RecommendationText = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecordState", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RecordState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedFindingsId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RelatedFindingsId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedFindingsProductArn", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RelatedFindingsProductArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceApplicationArn", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceApplicationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceApplicationName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceApplicationName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceIamInstanceProfileArn", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceIamInstanceProfileArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceImageId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceImageId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceIpV4Addresses", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceIpV4Addresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceIpV6Addresses", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceIpV6Addresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceKeyName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceKeyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceLaunchedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceLaunchedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceSubnetId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceSubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceType", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceVpcId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceVpcId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyCreatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyCreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyPrincipalName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyPrincipalName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyStatus", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyUserName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyUserName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamUserUserName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamUserUserName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsS3BucketOwnerId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsS3BucketOwnerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAwsS3BucketOwnerName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsS3BucketOwnerName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceContainerImageId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerImageId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceContainerImageName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerImageName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceContainerLaunchedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerLaunchedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceContainerName", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceDetailsOther", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceDetailsOther = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceId", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourcePartition", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourcePartition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceRegion", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceRegion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceTags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceType", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sample", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<BooleanFilter, BooleanFilterUnmarshaller>(BooleanFilterUnmarshaller.Instance);
                    unmarshalledObject.Sample = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SeverityLabel", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityLabel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SeverityNormalized", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityNormalized = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SeverityProduct", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityProduct = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceUrl", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.SourceUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorCategory", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorCategory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorLastObservedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorLastObservedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorSource", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorSourceUrl", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorSourceUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorType", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorValue", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UserDefinedFields", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.UserDefinedFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VerificationState", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VerificationState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VulnerabilitiesExploitAvailable", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VulnerabilitiesExploitAvailable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VulnerabilitiesFixAvailable", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VulnerabilitiesFixAvailable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkflowState", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.WorkflowState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkflowStatus", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.WorkflowStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsSecurityFindingFiltersUnmarshaller _instance = new AwsSecurityFindingFiltersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsSecurityFindingFiltersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}