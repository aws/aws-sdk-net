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
    /// Container for the parameters to the BatchDeleteScheduledAction operation.
    /// Deletes one or more scheduled actions for the specified Auto Scaling group.
    /// </summary>
    public partial class BatchDeleteScheduledActionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _scheduledActionNames = new List<string>();

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
        /// Gets and sets the property ScheduledActionNames. 
        /// <para>
        /// The names of the scheduled actions to delete. The maximum number allowed is 50. 
        /// </para>
        /// </summary>
        public List<string> ScheduledActionNames
        {
            get { return this._scheduledActionNames; }
            set { this._scheduledActionNames = value; }
        }

        // Check to see if ScheduledActionNames property is set
        internal bool IsSetScheduledActionNames()
        {
            return this._scheduledActionNames != null && this._scheduledActionNames.Count > 0; 
        }

    }
}