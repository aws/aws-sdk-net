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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Container for the parameters to the SignalApplicationInstanceNodeInstances operation.
    /// Signal camera nodes to stop or resume.
    /// </summary>
    public partial class SignalApplicationInstanceNodeInstancesRequest : AmazonPanoramaRequest
    {
        private string _applicationInstanceId;
        private List<NodeSignal> _nodeSignals = AWSConfigs.InitializeCollections ? new List<NodeSignal>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationInstanceId. 
        /// <para>
        /// An application instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ApplicationInstanceId
        {
            get { return this._applicationInstanceId; }
            set { this._applicationInstanceId = value; }
        }

        // Check to see if ApplicationInstanceId property is set
        internal bool IsSetApplicationInstanceId()
        {
            return this._applicationInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeSignals. 
        /// <para>
        /// A list of signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<NodeSignal> NodeSignals
        {
            get { return this._nodeSignals; }
            set { this._nodeSignals = value; }
        }

        // Check to see if NodeSignals property is set
        internal bool IsSetNodeSignals()
        {
            return this._nodeSignals != null && (this._nodeSignals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}