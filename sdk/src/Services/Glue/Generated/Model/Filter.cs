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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that splits a dataset into two, based on a filter condition.
    /// </summary>
    public partial class Filter
    {
        private List<FilterExpression> _filters = AWSConfigs.InitializeCollections ? new List<FilterExpression>() : null;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FilterLogicalOperator _logicalOperator;
        private string _name;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Specifies a filter expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FilterExpression> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The data inputs identified by their node names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogicalOperator. 
        /// <para>
        /// The operator used to filter rows by comparing the key value to a specified value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterLogicalOperator LogicalOperator
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the transform node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}