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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Provides step/procedure step information for a restart batch job operation.
    /// </summary>
    public partial class JobStepRestartMarker
    {
        /// <summary>
        /// Gets and sets the property FromProcStep. 
        /// <para>
        /// The procedure step name that a batch job was restarted from.
        /// </para>
        /// </summary>
        public string FromProcStep { get; set; }

        /// <summary>
        /// Checks to see if the FromProcStep property is set.
        /// </summary>
        internal bool IsSetFromProcStep() => this.FromProcStep != null;

        /// <summary>
        /// Gets and sets the property FromStep. 
        /// <para>
        /// The step name that a batch job was restarted from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FromStep { get; set; }

        /// <summary>
        /// Checks to see if the FromStep property is set.
        /// </summary>
        internal bool IsSetFromStep() => this.FromStep != null;

        /// <summary>
        /// Gets and sets the property Skip. 
        /// <para>
        /// The step-level checkpoint timestamp (creation or last modification) for an Amazon
        /// Web Services Blu Age application batch job.
        /// </para>
        /// </summary>
        public bool? Skip { get; set; }

        /// <summary>
        /// Checks to see if the Skip property is set.
        /// </summary>
        internal bool IsSetSkip() => this.Skip.HasValue;

        /// <summary>
        /// Gets and sets the property StepCheckpoint. 
        /// <para>
        /// Skip selected step and issue a restart from immediate successor step for an Amazon
        /// Web Services Blu Age application batch job.
        /// </para>
        /// </summary>
        public int? StepCheckpoint { get; set; }

        /// <summary>
        /// Checks to see if the StepCheckpoint property is set.
        /// </summary>
        internal bool IsSetStepCheckpoint() => this.StepCheckpoint.HasValue;

        /// <summary>
        /// Gets and sets the property ToProcStep. 
        /// <para>
        /// The procedure step name that a batch job was restarted to.
        /// </para>
        /// </summary>
        public string ToProcStep { get; set; }

        /// <summary>
        /// Checks to see if the ToProcStep property is set.
        /// </summary>
        internal bool IsSetToProcStep() => this.ToProcStep != null;

        /// <summary>
        /// Gets and sets the property ToStep. 
        /// <para>
        /// The step name that a batch job was restarted to.
        /// </para>
        /// </summary>
        public string ToStep { get; set; }

        /// <summary>
        /// Checks to see if the ToStep property is set.
        /// </summary>
        internal bool IsSetToStep() => this.ToStep != null;
    }
}
