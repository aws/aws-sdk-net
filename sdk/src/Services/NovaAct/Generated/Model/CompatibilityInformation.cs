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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Information about client compatibility and supported model versions.
    /// </summary>
    public partial class CompatibilityInformation
    {
        private int? _clientCompatibilityVersion;
        private string _message;
        private List<string> _supportedModelIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientCompatibilityVersion. 
        /// <para>
        /// The client compatibility version that was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ClientCompatibilityVersion
        {
            get { return this._clientCompatibilityVersion.GetValueOrDefault(); }
            set { this._clientCompatibilityVersion = value; }
        }

        // Check to see if ClientCompatibilityVersion property is set
        internal bool IsSetClientCompatibilityVersion()
        {
            return this._clientCompatibilityVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information about compatibility requirements or recommendations.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedModelIds. 
        /// <para>
        /// A list of model IDs that are supported for the client compatibility version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedModelIds
        {
            get { return this._supportedModelIds; }
            set { this._supportedModelIds = value; }
        }

        // Check to see if SupportedModelIds property is set
        internal bool IsSetSupportedModelIds()
        {
            return this._supportedModelIds != null && (this._supportedModelIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}