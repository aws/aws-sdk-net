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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIpamExternalResourceVerificationToken operation.
    /// Delete a verification token. A verification token is an Amazon Web Services-generated
    /// random value that you can use to prove ownership of an external resource. For example,
    /// you can use a verification token to validate that you control a public IP address
    /// range when you bring an IP address range to Amazon Web Services (BYOIP).
    /// </summary>
    public partial class DeleteIpamExternalResourceVerificationTokenRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _ipamExternalResourceVerificationTokenId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamExternalResourceVerificationTokenId. 
        /// <para>
        /// The token ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamExternalResourceVerificationTokenId
        {
            get { return this._ipamExternalResourceVerificationTokenId; }
            set { this._ipamExternalResourceVerificationTokenId = value; }
        }

        // Check to see if IpamExternalResourceVerificationTokenId property is set
        internal bool IsSetIpamExternalResourceVerificationTokenId()
        {
            return this._ipamExternalResourceVerificationTokenId != null;
        }

    }
}