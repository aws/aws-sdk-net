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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Describes the certificate extensions to be added to the certificate signing request
    /// (CSR).
    /// </summary>
    public partial class CsrExtensions
    {
        private KeyUsage _keyUsage;
        private List<AccessDescription> _subjectInformationAccess = AWSConfigs.InitializeCollections ? new List<AccessDescription>() : null;

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Indicates the purpose of the certificate and of the key contained in the certificate.
        /// </para>
        /// </summary>
        public KeyUsage KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectInformationAccess. 
        /// <para>
        /// For CA certificates, provides a path to additional information pertaining to the CA,
        /// such as revocation and policy. For more information, see <a href="https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.2.2">Subject
        /// Information Access</a> in RFC 5280.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccessDescription> SubjectInformationAccess
        {
            get { return this._subjectInformationAccess; }
            set { this._subjectInformationAccess = value; }
        }

        // Check to see if SubjectInformationAccess property is set
        internal bool IsSetSubjectInformationAccess()
        {
            return this._subjectInformationAccess != null && (this._subjectInformationAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}