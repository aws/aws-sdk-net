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
    /// Describes whether Malware Protection for EC2 instances with findings will be enabled
    /// as a data source.
    /// </summary>
    public partial class ScanEc2InstanceWithFindings
    {
        private bool? _ebsVolumes;

        /// <summary>
        /// Gets and sets the property EbsVolumes. 
        /// <para>
        /// Describes the configuration for scanning EBS volumes as data source.
        /// </para>
        /// </summary>
        public bool? EbsVolumes
        {
            get { return this._ebsVolumes; }
            set { this._ebsVolumes = value; }
        }

        // Check to see if EbsVolumes property is set
        internal bool IsSetEbsVolumes()
        {
            return this._ebsVolumes.HasValue; 
        }

    }
}