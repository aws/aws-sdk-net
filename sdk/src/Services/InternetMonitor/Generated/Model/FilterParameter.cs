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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
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
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// A filter that you use with the results of a Amazon CloudWatch Internet Monitor query
    /// that you created and ran. The query sets up a repository of data that is a subset
    /// of your application's Internet Monitor data. <c>FilterParameter</c> is a string that
    /// defines how you want to filter the repository of data to return a set of results,
    /// based on your criteria.
    /// 
    ///  
    /// <para>
    /// The filter parameters that you can specify depend on the query type that you used
    /// to create the repository, since each query type returns a different set of Internet
    /// Monitor data.
    /// </para>
    ///  
    /// <para>
    /// For each filter, you specify a field (such as <c>city</c>), an operator (such as <c>not_equals</c>,
    /// and a value or array of values (such as <c>["Seattle", "Redmond"]</c>). Separate values
    /// in the array with commas.
    /// </para>
    ///  
    /// <para>
    /// For more information about specifying filter parameters, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
    /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
    /// Internet Monitor User Guide.
    /// </para>
    /// </summary>
    public partial class FilterParameter
    {
        private string _field;
        private Operator _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// A data field that you want to filter, to further scope your application's Internet
        /// Monitor data in a repository that you created by running a query. A field might be
        /// <c>city</c>, for example. The field must be one of the fields that was returned by
        /// the specific query that you used to create the repository.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use with the filter field and a value, such as <c>not_equals</c>.
        /// </para>
        /// </summary>
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
        /// One or more values to be used, together with the specified operator, to filter data
        /// for a query. For example, you could specify an array of values such as <c>["Seattle",
        /// "Redmond"]</c>. Values in the array are separated by commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}