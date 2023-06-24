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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of nested <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Filter.html">Filter</a>
    /// objects. A resource must satisfy the conditions of all filters to be included in the
    /// results returned from the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
    /// API.
    /// 
    ///  
    /// <para>
    /// For example, to filter on a training job's <code>InputDataConfig</code> property with
    /// a specific channel name and <code>S3Uri</code> prefix, define the following filters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>'{Name:"InputDataConfig.ChannelName", "Operator":"Equals", "Value":"train"}',</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>'{Name:"InputDataConfig.DataSource.S3DataSource.S3Uri", "Operator":"Contains",
    /// "Value":"mybucket/catdata"}'</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class NestedFilters
    {
        private List<Filter> _filters = new List<Filter>();
        private string _nestedPropertyName;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filters. Each filter acts on a property. Filters must contain at least one
        /// <code>Filters</code> value. For example, a <code>NestedFilters</code> call might include
        /// a filter on the <code>PropertyName</code> parameter of the <code>InputDataConfig</code>
        /// property: <code>InputDataConfig.DataSource.S3DataSource.S3Uri</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Filter> Filters
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
        /// Gets and sets the property NestedPropertyName. 
        /// <para>
        /// The name of the property to use in the nested filters. The value must match a listed
        /// property name, such as <code>InputDataConfig</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string NestedPropertyName
        {
            get { return this._nestedPropertyName; }
            set { this._nestedPropertyName = value; }
        }

        // Check to see if NestedPropertyName property is set
        internal bool IsSetNestedPropertyName()
        {
            return this._nestedPropertyName != null;
        }

    }
}