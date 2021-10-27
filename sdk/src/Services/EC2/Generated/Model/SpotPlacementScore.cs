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
    /// The Spot placement score for this Region or Availability Zone. The score is calculated
    /// based on the assumption that the <code>capacity-optimized</code> allocation strategy
    /// is used and that all of the Availability Zones in the Region can be used.
    /// </summary>
    public partial class SpotPlacementScore
    {
        private string _availabilityZoneId;
        private string _region;
        private int? _score;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The placement score, on a scale from <code>1</code> to <code>10</code>. A score of
        /// <code>10</code> indicates that your Spot request is highly likely to succeed in this
        /// Region or Availability Zone. A score of <code>1</code> indicates that your Spot request
        /// is not likely to succeed. 
        /// </para>
        /// </summary>
        public int Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}