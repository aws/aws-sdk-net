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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Filter events using an event pattern. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html">Events
    /// and Event Patterns</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </summary>
    public partial class Filter
    {
        private string _pattern;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The event pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}