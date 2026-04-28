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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Media Connect Router Output Settings
    /// </summary>
    public partial class MediaConnectRouterOutputSettings
    {
        private MediaConnectRouterOutputConnectionMap _connectedRouterInputs;
        private MediaConnectRouterContainerSettings _containerSettings;
        private OutputLocationRef _destination;

        /// <summary>
        /// Gets and sets the property ConnectedRouterInputs. Shows the MediaConnect Router Inputs
        /// that are connected to this output. This parameter is purely informative, and editing
        /// it will have no effect. To connect or disconnect MediaConnect Router Inputs, go to
        /// MediaConnect.
        /// </summary>
        public MediaConnectRouterOutputConnectionMap ConnectedRouterInputs
        {
            get { return this._connectedRouterInputs; }
            set { this._connectedRouterInputs = value; }
        }

        // Check to see if ConnectedRouterInputs property is set
        internal bool IsSetConnectedRouterInputs()
        {
            return this._connectedRouterInputs != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerSettings.
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaConnectRouterContainerSettings ContainerSettings
        {
            get { return this._containerSettings; }
            set { this._containerSettings = value; }
        }

        // Check to see if ContainerSettings property is set
        internal bool IsSetContainerSettings()
        {
            return this._containerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. Destination for this MediaConnect Router Output.
        /// The referenced OutputDestination must have MediaConnect Router settings configured.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

    }
}