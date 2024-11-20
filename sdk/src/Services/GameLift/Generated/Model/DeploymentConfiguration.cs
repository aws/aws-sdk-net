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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Set of rules for processing a deployment for a container fleet update.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private DeploymentImpairmentStrategy _impairmentStrategy;
        private int? _minimumHealthyPercentage;
        private DeploymentProtectionStrategy _protectionStrategy;

        /// <summary>
        /// Gets and sets the property ImpairmentStrategy. 
        /// <para>
        /// Determines what actions to take if a deployment fails. If the fleet is multi-location,
        /// this strategy applies across all fleet locations. With a rollback strategy, updated
        /// fleet instances are rolled back to the last successful deployment. Alternatively,
        /// you can maintain a few impaired containers for the purpose of debugging, while all
        /// other tasks return to the last successful deployment.
        /// </para>
        /// </summary>
        public DeploymentImpairmentStrategy ImpairmentStrategy
        {
            get { return this._impairmentStrategy; }
            set { this._impairmentStrategy = value; }
        }

        // Check to see if ImpairmentStrategy property is set
        internal bool IsSetImpairmentStrategy()
        {
            return this._impairmentStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumHealthyPercentage. 
        /// <para>
        /// Sets a minimum level of healthy tasks to maintain during deployment activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=30, Max=75)]
        public int? MinimumHealthyPercentage
        {
            get { return this._minimumHealthyPercentage; }
            set { this._minimumHealthyPercentage = value; }
        }

        // Check to see if MinimumHealthyPercentage property is set
        internal bool IsSetMinimumHealthyPercentage()
        {
            return this._minimumHealthyPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProtectionStrategy. 
        /// <para>
        /// Determines how fleet deployment activity affects active game sessions on the fleet.
        /// With protection, a deployment honors game session protection, and delays actions that
        /// would interrupt a protected active game session until the game session ends. Without
        /// protection, deployment activity can shut down all running tasks, including active
        /// game sessions, regardless of game session protection. 
        /// </para>
        /// </summary>
        public DeploymentProtectionStrategy ProtectionStrategy
        {
            get { return this._protectionStrategy; }
            set { this._protectionStrategy = value; }
        }

        // Check to see if ProtectionStrategy property is set
        internal bool IsSetProtectionStrategy()
        {
            return this._protectionStrategy != null;
        }

    }
}