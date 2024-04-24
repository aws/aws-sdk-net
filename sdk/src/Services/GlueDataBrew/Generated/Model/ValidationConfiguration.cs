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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Configuration for data quality validation. Used to select the Rulesets and Validation
    /// Mode to be used in the profile job. When ValidationConfiguration is null, the profile
    /// job will run without data quality validation.
    /// </summary>
    public partial class ValidationConfiguration
    {
        private string _rulesetArn;
        private ValidationMode _validationMode;

        /// <summary>
        /// Gets and sets the property RulesetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the ruleset to be validated in the profile job.
        /// The TargetArn of the selected ruleset should be the same as the Amazon Resource Name
        /// (ARN) of the dataset that is associated with the profile job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RulesetArn
        {
            get { return this._rulesetArn; }
            set { this._rulesetArn = value; }
        }

        // Check to see if RulesetArn property is set
        internal bool IsSetRulesetArn()
        {
            return this._rulesetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMode. 
        /// <para>
        /// Mode of data quality validation. Default mode is “CHECK_ALL” which verifies all rules
        /// defined in the selected ruleset.
        /// </para>
        /// </summary>
        public ValidationMode ValidationMode
        {
            get { return this._validationMode; }
            set { this._validationMode = value; }
        }

        // Check to see if ValidationMode property is set
        internal bool IsSetValidationMode()
        {
            return this._validationMode != null;
        }

    }
}