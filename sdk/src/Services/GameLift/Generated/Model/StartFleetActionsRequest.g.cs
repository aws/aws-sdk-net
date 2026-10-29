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
    /// Container for the parameters to the StartFleetActions operation. <b>This API works
    /// with the following fleet types:</b> EC2, Container <para> Resumes certain types of
    /// activity on fleet instances that were suspended with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StopFleetActions.html">StopFleetActions</a>.
    /// For multi-location fleets, fleet actions are managed separately for each location.
    /// Currently, this operation is used to restart a fleet's auto-scaling activity. </para>
    /// <para> This operation can be used in the following ways: </para> <ul> <li> <para>
    /// To restart actions on instances in the fleet's home Region, provide a fleet ID and
    /// the type of actions to resume. </para> </li> <li> <para> To restart actions on instances
    /// in one of the fleet's remote locations, provide a fleet ID, a location name, and the
    /// type of actions to resume. </para> </li> </ul> <para> If successful, Amazon GameLift
    /// Servers once again initiates scaling events as triggered by the fleet's scaling policies.
    /// If actions on the fleet location were never stopped, this operation will have no effect.
    /// </para> <para> <b>Learn more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up Amazon GameLift Servers fleets</a> </para>
    /// </summary>
    public partial class StartFleetActionsRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// List of actions to restart on the fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to restart actions on. You can use either the fleet
        /// ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fleet location to restart fleet actions for. Specify a location in the form of
        /// an Amazon Web Services Region code, such as <c>us-west-2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;
    }
}
