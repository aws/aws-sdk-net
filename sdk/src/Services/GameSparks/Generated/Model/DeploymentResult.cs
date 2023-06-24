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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// The result of the deployment.
    /// </summary>
    public partial class DeploymentResult
    {
        private string _message;
        private ResultCode _resultCode;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Details about the deployment result.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ResultCode. 
        /// <para>
        /// The type of deployment result.
        /// </para>
        /// </summary>
        public ResultCode ResultCode
        {
            get { return this._resultCode; }
            set { this._resultCode = value; }
        }

        // Check to see if ResultCode property is set
        internal bool IsSetResultCode()
        {
            return this._resultCode != null;
        }

    }
}