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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Filters certificates by ACM metadata.
    /// </summary>
    public partial class AcmCertificateMetadataFilter
    {
        private bool? _exported;
        private CertificateExport _exportOption;
        private bool? _inUse;
        private CertificateManagedBy _managedBy;
        private RenewalStatus _renewalStatus;
        private CertificateStatus _status;
        private CertificateType _type;
        private ValidationMethod _validationMethod;

        /// <summary>
        /// Gets and sets the property Exported. 
        /// <para>
        /// Filter by whether the certificate has been exported.
        /// </para>
        /// </summary>
        public bool? Exported
        {
            get { return this._exported; }
            set { this._exported = value; }
        }

        // Check to see if Exported property is set
        internal bool IsSetExported()
        {
            return this._exported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportOption. 
        /// <para>
        /// Filter by certificate export option.
        /// </para>
        /// </summary>
        public CertificateExport ExportOption
        {
            get { return this._exportOption; }
            set { this._exportOption = value; }
        }

        // Check to see if ExportOption property is set
        internal bool IsSetExportOption()
        {
            return this._exportOption != null;
        }

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// Filter by whether the certificate is in use.
        /// </para>
        /// </summary>
        public bool? InUse
        {
            get { return this._inUse; }
            set { this._inUse = value; }
        }

        // Check to see if InUse property is set
        internal bool IsSetInUse()
        {
            return this._inUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// Filter by the entity that manages the certificate.
        /// </para>
        /// </summary>
        public CertificateManagedBy ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// Filter by certificate renewal status.
        /// </para>
        /// </summary>
        public RenewalStatus RenewalStatus
        {
            get { return this._renewalStatus; }
            set { this._renewalStatus = value; }
        }

        // Check to see if RenewalStatus property is set
        internal bool IsSetRenewalStatus()
        {
            return this._renewalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter by certificate status.
        /// </para>
        /// </summary>
        public CertificateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Filter by certificate type.
        /// </para>
        /// </summary>
        public CertificateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// Filter by validation method.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod
        {
            get { return this._validationMethod; }
            set { this._validationMethod = value; }
        }

        // Check to see if ValidationMethod property is set
        internal bool IsSetValidationMethod()
        {
            return this._validationMethod != null;
        }

    }
}