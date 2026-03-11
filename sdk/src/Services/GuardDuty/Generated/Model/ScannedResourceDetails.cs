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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains additional information about a resource that was scanned.
    /// </summary>
    public partial class ScannedResourceDetails
    {
        private EbsSnapshot _ebsSnapshot;
        private VolumeDetail _ebsVolume;

        /// <summary>
        /// Gets and sets the property EbsSnapshot. 
        /// <para>
        /// Contains information about the EBS snapshot that was scanned.
        /// </para>
        /// </summary>
        public EbsSnapshot EbsSnapshot
        {
            get { return this._ebsSnapshot; }
            set { this._ebsSnapshot = value; }
        }

        // Check to see if EbsSnapshot property is set
        internal bool IsSetEbsSnapshot()
        {
            return this._ebsSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property EbsVolume. 
        /// <para>
        /// Contains information about the EBS volume that was scanned.
        /// </para>
        /// </summary>
        public VolumeDetail EbsVolume
        {
            get { return this._ebsVolume; }
            set { this._ebsVolume = value; }
        }

        // Check to see if EbsVolume property is set
        internal bool IsSetEbsVolume()
        {
            return this._ebsVolume != null;
        }

    }
}