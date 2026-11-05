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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the GetCapacityManagerSupportabilityScores operation.
    /// Scores how well each instance type and Availability Zone combination can support
    /// a capacity request, based on current Amazon EC2 capacity. The response includes a
    /// score for each combination and an aggregate score for all combinations in the request.
    /// This action doesn't launch or reserve instances, and a score doesn't guarantee that
    /// a later launch will succeed. 
    /// 
    ///  
    /// <para>
    ///  Call this action in the Region where you turned on Capacity Manager. A single request
    /// can include Availability Zones in any Region. Real-time supportability checks are
    /// available only to Amazon Web Services Support customers on the Unified Operations
    /// plan. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/capacity-manager-supportability.html">Check
    /// supportability</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetCapacityManagerSupportabilityScoresRequest : AmazonEC2Request
    {
        private int? _capacityAmount;
        private List<string> _capacityAvailabilityZoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CapacityUnit _capacityUnit;
        private bool? _dryRun;
        private InstanceRequirementsWithMetadataRequest _instanceRequirementsWithMetadata;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SupportabilityMarketType _marketType;

        /// <summary>
        /// Gets and sets the property CapacityAmount. 
        /// <para>
        ///  The amount of capacity that you need, in the unit that you specify for <c>CapacityUnit</c>.
        /// Each score is relative to this amount. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? CapacityAmount
        {
            get { return this._capacityAmount; }
            set { this._capacityAmount = value; }
        }

        // Check to see if CapacityAmount property is set
        internal bool IsSetCapacityAmount()
        {
            return this._capacityAmount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityAvailabilityZoneIds. 
        /// <para>
        ///  The IDs of the Availability Zones to score, such as <c>use1-az1</c>. You can specify
        /// Availability Zones in different Regions. You can specify up to 10 Availability Zones.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> CapacityAvailabilityZoneIds
        {
            get { return this._capacityAvailabilityZoneIds; }
            set { this._capacityAvailabilityZoneIds = value; }
        }

        // Check to see if CapacityAvailabilityZoneIds property is set
        internal bool IsSetCapacityAvailabilityZoneIds()
        {
            return this._capacityAvailabilityZoneIds != null && (this._capacityAvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityUnit. 
        /// <para>
        ///  The unit for <c>CapacityAmount</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityUnit CapacityUnit
        {
            get { return this._capacityUnit; }
            set { this._capacityUnit = value; }
        }

        // Check to see if CapacityUnit property is set
        internal bool IsSetCapacityUnit()
        {
            return this._capacityUnit != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        ///  Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirementsWithMetadata. 
        /// <para>
        ///  The attributes that the instance types must have, such as vCPU and memory ranges.
        /// Capacity Manager resolves the attributes into matching instance types and scores each
        /// one. 
        /// </para>
        ///  
        /// <para>
        ///  Specify either <c>InstanceTypes</c> or <c>InstanceRequirementsWithMetadata</c>, but
        /// not both. 
        /// </para>
        /// </summary>
        public InstanceRequirementsWithMetadataRequest InstanceRequirementsWithMetadata
        {
            get { return this._instanceRequirementsWithMetadata; }
            set { this._instanceRequirementsWithMetadata = value; }
        }

        // Check to see if InstanceRequirementsWithMetadata property is set
        internal bool IsSetInstanceRequirementsWithMetadata()
        {
            return this._instanceRequirementsWithMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        ///  The instance types to score. You can specify up to 50 instance types. 
        /// </para>
        ///  
        /// <para>
        ///  Specify either <c>InstanceTypes</c> or <c>InstanceRequirementsWithMetadata</c>, but
        /// not both. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MarketType. 
        /// <para>
        ///  The capacity market to score. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportabilityMarketType MarketType
        {
            get { return this._marketType; }
            set { this._marketType = value; }
        }

        // Check to see if MarketType property is set
        internal bool IsSetMarketType()
        {
            return this._marketType != null;
        }

    }
}