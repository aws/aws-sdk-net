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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCrl operation. Updates the certificate revocation
    /// list (CRL). A CRL is a list of certificates that have been revoked by the issuing
    /// certificate authority (CA). IAM Roles Anywhere validates against the CRL before issuing
    /// credentials. <para> <b>Required permissions: </b> <c>rolesanywhere:UpdateCrl</c>.
    /// </para>
    /// </summary>
    public partial class UpdateCrlRequest : AmazonIAMRolesAnywhereRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias for the certificate revocation list (CRL).
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To set or change the alias, specify the new alias name. After the change, the previous
        /// alias ARN no longer identifies the resource. You can then assign the previous alias
        /// to another resource of the same type. A change can take a short time to take effect
        /// for requests that use an alias ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the alias, specify an empty string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To keep the current alias, omit this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An alias name contains 1 to 256 characters. It must begin with a letter (A-Z or a-z).
        /// It can contain only letters (A-Z and a-z), numbers (0-9), underscores (_), hyphens
        /// (-), and forward slashes (/). A forward slash can appear only between two other characters,
        /// so an alias name can't end with a forward slash or contain two in a row. Alias names
        /// that begin with <c>aws/</c>, in any combination of uppercase and lowercase letters,
        /// are reserved. Alias names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The alias name must be unique among resources of the same type in your account and
        /// Region. If another resource of the same type already has the alias, the request fails
        /// with a <c>ValidationException</c>. An invalid or reserved alias name also causes a
        /// <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property CrlData. 
        /// <para>
        /// The x509 v3 specified certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300000)]
        public MemoryStream CrlData { get; set; }

        /// <summary>
        /// Checks to see if the CrlData property is set.
        /// </summary>
        internal bool IsSetCrlData() => this.CrlData != null;

        /// <summary>
        /// Gets and sets the property CrlId. 
        /// <para>
        /// The certificate revocation list (CRL) to act on. You can specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The CRL ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CRL ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias ARN of the CRL.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An ARN must be for a CRL in your account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string CrlId { get; set; }

        /// <summary>
        /// Checks to see if the CrlId property is set.
        /// </summary>
        internal bool IsSetCrlId() => this.CrlId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Crl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
