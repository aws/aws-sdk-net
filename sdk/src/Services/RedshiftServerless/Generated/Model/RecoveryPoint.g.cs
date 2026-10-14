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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The automatically created recovery point of a namespace. Recovery points are created
    /// every 30 minutes and kept for 24 hours.
    /// </summary>
    public partial class RecoveryPoint
    {
        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the namespace the recovery point is associated with.
        /// </para>
        /// </summary>
        public string NamespaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceArn property is set.
        /// </summary>
        internal bool IsSetNamespaceArn() => this.NamespaceArn != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace the recovery point is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointCreateTime. 
        /// <para>
        /// The time the recovery point is created.
        /// </para>
        /// </summary>
        public DateTime? RecoveryPointCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointCreateTime property is set.
        /// </summary>
        internal bool IsSetRecoveryPointCreateTime() => this.RecoveryPointCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RecoveryPointId. 
        /// <para>
        /// The unique identifier of the recovery point.
        /// </para>
        /// </summary>
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointId property is set.
        /// </summary>
        internal bool IsSetRecoveryPointId() => this.RecoveryPointId != null;

        /// <summary>
        /// Gets and sets the property TotalSizeInMegaBytes. 
        /// <para>
        /// The total size of the data in the recovery point in megabytes.
        /// </para>
        /// </summary>
        public double? TotalSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalSizeInMegaBytes() => this.TotalSizeInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup the recovery point is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}
