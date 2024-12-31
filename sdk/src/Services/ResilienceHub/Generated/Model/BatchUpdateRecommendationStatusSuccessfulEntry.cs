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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
        private string _appComponentId;
        private string _entryId;
        private bool? _excluded;
        private ExcludeRecommendationReason _excludeReason;
        private UpdateRecommendationStatusItem _item;
        private string _referenceId;

        /// <summary>
        /// Gets and sets the property AppComponentId. 
        /// <para>
        /// Indicates the identifier of an AppComponent.
        /// </para>
        /// </summary>
        public string AppComponentId
        {
            get { return this._appComponentId; }
            set { this._appComponentId = value; }
        }

        // Check to see if AppComponentId property is set
        internal bool IsSetAppComponentId()
        {
            return this._appComponentId != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EntryId
        {
            get { return this._entryId; }
            set { this._entryId = value; }
        }

        // Check to see if EntryId property is set
        internal bool IsSetEntryId()
        {
            return this._entryId != null;
        }

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Indicates if the operational recommendation was successfully excluded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Excluded
        {
            get { return this._excluded; }
            set { this._excluded = value; }
        }

        // Check to see if Excluded property is set
        internal bool IsSetExcluded()
        {
            return this._excluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeReason. 
        /// <para>
        /// Indicates the reason for excluding an operational recommendation.
        /// </para>
        /// </summary>
        public ExcludeRecommendationReason ExcludeReason
        {
            get { return this._excludeReason; }
            set { this._excludeReason = value; }
        }

        // Check to see if ExcludeReason property is set
        internal bool IsSetExcludeReason()
        {
            return this._excludeReason != null;
        }

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// The operational recommendation item.
        /// </para>
        /// </summary>
        public UpdateRecommendationStatusItem Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this._item != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Reference identifier of the operational recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

    }
}