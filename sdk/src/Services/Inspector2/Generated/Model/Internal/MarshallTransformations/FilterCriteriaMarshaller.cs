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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FilterCriteria Marshaller
    /// </summary>
    public class FilterCriteriaMarshaller : IRequestMarshaller<FilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("awsAccountId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAwsAccountIdListValue in requestObject.AwsAccountId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAwsAccountIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeRepositoryProjectName())
            {
                context.Writer.WritePropertyName("codeRepositoryProjectName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeRepositoryProjectNameListValue in requestObject.CodeRepositoryProjectName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeRepositoryProjectNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeRepositoryProviderType())
            {
                context.Writer.WritePropertyName("codeRepositoryProviderType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeRepositoryProviderTypeListValue in requestObject.CodeRepositoryProviderType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeRepositoryProviderTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeVulnerabilityDetectorName())
            {
                context.Writer.WritePropertyName("codeVulnerabilityDetectorName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeVulnerabilityDetectorNameListValue in requestObject.CodeVulnerabilityDetectorName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeVulnerabilityDetectorNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeVulnerabilityDetectorTags())
            {
                context.Writer.WritePropertyName("codeVulnerabilityDetectorTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeVulnerabilityDetectorTagsListValue in requestObject.CodeVulnerabilityDetectorTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeVulnerabilityDetectorTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeVulnerabilityFilePath())
            {
                context.Writer.WritePropertyName("codeVulnerabilityFilePath");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeVulnerabilityFilePathListValue in requestObject.CodeVulnerabilityFilePath)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeVulnerabilityFilePathListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComponentId())
            {
                context.Writer.WritePropertyName("componentId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComponentIdListValue in requestObject.ComponentId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComponentType())
            {
                context.Writer.WritePropertyName("componentType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComponentTypeListValue in requestObject.ComponentType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2InstanceImageId())
            {
                context.Writer.WritePropertyName("ec2InstanceImageId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2InstanceImageIdListValue in requestObject.Ec2InstanceImageId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceImageIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2InstanceSubnetId())
            {
                context.Writer.WritePropertyName("ec2InstanceSubnetId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2InstanceSubnetIdListValue in requestObject.Ec2InstanceSubnetId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceSubnetIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2InstanceVpcId())
            {
                context.Writer.WritePropertyName("ec2InstanceVpcId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2InstanceVpcIdListValue in requestObject.Ec2InstanceVpcId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceVpcIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageArchitecture())
            {
                context.Writer.WritePropertyName("ecrImageArchitecture");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageArchitectureListValue in requestObject.EcrImageArchitecture)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageArchitectureListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageHash())
            {
                context.Writer.WritePropertyName("ecrImageHash");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageHashListValue in requestObject.EcrImageHash)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageHashListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageInUseCount())
            {
                context.Writer.WritePropertyName("ecrImageInUseCount");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageInUseCountListValue in requestObject.EcrImageInUseCount)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageInUseCountListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageLastInUseAt())
            {
                context.Writer.WritePropertyName("ecrImageLastInUseAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageLastInUseAtListValue in requestObject.EcrImageLastInUseAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageLastInUseAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImagePushedAt())
            {
                context.Writer.WritePropertyName("ecrImagePushedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImagePushedAtListValue in requestObject.EcrImagePushedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImagePushedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageRegistry())
            {
                context.Writer.WritePropertyName("ecrImageRegistry");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageRegistryListValue in requestObject.EcrImageRegistry)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageRegistryListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageRepositoryName())
            {
                context.Writer.WritePropertyName("ecrImageRepositoryName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageRepositoryNameListValue in requestObject.EcrImageRepositoryName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageRepositoryNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageTags())
            {
                context.Writer.WritePropertyName("ecrImageTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageTagsListValue in requestObject.EcrImageTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEpssScore())
            {
                context.Writer.WritePropertyName("epssScore");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEpssScoreListValue in requestObject.EpssScore)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEpssScoreListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExploitAvailable())
            {
                context.Writer.WritePropertyName("exploitAvailable");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExploitAvailableListValue in requestObject.ExploitAvailable)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectExploitAvailableListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingArn())
            {
                context.Writer.WritePropertyName("findingArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingArnListValue in requestObject.FindingArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingStatus())
            {
                context.Writer.WritePropertyName("findingStatus");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingStatusListValue in requestObject.FindingStatus)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingStatusListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingType())
            {
                context.Writer.WritePropertyName("findingType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingTypeListValue in requestObject.FindingType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFirstObservedAt())
            {
                context.Writer.WritePropertyName("firstObservedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFirstObservedAtListValue in requestObject.FirstObservedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirstObservedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFixAvailable())
            {
                context.Writer.WritePropertyName("fixAvailable");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFixAvailableListValue in requestObject.FixAvailable)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFixAvailableListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInspectorScore())
            {
                context.Writer.WritePropertyName("inspectorScore");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInspectorScoreListValue in requestObject.InspectorScore)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectInspectorScoreListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionExecutionRoleArn())
            {
                context.Writer.WritePropertyName("lambdaFunctionExecutionRoleArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionExecutionRoleArnListValue in requestObject.LambdaFunctionExecutionRoleArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionExecutionRoleArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionLastModifiedAt())
            {
                context.Writer.WritePropertyName("lambdaFunctionLastModifiedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionLastModifiedAtListValue in requestObject.LambdaFunctionLastModifiedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionLastModifiedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionLayers())
            {
                context.Writer.WritePropertyName("lambdaFunctionLayers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionLayersListValue in requestObject.LambdaFunctionLayers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionLayersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionName())
            {
                context.Writer.WritePropertyName("lambdaFunctionName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionNameListValue in requestObject.LambdaFunctionName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionRuntime())
            {
                context.Writer.WritePropertyName("lambdaFunctionRuntime");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionRuntimeListValue in requestObject.LambdaFunctionRuntime)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionRuntimeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("lastObservedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastObservedAtListValue in requestObject.LastObservedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastObservedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkProtocol())
            {
                context.Writer.WritePropertyName("networkProtocol");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkProtocolListValue in requestObject.NetworkProtocol)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkProtocolListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPortRange())
            {
                context.Writer.WritePropertyName("portRange");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPortRangeListValue in requestObject.PortRange)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PortRangeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortRangeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRelatedVulnerabilities())
            {
                context.Writer.WritePropertyName("relatedVulnerabilities");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRelatedVulnerabilitiesListValue in requestObject.RelatedVulnerabilities)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedVulnerabilitiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("resourceTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("severity");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSeverityListValue in requestObject.Severity)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTitleListValue in requestObject.Title)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTitleListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUpdatedAtListValue in requestObject.UpdatedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectUpdatedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVendorSeverity())
            {
                context.Writer.WritePropertyName("vendorSeverity");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVendorSeverityListValue in requestObject.VendorSeverity)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVendorSeverityListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVulnerabilityId())
            {
                context.Writer.WritePropertyName("vulnerabilityId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVulnerabilityIdListValue in requestObject.VulnerabilityId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilityIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVulnerabilitySource())
            {
                context.Writer.WritePropertyName("vulnerabilitySource");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVulnerabilitySourceListValue in requestObject.VulnerabilitySource)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilitySourceListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVulnerablePackages())
            {
                context.Writer.WritePropertyName("vulnerablePackages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVulnerablePackagesListValue in requestObject.VulnerablePackages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PackageFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerablePackagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterCriteriaMarshaller Instance = new FilterCriteriaMarshaller();

    }
}