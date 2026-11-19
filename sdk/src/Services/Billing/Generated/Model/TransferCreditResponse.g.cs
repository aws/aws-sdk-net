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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// This is the response object from the TransferCredit operation.
    /// </summary>
    public partial class TransferCreditResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The available balance of the credit, which is its remaining balance minus any amount
        /// reserved for a bill that isn't finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property DestinationAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the credit after the transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationAccountId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAccountId property is set.
        /// </summary>
        internal bool IsSetDestinationAccountId() => this.DestinationAccountId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether the request was a dry run. If <c>true</c>, the operation didn't
        /// change the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property NewCreditId. 
        /// <para>
        /// Always the same as <c>sourceCreditId</c>, because a transfer moves the credit and
        /// creates no new one. A dry run omits this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NewCreditId { get; set; }

        /// <summary>
        /// Checks to see if the NewCreditId property is set.
        /// </summary>
        internal bool IsSetNewCreditId() => this.NewCreditId != null;

        /// <summary>
        /// Gets and sets the property SourceCreditId. 
        /// <para>
        /// The ID of the transferred credit. The credit keeps this ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string SourceCreditId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCreditId property is set.
        /// </summary>
        internal bool IsSetSourceCreditId() => this.SourceCreditId != null;
    }
}
