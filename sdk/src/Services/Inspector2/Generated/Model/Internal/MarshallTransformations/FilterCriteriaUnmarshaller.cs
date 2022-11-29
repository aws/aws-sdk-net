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
using System.Net;
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
    /// Response Unmarshaller for FilterCriteria Object
    /// </summary>  
    public class FilterCriteriaUnmarshaller : IUnmarshaller<FilterCriteria, XmlUnmarshallerContext>, IUnmarshaller<FilterCriteria, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FilterCriteria IUnmarshaller<FilterCriteria, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FilterCriteria Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FilterCriteria unmarshalledObject = new FilterCriteria();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("awsAccountId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("componentId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComponentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("componentType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ComponentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceImageId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Ec2InstanceImageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceSubnetId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Ec2InstanceSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceVpcId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Ec2InstanceVpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrImageArchitecture", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImageArchitecture = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrImageHash", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImageHash = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrImagePushedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImagePushedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrImageRegistry", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImageRegistry = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrImageRepositoryName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImageRepositoryName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrImageTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImageTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exploitAvailable", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ExploitAvailable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingStatus", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FindingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstObservedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.FirstObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fixAvailable", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.FixAvailable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inspectorScore", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NumberFilter, NumberFilterUnmarshaller>(NumberFilterUnmarshaller.Instance);
                    unmarshalledObject.InspectorScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionExecutionRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionLastModifiedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionLastModifiedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionLayers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionLayers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionName", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionRuntime", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionRuntime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastObservedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkProtocol", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.NetworkProtocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portRange", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PortRangeFilter, PortRangeFilterUnmarshaller>(PortRangeFilterUnmarshaller.Instance);
                    unmarshalledObject.PortRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relatedVulnerabilities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.RelatedVulnerabilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MapFilter, MapFilterUnmarshaller>(MapFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("severity", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("title", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateFilter, DateFilterUnmarshaller>(DateFilterUnmarshaller.Instance);
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vendorSeverity", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VendorSeverity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vulnerabilityId", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VulnerabilityId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vulnerabilitySource", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringFilter, StringFilterUnmarshaller>(StringFilterUnmarshaller.Instance);
                    unmarshalledObject.VulnerabilitySource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vulnerablePackages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PackageFilter, PackageFilterUnmarshaller>(PackageFilterUnmarshaller.Instance);
                    unmarshalledObject.VulnerablePackages = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FilterCriteriaUnmarshaller _instance = new FilterCriteriaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FilterCriteriaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}