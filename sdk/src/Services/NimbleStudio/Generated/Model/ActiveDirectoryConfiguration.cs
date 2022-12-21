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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The configuration for a Directory Service for Microsoft Active Directory studio resource.
    /// </summary>
    public partial class ActiveDirectoryConfiguration
    {
        private List<ActiveDirectoryComputerAttribute> _computerAttributes = new List<ActiveDirectoryComputerAttribute>();
        private string _directoryId;
        private string _organizationalUnitDistinguishedName;

        /// <summary>
        /// Gets and sets the property ComputerAttributes. 
        /// <para>
        /// A collection of custom attributes for an Active Directory computer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ActiveDirectoryComputerAttribute> ComputerAttributes
        {
            get { return this._computerAttributes; }
            set { this._computerAttributes = value; }
        }

        // Check to see if ComputerAttributes property is set
        internal bool IsSetComputerAttributes()
        {
            return this._computerAttributes != null && this._computerAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID of the Directory Service for Microsoft Active Directory to access
        /// using this studio component.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitDistinguishedName. 
        /// <para>
        /// The distinguished name (DN) and organizational unit (OU) of an Active Directory computer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string OrganizationalUnitDistinguishedName
        {
            get { return this._organizationalUnitDistinguishedName; }
            set { this._organizationalUnitDistinguishedName = value; }
        }

        // Check to see if OrganizationalUnitDistinguishedName property is set
        internal bool IsSetOrganizationalUnitDistinguishedName()
        {
            return this._organizationalUnitDistinguishedName != null;
        }

    }
}