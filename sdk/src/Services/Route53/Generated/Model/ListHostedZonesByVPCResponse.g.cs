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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the ListHostedZonesByVPC operation.
    /// </summary>
    public partial class ListHostedZonesByVPCResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HostedZoneSummaries. 
        /// <para>
        /// A list that contains one <c>HostedZoneSummary</c> element for each hosted zone that
        /// the specified Amazon VPC is associated with. Each <c>HostedZoneSummary</c> element
        /// contains the hosted zone name and ID, and information about who owns the hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HostedZoneSummary> HostedZoneSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<HostedZoneSummary>() : null;

        /// <summary>
        /// Checks to see if the HostedZoneSummaries property is set.
        /// </summary>
        internal bool IsSetHostedZoneSummaries() => this.HostedZoneSummaries != null && (this.HostedZoneSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for <c>MaxItems</c> in the most recent <c>ListHostedZonesByVPC</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value that you will use for <c>NextToken</c> in the next <c>ListHostedZonesByVPC</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
