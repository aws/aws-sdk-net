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
    /// Details about a daemon revision during a deployment, including running and draining
    /// instance counts per capacity provider.
    /// </summary>
    public partial class DaemonDeploymentRevisionDetail
    {
        private string _arn;
        private List<DaemonDeploymentCapacityProvider> _capacityProviders = AWSConfigs.InitializeCollections ? new List<DaemonDeploymentCapacityProvider>() : null;
        private int? _totalDrainingInstanceCount;
        private int? _totalRunningInstanceCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon revision.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The capacity providers associated with this daemon revision during the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonDeploymentCapacityProvider> CapacityProviders
        {
            get { return this._capacityProviders; }
            set { this._capacityProviders = value; }
        }

        // Check to see if CapacityProviders property is set
        internal bool IsSetCapacityProviders()
        {
            return this._capacityProviders != null && (this._capacityProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalDrainingInstanceCount. 
        /// <para>
        /// The total number of instances being drained for this revision during the deployment.
        /// </para>
        /// </summary>
        public int? TotalDrainingInstanceCount
        {
            get { return this._totalDrainingInstanceCount; }
            set { this._totalDrainingInstanceCount = value; }
        }

        // Check to see if TotalDrainingInstanceCount property is set
        internal bool IsSetTotalDrainingInstanceCount()
        {
            return this._totalDrainingInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRunningInstanceCount. 
        /// <para>
        /// The total number of instances running daemon tasks for this revision.
        /// </para>
        /// </summary>
        public int? TotalRunningInstanceCount
        {
            get { return this._totalRunningInstanceCount; }
            set { this._totalRunningInstanceCount = value; }
        }

        // Check to see if TotalRunningInstanceCount property is set
        internal bool IsSetTotalRunningInstanceCount()
        {
            return this._totalRunningInstanceCount.HasValue; 
        }

    }
}