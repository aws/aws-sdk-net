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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private EvaluationFormNumericQuestionAutomation _automation;
        private int? _maxValue;
        private int? _minValue;
        private List<EvaluationFormNumericQuestionOption> _options = AWSConfigs.InitializeCollections ? new List<EvaluationFormNumericQuestionOption>() : null;

        /// <summary>
        /// Gets and sets the property Automation. 
        /// <para>
        /// The automation properties of the numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormNumericQuestionAutomation Automation
        {
            get { return this._automation; }
            set { this._automation = value; }
        }

        // Check to see if Automation property is set
        internal bool IsSetAutomation()
        {
            return this._automation != null;
        }

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum answer value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum answer value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The scoring options of the numeric question.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EvaluationFormNumericQuestionOption> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}