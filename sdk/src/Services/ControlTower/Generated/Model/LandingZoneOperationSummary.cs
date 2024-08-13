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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
        private string _operationIdentifier;
        private LandingZoneOperationType _operationType;
        private LandingZoneOperationStatus _status;

        /// <summary>
        /// Gets and sets the property OperationIdentifier. 
        /// <para>
        /// The <c>operationIdentifier</c> of the landing zone operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string OperationIdentifier
        {
            get { return this._operationIdentifier; }
            set { this._operationIdentifier = value; }
        }

        // Check to see if OperationIdentifier property is set
        internal bool IsSetOperationIdentifier()
        {
            return this._operationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of the landing zone operation.
        /// </para>
        /// </summary>
        public LandingZoneOperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the landing zone operation.
        /// </para>
        /// </summary>
        public LandingZoneOperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}