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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// A group of trigger conditions. The group matches when ALL present conditions pass.
    /// A group cannot be empty: at least one condition must be present.
    /// </summary>
    public partial class TriggerFilterGroup
    {
        private List<string> _events = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PatternFilter _targetBranches;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Passes when the webhook event is one of the listed events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetBranches. 
        /// <para>
        /// Passes when the change request target branch matches. Applicable to RELEASE_READINESS_REVIEW
        /// only.
        /// </para>
        /// </summary>
        public PatternFilter TargetBranches
        {
            get { return this._targetBranches; }
            set { this._targetBranches = value; }
        }

        // Check to see if TargetBranches property is set
        internal bool IsSetTargetBranches()
        {
            return this._targetBranches != null;
        }

    }
}