/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeVolumes</c> request.</para>
    /// </summary>
    public class DescribeVolumesResult
    {
        
        private List<Volume> volumes = new List<Volume>();

        /// <summary>
        /// An array of volume IDs.
        ///  
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this.volumes; }
            set { this.volumes = value; }
        }
        /// <summary>
        /// Adds elements to the Volumes collection
        /// </summary>
        /// <param name="volumes">The values to add to the Volumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesResult WithVolumes(params Volume[] volumes)
        {
            foreach (Volume element in volumes)
            {
                this.volumes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Volumes collection
        /// </summary>
        /// <param name="volumes">The values to add to the Volumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesResult WithVolumes(IEnumerable<Volume> volumes)
        {
            foreach (Volume element in volumes)
            {
                this.volumes.Add(element);
            }

            return this;
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this.volumes.Count > 0;
        }
    }
}
