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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about a destination where scheduled query results are processed, including
    /// processing status and any error messages.
    /// </summary>
    public partial class ScheduledQueryDestination
    {
        /// <summary>
        /// Gets and sets the property DestinationIdentifier. 
        /// <para>
        /// The identifier for the destination where results are delivered.
        /// </para>
        /// </summary>
        public string DestinationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIdentifier property is set.
        /// </summary>
        internal bool IsSetDestinationIdentifier() => this.DestinationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of destination for query results.
        /// </para>
        /// </summary>
        public ScheduledQueryDestinationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message if destination processing failed.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ProcessedIdentifier. 
        /// <para>
        /// The identifier of the processed result at the destination.
        /// </para>
        /// </summary>
        public string ProcessedIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedIdentifier property is set.
        /// </summary>
        internal bool IsSetProcessedIdentifier() => this.ProcessedIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The processing status of the destination delivery.
        /// </para>
        /// </summary>
        public ActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
