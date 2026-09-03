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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A single pre-evaluation filter condition. Specifies a resource type, filter type,
    /// key, value, and operator to match against a resource attribute.
    /// </summary>
    public partial class PreEvaluationFilter
    {
        private string _filterKey;
        private PreEvaluationFilterType _filterType;
        private string _filterValue;
        private PreEvaluationFilterOperator _operator;
        private PreEvaluationFilterResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property FilterKey. 
        /// <para>
        /// The key of the attribute to filter on. For tag filters, this is the tag key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilterKey
        {
            get { return this._filterKey; }
            set { this._filterKey = value; }
        }

        // Check to see if FilterKey property is set
        internal bool IsSetFilterKey()
        {
            return this._filterKey != null;
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of filter to apply. Valid values: <c>TAG</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PreEvaluationFilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValue. 
        /// <para>
        /// The value to match against. For tag filters, this is the tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilterValue
        {
            get { return this._filterValue; }
            set { this._filterValue = value; }
        }

        // Check to see if FilterValue property is set
        internal bool IsSetFilterValue()
        {
            return this._filterValue != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator for the filter condition. Valid values: <c>EQUALS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PreEvaluationFilterOperator Operator
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to filter on. Valid values: <c>CONTACT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PreEvaluationFilterResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}