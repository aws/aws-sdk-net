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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterParameterGroups operation.
    /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
    /// created and the default parameter group. For each parameter group, the response includes
    /// the parameter group name, description, and parameter group family name. You can optionally
    /// specify a name to retrieve the description of a specific parameter group. 
    /// 
    ///  
    /// <para>
    ///  For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
    /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all parameter groups that match any combination of the specified keys and values.
    /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
    /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
    /// that have any combination of those values are returned.
    /// </para>
    ///  
    /// <para>
    /// If both tag keys and values are omitted from the request, parameter groups are returned
    /// regardless of whether they have tag keys or values associated with them.
    /// </para>
    /// </summary>
    public partial class DescribeClusterParameterGroupsRequest : AmazonRedshiftRequest
    {
        private string _marker;
        private int? _maxRecords;
        private string _parameterGroupName;
        private List<string> _tagKeys = new List<string>();
        private List<string> _tagValues = new List<string>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusterParameterGroups</a> request exceed
        /// the value specified in <code>MaxRecords</code>, AWS returns a value in the <code>Marker</code>
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned marker value in the <code>Marker</code> parameter and retrying the request.
        /// 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///  The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <code>MaxRecords</code> value, a value is returned
        /// in a <code>marker</code> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>100</code>
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        ///  The name of a specific parameter group for which to return details. By default, details
        /// about all parameter groups and the default parameter group are returned. 
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching cluster parameter groups
        /// that are associated with the specified key or keys. For example, suppose that you
        /// have parameter groups that are tagged with keys called <code>owner</code> and <code>environment</code>.
        /// If you specify both of these tag keys in the request, Amazon Redshift returns a response
        /// with the parameter groups that have either or both of these tag keys associated with
        /// them.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A tag value or values for which you want to return all matching cluster parameter
        /// groups that are associated with the specified tag value or values. For example, suppose
        /// that you have parameter groups that are tagged with values called <code>admin</code>
        /// and <code>test</code>. If you specify both of these tag values in the request, Amazon
        /// Redshift returns a response with the parameter groups that have either or both of
        /// these tag values associated with them.
        /// </para>
        /// </summary>
        public List<string> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && this._tagValues.Count > 0; 
        }

    }
}