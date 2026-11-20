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
    /// The reason that one of the records requested from <c>BatchGetFinancialRecord</c> couldn't
    /// be returned. The other records in the request are unaffected.
    /// </summary>
    public partial class FinancialRecordError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code that indicates why the retrieval failed. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOT_FOUND</c> – No financial record on your account matches the key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c> – An internal error occurred while processing this record.
        /// The other records in the request are unaffected. You can retry this record.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the record that couldn't be retrieved, as you requested it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FinancialRecordKey Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of why the operation couldn't retrieve this record. The wording can
        /// change at any time and isn't localized, so don't parse this value. To handle the error
        /// in your code, use <c>code</c> instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
