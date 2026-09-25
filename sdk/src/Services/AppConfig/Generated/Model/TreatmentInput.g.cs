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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Input structure for defining a treatment when creating or updating an experiment definition.
    /// </summary>
    public partial class TreatmentInput
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlagValue. 
        /// <para>
        /// The feature flag value to serve to users assigned to this treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlagValue FlagValue { get; set; }

        /// <summary>
        /// Checks to see if the FlagValue property is set.
        /// </summary>
        internal bool IsSetFlagValue() => this.FlagValue != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The traffic allocation weight for this treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public float? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
