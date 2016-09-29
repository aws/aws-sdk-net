/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Spot fleet request.
    /// </summary>
    public partial class SpotFleetRequestConfig
    {
        private ActivityStatus _activityStatus;
        private SpotFleetRequestConfigData _configData;
        private DateTime? _createTime;
        private string _spotFleetRequestId;
        private BatchState _spotFleetRequestState;

        /// <summary>
        /// Gets and sets the property ActivityStatus. 
        /// <para>
        /// The progress of the Spot fleet request. If there is an error, the status is <code>error</code>.
        /// After all bids are placed, the status is <code>pending_fulfillment</code>. If the
        /// size of the fleet is equal to or greater than its target capacity, the status is <code>fulfilled</code>.
        /// If the size of the fleet is decreased, the status is <code>pending_termination</code>
        /// while Spot instances are terminating.
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
        /// Information about the configuration of the Spot fleet request.
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
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
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
        /// The ID of the Spot fleet request.
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
        /// The state of the Spot fleet request.
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

    }
}