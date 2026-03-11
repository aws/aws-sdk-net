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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Contains Auto Validation settings, allowing you to suppress sending to specific destination(s)
    /// if they do not meet required threshold. For details on Auto Validation, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/email-validation.html">Auto
    /// Validation</a>.
    /// </summary>
    public partial class SuppressionConditionThreshold
    {
        private FeatureStatus _conditionThresholdEnabled;
        private SuppressionConfidenceThreshold _overallConfidenceThreshold;

        /// <summary>
        /// Gets and sets the property ConditionThresholdEnabled. 
        /// <para>
        /// Indicates whether Auto Validation is enabled for suppression. Set to <c>ENABLED</c>
        /// to enable the Auto Validation feature, or set to <c>DISABLED</c> to disable it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureStatus ConditionThresholdEnabled
        {
            get { return this._conditionThresholdEnabled; }
            set { this._conditionThresholdEnabled = value; }
        }

        // Check to see if ConditionThresholdEnabled property is set
        internal bool IsSetConditionThresholdEnabled()
        {
            return this._conditionThresholdEnabled != null;
        }

        /// <summary>
        /// Gets and sets the property OverallConfidenceThreshold. 
        /// <para>
        /// The overall confidence threshold used to determine suppression decisions.
        /// </para>
        /// </summary>
        public SuppressionConfidenceThreshold OverallConfidenceThreshold
        {
            get { return this._overallConfidenceThreshold; }
            set { this._overallConfidenceThreshold = value; }
        }

        // Check to see if OverallConfidenceThreshold property is set
        internal bool IsSetOverallConfidenceThreshold()
        {
            return this._overallConfidenceThreshold != null;
        }

    }
}