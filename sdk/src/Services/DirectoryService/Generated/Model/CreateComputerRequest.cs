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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComputer operation.
    /// Creates an Active Directory computer object in the specified directory.
    /// </summary>
    public partial class CreateComputerRequest : AmazonDirectoryServiceRequest
    {
        private List<Attribute> _computerAttributes = new List<Attribute>();
        private string _computerName;
        private string _directoryId;
        private string _organizationalUnitDistinguishedName;
        private string _password;

        /// <summary>
        /// Gets and sets the property ComputerAttributes. 
        /// <para>
        /// An array of <a>Attribute</a> objects that contain any LDAP attributes to apply to
        /// the computer account.
        /// </para>
        /// </summary>
        public List<Attribute> ComputerAttributes
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
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The name of the computer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public string ComputerName
        {
            get { return this._computerName; }
            set { this._computerName = value; }
        }

        // Check to see if ComputerName property is set
        internal bool IsSetComputerName()
        {
            return this._computerName != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory in which to create the computer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The fully-qualified distinguished name of the organizational unit to place the computer
        /// account in.
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

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// A one-time password that is used to join the computer to the directory. You should
        /// generate a random, strong password to use for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=8, Max=64)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

    }
}