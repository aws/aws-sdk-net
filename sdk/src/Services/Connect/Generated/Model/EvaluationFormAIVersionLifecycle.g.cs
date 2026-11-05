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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the status and availability dates for an AI version, indicating when the
    /// version became active and when it reaches end of life.
    /// </summary>
    public partial class EvaluationFormAIVersionLifecycle
    {
        /// <summary>
        /// Gets and sets the property EndOfLifeTime. 
        /// <para>
        /// The timestamp when this AI version reaches or reached end of life.
        /// </para>
        /// </summary>
        public DateTime? EndOfLifeTime { get; set; }

        /// <summary>
        /// Checks to see if the EndOfLifeTime property is set.
        /// </summary>
        internal bool IsSetEndOfLifeTime() => this.EndOfLifeTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartOfLifeTime. 
        /// <para>
        /// The timestamp for when this AI version became available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartOfLifeTime { get; set; }

        /// <summary>
        /// Checks to see if the StartOfLifeTime property is set.
        /// </summary>
        internal bool IsSetStartOfLifeTime() => this.StartOfLifeTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the AI version. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Latest</c> - The most recent AI version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Preview</c> - An AI version available for preview.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - An AI version that is currently available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deprecated</c> - An AI version that is no longer recommended for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removed</c> - An AI version that is no longer available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormAIVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
