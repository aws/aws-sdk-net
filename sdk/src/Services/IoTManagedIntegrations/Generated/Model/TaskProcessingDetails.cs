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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
        private int? _numberOfCanceledThings;
        private int? _numberOfFailedThings;
        private int? _numberOfInProgressThings;
        private int? _numberOfQueuedThings;
        private int? _numberOfRejectedThings;
        private int? _numberOfRemovedThings;
        private int? _numberOfSucceededThings;
        private int? _numberOfTimedOutThings;
        private List<string> _processingTargets = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NumberOfCanceledThings. 
        /// <para>
        /// The number of canceled things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfCanceledThings
        {
            get { return this._numberOfCanceledThings; }
            set { this._numberOfCanceledThings = value; }
        }

        // Check to see if NumberOfCanceledThings property is set
        internal bool IsSetNumberOfCanceledThings()
        {
            return this._numberOfCanceledThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfFailedThings. 
        /// <para>
        /// The number of failed things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfFailedThings
        {
            get { return this._numberOfFailedThings; }
            set { this._numberOfFailedThings = value; }
        }

        // Check to see if NumberOfFailedThings property is set
        internal bool IsSetNumberOfFailedThings()
        {
            return this._numberOfFailedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfInProgressThings. 
        /// <para>
        /// The number of in progress things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfInProgressThings
        {
            get { return this._numberOfInProgressThings; }
            set { this._numberOfInProgressThings = value; }
        }

        // Check to see if NumberOfInProgressThings property is set
        internal bool IsSetNumberOfInProgressThings()
        {
            return this._numberOfInProgressThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfQueuedThings. 
        /// <para>
        /// The number of queued things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfQueuedThings
        {
            get { return this._numberOfQueuedThings; }
            set { this._numberOfQueuedThings = value; }
        }

        // Check to see if NumberOfQueuedThings property is set
        internal bool IsSetNumberOfQueuedThings()
        {
            return this._numberOfQueuedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRejectedThings. 
        /// <para>
        /// The number of rejected things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfRejectedThings
        {
            get { return this._numberOfRejectedThings; }
            set { this._numberOfRejectedThings = value; }
        }

        // Check to see if NumberOfRejectedThings property is set
        internal bool IsSetNumberOfRejectedThings()
        {
            return this._numberOfRejectedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRemovedThings. 
        /// <para>
        /// The number of removed things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfRemovedThings
        {
            get { return this._numberOfRemovedThings; }
            set { this._numberOfRemovedThings = value; }
        }

        // Check to see if NumberOfRemovedThings property is set
        internal bool IsSetNumberOfRemovedThings()
        {
            return this._numberOfRemovedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfSucceededThings. 
        /// <para>
        /// The number of succeeded things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfSucceededThings
        {
            get { return this._numberOfSucceededThings; }
            set { this._numberOfSucceededThings = value; }
        }

        // Check to see if NumberOfSucceededThings property is set
        internal bool IsSetNumberOfSucceededThings()
        {
            return this._numberOfSucceededThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTimedOutThings. 
        /// <para>
        /// The number of timed out things in an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public int? NumberOfTimedOutThings
        {
            get { return this._numberOfTimedOutThings; }
            set { this._numberOfTimedOutThings = value; }
        }

        // Check to see if NumberOfTimedOutThings property is set
        internal bool IsSetNumberOfTimedOutThings()
        {
            return this._numberOfTimedOutThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingTargets. 
        /// <para>
        /// The targets of the over-the-air (OTA) task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProcessingTargets
        {
            get { return this._processingTargets; }
            set { this._processingTargets = value; }
        }

        // Check to see if ProcessingTargets property is set
        internal bool IsSetProcessingTargets()
        {
            return this._processingTargets != null && (this._processingTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}