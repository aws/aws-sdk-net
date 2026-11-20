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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetFinancialRecord operation. Retrieves up
    /// to 100 financial records in one request, including the details that are specific to
    /// each record's type. Identify each record by its ID or by its invoice ID. Results can
    /// be partial: each key that you request appears once in the response, either as a record
    /// in <c>financialRecords</c> or as an error in <c>errors</c>. A key that matches no
    /// record on your account is returned in <c>errors</c> and doesn't fail the request.
    /// This operation provides strongly consistent reads. <para> To use this operation, you
    /// must have Amazon Web Services Identity and Access Management (IAM) permission for
    /// both <c>payments:BatchGetFinancialRecord</c> and <c>payments:GetPaymentStatus</c>.
    /// </para>
    /// </summary>
    public partial class BatchGetFinancialRecordRequest : AmazonPaymentsRequest
    {
        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The keys of the financial records to retrieve. Each key is either the record's ID
        /// or its invoice ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<FinancialRecordKey> Keys { get; set; } = AWSConfigs.InitializeCollections ? new List<FinancialRecordKey>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
