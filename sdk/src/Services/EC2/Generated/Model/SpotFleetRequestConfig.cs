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
    /// Describes a Spot Fleet request.
    /// </summary>
    public partial class SpotFleetRequestConfig
    {
        private ActivityStatus _activityStatus;
        private SpotFleetRequestConfigData _configData;
        private DateTime? _createTime;
        private string _spotFleetRequestId;
        private BatchState _spotFleetRequestState;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ActivityStatus. 
        /// <para>
        /// The progress of the Spot Fleet request. If there is an error, the status is <c>error</c>.
        /// After all requests are placed, the status is <c>pending_fulfillment</c>. If the size
        /// of the fleet is equal to or greater than its target capacity, the status is <c>fulfilled</c>.
        /// If the size of the fleet is decreased, the status is <c>pending_termination</c> while
        /// Spot Instances are terminating.
        /// </para>
        /// </summary>
        public ActivityStatus ActivityStatus
        {
            get { return this._activityStatus; }
            set { this._activityStatus = value; }
        }

        // Check to see if ActivityStatus property is set
        internal bool IsSetActivityStatus()
        {
            return this._activityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigData. 
        /// <para>
        /// The configuration of the Spot Fleet request.
        /// </para>
        /// </summary>
        public SpotFleetRequestConfigData ConfigData
        {
            get { return this._configData; }
            set { this._configData = value; }
        }

        // Check to see if ConfigData property is set
        internal bool IsSetConfigData()
        {
            return this._configData != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation date and time of the request.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId
        {
            get { return this._spotFleetRequestId; }
            set { this._spotFleetRequestId = value; }
        }

        // Check to see if SpotFleetRequestId property is set
        internal bool IsSetSpotFleetRequestId()
        {
            return this._spotFleetRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SpotFleetRequestState. 
        /// <para>
        /// The state of the Spot Fleet request.
        /// </para>
        /// </summary>
        public BatchState SpotFleetRequestState
        {
            get { return this._spotFleetRequestState; }
            set { this._spotFleetRequestState = value; }
        }

        // Check to see if SpotFleetRequestState property is set
        internal bool IsSetSpotFleetRequestState()
        {
            return this._spotFleetRequestState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a Spot Fleet resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}