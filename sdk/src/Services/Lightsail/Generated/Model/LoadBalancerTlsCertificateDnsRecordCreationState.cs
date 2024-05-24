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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// An object that describes the state of the canonical name (CNAME) records that are
    /// automatically added by Lightsail to the DNS of the domain to validate domain ownership.
    /// </summary>
    public partial class LoadBalancerTlsCertificateDnsRecordCreationState
    {
        private LoadBalancerTlsCertificateDnsRecordCreationStateCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The status code for the automated DNS record creation.
        /// </para>
        ///  
        /// <para>
        /// Following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - The validation records were successfully added.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTED</c> - The automatic DNS record creation has started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The validation record addition failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LoadBalancerTlsCertificateDnsRecordCreationStateCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message that describes the reason for the status code.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}