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
    /// Specifies which Amazon Web Services resource types Config records for configuration
    /// changes. In the recording group, you specify whether you want to record all supported
    /// resource types or only specific types of resources.
    /// 
    ///  
    /// <para>
    /// By default, Config records the configuration changes for all supported types of <i>regional
    /// resources</i> that Config discovers in the region in which it is running. Regional
    /// resources are tied to a region and can be used only in that region. Examples of regional
    /// resources are EC2 instances and EBS volumes.
    /// </para>
    ///  
    /// <para>
    /// You can also have Config record supported types of <i>global resources</i>. Global
    /// resources are not tied to a specific region and can be used in all regions. The global
    /// resource types that Config supports include IAM users, groups, roles, and customer
    /// managed policies.
    /// </para>
    ///  <important> 
    /// <para>
    /// Global resource types onboarded to Config recording after February 2022 will only
    /// be recorded in the service's home region for the commercial partition and Amazon Web
    /// Services GovCloud (US) West for the GovCloud partition. You can view the Configuration
    /// Items for these new global resource types only in their home region and Amazon Web
    /// Services GovCloud (US) West.
    /// </para>
    ///  
    /// <para>
    /// Supported global resource types onboarded before February 2022 such as <code>AWS::IAM::Group</code>,
    /// <code>AWS::IAM::Policy</code>, <code>AWS::IAM::Role</code>, <code>AWS::IAM::User</code>
    /// remain unchanged, and they will continue to deliver Configuration Items in all supported
    /// regions in Config. The change will only affect new global resource types onboarded
    /// after February 2022.
    /// </para>
    ///  
    /// <para>
    /// To record global resource types onboarded after February 2022, enable All Supported
    /// Resource Types in the home region of the global resource type you want to record.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you don't want Config to record all resources, you can specify which types of resources
    /// it will record with the <code>resourceTypes</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// For a list of supported resource types, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// Resource Types</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information and a table of the Home Regions for Global Resource Types Onboarded
    /// after February 2022, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/select-resources.html">Selecting
    /// Which Resources Config Records</a>.
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
        /// Specifies whether Config records configuration changes for every supported type of
        /// regional resource.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>true</code>, when Config adds support for a new type
        /// of regional resource, it starts recording resources of that type automatically.
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
        /// Specifies whether Config includes all supported types of global resources (for example,
        /// IAM resources) with the resources that it records.
        /// </para>
        ///  
        /// <para>
        /// Before you can set this option to <code>true</code>, you must set the <code>allSupported</code>
        /// option to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>true</code>, when Config adds support for a new type
        /// of global resource, it starts recording resources of that type automatically.
        /// </para>
        ///  
        /// <para>
        /// The configuration details for any global resource are the same in all regions. To
        /// prevent duplicate configuration items, you should consider customizing Config in only
        /// one region to record global resources.
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
        /// A comma-separated list that specifies the types of Amazon Web Services resources for
        /// which Config records configuration changes (for example, <code>AWS::EC2::Instance</code>
        /// or <code>AWS::CloudTrail::Trail</code>).
        /// </para>
        ///  
        /// <para>
        /// To record all configuration changes, you must set the <code>allSupported</code> option
        /// to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set this option to <code>false</code>, when Config adds support for a new type
        /// of resource, it will not record resources of that type unless you manually add that
        /// type to your recording group.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid <code>resourceTypes</code> values, see the <b>resourceType Value</b>
        /// column in <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
        /// Amazon Web Services resource Types</a>.
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