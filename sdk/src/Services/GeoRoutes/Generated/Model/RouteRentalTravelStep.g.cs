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
    /// A step that must be performed during the travel portion of the leg.
    /// </summary>
    public partial class RouteRentalTravelStep
    {
        /// <summary>
        /// Gets and sets the property ContinueStepDetails.
        /// </summary>
        public RouteContinueStepDetails ContinueStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContinueStepDetails property is set.
        /// </summary>
        internal bool IsSetContinueStepDetails() => this.ContinueStepDetails != null;

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
        /// Gets and sets the property ExitStepDetails.
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
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property KeepStepDetails.
        /// </summary>
        public RouteKeepStepDetails KeepStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the KeepStepDetails property is set.
        /// </summary>
        internal bool IsSetKeepStepDetails() => this.KeepStepDetails != null;

        /// <summary>
        /// Gets and sets the property RampStepDetails.
        /// </summary>
        public RouteRampStepDetails RampStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RampStepDetails property is set.
        /// </summary>
        internal bool IsSetRampStepDetails() => this.RampStepDetails != null;

        /// <summary>
        /// Gets and sets the property RoundaboutEnterStepDetails.
        /// </summary>
        public RouteRoundaboutEnterStepDetails RoundaboutEnterStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RoundaboutEnterStepDetails property is set.
        /// </summary>
        internal bool IsSetRoundaboutEnterStepDetails() => this.RoundaboutEnterStepDetails != null;

        /// <summary>
        /// Gets and sets the property RoundaboutExitStepDetails.
        /// </summary>
        public RouteRoundaboutExitStepDetails RoundaboutExitStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RoundaboutExitStepDetails property is set.
        /// </summary>
        internal bool IsSetRoundaboutExitStepDetails() => this.RoundaboutExitStepDetails != null;

        /// <summary>
        /// Gets and sets the property RoundaboutPassStepDetails.
        /// </summary>
        public RouteRoundaboutPassStepDetails RoundaboutPassStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the RoundaboutPassStepDetails property is set.
        /// </summary>
        internal bool IsSetRoundaboutPassStepDetails() => this.RoundaboutPassStepDetails != null;

        /// <summary>
        /// Gets and sets the property TurnStepDetails.
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
        public RouteRentalTravelStepType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UTurnStepDetails.
        /// </summary>
        public RouteUTurnStepDetails UTurnStepDetails { get; set; }

        /// <summary>
        /// Checks to see if the UTurnStepDetails property is set.
        /// </summary>
        internal bool IsSetUTurnStepDetails() => this.UTurnStepDetails != null;
    }
}
