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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies the configuration of a lifecycle policy.
    /// </summary>
    public partial class PolicyDetails
    {
        private List<string> _resourceTypes = new List<string>();
        private List<Schedule> _schedules = new List<Schedule>();
        private List<Tag> _targetTags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Schedules. 
        /// <para>
        /// The schedule.
        /// </para>
        /// </summary>
        public List<Schedule> Schedules
        {
            get { return this._schedules; }
            set { this._schedules = value; }
        }

        // Check to see if Schedules property is set
        internal bool IsSetSchedules()
        {
            return this._schedules != null && this._schedules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetTags. 
        /// <para>
        /// The target tags.
        /// </para>
        /// </summary>
        public List<Tag> TargetTags
        {
            get { return this._targetTags; }
            set { this._targetTags = value; }
        }

        // Check to see if TargetTags property is set
        internal bool IsSetTargetTags()
        {
            return this._targetTags != null && this._targetTags.Count > 0; 
        }

    }
}