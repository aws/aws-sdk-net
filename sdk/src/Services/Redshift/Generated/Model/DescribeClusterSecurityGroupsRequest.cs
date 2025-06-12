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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterSecurityGroups operation.
    /// Returns information about Amazon Redshift security groups. If the name of a security
    /// group is specified, the response will contain only information about only that security
    /// group.
    /// 
    ///  
    /// <para>
    ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
    /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all security groups that match any combination of the specified keys and values. For
    /// example, if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c>
    /// and <c>test</c> for tag values, all security groups that have any combination of those
    /// values are returned.
    /// </para>
    ///  
    /// <para>
    /// If both tag keys and values are omitted from the request, security groups are returned
    /// regardless of whether they have tag keys or values associated with them.
    /// </para>
    /// </summary>
    public partial class DescribeClusterSecurityGroupsRequest : AmazonRedshiftRequest
    {
        private string _clusterSecurityGroupName;
        private string _marker;
        private int? _maxRecords;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tagValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        /// The name of a cluster security group for which you are requesting details. You must
        /// specify either the <b>Marker</b> parameter or a <b>ClusterSecurityGroupName</b> parameter,
        /// but not both. 
        /// </para>
        ///  
        /// <para>
        ///  Example: <c>securitygroup1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterSecurityGroupName
        {
            get { return this._clusterSecurityGroupName; }
            set { this._clusterSecurityGroupName = value; }
        }

        // Check to see if ClusterSecurityGroupName property is set
        internal bool IsSetClusterSecurityGroupName()
        {
            return this._clusterSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusterSecurityGroups</a> request exceed
        /// the value specified in <c>MaxRecords</c>, Amazon Web Services returns a value in the
        /// <c>Marker</c> field of the response. You can retrieve the next set of response records
        /// by providing the returned marker value in the <c>Marker</c> parameter and retrying
        /// the request. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: You must specify either the <b>ClusterSecurityGroupName</b> parameter
        /// or the <b>Marker</b> parameter, but not both. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <c>MaxRecords</c> value, a value is returned
        /// in a <c>marker</c> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching cluster security groups
        /// that are associated with the specified key or keys. For example, suppose that you
        /// have security groups that are tagged with keys called <c>owner</c> and <c>environment</c>.
        /// If you specify both of these tag keys in the request, Amazon Redshift returns a response
        /// with the security groups that have either or both of these tag keys associated with
        /// them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A tag value or values for which you want to return all matching cluster security groups
        /// that are associated with the specified tag value or values. For example, suppose that
        /// you have security groups that are tagged with values called <c>admin</c> and <c>test</c>.
        /// If you specify both of these tag values in the request, Amazon Redshift returns a
        /// response with the security groups that have either or both of these tag values associated
        /// with them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && (this._tagValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}