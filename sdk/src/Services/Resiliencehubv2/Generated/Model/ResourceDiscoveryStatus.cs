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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains the status of resource discovery for a service.
    /// </summary>
    public partial class ResourceDiscoveryStatus
    {
        private ResourceDiscoveryErrorCode _errorCode;
        private string _errorMessage;
        private DateTime? _lastRunAt;
        private ResourceDiscoveryRunStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code if resource discovery failed.
        /// </para>
        /// </summary>
        public ResourceDiscoveryErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message describing the error if resource discovery failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunAt. 
        /// <para>
        /// The timestamp of the last resource discovery run.
        /// </para>
        /// </summary>
        public DateTime? LastRunAt
        {
            get { return this._lastRunAt; }
            set { this._lastRunAt = value; }
        }

        // Check to see if LastRunAt property is set
        internal bool IsSetLastRunAt()
        {
            return this._lastRunAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of resource discovery.
        /// </para>
        /// </summary>
        public ResourceDiscoveryRunStatus Status
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