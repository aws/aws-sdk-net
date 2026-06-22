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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
    /// Represents a successfully deleted instrumentation configuration.
    /// </summary>
    public partial class BatchDeleteSuccessfulDeletion
    {
        private string _locationHash;
        private string _resourceArn;
        private string _signalType;

        /// <summary>
        /// Gets and sets the property LocationHash. 
        /// <para>
        /// Location hash of the deleted configuration (populated only when deleting by scope).
        /// </para>
        /// </summary>
        public string LocationHash
        {
            get { return this._locationHash; }
            set { this._locationHash = value; }
        }

        // Check to see if LocationHash property is set
        internal bool IsSetLocationHash()
        {
            return this._locationHash != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// ARN of the deleted configuration (populated only when deleting by ARN list).
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// Signal type of the deleted configuration (populated only when deleting by scope).
        /// </para>
        /// </summary>
        public string SignalType
        {
            get { return this._signalType; }
            set { this._signalType = value; }
        }

        // Check to see if SignalType property is set
        internal bool IsSetSignalType()
        {
            return this._signalType != null;
        }

    }
}