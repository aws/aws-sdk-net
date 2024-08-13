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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Usage-specific statistics about the domain.
    /// </summary>
    public partial class DomainStats
    {
        private long? _meteringProfileCount;
        private long? _objectCount;
        private long? _profileCount;
        private long? _totalSize;

        /// <summary>
        /// Gets and sets the property MeteringProfileCount. 
        /// <para>
        /// The number of profiles that you are currently paying for in the domain. If you have
        /// more than 100 objects associated with a single profile, that profile counts as two
        /// profiles. If you have more than 200 objects, that profile counts as three, and so
        /// on.
        /// </para>
        /// </summary>
        public long? MeteringProfileCount
        {
            get { return this._meteringProfileCount; }
            set { this._meteringProfileCount = value; }
        }

        // Check to see if MeteringProfileCount property is set
        internal bool IsSetMeteringProfileCount()
        {
            return this._meteringProfileCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectCount. 
        /// <para>
        /// The total number of objects in domain.
        /// </para>
        /// </summary>
        public long? ObjectCount
        {
            get { return this._objectCount; }
            set { this._objectCount = value; }
        }

        // Check to see if ObjectCount property is set
        internal bool IsSetObjectCount()
        {
            return this._objectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileCount. 
        /// <para>
        /// The total number of profiles currently in the domain.
        /// </para>
        /// </summary>
        public long? ProfileCount
        {
            get { return this._profileCount; }
            set { this._profileCount = value; }
        }

        // Check to see if ProfileCount property is set
        internal bool IsSetProfileCount()
        {
            return this._profileCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSize. 
        /// <para>
        /// The total size, in bytes, of all objects in the domain.
        /// </para>
        /// </summary>
        public long? TotalSize
        {
            get { return this._totalSize; }
            set { this._totalSize = value; }
        }

        // Check to see if TotalSize property is set
        internal bool IsSetTotalSize()
        {
            return this._totalSize.HasValue; 
        }

    }
}