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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The status details of the analysis template validation. Clean Rooms Differential Privacy
    /// uses a general-purpose query structure to support complex SQL queries and validates
    /// whether an analysis template fits that general-purpose query structure. Validation
    /// is performed when analysis templates are created and fetched. Because analysis templates
    /// are immutable by design, we recommend that you create analysis templates after you
    /// associate the configured tables with their analysis rule to your collaboration.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/analysis-rules-custom.html#custom-diff-privacy">https://docs.aws.amazon.com/clean-rooms/latest/userguide/analysis-rules-custom.html#custom-diff-privacy</a>.
    /// </para>
    /// </summary>
    public partial class AnalysisTemplateValidationStatusDetail
    {
        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The reasons for the validation results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisTemplateValidationStatusReason> Reasons { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisTemplateValidationStatusReason>() : null;

        /// <summary>
        /// Checks to see if the Reasons property is set.
        /// </summary>
        internal bool IsSetReasons() => this.Reasons != null && (this.Reasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisTemplateValidationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of validation that was performed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisTemplateValidationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
