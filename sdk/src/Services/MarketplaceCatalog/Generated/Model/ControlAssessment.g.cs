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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The result of evaluating a single control as part of an assessment.
    /// </summary>
    public partial class ControlAssessment
    {
        /// <summary>
        /// Gets and sets the property ControlAssessmentResult. 
        /// <para>
        /// The result of the control evaluation.
        /// </para>
        /// </summary>
        public ControlAssessmentResult ControlAssessmentResult { get; set; }

        /// <summary>
        /// Checks to see if the ControlAssessmentResult property is set.
        /// </summary>
        internal bool IsSetControlAssessmentResult() => this.ControlAssessmentResult != null;

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// The unique ID of the control that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ControlId { get; set; }

        /// <summary>
        /// Checks to see if the ControlId property is set.
        /// </summary>
        internal bool IsSetControlId() => this.ControlId != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of <c>ControlError</c> objects associated with the control evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ControlError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
