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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataSources operation.
    /// Returns a list of <code>DataSource</code> that match the search criteria in the request.
    /// </summary>
    public partial class DescribeDataSourcesRequest : AmazonMachineLearningRequest
    {
        private string _eq;
        private DataSourceFilterVariable _filterVariable;
        private string _ge;
        private string _gt;
        private string _le;
        private int? _limit;
        private string _lt;
        private string _ne;
        private string _nextToken;
        private string _prefix;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property EQ. 
        /// <para>
        /// The equal to operator. The <code>DataSource</code> results will have <code>FilterVariable</code>
        /// values that exactly match the value specified with <code>EQ</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string EQ
        {
            get { return this._eq; }
            set { this._eq = value; }
        }

        // Check to see if EQ property is set
        internal bool IsSetEQ()
        {
            return this._eq != null;
        }

        /// <summary>
        /// Gets and sets the property FilterVariable. 
        /// <para>
        /// Use one of the following variables to filter a list of <code>DataSource</code>:
        /// </para>
        ///  <ul> <li> <code>CreatedAt</code> - Sets the search criteria to <code>DataSource</code>
        /// creation dates.</li> <li> <code>Status</code> - Sets the search criteria to <code>DataSource</code>
        /// statuses.</li> <li> <code>Name</code> - Sets the search criteria to the contents of
        /// <code>DataSource</code> <b> </b> <code>Name</code>.</li> <li> <code>DataUri</code>
        /// - Sets the search criteria to the URI of data files used to create the <code>DataSource</code>.
        /// The URI can identify either a file or an Amazon Simple Storage Service (Amazon S3)
        /// bucket or directory.</li> <li> <code>IAMUser</code> - Sets the search criteria to
        /// the user account that invoked the <code>DataSource</code> creation.</li> </ul>
        /// </summary>
        public DataSourceFilterVariable FilterVariable
        {
            get { return this._filterVariable; }
            set { this._filterVariable = value; }
        }

        // Check to see if FilterVariable property is set
        internal bool IsSetFilterVariable()
        {
            return this._filterVariable != null;
        }

        /// <summary>
        /// Gets and sets the property GE. 
        /// <para>
        /// The greater than or equal to operator. The <code>DataSource</code> results will have
        /// <code>FilterVariable</code> values that are greater than or equal to the value specified
        /// with <code>GE</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string GE
        {
            get { return this._ge; }
            set { this._ge = value; }
        }

        // Check to see if GE property is set
        internal bool IsSetGE()
        {
            return this._ge != null;
        }

        /// <summary>
        /// Gets and sets the property GT. 
        /// <para>
        /// The greater than operator. The <code>DataSource</code> results will have <code>FilterVariable</code>
        /// values that are greater than the value specified with <code>GT</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string GT
        {
            get { return this._gt; }
            set { this._gt = value; }
        }

        // Check to see if GT property is set
        internal bool IsSetGT()
        {
            return this._gt != null;
        }

        /// <summary>
        /// Gets and sets the property LE. 
        /// <para>
        /// The less than or equal to operator. The <code>DataSource</code> results will have
        /// <code>FilterVariable</code> values that are less than or equal to the value specified
        /// with <code>LE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string LE
        {
            get { return this._le; }
            set { this._le = value; }
        }

        // Check to see if LE property is set
        internal bool IsSetLE()
        {
            return this._le != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        ///  The maximum number of <code>DataSource</code> to include in the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LT. 
        /// <para>
        /// The less than operator. The <code>DataSource</code> results will have <code>FilterVariable</code>
        /// values that are less than the value specified with <code>LT</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string LT
        {
            get { return this._lt; }
            set { this._lt = value; }
        }

        // Check to see if LT property is set
        internal bool IsSetLT()
        {
            return this._lt != null;
        }

        /// <summary>
        /// Gets and sets the property NE. 
        /// <para>
        /// The not equal to operator. The <code>DataSource</code> results will have <code>FilterVariable</code>
        /// values not equal to the value specified with <code>NE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string NE
        {
            get { return this._ne; }
            set { this._ne = value; }
        }

        // Check to see if NE property is set
        internal bool IsSetNE()
        {
            return this._ne != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The ID of the page in the paginated results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A string that is found at the beginning of a variable, such as <code>Name</code> or
        /// <code>Id</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, a <code>DataSource</code> could have the <code>Name</code> <code>2014-09-09-HolidayGiftMailer</code>.
        /// To search for this <code>DataSource</code>, select <code>Name</code> for the <code>FilterVariable</code>
        /// and any of the following strings for the <code>Prefix</code>: 
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// 2014-09
        /// </para>
        /// </li> <li>
        /// <para>
        /// 2014-09-09
        /// </para>
        /// </li> <li>
        /// <para>
        /// 2014-09-09-Holiday
        /// </para>
        /// </li> </ul>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// A two-value parameter that determines the sequence of the resulting list of <code>DataSource</code>.
        /// </para>
        ///  <ul> <li> <code>asc</code> - Arranges the list in ascending order (A-Z, 0-9).</li>
        /// <li> <code>dsc</code> - Arranges the list in descending order (Z-A, 9-0).</li> </ul>
        /// 
        /// <para>
        /// Results are sorted by <code>FilterVariable</code>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}