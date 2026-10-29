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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the ListOperations operation. Returns information
    /// about all of the operations that return an operation ID and that have ever been performed
    /// on domains that were registered by the current account. <para> This command runs only
    /// in the us-east-1 Region. </para>
    /// </summary>
    public partial class ListOperationsRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For an initial request for a list of operations, omit this element. If the number
        /// of operations that are not yet complete is greater than the value that you specified
        /// for <c>MaxItems</c>, you can use <c>Marker</c> to return additional operations. Get
        /// the value of <c>NextPageMarker</c> from the previous response, and submit another
        /// request that includes the value of <c>NextPageMarker</c> in the <c>Marker</c> element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Number of domains to be returned.
        /// </para>
        ///  
        /// <para>
        /// Default: 20
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        ///  The sort type for returned values. 
        /// </para>
        /// </summary>
        public ListOperationsSortAttributeName SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        ///  The sort order for returned values, either ascending or descending. 
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the operations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Status { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null && (this.Status.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubmittedSince. 
        /// <para>
        /// An optional parameter that lets you get information about all the operations that
        /// you submitted after a specified date and time. Specify the date and time in Unix time
        /// format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime? SubmittedSince { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedSince property is set.
        /// </summary>
        internal bool IsSetSubmittedSince() => this.SubmittedSince.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  An arrays of the domains operation types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 21)]
        public List<string> Type { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null && (this.Type.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
