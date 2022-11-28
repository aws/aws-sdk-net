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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the GetPosition operation.
    /// </summary>
    [Obsolete("This operation is no longer supported.")]
    public partial class GetPositionResponse : AmazonWebServiceResponse
    {
        private Accuracy _accuracy;
        private List<float> _position = new List<float>();
        private PositionSolverProvider _solverProvider;
        private PositionSolverType _solverType;
        private string _solverVersion;
        private string _timestamp;

        /// <summary>
        /// Gets and sets the property Accuracy. 
        /// <para>
        /// The accuracy of the estimated position in meters. An empty value indicates that no
        /// position data is available. A value of ‘0.0’ value indicates that position data is
        /// available. This data corresponds to the position information that you specified instead
        /// of the position computed by solver.
        /// </para>
        /// </summary>
        public Accuracy Accuracy
        {
            get { return this._accuracy; }
            set { this._accuracy = value; }
        }

        // Check to see if Accuracy property is set
        internal bool IsSetAccuracy()
        {
            return this._accuracy != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position information of the resource.
        /// </para>
        /// </summary>
        public List<float> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && this._position.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SolverProvider. 
        /// <para>
        /// The vendor of the positioning solver.
        /// </para>
        /// </summary>
        public PositionSolverProvider SolverProvider
        {
            get { return this._solverProvider; }
            set { this._solverProvider = value; }
        }

        // Check to see if SolverProvider property is set
        internal bool IsSetSolverProvider()
        {
            return this._solverProvider != null;
        }

        /// <summary>
        /// Gets and sets the property SolverType. 
        /// <para>
        /// The type of solver used to identify the position of the resource.
        /// </para>
        /// </summary>
        public PositionSolverType SolverType
        {
            get { return this._solverType; }
            set { this._solverType = value; }
        }

        // Check to see if SolverType property is set
        internal bool IsSetSolverType()
        {
            return this._solverType != null;
        }

        /// <summary>
        /// Gets and sets the property SolverVersion. 
        /// <para>
        /// The version of the positioning solver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string SolverVersion
        {
            get { return this._solverVersion; }
            set { this._solverVersion = value; }
        }

        // Check to see if SolverVersion property is set
        internal bool IsSetSolverVersion()
        {
            return this._solverVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp at which the device's position was determined.
        /// </para>
        /// </summary>
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}