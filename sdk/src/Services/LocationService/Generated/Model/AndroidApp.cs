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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
        private string _certificateFingerprint;
        private string _package;

        /// <summary>
        /// Gets and sets the property CertificateFingerprint. 
        /// <para>
        /// 20 byte SHA-1 certificate fingerprint associated with the Android app signing certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=59, Max=59)]
        public string CertificateFingerprint
        {
            get { return this._certificateFingerprint; }
            set { this._certificateFingerprint = value; }
        }

        // Check to see if CertificateFingerprint property is set
        internal bool IsSetCertificateFingerprint()
        {
            return this._certificateFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        /// Unique package name for an Android app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Package
        {
            get { return this._package; }
            set { this._package = value; }
        }

        // Check to see if Package property is set
        internal bool IsSetPackage()
        {
            return this._package != null;
        }

    }
}