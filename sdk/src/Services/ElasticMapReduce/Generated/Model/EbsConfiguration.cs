/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The Amazon EBS configuration of a cluster instance.
    /// </summary>
    public partial class EbsConfiguration
    {
        private List<EbsBlockDeviceConfig> _ebsBlockDeviceConfigs = new List<EbsBlockDeviceConfig>();
        private bool? _ebsOptimized;

        /// <summary>
        /// Gets and sets the property EbsBlockDeviceConfigs. 
        /// <para>
        /// An array of Amazon EBS volume specifications attached to a cluster instance.
        /// </para>
        /// </summary>
        public List<EbsBlockDeviceConfig> EbsBlockDeviceConfigs
        {
            get { return this._ebsBlockDeviceConfigs; }
            set { this._ebsBlockDeviceConfigs = value; }
        }

        // Check to see if EbsBlockDeviceConfigs property is set
        internal bool IsSetEbsBlockDeviceConfigs()
        {
            return this._ebsBlockDeviceConfigs != null && this._ebsBlockDeviceConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether an Amazon EBS volume is EBS-optimized.
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

    }
}