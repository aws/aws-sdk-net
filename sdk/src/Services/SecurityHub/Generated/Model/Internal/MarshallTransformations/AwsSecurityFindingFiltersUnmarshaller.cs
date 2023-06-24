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
    /// Response Unmarshaller for AwsSecurityFindingFilters Object
    /// </summary>  
    public class AwsSecurityFindingFiltersUnmarshaller : IUnmarshaller<AwsSecurityFindingFilters, XmlUnmarshallerContext>, IUnmarshaller<AwsSecurityFindingFilters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsSecurityFindingFilters IUnmarshaller<AwsSecurityFindingFilters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsSecurityFindingFilters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsSecurityFindingFilters unmarshalledObject = new AwsSecurityFindingFilters();
        
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
                if (context.TestExpression("FindingProviderFieldsConfidence", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsConfidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsCriticality", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsCriticality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsRelatedFindingsId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsRelatedFindingsId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsRelatedFindingsProductArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsRelatedFindingsProductArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsSeverityLabel", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsSeverityLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsSeverityOriginal", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsSeverityOriginal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingProviderFieldsTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingProviderFieldsTypes = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("Keyword", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeywordFilter, KeywordFilterUnmarshaller>(KeywordFilterUnmarshaller.Instance);
                    unmarshalledObject.Keyword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastObservedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MalwareName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwareName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MalwarePath", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwarePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MalwareState", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwareState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MalwareType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.MalwareType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationDomain", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationIpV4", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationIpV4 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationIpV6", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationIpV6 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkDestinationPort", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDestinationPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkDirection", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkDirection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkProtocol", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkProtocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkSourceDomain", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkSourceIpV4", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceIpV4 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkSourceIpV6", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceIpV6 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkSourceMac", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourceMac = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkSourcePort", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkSourcePort = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("ProcessLaunchedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessLaunchedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessParentPid", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessParentPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessPath", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessPid", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessTerminatedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ProcessTerminatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ProductName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecommendationText", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RecommendationText = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordState", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RecordState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("ResourceAwsEc2InstanceIamInstanceProfileArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceIamInstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceImageId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceImageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceIpV4Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceIpV4Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceIpV6Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpFilter, IpFilterUnmarshaller>(IpFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceIpV6Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceKeyName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceKeyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceLaunchedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceLaunchedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceSubnetId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsEc2InstanceVpcId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsEc2InstanceVpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyCreatedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyCreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyPrincipalName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyPrincipalName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyStatus", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamAccessKeyUserName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamAccessKeyUserName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsIamUserUserName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsIamUserUserName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsS3BucketOwnerId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsS3BucketOwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAwsS3BucketOwnerName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceAwsS3BucketOwnerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceContainerImageId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerImageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceContainerImageName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerImageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceContainerLaunchedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerLaunchedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceContainerName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceContainerName = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("Sample", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BooleanFilter, BooleanFilterUnmarshaller>(BooleanFilterUnmarshaller.Instance);
                    unmarshalledObject.Sample = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SeverityLabel", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SeverityNormalized", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityNormalized = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SeverityProduct", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.SeverityProduct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceUrl", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.SourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorCategory", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorCategory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorLastObservedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorLastObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorSource", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorSourceUrl", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorSourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreatIntelIndicatorValue", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ThreatIntelIndicatorValue = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("WorkflowState", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.WorkflowState = unmarshaller.Unmarshall(context);
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