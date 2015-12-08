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
    /// Container for the parameters to the SetInstanceProtection operation.
    /// Updates the instance protection settings of the specified instances.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingBehavior.InstanceTermination.html#instance-protection">Instance
    /// Protection</a> in the <i>Auto Scaling Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetInstanceProtectionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _instanceIds = new List<string>();
        private bool? _protectedFromScaleIn;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the group.
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

        /// <summary>
        /// Gets and sets the property ProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether the instance is protected from termination by Auto Scaling when
        /// scaling in.
        /// </para>
        /// </summary>
        public bool ProtectedFromScaleIn
        {
            get { return this._protectedFromScaleIn.GetValueOrDefault(); }
            set { this._protectedFromScaleIn = value; }
        }

        // Check to see if ProtectedFromScaleIn property is set
        internal bool IsSetProtectedFromScaleIn()
        {
            return this._protectedFromScaleIn.HasValue; 
        }

    }
}