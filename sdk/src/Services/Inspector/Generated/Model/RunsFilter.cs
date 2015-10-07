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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as the request parameter in the <a>ListRuns</a> action.
    /// </summary>
    public partial class RunsFilter
    {
        private TimestampRange _completionTime;
        private TimestampRange _creationTime;
        private List<string> _rulesPackages = new List<string>();
        private List<string> _runNamePatterns = new List<string>();
        private List<string> _runStates = new List<string>();

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>completionTime</b> property of the <a>Run</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>creationTime</b> property of the <a>Run</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackages. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// match a list of values of the <b>rulesPackages</b> property of the <a>Run</a> data
        /// type.
        /// </para>
        /// </summary>
        public List<string> RulesPackages
        {
            get { return this._rulesPackages; }
            set { this._rulesPackages = value; }
        }

        // Check to see if RulesPackages property is set
        internal bool IsSetRulesPackages()
        {
            return this._rulesPackages != null && this._rulesPackages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunNamePatterns. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string containing a wildcard
        /// specified for this data type property must match the value of the <b>runName</b> property
        /// of the <a>Run</a> data type.
        /// </para>
        /// </summary>
        public List<string> RunNamePatterns
        {
            get { return this._runNamePatterns; }
            set { this._runNamePatterns = value; }
        }

        // Check to see if RunNamePatterns property is set
        internal bool IsSetRunNamePatterns()
        {
            return this._runNamePatterns != null && this._runNamePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunStates. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>runState</b> property of the <a>Run</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<string> RunStates
        {
            get { return this._runStates; }
            set { this._runStates = value; }
        }

        // Check to see if RunStates property is set
        internal bool IsSetRunStates()
        {
            return this._runStates != null && this._runStates.Count > 0; 
        }

    }
}