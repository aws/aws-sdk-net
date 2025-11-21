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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The storage configuration for Amazon ECS Managed Instances. This defines the root
    /// volume configuration for the instances.
    /// </summary>
    public partial class ManagedInstancesStorageConfiguration
    {
        private int? _storageSizeGiB;

        /// <summary>
        /// Gets and sets the property StorageSizeGiB. 
        /// <para>
        /// The size of the tasks volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? StorageSizeGiB
        {
            get { return this._storageSizeGiB; }
            set { this._storageSizeGiB = value; }
        }

        // Check to see if StorageSizeGiB property is set
        internal bool IsSetStorageSizeGiB()
        {
            return this._storageSizeGiB.HasValue; 
        }

    }
}