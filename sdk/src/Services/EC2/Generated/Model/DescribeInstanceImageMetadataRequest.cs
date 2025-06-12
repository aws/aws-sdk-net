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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceImageMetadata operation.
    /// Describes the AMI that was used to launch an instance, even if the AMI is deprecated,
    /// deregistered, made private (no longer public or shared with your account), or not
    /// allowed.
    /// 
    ///  
    /// <para>
    /// If you specify instance IDs, the output includes information for only the specified
    /// instances. If you specify filters, the output includes information for only those
    /// instances that meet the filter criteria. If you do not specify instance IDs or filters,
    /// the output includes information for all instances, which can affect performance.
    /// </para>
    ///  
    /// <para>
    /// If you specify an instance ID that is not valid, an instance that doesn't exist, or
    /// an instance that you do not own, an error (<c>InvalidInstanceID.NotFound</c>) is returned.
    /// </para>
    ///  
    /// <para>
    /// Recently terminated instances might appear in the returned results. This interval
    /// is usually less than one hour.
    /// </para>
    ///  
    /// <para>
    /// In the rare case where an Availability Zone is experiencing a service disruption and
    /// you specify instance IDs that are in the affected Availability Zone, or do not specify
    /// any instance IDs at all, the call fails. If you specify only instance IDs that are
    /// in an unaffected Availability Zone, the call works normally.
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeInstanceImageMetadataRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The name of the Availability Zone (for example, <c>us-west-2a</c>)
        /// or Local Zone (for example, <c>us-west-2-lax-1b</c>) of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> - The ID of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>image-allowed</c> - A Boolean that indicates whether the image meets the criteria
        /// specified for Allowed AMIs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-state-name</c> - The state of the instance (<c>pending</c> | <c>running</c>
        /// | <c>shutting-down</c> | <c>terminated</c> | <c>stopping</c> | <c>stopped</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The type of instance (for example, <c>t3.micro</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch-time</c> - The time when the instance was launched, in the ISO 8601 format
        /// in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ), for example, <c>2023-09-29T11:04:43.305Z</c>.
        /// You can use a wildcard (<c>*</c>), for example, <c>2023-09-29T*</c>, which matches
        /// an entire day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-alias</c> - The owner alias (<c>amazon</c> | <c>aws-marketplace</c> | <c>aws-backup-vault</c>).
        /// The valid aliases are defined in an Amazon-maintained list. This is not the Amazon
        /// Web Services account alias that can be set using the IAM console. We recommend that
        /// you use the <c>Owner</c> request parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The Amazon Web Services account ID of the owner. We recommend that
        /// you use the <c>Owner</c> request parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zone-id</c> - The ID of the Availability Zone (for example, <c>usw2-az2</c>) or
        /// Local Zone (for example, <c>usw2-lax1-az1</c>) of the instance.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The instance IDs.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an instance ID or filters, the output includes information for
        /// all instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: 1000
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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

    }
}