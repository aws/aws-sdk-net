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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Identifies the Amazon EC2 Auto Scaling group that Image Builder takes the build instance
    /// from, and how long Image Builder waits when the group has no instance available.
    /// </summary>
    public partial class AutoScalingGroupConfiguration
    {
        private int? _capacityWaitTimeoutSeconds;
        private string _name;

        /// <summary>
        /// Gets and sets the property CapacityWaitTimeoutSeconds. 
        /// <para>
        /// The number of seconds that Image Builder waits for an instance to become available
        /// in the group before the build fails. If you set this value to 0 or omit it, the build
        /// fails as soon as the group has no instance available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? CapacityWaitTimeoutSeconds
        {
            get { return this._capacityWaitTimeoutSeconds; }
            set { this._capacityWaitTimeoutSeconds = value; }
        }

        // Check to see if CapacityWaitTimeoutSeconds property is set
        internal bool IsSetCapacityWaitTimeoutSeconds()
        {
            return this._capacityWaitTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Auto Scaling group, in the same account and Amazon Web Services Region
        /// as the infrastructure configuration. To specify a group, you must have permissions
        /// to describe it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}