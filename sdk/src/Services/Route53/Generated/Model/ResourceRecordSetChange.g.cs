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
    /// One change to a resource record set in the change history of a hosted zone, with the
    /// resource record set that the change wrote or deleted.
    /// </summary>
    public partial class ResourceRecordSetChange
    {
        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The ID of the change batch that contains the change. To get every change in the change
        /// batch, specify this ID in <c>GetHostedZoneChangeBatch</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string ChangeId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeId property is set.
        /// </summary>
        internal bool IsSetChangeId() => this.ChangeId != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The Route 53 API operation that submitted the change. New values might be added, so
        /// ignore values that your code doesn't recognize.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeHistoryOperation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The date and time, in UTC, when the change batch that contains the change was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SubmittedBy. 
        /// <para>
        /// The Amazon Resource Name of the principal that submitted the request. This element
        /// is absent when Route 53 has no principal to record for the change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBy property is set.
        /// </summary>
        internal bool IsSetSubmittedBy() => this.SubmittedBy != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID of the call that submitted the change. CloudTrail records the same
        /// value in <c>requestID</c>. This element is absent when there was no request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action in the change: <c>CREATE</c>, <c>DELETE</c>, or <c>UPSERT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ResourceRecordSet. 
        /// <para>
        /// The resource record set that the change wrote or deleted, in the same form that <c>ListResourceRecordSets</c>
        /// returns. For example, the name is in lowercase and ends with a dot. For an <c>UPSERT</c>
        /// or a <c>DELETE</c>, the response doesn't contain the values that the resource record
        /// set had before the change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceRecordSet ResourceRecordSet { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRecordSet property is set.
        /// </summary>
        internal bool IsSetResourceRecordSet() => this.ResourceRecordSet != null;
    }
}
