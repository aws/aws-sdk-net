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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A top-level object field that provides details about an Amazon GuardDuty Extended
    /// Threat Detection attack sequence. GuardDuty generates an attack sequence finding when
    /// multiple events align to a potentially suspicious activity. To receive GuardDuty attack
    /// sequence findings in Security Hub, you must have GuardDuty enabled. For more information,
    /// see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class Detection
    {
        private Sequence _sequence;

        /// <summary>
        /// Gets and sets the property Sequence. 
        /// <para>
        ///  Provides details about an attack sequence. 
        /// </para>
        /// </summary>
        public Sequence Sequence
        {
            get { return this._sequence; }
            set { this._sequence = value; }
        }

        // Check to see if Sequence property is set
        internal bool IsSetSequence()
        {
            return this._sequence != null;
        }

    }
}