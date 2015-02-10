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
    /// Container for the parameters to the StartInstances operation.
    /// Starts an Amazon EBS-backed AMI that you've previously stopped.
    /// 
    ///  
    /// <para>
    /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
    /// and started. When an instance is stopped, the compute resources are released and you
    /// are not billed for hourly instance usage. However, your root partition Amazon EBS
    /// volume remains, continues to persist your data, and you are charged for Amazon EBS
    /// volume usage. You can restart your instance at any time. Each time you transition
    /// an instance from stopped to started, Amazon EC2 charges a full instance hour, even
    /// if transitions happen multiple times within a single hour.
    /// </para>
    ///  
    /// <para>
    /// Before stopping an instance, make sure it is in a state from which it can be restarted.
    /// Stopping an instance does not preserve data stored in RAM.
    /// </para>
    ///  
    /// <para>
    /// Performing this operation on an instance that uses an instance store as its root device
    /// returns an error.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stopping
    /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class StartInstancesRequest : AmazonEC2Request
    {
        private string _additionalInfo;
        private List<string> _instanceIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StartInstancesRequest() { }

        /// <summary>
        /// Instantiates StartInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceIds">One or more instance IDs.</param>
        public StartInstancesRequest(List<string> instanceIds)
        {
            _instanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// One or more instance IDs.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

    }
}