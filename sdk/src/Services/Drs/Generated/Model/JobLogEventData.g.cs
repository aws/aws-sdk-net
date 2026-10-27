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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Metadata associated with a Job log.
    /// </summary>
    public partial class JobLogEventData
    {
        /// <summary>
        /// Gets and sets the property AttemptCount. 
        /// <para>
        /// Retries for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 9)]
        public long? AttemptCount { get; set; }

        /// <summary>
        /// Checks to see if the AttemptCount property is set.
        /// </summary>
        internal bool IsSetAttemptCount() => this.AttemptCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConversionProperties. 
        /// <para>
        /// Properties of a conversion job
        /// </para>
        /// </summary>
        public ConversionProperties ConversionProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConversionProperties property is set.
        /// </summary>
        internal bool IsSetConversionProperties() => this.ConversionProperties != null;

        /// <summary>
        /// Gets and sets the property ConversionServerID. 
        /// <para>
        /// The ID of a conversion server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string ConversionServerID { get; set; }

        /// <summary>
        /// Checks to see if the ConversionServerID property is set.
        /// </summary>
        internal bool IsSetConversionServerID() => this.ConversionServerID != null;

        /// <summary>
        /// Gets and sets the property EventResourceData. 
        /// <para>
        /// Properties of resource related to a job event.
        /// </para>
        /// </summary>
        public EventResourceData EventResourceData { get; set; }

        /// <summary>
        /// Checks to see if the EventResourceData property is set.
        /// </summary>
        internal bool IsSetEventResourceData() => this.EventResourceData != null;

        /// <summary>
        /// Gets and sets the property MaxAttemptsCount. 
        /// <para>
        /// The maximum number of retries that will be attempted if this operation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 9)]
        public long? MaxAttemptsCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxAttemptsCount property is set.
        /// </summary>
        internal bool IsSetMaxAttemptsCount() => this.MaxAttemptsCount.HasValue;

        /// <summary>
        /// Gets and sets the property RawError. 
        /// <para>
        /// A string representing a job error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string RawError { get; set; }

        /// <summary>
        /// Checks to see if the RawError property is set.
        /// </summary>
        internal bool IsSetRawError() => this.RawError != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of a Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property TargetInstanceID. 
        /// <para>
        /// The ID of a Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string TargetInstanceID { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceID property is set.
        /// </summary>
        internal bool IsSetTargetInstanceID() => this.TargetInstanceID != null;
    }
}
