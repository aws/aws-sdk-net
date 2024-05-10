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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The termination policy for the Amazon EBS volume when the task exits. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volume-types">Amazon
    /// ECS volume termination policy</a>.
    /// </summary>
    public partial class TaskManagedEBSVolumeTerminationPolicy
    {
        private bool? _deleteOnTermination;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the volume should be deleted on when the task stops. If a value
        /// of <c>true</c> is specified, &#x2028;Amazon ECS deletes the Amazon EBS volume on your
        /// behalf when the task goes into the <c>STOPPED</c> state. If no value is specified,
        /// the &#x2028;default value is <c>true</c> is used. When set to <c>false</c>, Amazon
        /// ECS leaves the volume in your &#x2028;account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DeleteOnTermination
        {
            get { return this._deleteOnTermination; }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

    }
}