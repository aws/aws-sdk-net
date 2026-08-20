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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The local storage configuration for Amazon ECS Managed Instances.
    /// </summary>
    public partial class ManagedInstancesLocalStorageConfiguration
    {
        private bool? _useLocalStorage;

        /// <summary>
        /// Gets and sets the property UseLocalStorage. 
        /// <para>
        /// Specifies whether instance store volumes (local NVMe SSDs) are available to containers.
        /// When enabled, containers can use the instance store for high-performance temporary
        /// storage.
        /// </para>
        /// </summary>
        public bool? UseLocalStorage
        {
            get { return this._useLocalStorage; }
            set { this._useLocalStorage = value; }
        }

        // Check to see if UseLocalStorage property is set
        internal bool IsSetUseLocalStorage()
        {
            return this._useLocalStorage.HasValue; 
        }

    }
}