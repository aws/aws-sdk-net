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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Specifies which resource types Config records for configuration changes. By default,
    /// Config records configuration changes for all current and future supported resource
    /// types in the Amazon Web Services Region where you have enabled Config, excluding the
    /// global IAM resource types: IAM users, groups, roles, and customer managed policies.
    /// 
    ///  
    /// <para>
    /// In the recording group, you specify whether you want to record all supported current
    /// and future supported resource types or to include or exclude specific resources types.
    /// For a list of supported resource types, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// Resource Types</a> in the <i>Config developer guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you don't want Config to record all current and future supported resource types
    /// (excluding the global IAM resource types), use one of the following recording strategies:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    ///  <b>Record all current and future resource types with exclusions</b> (<code>EXCLUSION_BY_RESOURCE_TYPES</code>),
    /// or
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Record specific resource types</b> (<code>INCLUSION_BY_RESOURCE_TYPES</code>).
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you use the recording strategy to <b>Record all current and future resource types</b>
    /// (<code>ALL_SUPPORTED_RESOURCE_TYPES</code>), you can use the flag <code>includeGlobalResourceTypes</code>
    /// to include the global IAM resource types in your recording.
    /// </para>
    ///  <important> 
    /// <para>
    ///  <b>Aurora global clusters are recorded in all enabled Regions</b> 
    /// </para>
    ///  
    /// <para>
    /// The <code>AWS::RDS::GlobalCluster</code> resource type will be recorded in all supported
    /// Config Regions where the configuration recorder is enabled.
    /// </para>
    ///  
    /// <para>
    /// If you do not want to record <code>AWS::RDS::GlobalCluster</code> in all enabled Regions,
    /// use the <code>EXCLUSION_BY_RESOURCE_TYPES</code> or <code>INCLUSION_BY_RESOURCE_TYPES</code>
    /// recording strategy.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class RecordingGroup
    {
        private bool? _allSupported;
        private ExclusionByResourceTypes _exclusionByResourceTypes;
        private bool? _includeGlobalResourceTypes;
        private RecordingStrategy _recordingStrategy;
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property AllSupported. 
        /// <para>
        /// Specifies whether Config records configuration changes for all supported resource
        /// types, excluding the global IAM resource types.
        /// </para>
        ///  
        /// <para>
        /// If you set this field to <code>true</code>, when Config adds support for a new resource
        /// type, Config starts recording resources of that type automatically.
        /// </para>
        ///  
        /// <para>
        /// If you set this field to <code>true</code>, you cannot enumerate specific resource
        /// types to record in the <code>resourceTypes</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>,
        /// or to exclude in the <code>resourceTypes</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ExclusionByResourceTypes.html">ExclusionByResourceTypes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Region availability</b> 
        /// </para>
        ///  
        /// <para>
        /// Check <a href="https://docs.aws.amazon.com/config/latest/developerguide/what-is-resource-config-coverage.html">Resource
        /// Coverage by Region Availability</a> to see if a resource type is supported in the
        /// Amazon Web Services Region where you set up Config.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ExclusionByResourceTypes. 
        /// <para>
        /// An object that specifies how Config excludes resource types from being recorded by
        /// the configuration recorder.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Required fields</b> 
        /// </para>
        ///  
        /// <para>
        /// To use this option, you must set the <code>useOnly</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
        /// to <code>EXCLUSION_BY_RESOURCE_TYPES</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public ExclusionByResourceTypes ExclusionByResourceTypes
        {
            get { return this._exclusionByResourceTypes; }
            set { this._exclusionByResourceTypes = value; }
        }

        // Check to see if ExclusionByResourceTypes property is set
        internal bool IsSetExclusionByResourceTypes()
        {
            return this._exclusionByResourceTypes != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeGlobalResourceTypes. 
        /// <para>
        /// This option is a bundle which only applies to the global IAM resource types: IAM users,
        /// groups, roles, and customer managed policies. These global IAM resource types can
        /// only be recorded by Config in Regions where Config was available before February 2022.
        /// You cannot be record the global IAM resouce types in Regions supported by Config after
        /// February 2022. This list where you cannot record the global IAM resource types includes
        /// the following Regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Asia Pacific (Hyderabad)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Melbourne)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Spain)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Zurich)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Israel (Tel Aviv)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Middle East (UAE)
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  <b>Aurora global clusters are recorded in all enabled Regions</b> 
        /// </para>
        ///  
        /// <para>
        /// The <code>AWS::RDS::GlobalCluster</code> resource type will be recorded in all supported
        /// Config Regions where the configuration recorder is enabled, even if <code>includeGlobalResourceTypes</code>
        /// is not set to <code>true</code>. The <code>includeGlobalResourceTypes</code> option
        /// is a bundle which only applies to IAM users, groups, roles, and customer managed policies.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you do not want to record <code>AWS::RDS::GlobalCluster</code> in all enabled Regions,
        /// use one of the following recording strategies:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <b>Record all current and future resource types with exclusions</b> (<code>EXCLUSION_BY_RESOURCE_TYPES</code>),
        /// or
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Record specific resource types</b> (<code>INCLUSION_BY_RESOURCE_TYPES</code>).
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/select-resources.html#select-resources-all">Selecting
        /// Which Resources are Recorded</a> in the <i>Config developer guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Before you set this field to <code>true</code>, set the <code>allSupported</code>
        /// field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
        /// to <code>true</code>. Optionally, you can set the <code>useOnly</code> field of <a
        /// href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
        /// to <code>ALL_SUPPORTED_RESOURCE_TYPES</code>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Overriding fields</b> 
        /// </para>
        ///  
        /// <para>
        /// If you set this field to <code>false</code> but list global IAM resource types in
        /// the <code>resourceTypes</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>,
        /// Config will still record configuration changes for those specified resource types
        /// <i>regardless</i> of if you set the <code>includeGlobalResourceTypes</code> field
        /// to false.
        /// </para>
        ///  
        /// <para>
        /// If you do not want to record configuration changes to the global IAM resource types
        /// (IAM users, groups, roles, and customer managed policies), make sure to not list them
        /// in the <code>resourceTypes</code> field in addition to setting the <code>includeGlobalResourceTypes</code>
        /// field to false.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property RecordingStrategy. 
        /// <para>
        /// An object that specifies the recording strategy for the configuration recorder.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you set the <code>useOnly</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
        /// to <code>ALL_SUPPORTED_RESOURCE_TYPES</code>, Config records configuration changes
        /// for all supported resource types, excluding the global IAM resource types. You also
        /// must set the <code>allSupported</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
        /// to <code>true</code>. When Config adds support for a new resource type, Config automatically
        /// starts recording resources of that type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set the <code>useOnly</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
        /// to <code>INCLUSION_BY_RESOURCE_TYPES</code>, Config records configuration changes
        /// for only the resource types you specify in the <code>resourceTypes</code> field of
        /// <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set the <code>useOnly</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
        /// to <code>EXCLUSION_BY_RESOURCE_TYPES</code>, Config records configuration changes
        /// for all supported resource types except the resource types that you specify to exclude
        /// from being recorded in the <code>resourceTypes</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ExclusionByResourceTypes.html">ExclusionByResourceTypes</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <b>Required and optional fields</b> 
        /// </para>
        ///  
        /// <para>
        /// The <code>recordingStrategy</code> field is optional when you set the <code>allSupported</code>
        /// field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
        /// to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>recordingStrategy</code> field is optional when you list resource types
        /// in the <code>resourceTypes</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// The <code>recordingStrategy</code> field is required if you list resource types to
        /// exclude from recording in the <code>resourceTypes</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ExclusionByResourceTypes.html">ExclusionByResourceTypes</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Overriding fields</b> 
        /// </para>
        ///  
        /// <para>
        /// If you choose <code>EXCLUSION_BY_RESOURCE_TYPES</code> for the recording strategy,
        /// the <code>exclusionByResourceTypes</code> field will override other properties in
        /// the request.
        /// </para>
        ///  
        /// <para>
        /// For example, even if you set <code>includeGlobalResourceTypes</code> to false, global
        /// IAM resource types will still be automatically recorded in this option unless those
        /// resource types are specifically listed as exclusions in the <code>resourceTypes</code>
        /// field of <code>exclusionByResourceTypes</code>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Global resources types and the resource exclusion recording strategy</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, if you choose the <code>EXCLUSION_BY_RESOURCE_TYPES</code> recording strategy,
        /// when Config adds support for a new resource type in the Region where you set up the
        /// configuration recorder, including global resource types, Config starts recording resources
        /// of that type automatically.
        /// </para>
        ///  
        /// <para>
        /// Unless specifically listed as exclusions, <code>AWS::RDS::GlobalCluster</code> will
        /// be recorded automatically in all supported Config Regions were the configuration recorder
        /// is enabled.
        /// </para>
        ///  
        /// <para>
        /// IAM users, groups, roles, and customer managed policies will be recorded in the Region
        /// where you set up the configuration recorder if that is a Region where Config was available
        /// before February 2022. You cannot be record the global IAM resouce types in Regions
        /// supported by Config after February 2022. This list where you cannot record the global
        /// IAM resource types includes the following Regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Asia Pacific (Hyderabad)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Melbourne)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Spain)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Zurich)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Israel (Tel Aviv)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Middle East (UAE)
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public RecordingStrategy RecordingStrategy
        {
            get { return this._recordingStrategy; }
            set { this._recordingStrategy = value; }
        }

        // Check to see if RecordingStrategy property is set
        internal bool IsSetRecordingStrategy()
        {
            return this._recordingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A comma-separated list that specifies which resource types Config records.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid <code>resourceTypes</code> values, see the <b>Resource Type Value</b>
        /// column in <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
        /// Amazon Web Services resource Types</a> in the <i>Config developer guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Required and optional fields</b> 
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can set the <code>useOnly</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
        /// to <code>INCLUSION_BY_RESOURCE_TYPES</code>.
        /// </para>
        ///  
        /// <para>
        /// To record all configuration changes, set the <code>allSupported</code> field of <a
        /// href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
        /// to <code>true</code>, and either omit this field or don't specify any resource types
        /// in this field. If you set the <code>allSupported</code> field to <code>false</code>
        /// and specify values for <code>resourceTypes</code>, when Config adds support for a
        /// new type of resource, it will not record resources of that type unless you manually
        /// add that type to your recording group.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Region availability</b> 
        /// </para>
        ///  
        /// <para>
        /// Before specifying a resource type for Config to track, check <a href="https://docs.aws.amazon.com/config/latest/developerguide/what-is-resource-config-coverage.html">Resource
        /// Coverage by Region Availability</a> to see if the resource type is supported in the
        /// Amazon Web Services Region where you set up Config. If a resource type is supported
        /// by Config in at least one Region, you can enable the recording of that resource type
        /// in all Regions supported by Config, even if the specified resource type is not supported
        /// in the Amazon Web Services Region where you set up Config.
        /// </para>
        ///  </note>
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