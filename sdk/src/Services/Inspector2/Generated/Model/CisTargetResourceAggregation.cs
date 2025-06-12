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
    /// The CIS target resource aggregation.
    /// </summary>
    public partial class CisTargetResourceAggregation
    {
        private string _accountId;
        private string _platform;
        private string _scanArn;
        private StatusCounts _statusCounts;
        private string _targetResourceId;
        private Dictionary<string, List<string>> _targetResourceTags = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private CisTargetStatus _targetStatus;
        private CisTargetStatusReason _targetStatusReason;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for the CIS target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform for the CIS target resource.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The scan ARN for the CIS target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanArn
        {
            get { return this._scanArn; }
            set { this._scanArn = value; }
        }

        // Check to see if ScanArn property is set
        internal bool IsSetScanArn()
        {
            return this._scanArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCounts. 
        /// <para>
        /// The target resource status counts.
        /// </para>
        /// </summary>
        public StatusCounts StatusCounts
        {
            get { return this._statusCounts; }
            set { this._statusCounts = value; }
        }

        // Check to see if StatusCounts property is set
        internal bool IsSetStatusCounts()
        {
            return this._statusCounts != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceId. 
        /// <para>
        /// The ID of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=341)]
        public string TargetResourceId
        {
            get { return this._targetResourceId; }
            set { this._targetResourceId = value; }
        }

        // Check to see if TargetResourceId property is set
        internal bool IsSetTargetResourceId()
        {
            return this._targetResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceTags. 
        /// <para>
        /// The tag for the target resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, List<string>> TargetResourceTags
        {
            get { return this._targetResourceTags; }
            set { this._targetResourceTags = value; }
        }

        // Check to see if TargetResourceTags property is set
        internal bool IsSetTargetResourceTags()
        {
            return this._targetResourceTags != null && (this._targetResourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetStatus. 
        /// <para>
        /// The status of the target resource.
        /// </para>
        /// </summary>
        public CisTargetStatus TargetStatus
        {
            get { return this._targetStatus; }
            set { this._targetStatus = value; }
        }

        // Check to see if TargetStatus property is set
        internal bool IsSetTargetStatus()
        {
            return this._targetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TargetStatusReason. 
        /// <para>
        /// The reason for the target resource.
        /// </para>
        /// </summary>
        public CisTargetStatusReason TargetStatusReason
        {
            get { return this._targetStatusReason; }
            set { this._targetStatusReason = value; }
        }

        // Check to see if TargetStatusReason property is set
        internal bool IsSetTargetStatusReason()
        {
            return this._targetStatusReason != null;
        }

    }
}