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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Represents an individual contributor to a multi-timeseries alarm, containing information
    /// about a specific time series and its contribution to the alarm's state.
    /// </summary>
    public partial class AlarmContributor
    {
        private Dictionary<string, string> _contributorAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _contributorId;
        private string _stateReason;
        private DateTime? _stateTransitionedTimestamp;

        /// <summary>
        /// Gets and sets the property ContributorAttributes. 
        /// <para>
        /// A map of attributes that describe the contributor, such as metric dimensions and other
        /// identifying characteristics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=30)]
        public Dictionary<string, string> ContributorAttributes
        {
            get { return this._contributorAttributes; }
            set { this._contributorAttributes = value; }
        }

        // Check to see if ContributorAttributes property is set
        internal bool IsSetContributorAttributes()
        {
            return this._contributorAttributes != null && (this._contributorAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContributorId. 
        /// <para>
        /// The unique identifier for this alarm contributor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ContributorId
        {
            get { return this._contributorId; }
            set { this._contributorId = value; }
        }

        // Check to see if ContributorId property is set
        internal bool IsSetContributorId()
        {
            return this._contributorId != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// An explanation for the contributor's current state, providing context about why it
        /// is in its current condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1023)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitionedTimestamp. 
        /// <para>
        /// The timestamp when the contributor last transitioned to its current state.
        /// </para>
        /// </summary>
        public DateTime? StateTransitionedTimestamp
        {
            get { return this._stateTransitionedTimestamp; }
            set { this._stateTransitionedTimestamp = value; }
        }

        // Check to see if StateTransitionedTimestamp property is set
        internal bool IsSetStateTransitionedTimestamp()
        {
            return this._stateTransitionedTimestamp.HasValue; 
        }

    }
}