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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the PutPositionConfiguration operation.
    /// Put position configuration for a given resource.
    /// 
    ///  <important> 
    /// <para>
    /// This action is no longer supported. Calls to update the position configuration should
    /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_UpdateResourcePosition.html">UpdateResourcePosition</a>
    /// API operation instead.
    /// </para>
    ///  </important>
    /// </summary>
    [Obsolete("This operation is no longer supported.")]
    public partial class PutPositionConfigurationRequest : AmazonIoTWirelessRequest
    {
        private string _destination;
        private string _resourceIdentifier;
        private PositionResourceType _resourceType;
        private PositionSolverConfigurations _solvers;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The position data destination that describes the AWS IoT rule that processes the device's
        /// position data for use by AWS IoT Core for LoRaWAN.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Resource identifier used to update the position configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type of the resource for which you want to update the position configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PositionResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Solvers. 
        /// <para>
        /// The positioning solvers used to update the position configuration of the resource.
        /// </para>
        /// </summary>
        public PositionSolverConfigurations Solvers
        {
            get { return this._solvers; }
            set { this._solvers = value; }
        }

        // Check to see if Solvers property is set
        internal bool IsSetSolvers()
        {
            return this._solvers != null;
        }

    }
}