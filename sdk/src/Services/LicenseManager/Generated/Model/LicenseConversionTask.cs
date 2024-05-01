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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Information about a license type conversion task.
    /// </summary>
    public partial class LicenseConversionTask
    {
        private LicenseConversionContext _destinationLicenseContext;
        private DateTime? _endTime;
        private string _licenseConversionTaskId;
        private DateTime? _licenseConversionTime;
        private string _resourceArn;
        private LicenseConversionContext _sourceLicenseContext;
        private DateTime? _startTime;
        private LicenseConversionTaskStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property DestinationLicenseContext. 
        /// <para>
        /// Information about the license type this conversion task converted to.
        /// </para>
        /// </summary>
        public LicenseConversionContext DestinationLicenseContext
        {
            get { return this._destinationLicenseContext; }
            set { this._destinationLicenseContext = value; }
        }

        // Check to see if DestinationLicenseContext property is set
        internal bool IsSetDestinationLicenseContext()
        {
            return this._destinationLicenseContext != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the conversion task was completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseConversionTaskId. 
        /// <para>
        /// The ID of the license type conversion task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string LicenseConversionTaskId
        {
            get { return this._licenseConversionTaskId; }
            set { this._licenseConversionTaskId = value; }
        }

        // Check to see if LicenseConversionTaskId property is set
        internal bool IsSetLicenseConversionTaskId()
        {
            return this._licenseConversionTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConversionTime. 
        /// <para>
        /// The time the usage operation value of the resource was changed.
        /// </para>
        /// </summary>
        public DateTime? LicenseConversionTime
        {
            get { return this._licenseConversionTime; }
            set { this._licenseConversionTime = value; }
        }

        // Check to see if LicenseConversionTime property is set
        internal bool IsSetLicenseConversionTime()
        {
            return this._licenseConversionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource associated with the license type conversion
        /// task.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLicenseContext. 
        /// <para>
        /// Information about the license type this conversion task converted from.
        /// </para>
        /// </summary>
        public LicenseConversionContext SourceLicenseContext
        {
            get { return this._sourceLicenseContext; }
            set { this._sourceLicenseContext = value; }
        }

        // Check to see if SourceLicenseContext property is set
        internal bool IsSetSourceLicenseContext()
        {
            return this._sourceLicenseContext != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the conversion task was started at.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the conversion task.
        /// </para>
        /// </summary>
        public LicenseConversionTaskStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the conversion task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}