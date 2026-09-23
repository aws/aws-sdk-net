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
    /// List of operational recommendations that were successfully included or excluded.
    /// </summary>
    public partial class BatchUpdateRecommendationStatusSuccessfulEntry
    {
        /// <summary>
        /// Gets and sets the property AppComponentId. 
        /// <para>
        /// Indicates the identifier of an AppComponent.
        /// </para>
        /// </summary>
        public string AppComponentId { get; set; }

        /// <summary>
        /// Checks to see if the AppComponentId property is set.
        /// </summary>
        internal bool IsSetAppComponentId() => this.AppComponentId != null;

        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// An identifier for an entry in this batch that is used to communicate the result.
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
        /// Gets and sets the property ExcludeReason. 
        /// <para>
        /// Indicates the reason for excluding an operational recommendation.
        /// </para>
        /// </summary>
        public ExcludeRecommendationReason ExcludeReason { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeReason property is set.
        /// </summary>
        internal bool IsSetExcludeReason() => this.ExcludeReason != null;

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Indicates if the operational recommendation was successfully excluded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Excluded { get; set; }

        /// <summary>
        /// Checks to see if the Excluded property is set.
        /// </summary>
        internal bool IsSetExcluded() => this.Excluded.HasValue;

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// The operational recommendation item.
        /// </para>
        /// </summary>
        public UpdateRecommendationStatusItem Item { get; set; }

        /// <summary>
        /// Checks to see if the Item property is set.
        /// </summary>
        internal bool IsSetItem() => this.Item != null;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Reference identifier of the operational recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;
    }
}
