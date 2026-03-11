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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about a resource that was scanned as part of the malware scan
    /// operation.
    /// </summary>
    public partial class ScannedResource
    {
        private ScannedResourceDetails _resourceDetails;
        private string _scannedResourceArn;
        private MalwareProtectionScanStatus _scannedResourceStatus;
        private MalwareProtectionResourceType _scannedResourceType;
        private ScanStatusReason _scanStatusReason;

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Information about the scanned resource.
        /// </para>
        /// </summary>
        public ScannedResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ScannedResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the scanned resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ScannedResourceArn
        {
            get { return this._scannedResourceArn; }
            set { this._scannedResourceArn = value; }
        }

        // Check to see if ScannedResourceArn property is set
        internal bool IsSetScannedResourceArn()
        {
            return this._scannedResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScannedResourceStatus. 
        /// <para>
        /// The status of the scanned resource.
        /// </para>
        /// </summary>
        public MalwareProtectionScanStatus ScannedResourceStatus
        {
            get { return this._scannedResourceStatus; }
            set { this._scannedResourceStatus = value; }
        }

        // Check to see if ScannedResourceStatus property is set
        internal bool IsSetScannedResourceStatus()
        {
            return this._scannedResourceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ScannedResourceType. 
        /// <para>
        /// The resource type of the scanned resource.
        /// </para>
        /// </summary>
        public MalwareProtectionResourceType ScannedResourceType
        {
            get { return this._scannedResourceType; }
            set { this._scannedResourceType = value; }
        }

        // Check to see if ScannedResourceType property is set
        internal bool IsSetScannedResourceType()
        {
            return this._scannedResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ScanStatusReason. 
        /// <para>
        /// The reason for the scan status of this particular resource, if applicable.
        /// </para>
        /// </summary>
        public ScanStatusReason ScanStatusReason
        {
            get { return this._scanStatusReason; }
            set { this._scanStatusReason = value; }
        }

        // Check to see if ScanStatusReason property is set
        internal bool IsSetScanStatusReason()
        {
            return this._scanStatusReason != null;
        }

    }
}