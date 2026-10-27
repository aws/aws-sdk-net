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
    /// Summary information about documents grouped by the same document type.
    /// </summary>
    public partial class DocumentGroup
    {
        /// <summary>
        /// Gets and sets the property DetectedSignatures. 
        /// <para>
        /// A list of the detected signatures found in a document group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetectedSignature> DetectedSignatures { get; set; } = AWSConfigs.InitializeCollections ? new List<DetectedSignature>() : null;

        /// <summary>
        /// Checks to see if the DetectedSignatures property is set.
        /// </summary>
        internal bool IsSetDetectedSignatures() => this.DetectedSignatures != null && (this.DetectedSignatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SplitDocuments. 
        /// <para>
        /// An array that contains information about the pages of a document, defined by logical
        /// boundary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SplitDocument> SplitDocuments { get; set; } = AWSConfigs.InitializeCollections ? new List<SplitDocument>() : null;

        /// <summary>
        /// Checks to see if the SplitDocuments property is set.
        /// </summary>
        internal bool IsSetSplitDocuments() => this.SplitDocuments != null && (this.SplitDocuments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document that Amazon Textract has detected. See <a href="https://docs.aws.amazon.com/textract/latest/dg/lending-response-objects.html">Analyze
        /// Lending Response Objects</a> for a list of all types returned by Textract.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UndetectedSignatures. 
        /// <para>
        /// A list of any expected signatures not found in a document group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UndetectedSignature> UndetectedSignatures { get; set; } = AWSConfigs.InitializeCollections ? new List<UndetectedSignature>() : null;

        /// <summary>
        /// Checks to see if the UndetectedSignatures property is set.
        /// </summary>
        internal bool IsSetUndetectedSignatures() => this.UndetectedSignatures != null && (this.UndetectedSignatures.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
