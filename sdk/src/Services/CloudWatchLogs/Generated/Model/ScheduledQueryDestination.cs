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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Information about a destination where scheduled query results are processed and delivered.
    /// </summary>
    public partial class ScheduledQueryDestination
    {
        private string _destinationIdentifier;
        private ScheduledQueryDestinationType _destinationType;
        private string _errorMessage;
        private string _processedIdentifier;
        private ActionStatus _status;

        /// <summary>
        /// Gets and sets the property DestinationIdentifier. 
        /// <para>
        /// The destination identifier (S3 URI).
        /// </para>
        /// </summary>
        public string DestinationIdentifier
        {
            get { return this._destinationIdentifier; }
            set { this._destinationIdentifier = value; }
        }

        // Check to see if DestinationIdentifier property is set
        internal bool IsSetDestinationIdentifier()
        {
            return this._destinationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of destination (S3).
        /// </para>
        /// </summary>
        public ScheduledQueryDestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message if the destination processing failed.
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
        /// Gets and sets the property ProcessedIdentifier. 
        /// <para>
        /// The processed identifier returned for the destination (S3 key).
        /// </para>
        /// </summary>
        public string ProcessedIdentifier
        {
            get { return this._processedIdentifier; }
            set { this._processedIdentifier = value; }
        }

        // Check to see if ProcessedIdentifier property is set
        internal bool IsSetProcessedIdentifier()
        {
            return this._processedIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The processing status for this destination (IN_PROGRESS, ERROR, FAILED, or COMPLETE).
        /// </para>
        /// </summary>
        public ActionStatus Status
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