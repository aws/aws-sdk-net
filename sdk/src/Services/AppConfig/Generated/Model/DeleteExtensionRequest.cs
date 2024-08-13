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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteExtension operation.
    /// Deletes an AppConfig extension. You must delete all associations to an extension before
    /// you delete the extension.
    /// </summary>
    public partial class DeleteExtensionRequest : AmazonAppConfigRequest
    {
        private string _extensionIdentifier;
        private int? _versionNumber;

        /// <summary>
        /// Gets and sets the property ExtensionIdentifier. 
        /// <para>
        /// The name, ID, or Amazon Resource Name (ARN) of the extension you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ExtensionIdentifier
        {
            get { return this._extensionIdentifier; }
            set { this._extensionIdentifier = value; }
        }

        // Check to see if ExtensionIdentifier property is set
        internal bool IsSetExtensionIdentifier()
        {
            return this._extensionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// A specific version of an extension to delete. If omitted, the highest version is deleted.
        /// </para>
        /// </summary>
        public int? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}