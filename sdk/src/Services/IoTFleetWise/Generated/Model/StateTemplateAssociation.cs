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
    /// The state template associated with a vehicle. State templates contain state properties,
    /// which are signals that belong to a signal catalog that is synchronized between the
    /// Amazon Web Services IoT FleetWise Edge and the Amazon Web Services Cloud.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StateTemplateAssociation
    {
        private string _identifier;
        private StateTemplateUpdateStrategy _stateTemplateUpdateStrategy;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique ID of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property StateTemplateUpdateStrategy.
        /// </summary>
        [AWSProperty(Required=true)]
        public StateTemplateUpdateStrategy StateTemplateUpdateStrategy
        {
            get { return this._stateTemplateUpdateStrategy; }
            set { this._stateTemplateUpdateStrategy = value; }
        }

        // Check to see if StateTemplateUpdateStrategy property is set
        internal bool IsSetStateTemplateUpdateStrategy()
        {
            return this._stateTemplateUpdateStrategy != null;
        }

    }
}