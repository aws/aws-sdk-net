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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
    /// Information about an import task for wireless devices.
    /// </summary>
    public partial class WirelessDeviceImportTask
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _destinationName;
        private long? _failedImportedDeviceCount;
        private string _id;
        private long? _initializedImportedDeviceCount;
        private long? _onboardedImportedDeviceCount;
        private long? _pendingImportedDeviceCount;
        private SidewalkGetStartImportInfo _sidewalk;
        private ImportTaskStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the wireless device import task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the import task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the Sidewalk destination that that describes the IoT rule to route messages
        /// from the device in the import task that will be onboarded to AWS IoT Wireless
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property FailedImportedDeviceCount. 
        /// <para>
        /// The summary information of count of wireless devices in an import task that failed
        /// to onboarded to the import task.
        /// </para>
        /// </summary>
        public long? FailedImportedDeviceCount
        {
            get { return this._failedImportedDeviceCount; }
            set { this._failedImportedDeviceCount = value; }
        }

        // Check to see if FailedImportedDeviceCount property is set
        internal bool IsSetFailedImportedDeviceCount()
        {
            return this._failedImportedDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the wireless device import task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InitializedImportedDeviceCount. 
        /// <para>
        /// The summary information of count of wireless devices that are waiting for the control
        /// log to be added to an import task.
        /// </para>
        /// </summary>
        public long? InitializedImportedDeviceCount
        {
            get { return this._initializedImportedDeviceCount; }
            set { this._initializedImportedDeviceCount = value; }
        }

        // Check to see if InitializedImportedDeviceCount property is set
        internal bool IsSetInitializedImportedDeviceCount()
        {
            return this._initializedImportedDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnboardedImportedDeviceCount. 
        /// <para>
        /// The summary information of count of wireless devices in an import task that have been
        /// onboarded to the import task.
        /// </para>
        /// </summary>
        public long? OnboardedImportedDeviceCount
        {
            get { return this._onboardedImportedDeviceCount; }
            set { this._onboardedImportedDeviceCount = value; }
        }

        // Check to see if OnboardedImportedDeviceCount property is set
        internal bool IsSetOnboardedImportedDeviceCount()
        {
            return this._onboardedImportedDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingImportedDeviceCount. 
        /// <para>
        /// The summary information of count of wireless devices in an import task that are waiting
        /// in the queue to be onboarded.
        /// </para>
        /// </summary>
        public long? PendingImportedDeviceCount
        {
            get { return this._pendingImportedDeviceCount; }
            set { this._pendingImportedDeviceCount = value; }
        }

        // Check to see if PendingImportedDeviceCount property is set
        internal bool IsSetPendingImportedDeviceCount()
        {
            return this._pendingImportedDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk-related information of the wireless device import task.
        /// </para>
        /// </summary>
        public SidewalkGetStartImportInfo Sidewalk
        {
            get { return this._sidewalk; }
            set { this._sidewalk = value; }
        }

        // Check to see if Sidewalk property is set
        internal bool IsSetSidewalk()
        {
            return this._sidewalk != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status information of the wireless device import task.
        /// </para>
        /// </summary>
        public ImportTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that provides additional information about the import task status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}