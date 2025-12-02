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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// A single filter condition that specifies behavior, requirement, and matching conditions
    /// for WAF log records.
    /// </summary>
    public partial class Filter
    {
        private FilterBehavior _behavior;
        private List<Condition> _conditions = AWSConfigs.InitializeCollections ? new List<Condition>() : null;
        private FilterRequirement _requirement;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        ///  The action to take for log records matching this filter (KEEP or DROP). 
        /// </para>
        /// </summary>
        public FilterBehavior Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        ///  The list of conditions that determine if a log record matches this filter. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Condition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Requirement. 
        /// <para>
        ///  Whether the log record must meet all conditions (MEETS_ALL) or any condition (MEETS_ANY)
        /// to match this filter. 
        /// </para>
        /// </summary>
        public FilterRequirement Requirement
        {
            get { return this._requirement; }
            set { this._requirement = value; }
        }

        // Check to see if Requirement property is set
        internal bool IsSetRequirement()
        {
            return this._requirement != null;
        }

    }
}