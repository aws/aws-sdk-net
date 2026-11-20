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
    /// This is the response object from the BatchGetFinancialRecord operation.
    /// </summary>
    public partial class BatchGetFinancialRecordResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The errors for the records that the operation couldn't retrieve, one for each record,
        /// with the key as you requested it and the reason. This list is empty when the operation
        /// retrieved every record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<FinancialRecordError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<FinancialRecordError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FinancialRecords. 
        /// <para>
        /// The financial records that the operation retrieved, in no particular order. This list
        /// contains fewer records than you requested when <c>errors</c> names one or more keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<FinancialRecord> FinancialRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<FinancialRecord>() : null;

        /// <summary>
        /// Checks to see if the FinancialRecords property is set.
        /// </summary>
        internal bool IsSetFinancialRecords() => this.FinancialRecords != null && (this.FinancialRecords.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
