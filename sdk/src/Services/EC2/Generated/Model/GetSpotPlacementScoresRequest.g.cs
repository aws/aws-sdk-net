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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetSpotPlacementScores operation. Calculates the
    /// Spot placement score for a Region or Availability Zone based on the specified target
    /// capacity and compute requirements. <para> You can specify your compute requirements
    /// either by using <c>InstanceRequirementsWithMetadata</c> and letting Amazon EC2 choose
    /// the optimal instance types to fulfill your Spot request, or you can specify the instance
    /// types by using <c>InstanceTypes</c>. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
    /// placement score</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class GetSpotPlacementScoresRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeLocalZones. 
        /// <para>
        /// Specify <c>true</c> so that the response returns scores that include Local Zones.
        /// Otherwise, the response ignores Local Zones.
        /// </para>
        ///  
        /// <para>
        /// When you request regional scores, Local Zone capacity counts toward its parent Region.
        /// </para>
        /// </summary>
        public bool? IncludeLocalZones { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLocalZones property is set.
        /// </summary>
        internal bool IsSetIncludeLocalZones() => this.IncludeLocalZones.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceRequirementsWithMetadata. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with those attributes.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>InstanceRequirementsWithMetadata</c>, you can't specify <c>InstanceTypes</c>.
        /// </para>
        /// </summary>
        public InstanceRequirementsWithMetadataRequest InstanceRequirementsWithMetadata { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirementsWithMetadata property is set.
        /// </summary>
        internal bool IsSetInstanceRequirementsWithMetadata() => this.InstanceRequirementsWithMetadata != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types. We recommend that you specify at least three instance types. If
        /// you specify one or two instance types, or specify variations of a single instance
        /// type (for example, an <c>m3.xlarge</c> with and without instance storage), the returned
        /// placement score will always be low. 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>InstanceTypes</c>, you can't specify <c>InstanceRequirementsWithMetadata</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The Regions used to narrow down the list of Regions to be scored. Enter the Region
        /// code, for example, <c>us-east-1</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> RegionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegionNames property is set.
        /// </summary>
        internal bool IsSetRegionNames() => this.RegionNames != null && (this.RegionNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SingleAvailabilityZone. 
        /// <para>
        /// Specify <c>true</c> so that the response returns a list of scored Availability Zones.
        /// Otherwise, the response returns a list of scored Regions.
        /// </para>
        ///  
        /// <para>
        /// A list of scored Availability Zones is useful if you want to launch all of your Spot
        /// capacity into a single Availability Zone.
        /// </para>
        /// </summary>
        public bool? SingleAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SingleAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSingleAvailabilityZone() => this.SingleAvailabilityZone.HasValue;

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The target capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000000000)]
        public int? TargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TargetCapacity property is set.
        /// </summary>
        internal bool IsSetTargetCapacity() => this.TargetCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property TargetCapacityUnitType. 
        /// <para>
        /// The unit for the target capacity.
        /// </para>
        /// </summary>
        public TargetCapacityUnitType TargetCapacityUnitType { get; set; }

        /// <summary>
        /// Checks to see if the TargetCapacityUnitType property is set.
        /// </summary>
        internal bool IsSetTargetCapacityUnitType() => this.TargetCapacityUnitType != null;
    }
}
