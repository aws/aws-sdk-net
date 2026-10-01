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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Details about the over-the-air (OTA) task process.
    /// </summary>
    public partial class TaskProcessingDetails
    {
        /// <summary>
        /// Gets and sets the property NumberOfCanceledThings. 
        /// <para>
        /// The number of canceled things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfCanceledThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfCanceledThings property is set.
        /// </summary>
        internal bool IsSetNumberOfCanceledThings() => this.NumberOfCanceledThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfFailedThings. 
        /// <para>
        /// The number of failed things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfFailedThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfFailedThings property is set.
        /// </summary>
        internal bool IsSetNumberOfFailedThings() => this.NumberOfFailedThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfInProgressThings. 
        /// <para>
        /// The number of in progress things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfInProgressThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfInProgressThings property is set.
        /// </summary>
        internal bool IsSetNumberOfInProgressThings() => this.NumberOfInProgressThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfQueuedThings. 
        /// <para>
        /// The number of queued things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfQueuedThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfQueuedThings property is set.
        /// </summary>
        internal bool IsSetNumberOfQueuedThings() => this.NumberOfQueuedThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfRejectedThings. 
        /// <para>
        /// The number of rejected things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfRejectedThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRejectedThings property is set.
        /// </summary>
        internal bool IsSetNumberOfRejectedThings() => this.NumberOfRejectedThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfRemovedThings. 
        /// <para>
        /// The number of removed things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfRemovedThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRemovedThings property is set.
        /// </summary>
        internal bool IsSetNumberOfRemovedThings() => this.NumberOfRemovedThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfSucceededThings. 
        /// <para>
        /// The number of succeeded things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfSucceededThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSucceededThings property is set.
        /// </summary>
        internal bool IsSetNumberOfSucceededThings() => this.NumberOfSucceededThings.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfTimedOutThings. 
        /// <para>
        /// The number of timed out things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfTimedOutThings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTimedOutThings property is set.
        /// </summary>
        internal bool IsSetNumberOfTimedOutThings() => this.NumberOfTimedOutThings.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessingTargets. 
        /// <para>
        /// The targets of the over-the-air (OTA) task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProcessingTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProcessingTargets property is set.
        /// </summary>
        internal bool IsSetProcessingTargets() => this.ProcessingTargets != null && (this.ProcessingTargets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
