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
    /// Container for the parameters to the GetHostedZoneChangeBatch operation. Returns one
    /// change batch from the change history of a hosted zone, including every change in the
    /// batch. Each resource record set is in the same form that <c>ListResourceRecordSets</c>
    /// returns. For example, the name is in lowercase and ends with a dot. For an <c>UPSERT</c>
    /// or a <c>DELETE</c>, the response doesn't contain the values that the resource record
    /// set had before the change. <para> If the change batch isn't in the hosted zone's retained
    /// change history, for example because it's in another hosted zone, it expired, or it's
    /// from before <c>RetentionStartsAt</c>, Route 53 returns a <c>NoSuchChange</c> error.
    /// If Change History isn't turned on for the hosted zone, Route 53 returns a <c>FeatureNotEnabled</c>
    /// error. </para>
    /// </summary>
    public partial class GetHostedZoneChangeBatchRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the change batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The ID of the change batch that you want to get. This is the ID that <c>ChangeResourceRecordSets</c>
        /// returns in <c>ChangeInfo/Id</c>. You can specify the ID with or without the <c>/change/</c>
        /// prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string ChangeId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeId property is set.
        /// </summary>
        internal bool IsSetChangeId() => this.ChangeId != null;
    }
}
