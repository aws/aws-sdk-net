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
    /// Container for the parameters to the StartInstances operation.
    /// Starts an Amazon EBS-backed instance that you've previously stopped.
    /// 
    ///  
    /// <para>
    /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
    /// and started. When an instance is stopped, the compute resources are released and you
    /// are not billed for instance usage. However, your root partition Amazon EBS volume
    /// remains and continues to persist your data, and you are charged for Amazon EBS volume
    /// usage. You can restart your instance at any time. Every time you start your instance,
    /// Amazon EC2 charges a one-minute minimum for instance usage, and thereafter charges
    /// per second for instance usage.
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
    /// If you attempt to start a T3 instance with <c>host</c> tenancy and the <c>unlimited</c>
    /// CPU credit option, the request fails. The <c>unlimited</c> CPU credit option is not
    /// supported on Dedicated Hosts. Before you start the instance, either change its CPU
    /// credit option to <c>standard</c>, or change its tenancy to <c>default</c> or <c>dedicated</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stop
    /// and start Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartInstancesRequest : AmazonEC2Request
    {
        private string _additionalInfo;
        private bool? _dryRun;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StartInstancesRequest() { }

        /// <summary>
        /// Instantiates StartInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceIds">The IDs of the instances.</param>
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}