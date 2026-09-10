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
    /// Segment containing information extracted from the conversation. Each segment represents
    /// the results for a single extraction definition.
    /// </summary>
    public partial class ExtractedInformation
    {
        /// <summary>
        /// Gets and sets the property ExtractedValues. 
        /// <para>
        /// The list of values extracted from the conversation for this extraction definition.
        /// This field is empty when a <c>FailureCode</c> is present.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExtractedInformationValue> ExtractedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ExtractedInformationValue>() : null;

        /// <summary>
        /// Checks to see if the ExtractedValues property is set.
        /// </summary>
        internal bool IsSetExtractedValues() => this.ExtractedValues != null && (this.ExtractedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionDisplayLabel. 
        /// <para>
        /// The display label of the extraction definition that produced this result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public string ExtractionDefinitionDisplayLabel { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionDefinitionDisplayLabel property is set.
        /// </summary>
        internal bool IsSetExtractionDefinitionDisplayLabel() => this.ExtractionDefinitionDisplayLabel != null;

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionId. 
        /// <para>
        /// The identifier of the extraction definition that produced this result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExtractionDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionDefinitionId property is set.
        /// </summary>
        internal bool IsSetExtractionDefinitionId() => this.ExtractionDefinitionId != null;

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionName. 
        /// <para>
        /// The name of the extraction definition that produced this result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ExtractionDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionDefinitionName property is set.
        /// </summary>
        internal bool IsSetExtractionDefinitionName() => this.ExtractionDefinitionName != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// If the information failed to be extracted, one of the following failure codes occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>QUOTA_EXCEEDED</c>: The number of concurrent analytics jobs reached your service
        /// quota.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_CONVERSATION_CONTENT</c>: Information extraction requires a conversation
        /// with at least one turn from each participant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_SAFETY_GUIDELINES</c>: The extracted information cannot be provided because
        /// it failed to meet system safety guidelines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c>: Internal system error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAX_PACKAGE_FEATURE_ONLY</c>: Information extraction is only available in Amazon
        /// Connect Customer instances.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExtractedInformationFailureCode FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;
    }
}
