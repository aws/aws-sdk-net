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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Contains details about a call analytics job, including information about skipped analytics
    /// features.
    /// </summary>
    public partial class CallAnalyticsJobDetails
    {
        private List<CallAnalyticsSkippedFeature> _skipped = AWSConfigs.InitializeCollections ? new List<CallAnalyticsSkippedFeature>() : null;

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// Contains information about any skipped analytics features during the analysis of a
        /// call analytics job.
        /// </para>
        ///  
        /// <para>
        /// This array lists all the analytics features that were skipped, along with their corresponding
        /// reason code and message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsSkippedFeature> Skipped
        {
            get { return this._skipped; }
            set { this._skipped = value; }
        }

        // Check to see if Skipped property is set
        internal bool IsSetSkipped()
        {
            return this._skipped != null && (this._skipped.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}