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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComputer operation. Creates an Active Directory
    /// computer object in the specified directory.
    /// </summary>
    public partial class CreateComputerRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ComputerAttributes. 
        /// <para>
        /// An array of <a>Attribute</a> objects that contain any LDAP attributes to apply to
        /// the computer account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> ComputerAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the ComputerAttributes property is set.
        /// </summary>
        internal bool IsSetComputerAttributes() => this.ComputerAttributes != null && (this.ComputerAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The name of the computer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public string ComputerName { get; set; }

        /// <summary>
        /// Checks to see if the ComputerName property is set.
        /// </summary>
        internal bool IsSetComputerName() => this.ComputerName != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory in which to create the computer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitDistinguishedName. 
        /// <para>
        /// The fully-qualified distinguished name of the organizational unit to place the computer
        /// account in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string OrganizationalUnitDistinguishedName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitDistinguishedName property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitDistinguishedName() => this.OrganizationalUnitDistinguishedName != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// A one-time password that is used to join the computer to the directory. You should
        /// generate a random, strong password to use for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 8, Max = 64)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;
    }
}
