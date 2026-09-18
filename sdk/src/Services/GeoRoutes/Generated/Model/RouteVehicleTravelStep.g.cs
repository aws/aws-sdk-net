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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Steps of a leg that correspond to the travel portion of the leg.
    /// </summary>
    public partial class RouteVehicleTravelStep
    {
        /// <summary>
        /// Gets and sets the property ContinueHighwayStepDetails. 
        /// <para>
        /// Details that are specific to a Continue Highway step.
        /// </para>
        /// </summary>
        public RouteContinueHighwayStepDetails ContinueHighwayStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContinueHighwayStepDetails property is set.
        /// </summary>
        internal bool IsSetContinueHighwayStepDetails() => this.ContinueHighwayStepDetails != null;

        /// <summary>
        /// Gets and sets the property ContinueStepDetails. 
        /// <para>
        /// Details that are specific to a Continue step.
        /// </para>
        /// </summary>
        public RouteContinueStepDetails ContinueStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContinueStepDetails property is set.
        /// </summary>
        internal bool IsSetContinueStepDetails() => this.ContinueStepDetails != null;

        /// <summary>
        /// Gets and sets the property CurrentRoad. 
        /// <para>
        /// Details of the current road.
        /// </para>
        /// </summary>
        public RouteRoad CurrentRoad { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRoad property is set.
        /// </summary>
        internal bool IsSetCurrentRoad() => this.CurrentRoad != null;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration of the step.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property EnterHighwayStepDetails. 
        /// <para>
        /// Details that are specific to a Enter Highway step.
        /// </para>
        /// </summary>
        public RouteEnterHighwayStepDetails EnterHighwayStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the EnterHighwayStepDetails property is set.
        /// </summary>
        internal bool IsSetEnterHighwayStepDetails() => this.EnterHighwayStepDetails != null;

        /// <summary>
        /// Gets and sets the property ExitNumber. 
        /// <para>
        /// Exit number of the road exit, if applicable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalizedString> ExitNumber { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;

        /// <summary>
        /// Checks to see if the ExitNumber property is set.
        /// </summary>
        internal bool IsSetExitNumber() => this.ExitNumber != null && (this.ExitNumber.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExitStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Exit step.
        /// </para>
        /// </summary>
        public RouteExitStepDetails ExitStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExitStepDetails property is set.
        /// </summary>
        internal bool IsSetExitStepDetails() => this.ExitStepDetails != null;

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this step.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GeometryOffset { get; set; }

        /// <summary>
        /// Checks to see if the GeometryOffset property is set.
        /// </summary>
        internal bool IsSetGeometryOffset() => this.GeometryOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// Brief description of the step in the requested language.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only available when the TravelStepType is Default.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property KeepStepDetails. 
        /// <para>
        /// Details that are specific to a Keep step.
        /// </para>
        /// </summary>
        public RouteKeepStepDetails KeepStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the KeepStepDetails property is set.
        /// </summary>
        internal bool IsSetKeepStepDetails() => this.KeepStepDetails != null;

        /// <summary>
        /// Gets and sets the property NextRoad. 
        /// <para>
        /// Details of the next road. See RouteRoad for details of sub-attributes.
        /// </para>
        /// </summary>
        public RouteRoad NextRoad { get; set; }

        /// <summary>
        /// Checks to see if the NextRoad property is set.
        /// </summary>
        internal bool IsSetNextRoad() => this.NextRoad != null;

        /// <summary>
        /// Gets and sets the property RampStepDetails. 
        /// <para>
        /// Details that are specific to a Ramp step.
        /// </para>
        /// </summary>
        public RouteRampStepDetails RampStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RampStepDetails property is set.
        /// </summary>
        internal bool IsSetRampStepDetails() => this.RampStepDetails != null;

        /// <summary>
        /// Gets and sets the property RoundaboutEnterStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Enter step.
        /// </para>
        /// </summary>
        public RouteRoundaboutEnterStepDetails RoundaboutEnterStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RoundaboutEnterStepDetails property is set.
        /// </summary>
        internal bool IsSetRoundaboutEnterStepDetails() => this.RoundaboutEnterStepDetails != null;

        /// <summary>
        /// Gets and sets the property RoundaboutExitStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Exit step.
        /// </para>
        /// </summary>
        public RouteRoundaboutExitStepDetails RoundaboutExitStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RoundaboutExitStepDetails property is set.
        /// </summary>
        internal bool IsSetRoundaboutExitStepDetails() => this.RoundaboutExitStepDetails != null;

        /// <summary>
        /// Gets and sets the property RoundaboutPassStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Pass step.
        /// </para>
        /// </summary>
        public RouteRoundaboutPassStepDetails RoundaboutPassStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RoundaboutPassStepDetails property is set.
        /// </summary>
        internal bool IsSetRoundaboutPassStepDetails() => this.RoundaboutPassStepDetails != null;

        /// <summary>
        /// Gets and sets the property Signpost. 
        /// <para>
        /// Sign post information of the action, applicable only for TurnByTurn steps. See RouteSignpost
        /// for details of sub-attributes.
        /// </para>
        /// </summary>
        public RouteSignpost Signpost { get; set; }

        /// <summary>
        /// Checks to see if the Signpost property is set.
        /// </summary>
        internal bool IsSetSignpost() => this.Signpost != null;

        /// <summary>
        /// Gets and sets the property TurnStepDetails. 
        /// <para>
        /// Details that are specific to a Turn step.
        /// </para>
        /// </summary>
        public RouteTurnStepDetails TurnStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the TurnStepDetails property is set.
        /// </summary>
        internal bool IsSetTurnStepDetails() => this.TurnStepDetails != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RouteVehicleTravelStepType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UTurnStepDetails. 
        /// <para>
        /// Details that are specific to a Turn step.
        /// </para>
        /// </summary>
        public RouteUTurnStepDetails UTurnStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the UTurnStepDetails property is set.
        /// </summary>
        internal bool IsSetUTurnStepDetails() => this.UTurnStepDetails != null;
    }
}
