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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Contains the detections for each page analyzed through the Analyze Lending API.
    /// </summary>
    public partial class LendingResult
    {
        /// <summary>
        /// Gets and sets the property Extractions. 
        /// <para>
        /// An array of Extraction to hold structured data. e.g. normalized key value pairs instead
        /// of raw OCR detections .
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Extraction> Extractions { get; set; } = AWSConfigs.InitializeCollections ? new List<Extraction>() : null;

        /// <summary>
        /// Checks to see if the Extractions property is set.
        /// </summary>
        internal bool IsSetExtractions() => this.Extractions != null && (this.Extractions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// The page number for a page, with regard to whole submission.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Page { get; set; }

        /// <summary>
        /// Checks to see if the Page property is set.
        /// </summary>
        internal bool IsSetPage() => this.Page.HasValue;

        /// <summary>
        /// Gets and sets the property PageClassification. 
        /// <para>
        /// The classifier result for a given page.
        /// </para>
        /// </summary>
        public PageClassification PageClassification { get; set; }

        /// <summary>
        /// Checks to see if the PageClassification property is set.
        /// </summary>
        internal bool IsSetPageClassification() => this.PageClassification != null;
    }
}
