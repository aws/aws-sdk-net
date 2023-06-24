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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// A summary of enabled controls.
    /// </summary>
    public partial class EnabledControlSummary
    {
        private string _controlIdentifier;

        /// <summary>
        /// Gets and sets the property ControlIdentifier. 
        /// <para>
        /// The ARN of the control. Only <b>Strongly recommended</b> and <b>Elective</b> controls
        /// are permitted, with the exception of the <b>Region deny</b> guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ControlIdentifier
        {
            get { return this._controlIdentifier; }
            set { this._controlIdentifier = value; }
        }

        // Check to see if ControlIdentifier property is set
        internal bool IsSetControlIdentifier()
        {
            return this._controlIdentifier != null;
        }

    }
}