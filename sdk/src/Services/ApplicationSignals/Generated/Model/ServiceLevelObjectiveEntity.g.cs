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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains identifying information for a service level objective entity.
    /// </summary>
    public partial class ServiceLevelObjectiveEntity
    {
        /// <summary>
        /// Gets and sets the property SloArn. 
        /// <para>
        /// The ARN of the service level objective. The SLO must be provided with ARN for cross-account
        /// access.
        /// </para>
        /// </summary>
        public string SloArn { get; set; }

        /// <summary>
        /// Checks to see if the SloArn property is set.
        /// </summary>
        internal bool IsSetSloArn() => this.SloArn != null;

        /// <summary>
        /// Gets and sets the property SloName. 
        /// <para>
        /// The name of the service level objective.
        /// </para>
        /// </summary>
        public string SloName { get; set; }

        /// <summary>
        /// Checks to see if the SloName property is set.
        /// </summary>
        internal bool IsSetSloName() => this.SloName != null;
    }
}
