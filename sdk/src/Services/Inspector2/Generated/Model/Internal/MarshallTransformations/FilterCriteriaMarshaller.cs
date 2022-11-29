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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("awsAccountId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAwsAccountIdListValue in requestObject.AwsAccountId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAwsAccountIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComponentId())
            {
                context.Writer.WritePropertyName("componentId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComponentIdListValue in requestObject.ComponentId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComponentType())
            {
                context.Writer.WritePropertyName("componentType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComponentTypeListValue in requestObject.ComponentType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEc2InstanceImageId())
            {
                context.Writer.WritePropertyName("ec2InstanceImageId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2InstanceImageIdListValue in requestObject.Ec2InstanceImageId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceImageIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEc2InstanceSubnetId())
            {
                context.Writer.WritePropertyName("ec2InstanceSubnetId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2InstanceSubnetIdListValue in requestObject.Ec2InstanceSubnetId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceSubnetIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEc2InstanceVpcId())
            {
                context.Writer.WritePropertyName("ec2InstanceVpcId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2InstanceVpcIdListValue in requestObject.Ec2InstanceVpcId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceVpcIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImageArchitecture())
            {
                context.Writer.WritePropertyName("ecrImageArchitecture");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImageArchitectureListValue in requestObject.EcrImageArchitecture)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageArchitectureListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImageHash())
            {
                context.Writer.WritePropertyName("ecrImageHash");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImageHashListValue in requestObject.EcrImageHash)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageHashListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImagePushedAt())
            {
                context.Writer.WritePropertyName("ecrImagePushedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImagePushedAtListValue in requestObject.EcrImagePushedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImagePushedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImageRegistry())
            {
                context.Writer.WritePropertyName("ecrImageRegistry");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImageRegistryListValue in requestObject.EcrImageRegistry)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageRegistryListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImageRepositoryName())
            {
                context.Writer.WritePropertyName("ecrImageRepositoryName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImageRepositoryNameListValue in requestObject.EcrImageRepositoryName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageRepositoryNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImageTags())
            {
                context.Writer.WritePropertyName("ecrImageTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImageTagsListValue in requestObject.EcrImageTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExploitAvailable())
            {
                context.Writer.WritePropertyName("exploitAvailable");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExploitAvailableListValue in requestObject.ExploitAvailable)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectExploitAvailableListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingArn())
            {
                context.Writer.WritePropertyName("findingArn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingArnListValue in requestObject.FindingArn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingArnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingStatus())
            {
                context.Writer.WritePropertyName("findingStatus");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingStatusListValue in requestObject.FindingStatus)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingStatusListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingType())
            {
                context.Writer.WritePropertyName("findingType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingTypeListValue in requestObject.FindingType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFirstObservedAt())
            {
                context.Writer.WritePropertyName("firstObservedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFirstObservedAtListValue in requestObject.FirstObservedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirstObservedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFixAvailable())
            {
                context.Writer.WritePropertyName("fixAvailable");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFixAvailableListValue in requestObject.FixAvailable)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFixAvailableListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInspectorScore())
            {
                context.Writer.WritePropertyName("inspectorScore");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInspectorScoreListValue in requestObject.InspectorScore)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectInspectorScoreListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionExecutionRoleArn())
            {
                context.Writer.WritePropertyName("lambdaFunctionExecutionRoleArn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionExecutionRoleArnListValue in requestObject.LambdaFunctionExecutionRoleArn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionExecutionRoleArnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionLastModifiedAt())
            {
                context.Writer.WritePropertyName("lambdaFunctionLastModifiedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionLastModifiedAtListValue in requestObject.LambdaFunctionLastModifiedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionLastModifiedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionLayers())
            {
                context.Writer.WritePropertyName("lambdaFunctionLayers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionLayersListValue in requestObject.LambdaFunctionLayers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionLayersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionName())
            {
                context.Writer.WritePropertyName("lambdaFunctionName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionNameListValue in requestObject.LambdaFunctionName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionRuntime())
            {
                context.Writer.WritePropertyName("lambdaFunctionRuntime");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionRuntimeListValue in requestObject.LambdaFunctionRuntime)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionRuntimeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("lastObservedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastObservedAtListValue in requestObject.LastObservedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastObservedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkProtocol())
            {
                context.Writer.WritePropertyName("networkProtocol");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkProtocolListValue in requestObject.NetworkProtocol)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkProtocolListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPortRange())
            {
                context.Writer.WritePropertyName("portRange");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPortRangeListValue in requestObject.PortRange)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PortRangeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectPortRangeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRelatedVulnerabilities())
            {
                context.Writer.WritePropertyName("relatedVulnerabilities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedVulnerabilitiesListValue in requestObject.RelatedVulnerabilities)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedVulnerabilitiesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("resourceTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("severity");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSeverityListValue in requestObject.Severity)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTitleListValue in requestObject.Title)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTitleListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUpdatedAtListValue in requestObject.UpdatedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectUpdatedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVendorSeverity())
            {
                context.Writer.WritePropertyName("vendorSeverity");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVendorSeverityListValue in requestObject.VendorSeverity)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVendorSeverityListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVulnerabilityId())
            {
                context.Writer.WritePropertyName("vulnerabilityId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVulnerabilityIdListValue in requestObject.VulnerabilityId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilityIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVulnerabilitySource())
            {
                context.Writer.WritePropertyName("vulnerabilitySource");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVulnerabilitySourceListValue in requestObject.VulnerabilitySource)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilitySourceListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVulnerablePackages())
            {
                context.Writer.WritePropertyName("vulnerablePackages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVulnerablePackagesListValue in requestObject.VulnerablePackages)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PackageFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerablePackagesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterCriteriaMarshaller Instance = new FilterCriteriaMarshaller();

    }
}