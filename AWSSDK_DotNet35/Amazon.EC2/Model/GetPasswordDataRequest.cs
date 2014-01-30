/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetPasswordData operation.
    /// <para>Retrieves the encrypted administrator password for an instance running Windows.</para> <para>The Windows password is only generated
    /// the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.</para> <para>The
    /// password is encrypted using the key pair that you specified when you launched the instance. You must provide the corresponding key pair
    /// file.</para> <para>Password generation and encryption takes a few moments. We recommend that you wait up to 15 minutes after launching an
    /// instance before trying to retrieve the generated password.</para>
    /// </summary>
    public partial class GetPasswordDataRequest : AmazonEC2Request
    {
        private string instanceId;


        /// <summary>
        /// The ID of the Windows instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

    }
}
    
