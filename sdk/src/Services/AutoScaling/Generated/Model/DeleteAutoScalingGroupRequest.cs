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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Container for the parameters to the DeleteAutoScalingGroup operation.
    /// Deletes the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// If the group has instances or scaling activities in progress, you must specify the
    /// option to force the deletion in order for it to succeed.
    /// </para>
    ///  
    /// <para>
    /// If the group has policies, deleting the group deletes the policies, the underlying
    /// alarm actions, and any alarm that no longer has an associated action.
    /// </para>
    ///  
    /// <para>
    /// To remove instances from the Auto Scaling group before deleting it, call <a>DetachInstances</a>
    /// with the list of instances and the option to decrement the desired capacity so that
    /// Amazon EC2 Auto Scaling does not launch replacement instances.
    /// </para>
    ///  
    /// <para>
    /// To terminate all instances before deleting the Auto Scaling group, call <a>UpdateAutoScalingGroup</a>
    /// and set the minimum size and desired capacity of the Auto Scaling group to zero.
    /// </para>
    /// </summary>
    public partial class DeleteAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private bool? _forceDelete;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// Specifies that the group will be deleted along with all instances associated with
        /// the group, without waiting for all instances to be terminated. This parameter also
        /// deletes any lifecycle actions associated with the group.
        /// </para>
        /// </summary>
        public bool ForceDelete
        {
            get { return this._forceDelete.GetValueOrDefault(); }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

    }
}