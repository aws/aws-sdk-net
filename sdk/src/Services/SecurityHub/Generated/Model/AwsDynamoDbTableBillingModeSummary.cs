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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the billing for read/write capacity on the table.
    /// </summary>
    public partial class AwsDynamoDbTableBillingModeSummary
    {
        private string _billingMode;
        private string _lastUpdateToPayPerRequestDateTime;

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The method used to charge for read and write throughput and to manage capacity.
        /// </para>
        /// </summary>
        public string BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateToPayPerRequestDateTime. 
        /// <para>
        /// If the billing mode is <c>PAY_PER_REQUEST</c>, indicates when the billing mode was
        /// set to that value.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastUpdateToPayPerRequestDateTime
        {
            get { return this._lastUpdateToPayPerRequestDateTime; }
            set { this._lastUpdateToPayPerRequestDateTime = value; }
        }

        // Check to see if LastUpdateToPayPerRequestDateTime property is set
        internal bool IsSetLastUpdateToPayPerRequestDateTime()
        {
            return this._lastUpdateToPayPerRequestDateTime != null;
        }

    }
}