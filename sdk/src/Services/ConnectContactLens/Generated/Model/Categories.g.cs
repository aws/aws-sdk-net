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

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// Provides the category rules that are used to automatically categorize contacts based
    /// on uttered keywords and phrases.
    /// </summary>
    public partial class Categories
    {
        /// <summary>
        /// Gets and sets the property MatchedCategories. 
        /// <para>
        /// The category rules that have been matched in the analyzed segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 150)]
        public List<string> MatchedCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchedCategories property is set.
        /// </summary>
        internal bool IsSetMatchedCategories() => this.MatchedCategories != null && (this.MatchedCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchedDetails. 
        /// <para>
        /// The category rule that was matched and when it occurred in the transcript.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 150)]
        public Dictionary<string, CategoryDetails> MatchedDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CategoryDetails>() : null;

        /// <summary>
        /// Checks to see if the MatchedDetails property is set.
        /// </summary>
        internal bool IsSetMatchedDetails() => this.MatchedDetails != null && (this.MatchedDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
