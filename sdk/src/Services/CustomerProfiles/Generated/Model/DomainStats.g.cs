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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Usage-specific statistics about the domain.
    /// </summary>
    public partial class DomainStats
    {
        /// <summary>
        /// Gets and sets the property MeteringProfileCount. 
        /// <para>
        /// The number of profiles that you are currently paying for in the domain. If you have
        /// more than 100 objects associated with a single profile, that profile counts as two
        /// profiles. If you have more than 200 objects, that profile counts as three, and so
        /// on.
        /// </para>
        /// </summary>
        public long? MeteringProfileCount { get; set; }

        /// <summary>
        /// Checks to see if the MeteringProfileCount property is set.
        /// </summary>
        internal bool IsSetMeteringProfileCount() => this.MeteringProfileCount.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectCount. 
        /// <para>
        /// The total number of objects in domain.
        /// </para>
        /// </summary>
        public long? ObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCount property is set.
        /// </summary>
        internal bool IsSetObjectCount() => this.ObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileCount. 
        /// <para>
        /// The total number of profiles currently in the domain.
        /// </para>
        /// </summary>
        public long? ProfileCount { get; set; }

        /// <summary>
        /// Checks to see if the ProfileCount property is set.
        /// </summary>
        internal bool IsSetProfileCount() => this.ProfileCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSize. 
        /// <para>
        /// The total size, in bytes, of all objects in the domain.
        /// </para>
        /// </summary>
        public long? TotalSize { get; set; }

        /// <summary>
        /// Checks to see if the TotalSize property is set.
        /// </summary>
        internal bool IsSetTotalSize() => this.TotalSize.HasValue;
    }
}
