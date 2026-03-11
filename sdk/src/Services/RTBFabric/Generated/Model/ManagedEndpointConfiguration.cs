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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the configuration of a managed endpoint.
    /// </summary>
    public partial class ManagedEndpointConfiguration
    {
        private AutoScalingGroupsConfiguration _autoScalingGroups;
        private EksEndpointsConfiguration _eksEndpoints;

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// Describes the configuration of an auto scaling group.
        /// </para>
        /// </summary>
        public AutoScalingGroupsConfiguration AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null;
        }

        /// <summary>
        /// Gets and sets the property EksEndpoints. 
        /// <para>
        /// Describes the configuration of an Amazon Elastic Kubernetes Service endpoint.
        /// </para>
        /// </summary>
        public EksEndpointsConfiguration EksEndpoints
        {
            get { return this._eksEndpoints; }
            set { this._eksEndpoints = value; }
        }

        // Check to see if EksEndpoints property is set
        internal bool IsSetEksEndpoints()
        {
            return this._eksEndpoints != null;
        }

    }
}