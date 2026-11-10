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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Set of rules for processing a deployment for a container fleet update. For how Amazon
    /// GameLift Servers validates and rolls out a deployment, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/containers-deployment-validation.html">Container
    /// fleet deployments</a>.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        /// <summary>
        /// Gets and sets the property ImpairmentStrategy. 
        /// <para>
        /// Determines what actions to take if a deployment fails validation. If the fleet is
        /// multi-location, this strategy applies across all fleet locations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ROLLBACK</c> -- Returns all of the fleet's containers to the last successful deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAINTAIN</c> -- Keeps the containers that failed validation in place so that you
        /// can inspect them, and returns all other containers to the last successful deployment.
        /// Use this option when you're deploying a container image that you want to be able to
        /// debug on failure.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default value: <c>MAINTAIN</c> 
        /// </para>
        /// </summary>
        public DeploymentImpairmentStrategy ImpairmentStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ImpairmentStrategy property is set.
        /// </summary>
        internal bool IsSetImpairmentStrategy() => this.ImpairmentStrategy != null;

        /// <summary>
        /// Gets and sets the property MinimumHealthyPercentage. 
        /// <para>
        /// Sets the minimum percentage of the fleet's game server container groups to keep healthy
        /// during deployment activity. A low value favors deployment speed; a high value favors
        /// game server availability. For example, if the fleet runs 20 game server container
        /// groups and this value is 75, Amazon GameLift Servers keeps at least 15 of them healthy,
        /// so it replaces no more than 5 at a time.
        /// </para>
        ///  
        /// <para>
        /// Default value: 75
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 75)]
        public int? MinimumHealthyPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MinimumHealthyPercentage property is set.
        /// </summary>
        internal bool IsSetMinimumHealthyPercentage() => this.MinimumHealthyPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property ProtectionStrategy. 
        /// <para>
        /// Determines how fleet deployment activity affects active game sessions on the fleet.
        /// A protected game session can't be terminated while it's active; a fleet sets the default
        /// protection for its new game sessions with <c>NewGameSessionProtectionPolicy</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>WITH_PROTECTION</c> -- The deployment honors game session protection, and delays
        /// actions that would interrupt a protected active game session until the game session
        /// ends.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IGNORE_PROTECTION</c> -- The deployment replaces containers regardless of game
        /// session activity, including active game sessions. This option is useful during development
        /// and testing.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This setting also affects how long deployment validation can take. When the fleet's
        /// <c>NewGameSessionProtectionPolicy</c> is <c>FullProtection</c> and the deployment
        /// uses <c>WITH_PROTECTION</c>, validation waits for protected game sessions to end.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>WITH_PROTECTION</c> 
        /// </para>
        /// </summary>
        public DeploymentProtectionStrategy ProtectionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ProtectionStrategy property is set.
        /// </summary>
        internal bool IsSetProtectionStrategy() => this.ProtectionStrategy != null;
    }
}
