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
    /// Information about the automation configuration in single select questions. Automation
    /// options are evaluated in order, and the first matched option is applied. If no automation
    /// option matches, and there is a default option, then the default option is applied.
    /// </summary>
    public partial class EvaluationFormSingleSelectQuestionAutomation
    {
        private string _defaultOptionRefId;
        private List<EvaluationFormSingleSelectQuestionAutomationOption> _options = AWSConfigs.InitializeCollections ? new List<EvaluationFormSingleSelectQuestionAutomationOption>() : null;

        /// <summary>
        /// Gets and sets the property DefaultOptionRefId. 
        /// <para>
        /// The identifier of the default answer option, when none of the automation options match
        /// the criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string DefaultOptionRefId
        {
            get { return this._defaultOptionRefId; }
            set { this._defaultOptionRefId = value; }
        }

        // Check to see if DefaultOptionRefId property is set
        internal bool IsSetDefaultOptionRefId()
        {
            return this._defaultOptionRefId != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The automation options of the single select question.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<EvaluationFormSingleSelectQuestionAutomationOption> Options
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