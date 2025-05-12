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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Dataflow details for the destination side.
    /// </summary>
    public partial class Destination
    {
        private ConfigDetails _configDetails;
        private string _configId;
        private ConfigCapabilityType _configType;
        private string _dataflowDestinationRegion;

        /// <summary>
        /// Gets and sets the property ConfigDetails. 
        /// <para>
        /// Additional details for a <c>Config</c>, if type is dataflow endpoint or antenna demod
        /// decode.
        /// </para>
        /// </summary>
        public ConfigDetails ConfigDetails
        {
            get { return this._configDetails; }
            set { this._configDetails = value; }
        }

        // Check to see if ConfigDetails property is set
        internal bool IsSetConfigDetails()
        {
            return this._configDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// UUID of a <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }

        // Check to see if ConfigId property is set
        internal bool IsSetConfigId()
        {
            return this._configId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigType. 
        /// <para>
        /// Type of a <c>Config</c>.
        /// </para>
        /// </summary>
        public ConfigCapabilityType ConfigType
        {
            get { return this._configType; }
            set { this._configType = value; }
        }

        // Check to see if ConfigType property is set
        internal bool IsSetConfigType()
        {
            return this._configType != null;
        }

        /// <summary>
        /// Gets and sets the property DataflowDestinationRegion. 
        /// <para>
        /// Region of a dataflow destination.
        /// </para>
        /// </summary>
        public string DataflowDestinationRegion
        {
            get { return this._dataflowDestinationRegion; }
            set { this._dataflowDestinationRegion = value; }
        }

        // Check to see if DataflowDestinationRegion property is set
        internal bool IsSetDataflowDestinationRegion()
        {
            return this._dataflowDestinationRegion != null;
        }

    }
}