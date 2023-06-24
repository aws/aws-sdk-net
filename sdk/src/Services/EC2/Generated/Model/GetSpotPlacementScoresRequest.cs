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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetSpotPlacementScores operation.
    /// Calculates the Spot placement score for a Region or Availability Zone based on the
    /// specified target capacity and compute requirements.
    /// 
    ///  
    /// <para>
    /// You can specify your compute requirements either by using <code>InstanceRequirementsWithMetadata</code>
    /// and letting Amazon EC2 choose the optimal instance types to fulfill your Spot request,
    /// or you can specify the instance types by using <code>InstanceTypes</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
    /// placement score</a> in the Amazon EC2 User Guide.
    /// </para>
    /// </summary>
    public partial class GetSpotPlacementScoresRequest : AmazonEC2Request
    {
        private InstanceRequirementsWithMetadataRequest _instanceRequirementsWithMetadata;
        private List<string> _instanceTypes = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _regionNames = new List<string>();
        private bool? _singleAvailabilityZone;
        private int? _targetCapacity;
        private TargetCapacityUnitType _targetCapacityUnitType;

        /// <summary>
        /// Gets and sets the property InstanceRequirementsWithMetadata. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with those attributes.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>InstanceRequirementsWithMetadata</code>, you can't specify <code>InstanceTypes</code>.
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
        /// The instance types. We recommend that you specify at least three instance types. If
        /// you specify one or two instance types, or specify variations of a single instance
        /// type (for example, an <code>m3.xlarge</code> with and without instance storage), the
        /// returned placement score will always be low. 
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>InstanceTypes</code>, you can't specify <code>InstanceRequirementsWithMetadata</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The Regions used to narrow down the list of Regions to be scored. Enter the Region
        /// code, for example, <code>us-east-1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> RegionNames
        {
            get { return this._regionNames; }
            set { this._regionNames = value; }
        }

        // Check to see if RegionNames property is set
        internal bool IsSetRegionNames()
        {
            return this._regionNames != null && this._regionNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SingleAvailabilityZone. 
        /// <para>
        /// Specify <code>true</code> so that the response returns a list of scored Availability
        /// Zones. Otherwise, the response returns a list of scored Regions.
        /// </para>
        ///  
        /// <para>
        /// A list of scored Availability Zones is useful if you want to launch all of your Spot
        /// capacity into a single Availability Zone.
        /// </para>
        /// </summary>
        public bool SingleAvailabilityZone
        {
            get { return this._singleAvailabilityZone.GetValueOrDefault(); }
            set { this._singleAvailabilityZone = value; }
        }

        // Check to see if SingleAvailabilityZone property is set
        internal bool IsSetSingleAvailabilityZone()
        {
            return this._singleAvailabilityZone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The target capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000000000)]
        public int TargetCapacity
        {
            get { return this._targetCapacity.GetValueOrDefault(); }
            set { this._targetCapacity = value; }
        }

        // Check to see if TargetCapacity property is set
        internal bool IsSetTargetCapacity()
        {
            return this._targetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetCapacityUnitType. 
        /// <para>
        /// The unit for the target capacity.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>units</code> (translates to number of instances)
        /// </para>
        /// </summary>
        public TargetCapacityUnitType TargetCapacityUnitType
        {
            get { return this._targetCapacityUnitType; }
            set { this._targetCapacityUnitType = value; }
        }

        // Check to see if TargetCapacityUnitType property is set
        internal bool IsSetTargetCapacityUnitType()
        {
            return this._targetCapacityUnitType != null;
        }

    }
}