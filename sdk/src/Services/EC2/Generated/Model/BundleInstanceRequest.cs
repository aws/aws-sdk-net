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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Bundles an Amazon instance store-backed Windows instance.
    /// 
    ///  
    /// <para>
    /// During bundling, only the root device volume (C:\) is bundled. Data on other instance
    /// store volumes is not preserved.
    /// </para>
    ///  <note> 
    /// <para>
    /// This action is not applicable for Linux/Unix instances or Windows instances that are
    /// backed by Amazon EBS.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html">Creating
    /// an Instance Store-Backed Windows AMI</a>.
    /// </para>
    /// </summary>
    public partial class BundleInstanceRequest : AmazonEC2Request
    {
        private string _instanceId;
        private Storage _storage;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public BundleInstanceRequest() { }

        /// <summary>
        /// Instantiates BundleInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance to bundle. Type: String Default: None Required: Yes</param>
        /// <param name="storage">The bucket in which to store the AMI. You can specify a bucket that you already own or a new bucket that Amazon EC2 creates on your behalf. If you specify a bucket that belongs to someone else, Amazon EC2 returns an error.</param>
        public BundleInstanceRequest(string instanceId, Storage storage)
        {
            _instanceId = instanceId;
            _storage = storage;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to bundle.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The bucket in which to store the AMI. You can specify a bucket that you already own
        /// or a new bucket that Amazon EC2 creates on your behalf. If you specify a bucket that
        /// belongs to someone else, Amazon EC2 returns an error.
        /// </para>
        /// </summary>
        public Storage Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}