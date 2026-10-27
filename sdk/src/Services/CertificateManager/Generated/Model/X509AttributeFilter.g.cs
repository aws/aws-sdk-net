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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Filters certificates by X.509 attributes.
    /// </summary>
    public partial class X509AttributeFilter
    {
        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Filter by extended key usage.
        /// </para>
        /// </summary>
        public ExtendedKeyUsageName ExtendedKeyUsage { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedKeyUsage property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsage() => this.ExtendedKeyUsage != null;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// Filter by key algorithm.
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Filter by key usage.
        /// </para>
        /// </summary>
        public KeyUsageName KeyUsage { get; set; }

        /// <summary>
        /// Checks to see if the KeyUsage property is set.
        /// </summary>
        internal bool IsSetKeyUsage() => this.KeyUsage != null;

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// Filter by certificate expiration date. The start date is inclusive.
        /// </para>
        /// </summary>
        public TimestampRange NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter != null;

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// Filter by certificate validity start date. The start date is inclusive.
        /// </para>
        /// </summary>
        public TimestampRange NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// Filter by serial number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 59)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// Filter by certificate subject.
        /// </para>
        /// </summary>
        public SubjectFilter Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeName. 
        /// <para>
        /// Filter by subject alternative names.
        /// </para>
        /// </summary>
        public SubjectAlternativeNameFilter SubjectAlternativeName { get; set; }

        /// <summary>
        /// Checks to see if the SubjectAlternativeName property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeName() => this.SubjectAlternativeName != null;
    }
}
