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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Filters for your invoice summaries.
    /// </summary>
    public partial class InvoiceSummariesFilter
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period associated with the invoice documents. 
        /// </para>
        /// </summary>
        public BillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property InvoicingEntity. 
        /// <para>
        /// The name of the entity that issues the Amazon Web Services invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InvoicingEntity { get; set; }

        /// <summary>
        /// Checks to see if the InvoicingEntity property is set.
        /// </summary>
        internal bool IsSetInvoicingEntity() => this.InvoicingEntity != null;

        /// <summary>
        /// Gets and sets the property ReceiverRole. 
        /// <para>
        /// The role of the invoice receiver to filter by.
        /// </para>
        ///  <note> 
        /// <para>
        /// When <c>ReceiverRole</c> is specified:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data is available starting <c>2025-06-01</c>. Queries for periods before <c>2025-06-01</c>
        /// return a validation error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TimeInterval</c> supports a time interval of up to 5 years. Without <c>ReceiverRole</c>,
        /// <c>TimeInterval</c> is limited to one month.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public ReceiverRole ReceiverRole { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverRole property is set.
        /// </summary>
        internal bool IsSetReceiverRole() => this.ReceiverRole != null;

        /// <summary>
        /// Gets and sets the property TimeInterval. 
        /// <para>
        /// The date range for invoice summary retrieval. 
        /// </para>
        /// </summary>
        public DateInterval TimeInterval { get; set; }

        /// <summary>
        /// Checks to see if the TimeInterval property is set.
        /// </summary>
        internal bool IsSetTimeInterval() => this.TimeInterval != null;
    }
}
