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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies an action for an event-based policy.
    /// </summary>
    public partial class Action
    {
        private List<CrossRegionCopyAction> _crossRegionCopy = new List<CrossRegionCopyAction>();
        private string _name;

        /// <summary>
        /// Gets and sets the property CrossRegionCopy. 
        /// <para>
        /// The rule for copying shared snapshots across Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3)]
        public List<CrossRegionCopyAction> CrossRegionCopy
        {
            get { return this._crossRegionCopy; }
            set { this._crossRegionCopy = value; }
        }

        // Check to see if CrossRegionCopy property is set
        internal bool IsSetCrossRegionCopy()
        {
            return this._crossRegionCopy != null && this._crossRegionCopy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=120)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}