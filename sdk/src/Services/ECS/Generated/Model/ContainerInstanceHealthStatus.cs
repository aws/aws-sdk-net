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
    /// An object representing the health status of the container instance.
    /// </summary>
    public partial class ContainerInstanceHealthStatus
    {
        private List<InstanceHealthCheckResult> _details = AWSConfigs.InitializeCollections ? new List<InstanceHealthCheckResult>() : null;
        private InstanceHealthCheckState _overallStatus;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// An array of objects representing the details of the container instance health status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceHealthCheckResult> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverallStatus. 
        /// <para>
        /// The overall health status of the container instance. This is an aggregate status of
        /// all container instance health checks.
        /// </para>
        /// </summary>
        public InstanceHealthCheckState OverallStatus
        {
            get { return this._overallStatus; }
            set { this._overallStatus = value; }
        }

        // Check to see if OverallStatus property is set
        internal bool IsSetOverallStatus()
        {
            return this._overallStatus != null;
        }

    }
}