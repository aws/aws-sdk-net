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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the AttachInstances operation.
    /// Attaches one or more Amazon EC2 instances to an existing Auto Scaling group.
    ///            After the instance(s) is attached, it becomes a part of the Auto Scaling
    /// group.       
    /// 
    ///         
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-instance-asg.html">Attach
    /// Amazon EC2 Instance(s) to Your Existing Auto Scaling Group</a>        in the <i>Auto
    /// Scaling Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AttachInstancesRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private List<string> _instanceIds = new List<string>();


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///             The name of the Auto Scaling group to which to attach the specified instance(s).
        ///         
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttachInstancesRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        ///             One or more IDs of the Amazon EC2 instances to attach to the specified
        /// Auto Scaling group.             You must specify at least one instance ID.       
        ///  
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttachInstancesRequest WithInstanceIds(params string[] instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttachInstancesRequest WithInstanceIds(IEnumerable<string> instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }
        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

    }
}