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
    /// Container for the parameters to the GetPasswordData operation.
    /// Retrieves the encrypted administrator password for a running Windows instance.
    /// 
    ///  
    /// <para>
    /// The Windows password is generated at boot by the <c>EC2Config</c> service or <c>EC2Launch</c>
    /// scripts (Windows Server 2016 and later). This usually only happens the first time
    /// an instance is launched. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UsingConfig_WinAMI.html">EC2Config</a>
    /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2launch.html">EC2Launch</a>
    /// in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For the <c>EC2Config</c> service, the password is not generated for rebundled AMIs
    /// unless <c>Ec2SetPassword</c> is enabled before bundling.
    /// </para>
    ///  
    /// <para>
    /// The password is encrypted using the key pair that you specified when you launched
    /// the instance. You must provide the corresponding key pair file.
    /// </para>
    ///  
    /// <para>
    /// When you launch an instance, password generation and encryption may take a few minutes.
    /// If you try to retrieve the password before it's available, the output returns an empty
    /// string. We recommend that you wait up to 15 minutes after launching an instance before
    /// trying to retrieve the generated password.
    /// </para>
    /// </summary>
    public partial class GetPasswordDataRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _instanceId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetPasswordDataRequest() { }

        /// <summary>
        /// Instantiates GetPasswordDataRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the Windows instance.</param>
        public GetPasswordDataRequest(string instanceId)
        {
            _instanceId = instanceId;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Windows instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}