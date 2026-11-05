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
    /// Container for the parameters to the DescribeTags operation. Returns a list of tags.
    /// You can return tags from a specific resource by specifying an ARN, or you can return
    /// all tags for a given type of resource, such as clusters, snapshots, and so on. <para>
    /// The following are limitations for <c>DescribeTags</c>: </para> <ul> <li> <para> You
    /// cannot specify an ARN and a resource-type value together in the same request. </para>
    /// </li> <li> <para> You cannot use the <c>MaxRecords</c> and <c>Marker</c> parameters
    /// together with the ARN parameter. </para> </li> <li> <para> The <c>MaxRecords</c> parameter
    /// can be a range from 10 to 50 results to return in a request. </para> </li> </ul> <para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all resources that match any combination of the specified keys and values. For example,
    /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
    /// <c>test</c> for tag values, all resources that have any combination of those values
    /// are returned. </para> <para> If both tag keys and values are omitted from the request,
    /// resources are returned regardless of whether they have tag keys or values associated
    /// with them. </para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned marker value in the <c>marker</c> parameter
        /// and retrying the command. If the <c>marker</c> field is empty, all response records
        /// have been retrieved for the request. 
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
        /// The maximum number or response records to return in each call. If the number of remaining
        /// response records exceeds the specified <c>MaxRecords</c> value, a value is returned
        /// in a <c>marker</c> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned <c>marker</c> value. 
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) for which you want to describe the tag or tags. For
        /// example, <c>arn:aws:redshift:us-east-2:123456789:cluster:t1</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource with which you want to view tags. Valid resource types are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CIDR/IP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EC2 security group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Snapshot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cluster security group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subnet group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HSM connection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HSM certificate
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parameter group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Snapshot copy grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Integration (zero-ETL integration or S3 event integration)
        /// </para>
        ///  <note> 
        /// <para>
        /// To describe the tags associated with an <c>integration</c>, don't specify <c>ResourceType</c>,
        /// instead specify the <c>ResourceName</c> of the integration.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For more information about Amazon Redshift resource types and constructing ARNs, go
        /// to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-overview.html#redshift-iam-access-control-specify-actions">Specifying
        /// Policy Elements: Actions, Effects, Resources, and Principals</a> in the Amazon Redshift
        /// Cluster Management Guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching resources that are associated
        /// with the specified key or keys. For example, suppose that you have resources tagged
        /// with keys called <c>owner</c> and <c>environment</c>. If you specify both of these
        /// tag keys in the request, Amazon Redshift returns a response with all resources that
        /// have either or both of these tag keys associated with them.
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
        /// A tag value or values for which you want to return all matching resources that are
        /// associated with the specified value or values. For example, suppose that you have
        /// resources tagged with values called <c>admin</c> and <c>test</c>. If you specify both
        /// of these tag values in the request, Amazon Redshift returns a response with all resources
        /// that have either or both of these tag values associated with them.
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
