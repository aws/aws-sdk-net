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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateModelManifest operation.
    /// Creates a vehicle model (model manifest) that specifies signals (attributes, branches,
    /// sensors, and actuators). 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/vehicle-models.html">Vehicle
    /// models</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateModelManifestRequest : AmazonIoTFleetWiseRequest
    {
        private string _description;
        private string _name;
        private List<string> _nodes = new List<string>();
        private string _signalCatalogArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the vehicle model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the vehicle model to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Nodes. 
        /// <para>
        ///  A list of nodes, which are a general abstraction of signals. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Nodes
        {
            get { return this._nodes; }
            set { this._nodes = value; }
        }

        // Check to see if Nodes property is set
        internal bool IsSetNodes()
        {
            return this._nodes != null && this._nodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a signal catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SignalCatalogArn
        {
            get { return this._signalCatalogArn; }
            set { this._signalCatalogArn = value; }
        }

        // Check to see if SignalCatalogArn property is set
        internal bool IsSetSignalCatalogArn()
        {
            return this._signalCatalogArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the vehicle model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}