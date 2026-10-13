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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Used to configure quotas that define how much storage a user or group can use on an
    /// FSx for OpenZFS volume. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/managing-volumes.html#volume-properties">Volume
    /// properties</a> in the FSx for OpenZFS User Guide.
    /// </summary>
    public partial class OpenZFSUserOrGroupQuota
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the user or group that the quota applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCapacityQuotaGiB. 
        /// <para>
        /// The user or group's storage quota, in gibibytes (GiB).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? StorageCapacityQuotaGiB { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacityQuotaGiB property is set.
        /// </summary>
        internal bool IsSetStorageCapacityQuotaGiB() => this.StorageCapacityQuotaGiB.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies whether the quota applies to a user or group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpenZFSQuotaType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
