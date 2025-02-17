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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the detected behavior.
    /// </summary>
    public partial class Detection
    {
        private Anomaly _anomaly;
        private Sequence _sequence;

        /// <summary>
        /// Gets and sets the property Anomaly. 
        /// <para>
        /// The details about the anomalous activity that caused GuardDuty to generate the finding.
        /// </para>
        /// </summary>
        public Anomaly Anomaly
        {
            get { return this._anomaly; }
            set { this._anomaly = value; }
        }

        // Check to see if Anomaly property is set
        internal bool IsSetAnomaly()
        {
            return this._anomaly != null;
        }

        /// <summary>
        /// Gets and sets the property Sequence. 
        /// <para>
        /// The details about the attack sequence.
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