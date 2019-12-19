/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Information about the use of a TLS/SSL certificate for a fleet. TLS certificate generation
    /// is enabled at the fleet level, with one certificate generated for the fleet. When
    /// this feature is enabled, the certificate can be retrieved using the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk.html">GameLift
    /// Server SDK</a> call <code>GetInstanceCertificate</code>. All instances in a fleet
    /// share the same certificate.
    /// </summary>
    public partial class CertificateConfiguration
    {
        private CertificateType _certificateType;

        /// <summary>
        /// Gets and sets the property CertificateType. 
        /// <para>
        /// Indicates whether a TLS/SSL certificate was generated for a fleet. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateType CertificateType
        {
            get { return this._certificateType; }
            set { this._certificateType = value; }
        }

        // Check to see if CertificateType property is set
        internal bool IsSetCertificateType()
        {
            return this._certificateType != null;
        }

    }
}