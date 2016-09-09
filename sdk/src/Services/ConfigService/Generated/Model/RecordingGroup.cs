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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Specifies the types of AWS resource for which AWS Config records configuration changes.
    /// 
    ///  
    /// <para>
    /// In the recording group, you specify whether all supported types or specific types
    /// of resources are recorded.
    /// </para>
    ///  
    /// <para>
    /// By default, AWS Config records configuration changes for all supported types of regional
    /// resources that AWS Config discovers in the region in which it is running. Regional
    /// resources are tied to a region and can be used only in that region. Examples of regional
    /// resources are EC2 instances and EBS volumes.
    /// </para>
    ///  
    /// <para>
    /// You can also have AWS Config record configuration changes for supported types of global
    /// resources (for example, IAM resources). Global resources are not tied to an individual
    /// region and can be used in all regions.
    /// </para>
    ///  <important> 
    /// <para>
    /// The configuration details for any global resource are the same in all regions. If
    /// you customize AWS Config in multiple regions to record global resources, it will create
    /// multiple configuration items each time a global resource changes: one configuration
    /// item for each region. These configuration items will contain identical data. To prevent
    /// duplicate configuration items, you should consider customizing AWS Config in only
    /// one region to record global resources, unless you want the configuration items to
    /// be available in multiple regions.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you don't want AWS Config to record all resources, you can specify which types
    /// of resources it will record with the <code>resourceTypes</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// For a list of supported resource types, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// resource types</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/select-resources.html">Selecting
    /// Which Resources AWS Config Records</a>.
    /// </para>
    /// </summary>
    public partial class RecordingGroup
    {
        private bool? _allSupported;
        private bool? _includeGlobalResourceTypes;
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property AllSupported. 
        /// <para>
        /// Specifies whether AWS Config records configuration changes for every supported type
        /// of regional resource.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>true</code>, when AWS Config adds support for a new
        /// type of regional resource, it automatically starts recording resources of that type.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>true</code>, you cannot enumerate a list of <code>resourceTypes</code>.
        /// </para>
        /// </summary>
        public bool AllSupported
        {
            get { return this._allSupported.GetValueOrDefault(); }
            set { this._allSupported = value; }
        }

        // Check to see if AllSupported property is set
        internal bool IsSetAllSupported()
        {
            return this._allSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeGlobalResourceTypes. 
        /// <para>
        /// Specifies whether AWS Config includes all supported types of global resources (for
        /// example, IAM resources) with the resources that it records.
        /// </para>
        ///  
        /// <para>
        /// Before you can set this option to <code>true</code>, you must set the <code>allSupported</code>
        /// option to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>true</code>, when AWS Config adds support for a new
        /// type of global resource, it automatically starts recording resources of that type.
        /// </para>
        ///  
        /// <para>
        /// The configuration details for any global resource are the same in all regions. To
        /// prevent duplicate configuration items, you should consider customizing AWS Config
        /// in only one region to record global resources.
        /// </para>
        /// </summary>
        public bool IncludeGlobalResourceTypes
        {
            get { return this._includeGlobalResourceTypes.GetValueOrDefault(); }
            set { this._includeGlobalResourceTypes = value; }
        }

        // Check to see if IncludeGlobalResourceTypes property is set
        internal bool IsSetIncludeGlobalResourceTypes()
        {
            return this._includeGlobalResourceTypes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A comma-separated list that specifies the types of AWS resources for which AWS Config
        /// records configuration changes (for example, <code>AWS::EC2::Instance</code> or <code>AWS::CloudTrail::Trail</code>).
        /// </para>
        ///  
        /// <para>
        /// Before you can set this option to <code>true</code>, you must set the <code>allSupported</code>
        /// option to <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>true</code>, when AWS Config adds support for a new
        /// type of resource, it will not record resources of that type unless you manually add
        /// that type to your recording group.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid <code>resourceTypes</code> values, see the <b>resourceType Value</b>
        /// column in <a href="http://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
        /// AWS Resource Types</a>.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

    }
}