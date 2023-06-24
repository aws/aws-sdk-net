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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// An extension that was invoked during a deployment.
    /// </summary>
    public partial class AppliedExtension
    {
        private string _extensionAssociationId;
        private string _extensionId;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private int? _versionNumber;

        /// <summary>
        /// Gets and sets the property ExtensionAssociationId. 
        /// <para>
        /// The system-generated ID for the association.
        /// </para>
        /// </summary>
        public string ExtensionAssociationId
        {
            get { return this._extensionAssociationId; }
            set { this._extensionAssociationId = value; }
        }

        // Check to see if ExtensionAssociationId property is set
        internal bool IsSetExtensionAssociationId()
        {
            return this._extensionAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property ExtensionId. 
        /// <para>
        /// The system-generated ID of the extension.
        /// </para>
        /// </summary>
        public string ExtensionId
        {
            get { return this._extensionId; }
            set { this._extensionId = value; }
        }

        // Check to see if ExtensionId property is set
        internal bool IsSetExtensionId()
        {
            return this._extensionId != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// One or more parameters for the actions called by the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The extension version number.
        /// </para>
        /// </summary>
        public int VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}