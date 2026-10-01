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

namespace Amazon.FIS.Model
{
    /// <summary>
    /// Describes the options for an experiment.
    /// </summary>
    public partial class ExperimentOptions
    {
        /// <summary>
        /// Gets and sets the property AccountTargeting. 
        /// <para>
        /// The account targeting setting for an experiment.
        /// </para>
        /// </summary>
        public AccountTargeting AccountTargeting { get; set; }

        /// <summary>
        /// Checks to see if the AccountTargeting property is set.
        /// </summary>
        internal bool IsSetAccountTargeting() => this.AccountTargeting != null;

        /// <summary>
        /// Gets and sets the property ActionsMode. 
        /// <para>
        /// The actions mode of the experiment that is set from the StartExperiment API command.
        /// </para>
        /// </summary>
        public ActionsMode ActionsMode { get; set; }

        /// <summary>
        /// Checks to see if the ActionsMode property is set.
        /// </summary>
        internal bool IsSetActionsMode() => this.ActionsMode != null;

        /// <summary>
        /// Gets and sets the property EmptyTargetResolutionMode. 
        /// <para>
        /// The empty target resolution mode for an experiment.
        /// </para>
        /// </summary>
        public EmptyTargetResolutionMode EmptyTargetResolutionMode { get; set; }

        /// <summary>
        /// Checks to see if the EmptyTargetResolutionMode property is set.
        /// </summary>
        internal bool IsSetEmptyTargetResolutionMode() => this.EmptyTargetResolutionMode != null;
    }
}
