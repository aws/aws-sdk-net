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
    /// Container for the parameters to the UpdateFleetAttributes operation. <b>This API works
    /// with the following fleet types:</b> EC2, Anywhere <para> Updates a fleet's mutable
    /// attributes, such as game session protection and resource creation limits. </para>
    /// <para> To update fleet attributes, specify the fleet ID and the property values that
    /// you want to change. If successful, Amazon GameLift Servers returns the identifiers
    /// for the updated fleet. </para> <note> <para> A managed fleet's runtime environment,
    /// which depends on the fleet's Amazon Machine Image (AMI) version, can't be updated.
    /// You must create a new fleet. As a best practice, we recommend replacing your managed
    /// fleets every 30 days to maintain a secure and up-to-date runtime environment for your
    /// hosted game servers. For guidance, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/security-best-practices.html">
    /// Security best practices for Amazon GameLift Servers</a>. </para> </note> <para> <b>Learn
    /// more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up Amazon GameLift Servers fleets</a> </para>
    /// </summary>
    public partial class UpdateFleetAttributesRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property AnywhereConfiguration. 
        /// <para>
        /// Amazon GameLift Servers Anywhere configuration options.
        /// </para>
        /// </summary>
        public AnywhereConfiguration AnywhereConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnywhereConfiguration property is set.
        /// </summary>
        internal bool IsSetAnywhereConfiguration() => this.AnywhereConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of a fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to update attribute metadata for. You can use either
        /// the fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of a metric group to add this fleet to. Use a metric group in Amazon CloudWatch
        /// to aggregate the metrics from multiple fleets. Provide an existing metric group name,
        /// or create a new metric group by providing a new name. A fleet can only be in one metric
        /// group at a time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> MetricGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetricGroups property is set.
        /// </summary>
        internal bool IsSetMetricGroups() => this.MetricGroups != null && (this.MetricGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a fleet. Fleet names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NewGameSessionProtectionPolicy. 
        /// <para>
        /// The game session protection policy to apply to all new game sessions created in this
        /// fleet. Game sessions that already exist are not affected. You can set protection for
        /// individual game sessions using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSession.html">UpdateGameSession</a>
        /// .
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> -- The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> -- If the game session is in an <c>ACTIVE</c> status, it cannot
        /// be terminated during a scale-down event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtectionPolicy NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the NewGameSessionProtectionPolicy property is set.
        /// </summary>
        internal bool IsSetNewGameSessionProtectionPolicy() => this.NewGameSessionProtectionPolicy != null;

        /// <summary>
        /// Gets and sets the property ResourceCreationLimitPolicy. 
        /// <para>
        /// Policy settings that limit the number of game sessions an individual player can create
        /// over a span of time. 
        /// </para>
        /// </summary>
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCreationLimitPolicy property is set.
        /// </summary>
        internal bool IsSetResourceCreationLimitPolicy() => this.ResourceCreationLimitPolicy != null;
    }
}
