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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateSecurityProfileBehaviors operation.
    /// Validates a Device Defender security profile behaviors specification.
    /// </summary>
    public partial class ValidateSecurityProfileBehaviorsRequest : AmazonIoTRequest
    {
        private List<Behavior> _behaviors = new List<Behavior>();

        /// <summary>
        /// Gets and sets the property Behaviors. 
        /// <para>
        /// Specifies the behaviors that, when violated by a device (thing), cause an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public List<Behavior> Behaviors
        {
            get { return this._behaviors; }
            set { this._behaviors = value; }
        }

        // Check to see if Behaviors property is set
        internal bool IsSetBehaviors()
        {
            return this._behaviors != null && this._behaviors.Count > 0; 
        }

    }
}