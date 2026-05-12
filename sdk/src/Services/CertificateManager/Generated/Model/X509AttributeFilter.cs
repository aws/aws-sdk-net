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
    /// Filters certificates by X.509 attributes.
    /// </summary>
    public partial class X509AttributeFilter
    {
        private ExtendedKeyUsageName _extendedKeyUsage;
        private KeyAlgorithm _keyAlgorithm;
        private KeyUsageName _keyUsage;
        private TimestampRange _notAfter;
        private TimestampRange _notBefore;
        private string _serialNumber;
        private SubjectFilter _subject;
        private SubjectAlternativeNameFilter _subjectAlternativeName;

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Filter by extended key usage.
        /// </para>
        /// </summary>
        public ExtendedKeyUsageName ExtendedKeyUsage
        {
            get { return this._extendedKeyUsage; }
            set { this._extendedKeyUsage = value; }
        }

        // Check to see if ExtendedKeyUsage property is set
        internal bool IsSetExtendedKeyUsage()
        {
            return this._extendedKeyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// Filter by key algorithm.
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Filter by key usage.
        /// </para>
        /// </summary>
        public KeyUsageName KeyUsage
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
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// Filter by certificate expiration date. The start date is inclusive.
        /// </para>
        /// </summary>
        public TimestampRange NotAfter
        {
            get { return this._notAfter; }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter != null;
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// Filter by certificate validity start date. The start date is inclusive.
        /// </para>
        /// </summary>
        public TimestampRange NotBefore
        {
            get { return this._notBefore; }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// Filter by serial number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=59)]
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// Filter by certificate subject.
        /// </para>
        /// </summary>
        public SubjectFilter Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectAlternativeName. 
        /// <para>
        /// Filter by subject alternative names.
        /// </para>
        /// </summary>
        public SubjectAlternativeNameFilter SubjectAlternativeName
        {
            get { return this._subjectAlternativeName; }
            set { this._subjectAlternativeName = value; }
        }

        // Check to see if SubjectAlternativeName property is set
        internal bool IsSetSubjectAlternativeName()
        {
            return this._subjectAlternativeName != null;
        }

    }
}