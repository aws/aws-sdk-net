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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Determines whether a TLS/SSL certificate is generated for a fleet. This feature must
    /// be enabled when creating the fleet. All instances in a fleet share the same certificate.
    /// The certificate can be retrieved by calling the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk.html">GameLift
    /// Server SDK</a> operation <code>GetInstanceCertificate</code>.
    /// </summary>
    public partial class CertificateConfiguration
    {
        private CertificateType _certificateType;

        /// <summary>
        /// Gets and sets the property CertificateType. 
        /// <para>
        /// Indicates whether a TLS/SSL certificate is generated for a fleet. 
        /// </para>
        ///  
        /// <para>
        /// Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GENERATED</b> - Generate a TLS/SSL certificate for this fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLED</b> - (default) Do not generate a TLS/SSL certificate for this fleet.
        /// 
        /// </para>
        ///  </li> </ul>
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