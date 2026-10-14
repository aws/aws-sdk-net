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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Information about a license type conversion task.
    /// </summary>
    public partial class LicenseConversionTask
    {
        /// <summary>
        /// Gets and sets the property DestinationLicenseContext. 
        /// <para>
        /// Information about the license type this conversion task converted to.
        /// </para>
        /// </summary>
        public LicenseConversionContext DestinationLicenseContext { get; set; }

        /// <summary>
        /// Checks to see if the DestinationLicenseContext property is set.
        /// </summary>
        internal bool IsSetDestinationLicenseContext() => this.DestinationLicenseContext != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the conversion task was completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseConversionTaskId. 
        /// <para>
        /// The ID of the license type conversion task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string LicenseConversionTaskId { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConversionTaskId property is set.
        /// </summary>
        internal bool IsSetLicenseConversionTaskId() => this.LicenseConversionTaskId != null;

        /// <summary>
        /// Gets and sets the property LicenseConversionTime. 
        /// <para>
        /// The time the usage operation value of the resource was changed.
        /// </para>
        /// </summary>
        public DateTime? LicenseConversionTime { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConversionTime property is set.
        /// </summary>
        internal bool IsSetLicenseConversionTime() => this.LicenseConversionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource associated with the license type conversion
        /// task.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceLicenseContext. 
        /// <para>
        /// Information about the license type this conversion task converted from.
        /// </para>
        /// </summary>
        public LicenseConversionContext SourceLicenseContext { get; set; }

        /// <summary>
        /// Checks to see if the SourceLicenseContext property is set.
        /// </summary>
        internal bool IsSetSourceLicenseContext() => this.SourceLicenseContext != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the conversion task was started at.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the conversion task.
        /// </para>
        /// </summary>
        public LicenseConversionTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the conversion task.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
