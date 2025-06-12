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
    /// Specifies whether the configuration recorder excludes certain resource types from
    /// being recorded. Use the <c>resourceTypes</c> field to enter a comma-separated list
    /// of resource types you want to exclude from recording.
    /// 
    ///  
    /// <para>
    /// By default, when Config adds support for a new resource type in the Region where you
    /// set up the configuration recorder, including global resource types, Config starts
    /// recording resources of that type automatically.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>How to use the exclusion recording strategy </b> 
    /// </para>
    ///  
    /// <para>
    /// To use this option, you must set the <c>useOnly</c> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
    /// to <c>EXCLUSION_BY_RESOURCE_TYPES</c>.
    /// </para>
    ///  
    /// <para>
    /// Config will then record configuration changes for all supported resource types, except
    /// the resource types that you specify to exclude from being recorded.
    /// </para>
    ///  
    /// <para>
    ///  <b>Global resource types and the exclusion recording strategy </b> 
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
    /// supported by Config after February 2022. For a list of those Regions, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/select-resources.html#select-resources-all">Recording
    /// Amazon Web Services Resources | Global Resources</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ExclusionByResourceTypes
    {
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A comma-separated list of resource types to exclude from recording by the configuration
        /// recorder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}