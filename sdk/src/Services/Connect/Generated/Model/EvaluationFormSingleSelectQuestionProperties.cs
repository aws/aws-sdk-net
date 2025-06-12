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
    /// Information about the options in single select questions.
    /// </summary>
    public partial class EvaluationFormSingleSelectQuestionProperties
    {
        private EvaluationFormSingleSelectQuestionAutomation _automation;
        private EvaluationFormSingleSelectQuestionDisplayMode _displayAs;
        private List<EvaluationFormSingleSelectQuestionOption> _options = AWSConfigs.InitializeCollections ? new List<EvaluationFormSingleSelectQuestionOption>() : null;

        /// <summary>
        /// Gets and sets the property Automation. 
        /// <para>
        /// The display mode of the single select question.
        /// </para>
        /// </summary>
        public EvaluationFormSingleSelectQuestionAutomation Automation
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
        /// Gets and sets the property DisplayAs. 
        /// <para>
        /// The display mode of the single select question.
        /// </para>
        /// </summary>
        public EvaluationFormSingleSelectQuestionDisplayMode DisplayAs
        {
            get { return this._displayAs; }
            set { this._displayAs = value; }
        }

        // Check to see if DisplayAs property is set
        internal bool IsSetDisplayAs()
        {
            return this._displayAs != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The answer options of the single select question.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public List<EvaluationFormSingleSelectQuestionOption> Options
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