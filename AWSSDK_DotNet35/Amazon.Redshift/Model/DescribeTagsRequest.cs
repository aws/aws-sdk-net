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
    /// Container for the parameters to the DescribeTags operation.
    /// Returns a list of tags. You can return tags from a specific resource by specifying
    /// an ARN, or you can return all tags for a given type of resource, such as clusters,
    /// snapshots, and so on.
    /// 
    ///  
    /// <para>
    ///  The following are limitations for <code>DescribeTags</code>: <ul> <li>You cannot
    /// specify an ARN and a resource-type value together in the same request.</li> <li>You
    /// cannot use the <code>MaxRecords</code> and <code>Marker</code> parameters together
    /// with the ARN parameter.</li> <li>The <code>MaxRecords</code> parameter can be a range
    /// from 10 to 50 results to return in a request.</li> </ul> 
    /// </para>
    ///  
    /// <para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all resources that match any combination of the specified keys and values. For example,
    /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
    /// and <code>test</code> for tag values, all resources that have any combination of those
    /// values are returned.
    /// </para>
    ///  
    /// <para>
    /// If both tag keys and values are omitted from the request, resources are returned regardless
    /// of whether they have tag keys or values associated with them.
    /// </para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonRedshiftRequest
    {
        private string _marker;
        private int? _maxRecords;
        private string _resourceName;
        private string _resourceType;
        private List<string> _tagKeys = new List<string>();
        private List<string> _tagValues = new List<string>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned marker value in the <code>marker</code>
        /// parameter and retrying the command. If the <code>marker</code> field is empty, all
        /// response records have been retrieved for the request. 
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
        ///  The maximum number or response records to return in each call. If the number of remaining
        /// response records exceeds the specified <code>MaxRecords</code> value, a value is returned
        /// in a <code>marker</code> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned <code>marker</code> value. 
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for which you want to describe the tag or tags. For
        /// example, <code>arn:aws:redshift:us-east-1:123456789:cluster:t1</code>. 
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of resource with which you want to view tags. Valid resource types are:
        /// <ul> <li>Cluster</li> <li>CIDR/IP</li> <li>EC2 security group</li> <li>Snapshot</li>
        /// <li>Cluster security group</li> <li>Subnet group</li> <li>HSM connection</li> <li>HSM
        /// certificate</li> <li>Parameter group</li> </ul> 
        /// </para>
        ///  
        /// <para>
        ///  For more information about Amazon Redshift resource types and constructing ARNs,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/constructing-redshift-arn.html">Constructing
        /// an Amazon Redshift Amazon Resource Name (ARN)</a> in the Amazon Redshift Cluster Management
        /// Guide. 
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching resources that are associated
        /// with the specified key or keys. For example, suppose that you have resources tagged
        /// with keys called <code>owner</code> and <code>environment</code>. If you specify both
        /// of these tag keys in the request, Amazon Redshift returns a response with all resources
        /// that have either or both of these tag keys associated with them.
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
        /// A tag value or values for which you want to return all matching resources that are
        /// associated with the specified value or values. For example, suppose that you have
        /// resources tagged with values called <code>admin</code> and <code>test</code>. If you
        /// specify both of these tag values in the request, Amazon Redshift returns a response
        /// with all resources that have either or both of these tag values associated with them.
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