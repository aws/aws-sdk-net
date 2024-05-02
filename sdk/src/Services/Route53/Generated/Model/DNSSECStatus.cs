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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A string representing the status of DNSSEC signing.
    /// </summary>
    public partial class DNSSECStatus
    {
        private string _serveSignature;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ServeSignature. 
        /// <para>
        /// A string that represents the current hosted zone signing status.
        /// </para>
        ///  
        /// <para>
        /// Status can have one of the following values:
        /// </para>
        ///  <dl> <dt>SIGNING</dt> <dd> 
        /// <para>
        /// DNSSEC signing is enabled for the hosted zone.
        /// </para>
        ///  </dd> <dt>NOT_SIGNING</dt> <dd> 
        /// <para>
        /// DNSSEC signing is not enabled for the hosted zone.
        /// </para>
        ///  </dd> <dt>DELETING</dt> <dd> 
        /// <para>
        /// DNSSEC signing is in the process of being removed for the hosted zone.
        /// </para>
        ///  </dd> <dt>ACTION_NEEDED</dt> <dd> 
        /// <para>
        /// There is a problem with signing in the hosted zone that requires you to take action
        /// to resolve. For example, the customer managed key might have been deleted, or the
        /// permissions for the customer managed key might have been changed.
        /// </para>
        ///  </dd> <dt>INTERNAL_FAILURE</dt> <dd> 
        /// <para>
        /// There was an error during a request. Before you can continue to work with DNSSEC signing,
        /// including with key-signing keys (KSKs), you must correct the problem by enabling or
        /// disabling DNSSEC signing for the hosted zone.
        /// </para>
        ///  </dd> </dl>
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
        /// The status message provided for the following DNSSEC signing status: <c>INTERNAL_FAILURE</c>.
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