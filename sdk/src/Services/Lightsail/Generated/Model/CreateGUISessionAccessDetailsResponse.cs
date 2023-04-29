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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the CreateGUISessionAccessDetails operation.
    /// </summary>
    public partial class CreateGUISessionAccessDetailsResponse : AmazonWebServiceResponse
    {
        private string _failureReason;
        private int? _percentageComplete;
        private string _resourceName;
        private List<Session> _sessions = new List<Session>();
        private Status _status;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the operation failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property PercentageComplete. 
        /// <para>
        /// The percentage of completion for the operation.
        /// </para>
        /// </summary>
        public int PercentageComplete
        {
            get { return this._percentageComplete.GetValueOrDefault(); }
            set { this._percentageComplete = value; }
        }

        // Check to see if PercentageComplete property is set
        internal bool IsSetPercentageComplete()
        {
            return this._percentageComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Sessions. 
        /// <para>
        /// Returns information about the specified NICE DCV GUI session.
        /// </para>
        /// </summary>
        public List<Session> Sessions
        {
            get { return this._sessions; }
            set { this._sessions = value; }
        }

        // Check to see if Sessions property is set
        internal bool IsSetSessions()
        {
            return this._sessions != null && this._sessions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation.
        /// </para>
        /// </summary>
        public Status Status
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