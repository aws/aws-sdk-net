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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about properties for a numeric question in an evaluation form.
    /// </summary>
    public partial class EvaluationFormNumericQuestionProperties
    {
        /// <summary>
        /// Gets and sets the property Automation. 
        /// <para>
        /// The automation properties of the numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormNumericQuestionAutomation Automation { get; set; }

        /// <summary>
        /// Checks to see if the Automation property is set.
        /// </summary>
        internal bool IsSetAutomation() => this.Automation != null;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum answer value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum answer value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The scoring options of the numeric question.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormNumericQuestionOption> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationFormNumericQuestionOption>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
