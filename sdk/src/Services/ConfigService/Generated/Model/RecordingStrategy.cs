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
    /// Specifies the recording strategy of the configuration recorder.
    /// </summary>
    public partial class RecordingStrategy
    {
        private RecordingStrategyType _useOnly;

        /// <summary>
        /// Gets and sets the property UseOnly. 
        /// <para>
        /// The recording strategy for the configuration recorder.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you set this option to <c>ALL_SUPPORTED_RESOURCE_TYPES</c>, Config records configuration
        /// changes for all supported resource types, excluding the global IAM resource types.
        /// You also must set the <c>allSupported</c> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
        /// to <c>true</c>. When Config adds support for a new resource type, Config automatically
        /// starts recording resources of that type. For a list of supported resource types, see
        /// <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
        /// Resource Types</a> in the <i>Config developer guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set this option to <c>INCLUSION_BY_RESOURCE_TYPES</c>, Config records configuration
        /// changes for only the resource types that you specify in the <c>resourceTypes</c> field
        /// of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set this option to <c>EXCLUSION_BY_RESOURCE_TYPES</c>, Config records configuration
        /// changes for all supported resource types, except the resource types that you specify
        /// to exclude from being recorded in the <c>resourceTypes</c> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ExclusionByResourceTypes.html">ExclusionByResourceTypes</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <b>Required and optional fields</b> 
        /// </para>
        ///  
        /// <para>
        /// The <c>recordingStrategy</c> field is optional when you set the <c>allSupported</c>
        /// field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
        /// to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>recordingStrategy</c> field is optional when you list resource types in the
        /// <c>resourceTypes</c> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>recordingStrategy</c> field is required if you list resource types to exclude
        /// from recording in the <c>resourceTypes</c> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ExclusionByResourceTypes.html">ExclusionByResourceTypes</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Overriding fields</b> 
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>EXCLUSION_BY_RESOURCE_TYPES</c> for the recording strategy, the <c>exclusionByResourceTypes</c>
        /// field will override other properties in the request.
        /// </para>
        ///  
        /// <para>
        /// For example, even if you set <c>includeGlobalResourceTypes</c> to false, global IAM
        /// resource types will still be automatically recorded in this option unless those resource
        /// types are specifically listed as exclusions in the <c>resourceTypes</c> field of <c>exclusionByResourceTypes</c>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <b>Global resource types and the exclusion recording strategy</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, if you choose the <c>EXCLUSION_BY_RESOURCE_TYPES</c> recording strategy,
        /// when Config adds support for a new resource type in the Region where you set up the
        /// configuration recorder, including global resource types, Config starts recording resources
        /// of that type automatically.
        /// </para>
        ///  
        /// <para>
        /// Unless specifically listed as exclusions, <c>AWS::RDS::GlobalCluster</c> will be recorded
        /// automatically in all supported Config Regions were the configuration recorder is enabled.
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
        /// Canada West (Calgary)
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
        public RecordingStrategyType UseOnly
        {
            get { return this._useOnly; }
            set { this._useOnly = value; }
        }

        // Check to see if UseOnly property is set
        internal bool IsSetUseOnly()
        {
            return this._useOnly != null;
        }

    }
}