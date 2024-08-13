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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The number of Amazon Web Services resources or Config rules responsible for the current
    /// compliance of the item, up to a maximum number.
    /// </summary>
    public partial class ComplianceContributorCount
    {
        private bool? _capExceeded;
        private int? _cappedCount;

        /// <summary>
        /// Gets and sets the property CapExceeded. 
        /// <para>
        /// Indicates whether the maximum count is reached.
        /// </para>
        /// </summary>
        public bool? CapExceeded
        {
            get { return this._capExceeded; }
            set { this._capExceeded = value; }
        }

        // Check to see if CapExceeded property is set
        internal bool IsSetCapExceeded()
        {
            return this._capExceeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CappedCount. 
        /// <para>
        /// The number of Amazon Web Services resources or Config rules responsible for the current
        /// compliance of the item.
        /// </para>
        /// </summary>
        public int? CappedCount
        {
            get { return this._cappedCount; }
            set { this._cappedCount = value; }
        }

        // Check to see if CappedCount property is set
        internal bool IsSetCappedCount()
        {
            return this._cappedCount.HasValue; 
        }

    }
}