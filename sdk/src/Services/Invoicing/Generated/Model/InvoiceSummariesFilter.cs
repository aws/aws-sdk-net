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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
        private BillingPeriod _billingPeriod;
        private string _invoicingEntity;
        private DateInterval _timeInterval;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period associated with the invoice documents. 
        /// </para>
        /// </summary>
        public BillingPeriod BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property InvoicingEntity. 
        /// <para>
        /// The name of the entity that issues the Amazon Web Services invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string InvoicingEntity
        {
            get { return this._invoicingEntity; }
            set { this._invoicingEntity = value; }
        }

        // Check to see if InvoicingEntity property is set
        internal bool IsSetInvoicingEntity()
        {
            return this._invoicingEntity != null;
        }

        /// <summary>
        /// Gets and sets the property TimeInterval. 
        /// <para>
        /// The date range for invoice summary retrieval. 
        /// </para>
        /// </summary>
        public DateInterval TimeInterval
        {
            get { return this._timeInterval; }
            set { this._timeInterval = value; }
        }

        // Check to see if TimeInterval property is set
        internal bool IsSetTimeInterval()
        {
            return this._timeInterval != null;
        }

    }
}