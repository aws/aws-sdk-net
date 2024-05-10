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
    /// Contains the configuration information of alarm state changes.
    /// </summary>
    public partial class AlarmCapabilities
    {
        private AcknowledgeFlow _acknowledgeFlow;
        private InitializationConfiguration _initializationConfiguration;

        /// <summary>
        /// Gets and sets the property AcknowledgeFlow. 
        /// <para>
        /// Specifies whether to get notified for alarm state changes.
        /// </para>
        /// </summary>
        public AcknowledgeFlow AcknowledgeFlow
        {
            get { return this._acknowledgeFlow; }
            set { this._acknowledgeFlow = value; }
        }

        // Check to see if AcknowledgeFlow property is set
        internal bool IsSetAcknowledgeFlow()
        {
            return this._acknowledgeFlow != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationConfiguration. 
        /// <para>
        /// Specifies the default alarm state. The configuration applies to all alarms that were
        /// created based on this alarm model.
        /// </para>
        /// </summary>
        public InitializationConfiguration InitializationConfiguration
        {
            get { return this._initializationConfiguration; }
            set { this._initializationConfiguration = value; }
        }

        // Check to see if InitializationConfiguration property is set
        internal bool IsSetInitializationConfiguration()
        {
            return this._initializationConfiguration != null;
        }

    }
}