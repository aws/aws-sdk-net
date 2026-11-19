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
    /// Container for the parameters to the ListResourceRecordSetProtections operation. Lists
    /// the resource record set protections in a hosted zone. We recommend using pagination
    /// to ensure that the operation returns quickly and successfully. <para> If the response
    /// includes a <c>NextToken</c> element, there are more protections to list. To get the
    /// next page of results, submit another request and specify the value of <c>NextToken</c>
    /// in the <c>NextToken</c> parameter. </para>
    /// </summary>
    public partial class ListResourceRecordSetProtectionsRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the protections that you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property StartRecordName. 
        /// <para>
        /// The first resource record set name that you want Route 53 to list protections for.
        /// If you don't specify a value, the list starts with the first protection in the hosted
        /// zone.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>NextToken</c>, Route 53 ignores <c>StartRecordName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StartRecordName { get; set; }

        /// <summary>
        /// Checks to see if the StartRecordName property is set.
        /// </summary>
        internal bool IsSetStartRecordName() => this.StartRecordName != null;

        /// <summary>
        /// Gets and sets the property StartRecordType. 
        /// <para>
        /// The first resource record set type, within the name specified by <c>StartRecordName</c>,
        /// that you want Route 53 to list protections for. If you specify <c>StartRecordType</c>,
        /// you must also specify <c>StartRecordName</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>NextToken</c>, Route 53 ignores <c>StartRecordType</c>.
        /// </para>
        /// </summary>
        public RRType StartRecordType { get; set; }

        /// <summary>
        /// Checks to see if the StartRecordType property is set.
        /// </summary>
        internal bool IsSetStartRecordType() => this.StartRecordType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of protections that you want Route 53 to return in this response.
        /// If you don't specify a value, or if you specify a value greater than 300, Route 53
        /// returns up to 300 protections.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListResourceRecordSetProtections</c> request included
        /// a <c>NextToken</c> element, specify that value here to get the next page of results.
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
