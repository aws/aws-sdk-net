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
    /// This is the response object from the GetHostedZoneChangeBatch operation.
    /// </summary>
    public partial class GetHostedZoneChangeBatchResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeBatchSummary. 
        /// <para>
        /// A summary of the change batch, including who submitted it and when.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeBatchSummary ChangeBatchSummary { get; set; }

        /// <summary>
        /// Checks to see if the ChangeBatchSummary property is set.
        /// </summary>
        internal bool IsSetChangeBatchSummary() => this.ChangeBatchSummary != null;

        /// <summary>
        /// Gets and sets the property ChangeBatch. 
        /// <para>
        /// The changes in the change batch. Each resource record set is in the same form that
        /// <c>ListResourceRecordSets</c> returns. For example, the name is in lowercase and ends
        /// with a dot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeBatch ChangeBatch { get; set; }

        /// <summary>
        /// Checks to see if the ChangeBatch property is set.
        /// </summary>
        internal bool IsSetChangeBatch() => this.ChangeBatch != null;
    }
}
