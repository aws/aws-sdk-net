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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about a resource covered by Amazon Inspector.
    /// </summary>
    public partial class CoveredResource
    {
        private string _accountId;
        private DateTime? _lastScannedAt;
        private string _resourceId;
        private ResourceScanMetadata _resourceMetadata;
        private CoverageResourceType _resourceType;
        private ScanMode _scanMode;
        private ScanStatus _scanStatus;
        private ScanType _scanType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property LastScannedAt. 
        /// <para>
        /// The date and time the resource was last checked for vulnerabilities.
        /// </para>
        /// </summary>
        public DateTime? LastScannedAt
        {
            get { return this._lastScannedAt; }
            set { this._lastScannedAt = value; }
        }

        // Check to see if LastScannedAt property is set
        internal bool IsSetLastScannedAt()
        {
            return this._lastScannedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=341)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceMetadata. 
        /// <para>
        /// An object that contains details about the metadata.
        /// </para>
        /// </summary>
        public ResourceScanMetadata ResourceMetadata
        {
            get { return this._resourceMetadata; }
            set { this._resourceMetadata = value; }
        }

        // Check to see if ResourceMetadata property is set
        internal bool IsSetResourceMetadata()
        {
            return this._resourceMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CoverageResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The scan method that is applied to the instance.
        /// </para>
        /// </summary>
        public ScanMode ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null;
        }

        /// <summary>
        /// Gets and sets the property ScanStatus. 
        /// <para>
        /// The status of the scan covering the resource.
        /// </para>
        /// </summary>
        public ScanStatus ScanStatus
        {
            get { return this._scanStatus; }
            set { this._scanStatus = value; }
        }

        // Check to see if ScanStatus property is set
        internal bool IsSetScanStatus()
        {
            return this._scanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The Amazon Inspector scan type covering the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

    }
}