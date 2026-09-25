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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Unique identifying information for an Android app. Consists of a package name and
    /// a 20 byte SHA-1 certificate fingerprint.
    /// </summary>
    public partial class AndroidApp
    {
        /// <summary>
        /// Gets and sets the property CertificateFingerprint. 
        /// <para>
        /// 20 byte SHA-1 certificate fingerprint associated with the Android app signing certificate.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>BB:0D:AC:74:D3:21:E1:43:67:71:9B:62:91:AF:A1:66:6E:44:5D:75</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 59, Max = 59)]
        public string CertificateFingerprint { get; set; }

        /// <summary>
        /// Checks to see if the CertificateFingerprint property is set.
        /// </summary>
        internal bool IsSetCertificateFingerprint() => this.CertificateFingerprint != null;

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        /// Unique package name identifier for an Android app.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>com.mydomain.appname</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;
    }
}
