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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// You can use API filters to narrow down the list of resources returned by <code>ListTasks</code>.
    /// For example, to retrieve all tasks on a source location, you can use <code>ListTasks</code>
    /// with filter name <code>LocationId</code> and <code>Operator Equals</code> with the
    /// ARN for the location.
    /// </summary>
    public partial class TaskFilter
    {
        private TaskFilterName _name;
        private Operator _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter being used. Each API call supports a list of filters that are
        /// available for it. For example, <code>LocationId</code> for <code>ListTasks</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskFilterName Name
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator that is used to compare filter values (for example, <code>Equals</code>
        /// or <code>Contains</code>). For more about API filtering operators, see <a>query-resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Operator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that you want to filter for. For example, you might want to display only
        /// tasks for a specific destination location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}