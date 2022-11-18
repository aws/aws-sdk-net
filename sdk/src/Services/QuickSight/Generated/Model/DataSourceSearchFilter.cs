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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter that you apply when searching for data sources.
    /// </summary>
    public partial class DataSourceSearchFilter
    {
        private DataSourceFilterAttribute _name;
        private FilterOperator _operator;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the value that you want to use as a filter, for example, <code>"Name":
        /// "DIRECT_QUICKSIGHT_OWNER"</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DIRECT_QUICKSIGHT_VIEWER_OR_OWNER</code>: Provide an ARN of a user or group,
        /// and any data sources with that ARN listed as one of the owners or viewers of the data
        /// sources are returned. Implicit permissions from folders or groups are not considered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DIRECT_QUICKSIGHT_OWNER</code>: Provide an ARN of a user or group, and any
        /// data sources with that ARN listed as one of the owners if the data source are returned.
        /// Implicit permissions from folders or groups are not considered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DIRECT_QUICKSIGHT_SOLE_OWNER</code>: Provide an ARN of a user or group, and
        /// any data sources with that ARN listed as the only owner of the data source are returned.
        /// Implicit permissions from folders or groups are not considered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DATASOURCE_NAME</code>: Any data sources whose names have a substring match
        /// to the provided value are returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceFilterAttribute Name
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
        /// The comparison operator that you want to use as a filter, for example <code>"Operator":
        /// "StringEquals"</code>. Valid values are <code>"StringEquals"</code> and <code>"StringLike"</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set the operator value to <code>"StringEquals"</code>, you need to provide
        /// an ownership related filter in the <code>"NAME"</code> field and the arn of the user
        /// or group whose data sources you want to search in the <code>"Value"</code> field.
        /// For example, <code>"Name":"DIRECT_QUICKSIGHT_OWNER", "Operator": "StringEquals", "Value":
        /// "arn:aws:quicksight:us-east-1:1:user/default/UserName1"</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set the value to <code>"StringLike"</code>, you need to provide the name of
        /// the data sources you are searching for. For example, <code>"Name":"DATASOURCE_NAME",
        /// "Operator": "StringLike", "Value": "Test"</code>. The <code>"StringLike"</code> operator
        /// only supports the <code>NAME</code> value <code>DATASOURCE_NAME</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterOperator Operator
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the named item, for example <code>DIRECT_QUICKSIGHT_OWNER</code>, that
        /// you want to use as a filter, for example, <code>"Value": "arn:aws:quicksight:us-east-1:1:user/default/UserName1"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}