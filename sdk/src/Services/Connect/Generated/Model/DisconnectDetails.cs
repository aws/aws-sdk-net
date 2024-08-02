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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Information about the call disconnect experience.
    /// </summary>
    public partial class DisconnectDetails
    {
        private string _potentialDisconnectIssue;

        /// <summary>
        /// Gets and sets the property PotentialDisconnectIssue. 
        /// <para>
        /// Indicates the potential disconnection issues for a call. This field is not populated
        /// if the service does not detect potential issues.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string PotentialDisconnectIssue
        {
            get { return this._potentialDisconnectIssue; }
            set { this._potentialDisconnectIssue = value; }
        }

        // Check to see if PotentialDisconnectIssue property is set
        internal bool IsSetPotentialDisconnectIssue()
        {
            return this._potentialDisconnectIssue != null;
        }

    }
}