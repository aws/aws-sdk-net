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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains information for an entry that has been processed by the previous <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_BatchGetAssetPropertyValue.html">BatchGetAssetPropertyValue</a>
    /// request.
    /// </summary>
    public partial class BatchGetAssetPropertyValueSkippedEntry
    {
        /// <summary>
        /// Gets and sets the property CompletionStatus. 
        /// <para>
        /// The completion status of each entry that is associated with the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_BatchGetAssetPropertyValue.html">BatchGetAssetPropertyValue</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchEntryCompletionStatus CompletionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CompletionStatus property is set.
        /// </summary>
        internal bool IsSetCompletionStatus() => this.CompletionStatus != null;

        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// The ID of the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EntryId { get; set; }

        /// <summary>
        /// Checks to see if the EntryId property is set.
        /// </summary>
        internal bool IsSetEntryId() => this.EntryId != null;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// The error information, such as the error code and the timestamp.
        /// </para>
        /// </summary>
        public BatchGetAssetPropertyValueErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;
    }
}
