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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more aggregators for viewing counts of OpsItems using different dimensions
    /// such as <code>Source</code>, <code>CreatedTime</code>, or <code>Source and CreatedTime</code>,
    /// to name a few.
    /// </summary>
    public partial class OpsAggregator
    {
        private List<OpsAggregator> _aggregators = new List<OpsAggregator>();
        private string _aggregatorType;
        private string _attributeName;
        private List<OpsFilter> _filters = new List<OpsFilter>();
        private string _typeName;
        private Dictionary<string, string> _values = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// A nested aggregator for viewing counts of OpsItems.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public List<OpsAggregator> Aggregators
        {
            get { return this._aggregators; }
            set { this._aggregators = value; }
        }

        // Check to see if Aggregators property is set
        internal bool IsSetAggregators()
        {
            return this._aggregators != null && this._aggregators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AggregatorType. 
        /// <para>
        /// Either a Range or Count aggregator for limiting an OpsItem summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string AggregatorType
        {
            get { return this._aggregatorType; }
            set { this._aggregatorType = value; }
        }

        // Check to see if AggregatorType property is set
        internal bool IsSetAggregatorType()
        {
            return this._aggregatorType != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of an OpsItem attribute on which to limit the count of OpsItems.
        /// </para>
        /// </summary>
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The aggregator filters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<OpsFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The data type name to use for viewing counts of OpsItems.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The aggregator value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> Values
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