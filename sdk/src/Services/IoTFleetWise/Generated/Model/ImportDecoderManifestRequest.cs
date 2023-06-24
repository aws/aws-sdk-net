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
    /// Container for the parameters to the ImportDecoderManifest operation.
    /// Creates a decoder manifest using your existing CAN DBC file from your local device.
    /// </summary>
    public partial class ImportDecoderManifestRequest : AmazonIoTFleetWiseRequest
    {
        private string _name;
        private List<NetworkFileDefinition> _networkFileDefinitions = new List<NetworkFileDefinition>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the decoder manifest to import. 
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
        /// Gets and sets the property NetworkFileDefinitions. 
        /// <para>
        ///  The file to load into an Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<NetworkFileDefinition> NetworkFileDefinitions
        {
            get { return this._networkFileDefinitions; }
            set { this._networkFileDefinitions = value; }
        }

        // Check to see if NetworkFileDefinitions property is set
        internal bool IsSetNetworkFileDefinitions()
        {
            return this._networkFileDefinitions != null && this._networkFileDefinitions.Count > 0; 
        }

    }
}