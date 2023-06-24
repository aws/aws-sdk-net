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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The automatically created recovery point of a namespace. Recovery points are created
    /// every 30 minutes and kept for 24 hours.
    /// </summary>
    public partial class RecoveryPoint
    {
        private string _namespaceArn;
        private string _namespaceName;
        private DateTime? _recoveryPointCreateTime;
        private string _recoveryPointId;
        private double? _totalSizeInMegaBytes;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the namespace the recovery point is associated with.
        /// </para>
        /// </summary>
        public string NamespaceArn
        {
            get { return this._namespaceArn; }
            set { this._namespaceArn = value; }
        }

        // Check to see if NamespaceArn property is set
        internal bool IsSetNamespaceArn()
        {
            return this._namespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace the recovery point is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointCreateTime. 
        /// <para>
        /// The time the recovery point is created.
        /// </para>
        /// </summary>
        public DateTime RecoveryPointCreateTime
        {
            get { return this._recoveryPointCreateTime.GetValueOrDefault(); }
            set { this._recoveryPointCreateTime = value; }
        }

        // Check to see if RecoveryPointCreateTime property is set
        internal bool IsSetRecoveryPointCreateTime()
        {
            return this._recoveryPointCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointId. 
        /// <para>
        /// The unique identifier of the recovery point.
        /// </para>
        /// </summary>
        public string RecoveryPointId
        {
            get { return this._recoveryPointId; }
            set { this._recoveryPointId = value; }
        }

        // Check to see if RecoveryPointId property is set
        internal bool IsSetRecoveryPointId()
        {
            return this._recoveryPointId != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSizeInMegaBytes. 
        /// <para>
        /// The total size of the data in the recovery point in megabytes.
        /// </para>
        /// </summary>
        public double TotalSizeInMegaBytes
        {
            get { return this._totalSizeInMegaBytes.GetValueOrDefault(); }
            set { this._totalSizeInMegaBytes = value; }
        }

        // Check to see if TotalSizeInMegaBytes property is set
        internal bool IsSetTotalSizeInMegaBytes()
        {
            return this._totalSizeInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup the recovery point is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}