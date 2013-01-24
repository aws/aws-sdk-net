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
    /// Cancels a bundling operation for an instance store-backed Windows instance.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelBundleTaskRequest
    {    
        private string bundleIdField;

        /// <summary>
        /// The ID of the bundle task to cancel.
        /// </summary>
        [XmlElementAttribute(ElementName = "BundleId")]
        public string BundleId
        {
            get { return this.bundleIdField; }
            set { this.bundleIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the bundle task to cancel.
        /// </summary>
        /// <param name="bundleId">The ID of the bundle task to cancel.</param>
        /// <returns>this instance</returns>
        public CancelBundleTaskRequest WithBundleId(string bundleId)
        {
            this.bundleIdField = bundleId;
            return this;
        }

        /// <summary>
        /// Checks if BundleId property is set
        /// </summary>
        /// <returns>true if BundleId property is set</returns>
        public bool IsSetBundleId()
        {
            return this.bundleIdField != null;
        }

    }
}
