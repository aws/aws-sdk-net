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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will stop returning <c>DisplayName</c>.
    /// Update your applications to use canonical IDs (unique identifier for Amazon Web Services
    /// accounts), Amazon Web Services account ID (12 digit identifier) or IAM ARNs (full
    /// resource naming) as a direct replacement of <c>DisplayName</c>. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> 
    /// <para>
    /// The owner of an S3 bucket.
    /// </para>
    /// </summary>
    public class Owner
    {
        /// <summary>
        /// <para>
        /// Container for the display name of the owner. This value is only supported in the following
        /// Amazon Web Services Regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string DisplayName { set; get; }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this.DisplayName != null;
        }

        /// <summary>
        /// The unique identifier of the owner.
        /// </summary>
        public string Id { get; set; }

        // Check to see if ID property is set
        internal bool IsSetId()
        {
            return this.Id != null;
        }
    }
}
