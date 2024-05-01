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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Specifies the default alarm state. The configuration applies to all alarms that were
    /// created based on this alarm model.
    /// </summary>
    public partial class InitializationConfiguration
    {
        private bool? _disabledOnInitialization;

        /// <summary>
        /// Gets and sets the property DisabledOnInitialization. 
        /// <para>
        /// The value must be <c>TRUE</c> or <c>FALSE</c>. If <c>FALSE</c>, all alarm instances
        /// created based on the alarm model are activated. The default value is <c>TRUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DisabledOnInitialization
        {
            get { return this._disabledOnInitialization; }
            set { this._disabledOnInitialization = value; }
        }

        // Check to see if DisabledOnInitialization property is set
        internal bool IsSetDisabledOnInitialization()
        {
            return this._disabledOnInitialization.HasValue; 
        }

    }
}