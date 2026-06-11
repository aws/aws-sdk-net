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
    /// A step that must be performed during the travel portion of the leg.
    /// </summary>
    public partial class RouteTaxiTravelStep
    {
        private RouteContinueStepDetails _continueStepDetails;
        private long? _distance;
        private long? _duration;
        private RouteExitStepDetails _exitStepDetails;
        private int? _geometryOffset;
        private string _instruction;
        private RouteKeepStepDetails _keepStepDetails;
        private RouteRampStepDetails _rampStepDetails;
        private RouteRoundaboutEnterStepDetails _roundaboutEnterStepDetails;
        private RouteRoundaboutExitStepDetails _roundaboutExitStepDetails;
        private RouteRoundaboutPassStepDetails _roundaboutPassStepDetails;
        private RouteTurnStepDetails _turnStepDetails;
        private RouteTaxiTravelStepType _type;
        private RouteUTurnStepDetails _uTurnStepDetails;

        /// <summary>
        /// Gets and sets the property ContinueStepDetails.
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
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the step.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Distance
        {
            get { return this._distance; }
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
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExitStepDetails.
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
        public int? GeometryOffset
        {
            get { return this._geometryOffset; }
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
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property RampStepDetails.
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
        /// Gets and sets the property TurnStepDetails.
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
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteTaxiTravelStepType Type
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