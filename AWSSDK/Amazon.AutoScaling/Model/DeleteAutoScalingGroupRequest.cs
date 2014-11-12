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
    /// Container for the parameters to the DeleteAutoScalingGroup operation.
    /// Deletes the specified Auto Scaling group if the group has no        instances
    /// and no scaling activities in progress.        
    /// 
    ///         <note>            To remove all instances before calling <a>DeleteAutoScalingGroup</a>,
    ///            you can call <a>UpdateAutoScalingGroup</a> to set the minimum and     
    ///        maximum size of the AutoScalingGroup to zero.        </note>
    /// </summary>
    public partial class DeleteAutoScalingGroupRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private bool? _forceDelete;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///         The name of the Auto Scaling group to delete.        
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
        public DeleteAutoScalingGroupRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// Starting with API version 2011-01-01, specifies that the Auto Scaling group will be
        /// deleted along with all instances           associated with the group, without waiting
        /// for all instances to be terminated.         
        /// </para>
        /// </summary>
        public bool ForceDelete
        {
            get { return this._forceDelete.GetValueOrDefault(); }
            set { this._forceDelete = value; }
        }


        /// <summary>
        /// Sets the ForceDelete property
        /// </summary>
        /// <param name="forceDelete">The value to set for the ForceDelete property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteAutoScalingGroupRequest WithForceDelete(bool forceDelete)
        {
            this._forceDelete = forceDelete;
            return this;
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

    }
}