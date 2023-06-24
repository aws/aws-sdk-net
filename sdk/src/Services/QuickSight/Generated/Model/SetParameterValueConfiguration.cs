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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of adding parameters in action.
    /// </summary>
    public partial class SetParameterValueConfiguration
    {
        private string _destinationParameterName;
        private DestinationParameterValueConfiguration _value;

        /// <summary>
        /// Gets and sets the property DestinationParameterName. 
        /// <para>
        /// The destination parameter name of the <code>SetParameterValueConfiguration</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DestinationParameterName
        {
            get { return this._destinationParameterName; }
            set { this._destinationParameterName = value; }
        }

        // Check to see if DestinationParameterName property is set
        internal bool IsSetDestinationParameterName()
        {
            return this._destinationParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationParameterValueConfiguration Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}