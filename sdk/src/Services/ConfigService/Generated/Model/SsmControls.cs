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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Amazon Web Services Systems Manager (SSM) specific remediation controls.
    /// </summary>
    public partial class SsmControls
    {
        private int? _concurrentExecutionRatePercentage;
        private int? _errorPercentage;

        /// <summary>
        /// Gets and sets the property ConcurrentExecutionRatePercentage. 
        /// <para>
        /// The maximum percentage of remediation actions allowed to run in parallel on the non-compliant
        /// resources for that specific rule. You can specify a percentage, such as 10%. The default
        /// value is 10. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? ConcurrentExecutionRatePercentage
        {
            get { return this._concurrentExecutionRatePercentage; }
            set { this._concurrentExecutionRatePercentage = value; }
        }

        // Check to see if ConcurrentExecutionRatePercentage property is set
        internal bool IsSetConcurrentExecutionRatePercentage()
        {
            return this._concurrentExecutionRatePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorPercentage. 
        /// <para>
        /// The percentage of errors that are allowed before SSM stops running automations on
        /// non-compliant resources for that specific rule. You can specify a percentage of errors,
        /// for example 10%. If you do not specifiy a percentage, the default is 50%. For example,
        /// if you set the ErrorPercentage to 40% for 10 non-compliant resources, then SSM stops
        /// running the automations when the fifth error is received. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? ErrorPercentage
        {
            get { return this._errorPercentage; }
            set { this._errorPercentage = value; }
        }

        // Check to see if ErrorPercentage property is set
        internal bool IsSetErrorPercentage()
        {
            return this._errorPercentage.HasValue; 
        }

    }
}