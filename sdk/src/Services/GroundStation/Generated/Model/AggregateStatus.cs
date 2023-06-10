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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Aggregate status of Agent components.
    /// </summary>
    public partial class AggregateStatus
    {
        private Dictionary<string, bool> _signatureMap = new Dictionary<string, bool>();
        private AgentStatus _status;

        /// <summary>
        /// Gets and sets the property SignatureMap. 
        /// <para>
        /// Sparse map of failure signatures.
        /// </para>
        /// </summary>
        public Dictionary<string, bool> SignatureMap
        {
            get { return this._signatureMap; }
            set { this._signatureMap = value; }
        }

        // Check to see if SignatureMap property is set
        internal bool IsSetSignatureMap()
        {
            return this._signatureMap != null && this._signatureMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Aggregate status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus Status
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