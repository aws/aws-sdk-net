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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeClusterParameterGroups operation. Returns
    /// a list of Amazon Redshift parameter groups, including parameter groups you created
    /// and the default parameter group. For each parameter group, the response includes the
    /// parameter group name, description, and parameter group family name. You can optionally
    /// specify a name to retrieve the description of a specific parameter group. <para> For
    /// more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
    /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para> <para> If you specify both tag keys and tag values in the same request, Amazon
    /// Redshift returns all parameter groups that match any combination of the specified
    /// keys and values. For example, if you have <c>owner</c> and <c>environment</c> for
    /// tag keys, and <c>admin</c> and <c>test</c> for tag values, all parameter groups that
    /// have any combination of those values are returned. </para> <para> If both tag keys
    /// and values are omitted from the request, parameter groups are returned regardless
    /// of whether they have tag keys or values associated with them. </para>
    /// </summary>
    public partial class DescribeClusterParameterGroupsRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusterParameterGroups</a> request exceed
        /// the value specified in <c>MaxRecords</c>, Amazon Web Services returns a value in the
        /// <c>Marker</c> field of the response. You can retrieve the next set of response records
        /// by providing the returned marker value in the <c>Marker</c> parameter and retrying
        /// the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

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
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of a specific parameter group for which to return details. By default, details
        /// about all parameter groups and the default parameter group are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupName property is set.
        /// </summary>
        internal bool IsSetParameterGroupName() => this.ParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching cluster parameter groups
        /// that are associated with the specified key or keys. For example, suppose that you
        /// have parameter groups that are tagged with keys called <c>owner</c> and <c>environment</c>.
        /// If you specify both of these tag keys in the request, Amazon Redshift returns a response
        /// with the parameter groups that have either or both of these tag keys associated with
        /// them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagKeys property is set.
        /// </summary>
        internal bool IsSetTagKeys() => this.TagKeys != null && (this.TagKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A tag value or values for which you want to return all matching cluster parameter
        /// groups that are associated with the specified tag value or values. For example, suppose
        /// that you have parameter groups that are tagged with values called <c>admin</c> and
        /// <c>test</c>. If you specify both of these tag values in the request, Amazon Redshift
        /// returns a response with the parameter groups that have either or both of these tag
        /// values associated with them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagValues property is set.
        /// </summary>
        internal bool IsSetTagValues() => this.TagValues != null && (this.TagValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
