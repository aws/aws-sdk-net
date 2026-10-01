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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Live evaluation state for an alert. Read-only, system-managed.
    /// </summary>
    public partial class AlertStateInfo
    {
        private ContributorSummary _contributorSummary;
        private AlertStateData _data;
        private DateTime? _transitionedAt;
        private AlertState _value;

        /// <summary>
        /// Gets and sets the property ContributorSummary. 
        /// <para>
        /// Counts of contributors currently breaching each severity threshold. Present only when
        /// contributor-level tracking is active; absent until the first contributor breaches
        /// a {@code WARNING} or {@code CRITICAL} threshold.
        /// </para>
        /// </summary>
        public ContributorSummary ContributorSummary
        {
            get { return this._contributorSummary; }
            set { this._contributorSummary = value; }
        }

        // Check to see if ContributorSummary property is set
        internal bool IsSetContributorSummary()
        {
            return this._contributorSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Structured detail about why the alert is in its current state.
        /// </para>
        /// </summary>
        public AlertStateData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property TransitionedAt. 
        /// <para>
        /// When the alert transitioned to its current state.
        /// </para>
        /// </summary>
        public DateTime? TransitionedAt
        {
            get { return this._transitionedAt; }
            set { this._transitionedAt = value; }
        }

        // Check to see if TransitionedAt property is set
        internal bool IsSetTransitionedAt()
        {
            return this._transitionedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Current flat state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlertState Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}