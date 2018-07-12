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
    /// Specifies a schedule.
    /// </summary>
    public partial class Schedule
    {
        private CreateRule _createRule;
        private string _name;
        private RetainRule _retainRule;
        private List<Tag> _tagsToAdd = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CreateRule. 
        /// <para>
        /// The create rule.
        /// </para>
        /// </summary>
        public CreateRule CreateRule
        {
            get { return this._createRule; }
            set { this._createRule = value; }
        }

        // Check to see if CreateRule property is set
        internal bool IsSetCreateRule()
        {
            return this._createRule != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property RetainRule. 
        /// <para>
        /// The retain rule.
        /// </para>
        /// </summary>
        public RetainRule RetainRule
        {
            get { return this._retainRule; }
            set { this._retainRule = value; }
        }

        // Check to see if RetainRule property is set
        internal bool IsSetRetainRule()
        {
            return this._retainRule != null;
        }

        /// <summary>
        /// Gets and sets the property TagsToAdd. 
        /// <para>
        /// The tags to add to policy-created resources. These tags are added in addition to the
        /// default lifecycle tags.
        /// </para>
        /// </summary>
        public List<Tag> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && this._tagsToAdd.Count > 0; 
        }

    }
}