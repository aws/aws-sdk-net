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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the GetWirelessDeviceImportTask operation.
    /// </summary>
    public partial class GetWirelessDeviceImportTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the import task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the destination that's assigned to the wireless devices in the import
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationName property is set.
        /// </summary>
        internal bool IsSetDestinationName() => this.DestinationName != null;

        /// <summary>
        /// Gets and sets the property FailedImportedDeviceCount. 
        /// <para>
        /// The number of devices in the import task that failed to onboard to the import task.
        /// </para>
        /// </summary>
        public long? FailedImportedDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedImportedDeviceCount property is set.
        /// </summary>
        internal bool IsSetFailedImportedDeviceCount() => this.FailedImportedDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the import task for which information is retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InitializedImportedDeviceCount. 
        /// <para>
        /// The number of devices in the import task that are waiting for the control log to start
        /// processing.
        /// </para>
        /// </summary>
        public long? InitializedImportedDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the InitializedImportedDeviceCount property is set.
        /// </summary>
        internal bool IsSetInitializedImportedDeviceCount() => this.InitializedImportedDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property OnboardedImportedDeviceCount. 
        /// <para>
        /// The number of devices in the import task that have been onboarded to the import task.
        /// </para>
        /// </summary>
        public long? OnboardedImportedDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the OnboardedImportedDeviceCount property is set.
        /// </summary>
        internal bool IsSetOnboardedImportedDeviceCount() => this.OnboardedImportedDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property PendingImportedDeviceCount. 
        /// <para>
        /// The number of devices in the import task that are waiting in the import task queue
        /// to be onboarded.
        /// </para>
        /// </summary>
        public long? PendingImportedDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingImportedDeviceCount property is set.
        /// </summary>
        internal bool IsSetPendingImportedDeviceCount() => this.PendingImportedDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// The integration status of the Device Location feature for LoRaWAN and Sidewalk devices.
        /// </para>
        /// </summary>
        public PositioningConfigStatus Positioning { get; set; }

        /// <summary>
        /// Checks to see if the Positioning property is set.
        /// </summary>
        internal bool IsSetPositioning() => this.Positioning != null;

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk-related information about an import task.
        /// </para>
        /// </summary>
        public SidewalkGetStartImportInfo Sidewalk { get; set; }

        /// <summary>
        /// Checks to see if the Sidewalk property is set.
        /// </summary>
        internal bool IsSetSidewalk() => this.Sidewalk != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The import task status.
        /// </para>
        /// </summary>
        public ImportTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the provided status information, such as a validation error that causes
        /// the import task to fail.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
