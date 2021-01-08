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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDirectoryConfig operation.
    /// Creates a Directory Config object in AppStream 2.0. This object includes the configuration
    /// information required to join fleets and image builders to Microsoft Active Directory
    /// domains.
    /// </summary>
    public partial class CreateDirectoryConfigRequest : AmazonAppStreamRequest
    {
        private string _directoryName;
        private List<string> _organizationalUnitDistinguishedNames = new List<string>();
        private ServiceAccountCredentials _serviceAccountCredentials;

        /// <summary>
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The fully qualified name of the directory (for example, corp.example.com).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryName
        {
            get { return this._directoryName; }
            set { this._directoryName = value; }
        }

        // Check to see if DirectoryName property is set
        internal bool IsSetDirectoryName()
        {
            return this._directoryName != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitDistinguishedNames. 
        /// <para>
        /// The distinguished names of the organizational units for computer accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OrganizationalUnitDistinguishedNames
        {
            get { return this._organizationalUnitDistinguishedNames; }
            set { this._organizationalUnitDistinguishedNames = value; }
        }

        // Check to see if OrganizationalUnitDistinguishedNames property is set
        internal bool IsSetOrganizationalUnitDistinguishedNames()
        {
            return this._organizationalUnitDistinguishedNames != null && this._organizationalUnitDistinguishedNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountCredentials. 
        /// <para>
        /// The credentials for the service account used by the fleet or image builder to connect
        /// to the directory.
        /// </para>
        /// </summary>
        public ServiceAccountCredentials ServiceAccountCredentials
        {
            get { return this._serviceAccountCredentials; }
            set { this._serviceAccountCredentials = value; }
        }

        // Check to see if ServiceAccountCredentials property is set
        internal bool IsSetServiceAccountCredentials()
        {
            return this._serviceAccountCredentials != null;
        }

    }
}