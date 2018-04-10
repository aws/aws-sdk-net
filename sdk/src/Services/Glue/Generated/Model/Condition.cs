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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a condition under which a trigger fires.
    /// </summary>
    public partial class Condition
    {
        private string _jobName;
        private LogicalOperator _logicalOperator;
        private JobRunState _state;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Job to whose JobRuns this condition applies and on which this trigger
        /// waits.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalOperator. 
        /// <para>
        /// A logical operator.
        /// </para>
        /// </summary>
        public LogicalOperator LogicalOperator
        {
            get { return this._logicalOperator; }
            set { this._logicalOperator = value; }
        }

        // Check to see if LogicalOperator property is set
        internal bool IsSetLogicalOperator()
        {
            return this._logicalOperator != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The condition state. Currently, the values supported are SUCCEEDED, STOPPED, TIMEOUT
        /// and FAILED.
        /// </para>
        /// </summary>
        public JobRunState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}