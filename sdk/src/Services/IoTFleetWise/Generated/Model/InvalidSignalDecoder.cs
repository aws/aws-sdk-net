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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// A reason that a signal decoder isn't valid.
    /// </summary>
    public partial class InvalidSignalDecoder
    {
        private string _hint;
        private string _name;
        private SignalDecoderFailureReason _reason;

        /// <summary>
        /// Gets and sets the property Hint. 
        /// <para>
        /// The possible cause for the invalid signal decoder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Hint
        {
            get { return this._hint; }
            set { this._hint = value; }
        }

        // Check to see if Hint property is set
        internal bool IsSetHint()
        {
            return this._hint != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a signal decoder that isn't valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message about why the signal decoder isn't valid.
        /// </para>
        /// </summary>
        public SignalDecoderFailureReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}