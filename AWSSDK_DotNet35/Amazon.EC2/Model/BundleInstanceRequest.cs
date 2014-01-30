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
    /// Container for the parameters to the BundleInstance operation.
    /// <para>Bundles an Amazon instance store-backed Windows instance.</para> <para>During bundling, only the root device volume (C:\) is bundled.
    /// Data on other instance store volumes is not preserved.</para> <para><b>NOTE:</b> This procedure is not applicable for Linux/Unix instances
    /// or Windows instances that are backed by Amazon EBS. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html" >Creating an Instance Store-Backed
    /// Windows AMI</a> .</para>
    /// </summary>
    public partial class BundleInstanceRequest : AmazonEC2Request
    {
        private string instanceId;
        private Storage storage;


        /// <summary>
        /// The ID of the instance to bundle.
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

        /// <summary>
        /// The bucket in which to store the AMI. You can specify a bucket that you already own or a new bucket that Amazon EC2 creates on your behalf.
        /// If you specify a bucket that belongs to someone else, Amazon EC2 returns an error.
        ///  
        /// </summary>
        public Storage Storage
        {
            get { return this.storage; }
            set { this.storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this.storage != null;
        }

    }
}
    
