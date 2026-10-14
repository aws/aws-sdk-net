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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Rule statement that uses a script to evaluate license asset conditions.
    /// </summary>
    public partial class ScriptRuleStatement
    {
        /// <summary>
        /// Gets and sets the property KeyToMatch. 
        /// <para>
        /// Key name to match against in the script rule evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyToMatch { get; set; }

        /// <summary>
        /// Checks to see if the KeyToMatch property is set.
        /// </summary>
        internal bool IsSetKeyToMatch() => this.KeyToMatch != null;

        /// <summary>
        /// Gets and sets the property Script. 
        /// <para>
        /// Script code used to evaluate the rule condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Script { get; set; }

        /// <summary>
        /// Checks to see if the Script property is set.
        /// </summary>
        internal bool IsSetScript() => this.Script != null;
    }
}
