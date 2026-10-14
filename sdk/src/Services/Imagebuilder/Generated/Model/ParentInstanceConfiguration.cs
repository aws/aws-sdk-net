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
    /// Settings for building on an instance that is already running, instead of an instance
    /// that Image Builder launches for the build.
    /// </summary>
    public partial class ParentInstanceConfiguration
    {
        private AutoScalingGroupConfiguration _autoScalingGroup;

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// The Amazon EC2 Auto Scaling group that Image Builder takes the build instance from.
        /// This is required when you specify <c>parentInstance</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoScalingGroupConfiguration AutoScalingGroup
        {
            get { return this._autoScalingGroup; }
            set { this._autoScalingGroup = value; }
        }

        // Check to see if AutoScalingGroup property is set
        internal bool IsSetAutoScalingGroup()
        {
            return this._autoScalingGroup != null;
        }

    }
}