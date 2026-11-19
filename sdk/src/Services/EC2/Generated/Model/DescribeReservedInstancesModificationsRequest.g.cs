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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstancesModifications operation.
    /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
    /// information about all your Reserved Instances modification requests is returned. If
    /// a modification ID is specified, only information about the specific modification is
    /// returned. <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modify
    /// Reserved Instances</a> in the <i>Amazon EC2 User Guide</i>. </para> <note> <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para> </note>
    /// </summary>
    public partial class DescribeReservedInstancesModificationsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>client-token</c> - The idempotency token for the modification request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>create-date</c> - The time when the modification request was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>effective-date</c> - The time when the modification becomes effective.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modification-result.reserved-instances-id</c> - The ID for the Reserved Instances
        /// created as part of the modification request. This ID is only available when the status
        /// of the modification is <c>fulfilled</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modification-result.target-configuration.availability-zone</c> - The Availability
        /// Zone for the new Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modification-result.target-configuration.availability-zone-id</c> - The ID of
        /// the Availability Zone for the new Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modification-result.target-configuration.instance-count </c> - The number of new
        /// Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modification-result.target-configuration.instance-type</c> - The instance type
        /// of the new Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reserved-instances-id</c> - The ID of the Reserved Instances modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reserved-instances-modification-id</c> - The ID of the modification request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The status of the Reserved Instances modification request (<c>processing</c>
        /// | <c>fulfilled</c> | <c>failed</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status-message</c> - The reason for the status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>update-date</c> - The time when the modification request was last updated.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReservedInstancesModificationIds. 
        /// <para>
        /// IDs for the submitted modification request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReservedInstancesModificationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReservedInstancesModificationIds property is set.
        /// </summary>
        internal bool IsSetReservedInstancesModificationIds() => this.ReservedInstancesModificationIds != null && (this.ReservedInstancesModificationIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
