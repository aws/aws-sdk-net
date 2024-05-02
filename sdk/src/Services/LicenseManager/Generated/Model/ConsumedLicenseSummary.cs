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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details about license consumption.
    /// </summary>
    public partial class ConsumedLicenseSummary
    {
        private long? _consumedLicenses;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ConsumedLicenses. 
        /// <para>
        /// Number of licenses consumed by the resource.
        /// </para>
        /// </summary>
        public long? ConsumedLicenses
        {
            get { return this._consumedLicenses; }
            set { this._consumedLicenses = value; }
        }

        // Check to see if ConsumedLicenses property is set
        internal bool IsSetConsumedLicenses()
        {
            return this._consumedLicenses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type of the resource consuming a license.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}