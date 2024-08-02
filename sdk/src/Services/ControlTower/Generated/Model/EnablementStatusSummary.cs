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
    /// The deployment summary of an <c>EnabledControl</c> or <c>EnabledBaseline</c> resource.
    /// </summary>
    public partial class EnablementStatusSummary
    {
        private string _lastOperationIdentifier;
        private EnablementStatus _status;

        /// <summary>
        /// Gets and sets the property LastOperationIdentifier. 
        /// <para>
        /// The last operation identifier for the enabled resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string LastOperationIdentifier
        {
            get { return this._lastOperationIdentifier; }
            set { this._lastOperationIdentifier = value; }
        }

        // Check to see if LastOperationIdentifier property is set
        internal bool IsSetLastOperationIdentifier()
        {
            return this._lastOperationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The deployment status of the enabled resource.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The <c>EnabledControl</c> or <c>EnabledBaseline</c> configuration
        /// was deployed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNDER_CHANGE</c>: The <c>EnabledControl</c> or <c>EnabledBaseline</c> configuration
        /// is changing. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The <c>EnabledControl</c> or <c>EnabledBaseline</c> configuration
        /// failed to deploy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EnablementStatus Status
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