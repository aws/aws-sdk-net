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

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Returns a summary of information about a landing zone operation.
    /// </summary>
    public partial class LandingZoneOperationSummary
    {
        /// <summary>
        /// Gets and sets the property OperationIdentifier. 
        /// <para>
        /// The <c>operationIdentifier</c> of the landing zone operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string OperationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OperationIdentifier property is set.
        /// </summary>
        internal bool IsSetOperationIdentifier() => this.OperationIdentifier != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of the landing zone operation.
        /// </para>
        /// </summary>
        public LandingZoneOperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the landing zone operation.
        /// </para>
        /// </summary>
        public LandingZoneOperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
