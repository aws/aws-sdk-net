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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the GetPosition operation.
    /// </summary>
    [Obsolete("This operation is no longer supported.")]
    public partial class GetPositionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Accuracy. 
        /// <para>
        /// The accuracy of the estimated position in meters. An empty value indicates that no
        /// position data is available. A value of ‘0.0’ value indicates that position data is
        /// available. This data corresponds to the position information that you specified instead
        /// of the position computed by solver.
        /// </para>
        /// </summary>
        public Accuracy Accuracy { get; set; }

        /// <summary>
        /// Checks to see if the Accuracy property is set.
        /// </summary>
        internal bool IsSetAccuracy() => this.Accuracy != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position information of the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<float> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<float>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SolverProvider. 
        /// <para>
        /// The vendor of the positioning solver.
        /// </para>
        /// </summary>
        public PositionSolverProvider SolverProvider { get; set; }

        /// <summary>
        /// Checks to see if the SolverProvider property is set.
        /// </summary>
        internal bool IsSetSolverProvider() => this.SolverProvider != null;

        /// <summary>
        /// Gets and sets the property SolverType. 
        /// <para>
        /// The type of solver used to identify the position of the resource.
        /// </para>
        /// </summary>
        public PositionSolverType SolverType { get; set; }

        /// <summary>
        /// Checks to see if the SolverType property is set.
        /// </summary>
        internal bool IsSetSolverType() => this.SolverType != null;

        /// <summary>
        /// Gets and sets the property SolverVersion. 
        /// <para>
        /// The version of the positioning solver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string SolverVersion { get; set; }

        /// <summary>
        /// Checks to see if the SolverVersion property is set.
        /// </summary>
        internal bool IsSetSolverVersion() => this.SolverVersion != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp at which the device's position was determined.
        /// </para>
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
