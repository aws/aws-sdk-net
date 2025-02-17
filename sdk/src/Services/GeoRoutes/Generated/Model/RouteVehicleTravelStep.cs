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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
        private RouteContinueHighwayStepDetails _continueHighwayStepDetails;
        private RouteContinueStepDetails _continueStepDetails;
        private RouteRoad _currentRoad;
        private long? _distance;
        private long? _duration;
        private RouteEnterHighwayStepDetails _enterHighwayStepDetails;
        private List<LocalizedString> _exitNumber = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;
        private RouteExitStepDetails _exitStepDetails;
        private int? _geometryOffset;
        private string _instruction;
        private RouteKeepStepDetails _keepStepDetails;
        private RouteRoad _nextRoad;
        private RouteRampStepDetails _rampStepDetails;
        private RouteRoundaboutEnterStepDetails _roundaboutEnterStepDetails;
        private RouteRoundaboutExitStepDetails _roundaboutExitStepDetails;
        private RouteRoundaboutPassStepDetails _roundaboutPassStepDetails;
        private RouteSignpost _signpost;
        private RouteTurnStepDetails _turnStepDetails;
        private RouteVehicleTravelStepType _type;
        private RouteUTurnStepDetails _uTurnStepDetails;

        /// <summary>
        /// Gets and sets the property ContinueHighwayStepDetails. 
        /// <para>
        /// Details that are specific to a Continue Highway step.
        /// </para>
        /// </summary>
        public RouteContinueHighwayStepDetails ContinueHighwayStepDetails
        {
            get { return this._continueHighwayStepDetails; }
            set { this._continueHighwayStepDetails = value; }
        }

        // Check to see if ContinueHighwayStepDetails property is set
        internal bool IsSetContinueHighwayStepDetails()
        {
            return this._continueHighwayStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContinueStepDetails. 
        /// <para>
        /// Details that are specific to a Continue step.
        /// </para>
        /// </summary>
        public RouteContinueStepDetails ContinueStepDetails
        {
            get { return this._continueStepDetails; }
            set { this._continueStepDetails = value; }
        }

        // Check to see if ContinueStepDetails property is set
        internal bool IsSetContinueStepDetails()
        {
            return this._continueStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRoad. 
        /// <para>
        /// Details of the current road.
        /// </para>
        /// </summary>
        public RouteRoad CurrentRoad
        {
            get { return this._currentRoad; }
            set { this._currentRoad = value; }
        }

        // Check to see if CurrentRoad property is set
        internal bool IsSetCurrentRoad()
        {
            return this._currentRoad != null;
        }

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long Distance
        {
            get { return this._distance.GetValueOrDefault(); }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

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
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnterHighwayStepDetails. 
        /// <para>
        /// Details that are specific to a Enter Highway step.
        /// </para>
        /// </summary>
        public RouteEnterHighwayStepDetails EnterHighwayStepDetails
        {
            get { return this._enterHighwayStepDetails; }
            set { this._enterHighwayStepDetails = value; }
        }

        // Check to see if EnterHighwayStepDetails property is set
        internal bool IsSetEnterHighwayStepDetails()
        {
            return this._enterHighwayStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExitNumber. 
        /// <para>
        /// Exit number of the road exit, if applicable.
        /// </para>
        /// </summary>
        public List<LocalizedString> ExitNumber
        {
            get { return this._exitNumber; }
            set { this._exitNumber = value; }
        }

        // Check to see if ExitNumber property is set
        internal bool IsSetExitNumber()
        {
            return this._exitNumber != null && (this._exitNumber.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExitStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Exit step.
        /// </para>
        /// </summary>
        public RouteExitStepDetails ExitStepDetails
        {
            get { return this._exitStepDetails; }
            set { this._exitStepDetails = value; }
        }

        // Check to see if ExitStepDetails property is set
        internal bool IsSetExitStepDetails()
        {
            return this._exitStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int GeometryOffset
        {
            get { return this._geometryOffset.GetValueOrDefault(); }
            set { this._geometryOffset = value; }
        }

        // Check to see if GeometryOffset property is set
        internal bool IsSetGeometryOffset()
        {
            return this._geometryOffset.HasValue; 
        }

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
        public string Instruction
        {
            get { return this._instruction; }
            set { this._instruction = value; }
        }

        // Check to see if Instruction property is set
        internal bool IsSetInstruction()
        {
            return this._instruction != null;
        }

        /// <summary>
        /// Gets and sets the property KeepStepDetails. 
        /// <para>
        /// Details that are specific to a Keep step.
        /// </para>
        /// </summary>
        public RouteKeepStepDetails KeepStepDetails
        {
            get { return this._keepStepDetails; }
            set { this._keepStepDetails = value; }
        }

        // Check to see if KeepStepDetails property is set
        internal bool IsSetKeepStepDetails()
        {
            return this._keepStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property NextRoad. 
        /// <para>
        /// Details of the next road. See RouteRoad for details of sub-attributes.
        /// </para>
        /// </summary>
        public RouteRoad NextRoad
        {
            get { return this._nextRoad; }
            set { this._nextRoad = value; }
        }

        // Check to see if NextRoad property is set
        internal bool IsSetNextRoad()
        {
            return this._nextRoad != null;
        }

        /// <summary>
        /// Gets and sets the property RampStepDetails. 
        /// <para>
        /// Details that are specific to a Ramp step.
        /// </para>
        /// </summary>
        public RouteRampStepDetails RampStepDetails
        {
            get { return this._rampStepDetails; }
            set { this._rampStepDetails = value; }
        }

        // Check to see if RampStepDetails property is set
        internal bool IsSetRampStepDetails()
        {
            return this._rampStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RoundaboutEnterStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Enter step.
        /// </para>
        /// </summary>
        public RouteRoundaboutEnterStepDetails RoundaboutEnterStepDetails
        {
            get { return this._roundaboutEnterStepDetails; }
            set { this._roundaboutEnterStepDetails = value; }
        }

        // Check to see if RoundaboutEnterStepDetails property is set
        internal bool IsSetRoundaboutEnterStepDetails()
        {
            return this._roundaboutEnterStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RoundaboutExitStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Exit step.
        /// </para>
        /// </summary>
        public RouteRoundaboutExitStepDetails RoundaboutExitStepDetails
        {
            get { return this._roundaboutExitStepDetails; }
            set { this._roundaboutExitStepDetails = value; }
        }

        // Check to see if RoundaboutExitStepDetails property is set
        internal bool IsSetRoundaboutExitStepDetails()
        {
            return this._roundaboutExitStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RoundaboutPassStepDetails. 
        /// <para>
        /// Details that are specific to a Roundabout Pass step.
        /// </para>
        /// </summary>
        public RouteRoundaboutPassStepDetails RoundaboutPassStepDetails
        {
            get { return this._roundaboutPassStepDetails; }
            set { this._roundaboutPassStepDetails = value; }
        }

        // Check to see if RoundaboutPassStepDetails property is set
        internal bool IsSetRoundaboutPassStepDetails()
        {
            return this._roundaboutPassStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Signpost. 
        /// <para>
        /// Sign post information of the action, applicable only for TurnByTurn steps. See RouteSignpost
        /// for details of sub-attributes.
        /// </para>
        /// </summary>
        public RouteSignpost Signpost
        {
            get { return this._signpost; }
            set { this._signpost = value; }
        }

        // Check to see if Signpost property is set
        internal bool IsSetSignpost()
        {
            return this._signpost != null;
        }

        /// <summary>
        /// Gets and sets the property TurnStepDetails. 
        /// <para>
        /// Details that are specific to a Turn step.
        /// </para>
        /// </summary>
        public RouteTurnStepDetails TurnStepDetails
        {
            get { return this._turnStepDetails; }
            set { this._turnStepDetails = value; }
        }

        // Check to see if TurnStepDetails property is set
        internal bool IsSetTurnStepDetails()
        {
            return this._turnStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteVehicleTravelStepType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UTurnStepDetails. 
        /// <para>
        /// Details that are specific to a Turn step.
        /// </para>
        /// </summary>
        public RouteUTurnStepDetails UTurnStepDetails
        {
            get { return this._uTurnStepDetails; }
            set { this._uTurnStepDetails = value; }
        }

        // Check to see if UTurnStepDetails property is set
        internal bool IsSetUTurnStepDetails()
        {
            return this._uTurnStepDetails != null;
        }

    }
}