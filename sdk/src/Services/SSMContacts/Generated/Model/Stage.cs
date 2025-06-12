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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// A set amount of time that an escalation plan or engagement plan engages the specified
    /// contacts or contact methods.
    /// </summary>
    public partial class Stage
    {
        private int? _durationInMinutes;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// The time to wait until beginning the next stage. The duration can only be set to 0
        /// if a target is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=30)]
        public int? DurationInMinutes
        {
            get { return this._durationInMinutes; }
            set { this._durationInMinutes = value; }
        }

        // Check to see if DurationInMinutes property is set
        internal bool IsSetDurationInMinutes()
        {
            return this._durationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The contacts or contact methods that the escalation plan or engagement plan is engaging.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}