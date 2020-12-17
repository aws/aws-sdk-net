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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A string repesenting the status of DNSSEC signing.
    /// </summary>
    public partial class DNSSECStatus
    {
        private string _serveSignature;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ServeSignature. 
        /// <para>
        /// Indicates your hosted zone signging status: <code>SIGNING</code>, <code>NOT_SIGNING</code>,
        /// or <code>INTERNAL_FAILURE</code>. If the status is <code>INTERNAL_FAILURE</code>,
        /// see <code>StatusMessage</code> for information about steps that you can take to correct
        /// the problem.
        /// </para>
        ///  
        /// <para>
        /// A status <code>INTERNAL_FAILURE</code> means there was an error during a request.
        /// Before you can continue to work with DNSSEC signing, including working with key signing
        /// keys (KSKs), you must correct the problem by enabling or disabling DNSSEC signing
        /// for the hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ServeSignature
        {
            get { return this._serveSignature; }
            set { this._serveSignature = value; }
        }

        // Check to see if ServeSignature property is set
        internal bool IsSetServeSignature()
        {
            return this._serveSignature != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message provided for the following DNSSEC signing status: <code>INTERNAL_FAILURE</code>.
        /// The status message includes information about what the problem might be and steps
        /// that you can take to correct the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}