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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// List of operational recommendations that did not get included or excluded.
    /// </summary>
    public partial class BatchUpdateRecommendationStatusFailedEntry
    {
        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// An identifier of an entry in this batch that is used to communicate the result.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>entryId</c>s of a batch request need to be unique within a request.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EntryId { get; set; }

        /// <summary>
        /// Checks to see if the EntryId property is set.
        /// </summary>
        internal bool IsSetEntryId() => this.EntryId != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Indicates the error that occurred while excluding an operational recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;
    }
}
