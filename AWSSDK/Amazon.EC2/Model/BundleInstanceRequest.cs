/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Bundles an Amazon instance store-backed Windows instance.
    /// This procedure is not applicable for Linux and UNIX instances.
    /// During bundling, only the root device volume (C:\) is bundled. Data on other instance store volumes is not preserved.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class BundleInstanceRequest : EC2Request
    {    
        private string instanceIdField;
        private Storage storageField;

        /// <summary>
        /// The ID of the instance to bundle.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance to bundle.
        /// </summary>
        /// <param name="instanceId">The ID of the instance to bundle.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BundleInstanceRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Storage configuration for the bundle
        /// </summary>
        [XmlElementAttribute(ElementName = "Storage")]
        public Storage Storage
        {
            get { return this.storageField; }
            set { this.storageField = value; }
        }

        /// <summary>
        /// Sets the storage configuration for the bundle
        /// </summary>
        /// <param name="storage">Storage</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BundleInstanceRequest WithStorage(Storage storage)
        {
            this.storageField = storage;
            return this;
        }

        /// <summary>
        /// Checks if Storage property is set
        /// </summary>
        /// <returns>true if Storage property is set</returns>
        public bool IsSetStorage()
        {
            return this.storageField != null;
        }

    }
}
