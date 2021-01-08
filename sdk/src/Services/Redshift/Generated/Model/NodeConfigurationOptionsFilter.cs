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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A set of elements to filter the returned node configurations.
    /// </summary>
    public partial class NodeConfigurationOptionsFilter
    {
        private NodeConfigurationOptionsFilterName _name;
        private OperatorType _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the element to filter.
        /// </para>
        /// </summary>
        public NodeConfigurationOptionsFilterName Name
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
        /// The filter operator. If filter Name is NodeType only the 'in' operator is supported.
        /// Provide one value to evaluate for 'eq', 'lt', 'le', 'gt', and 'ge'. Provide two values
        /// to evaluate for 'between'. Provide a list of values for 'in'.
        /// </para>
        /// </summary>
        public OperatorType Operator
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
        /// List of values. Compare Name using Operator to Values. If filter Name is NumberOfNodes,
        /// then values can range from 0 to 200. If filter Name is EstimatedDiskUtilizationPercent,
        /// then values can range from 0 to 100. For example, filter NumberOfNodes (name) GT (operator)
        /// 3 (values).
        /// </para>
        /// </summary>
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