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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTargets operation.
    /// Removes target(s) from a rule so that when the rule is triggered, those targets will
    /// no longer be invoked.
    /// 
    ///  
    /// <para>
    ///  <b>Note:</b> When you remove a target, when the associated rule triggers, removed
    /// targets might still continue to be invoked. Please allow a short period of time for
    /// changes to take effect. 
    /// </para>
    /// </summary>
    public partial class RemoveTargetsRequest : AmazonCloudWatchEventsRequest
    {
        private List<string> _ids = new List<string>();
        private string _rule;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// The list of target IDs to remove from the rule.
        /// </para>
        /// </summary>
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && this._ids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The name of the rule you want to remove targets from.
        /// </para>
        /// </summary>
        public string Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

    }
}