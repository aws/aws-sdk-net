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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The preference to control which resource type values are considered when generating
    /// rightsizing recommendations. You can specify this preference as a combination of include
    /// and exclude lists. You must specify either an <c>includeList</c> or <c>excludeList</c>.
    /// If the preference is an empty set of resource type values, an error occurs. For more
    /// information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/rightsizing-preferences.html">
    /// Rightsizing recommendation preferences</a> in the <i>Compute Optimizer User Guide</i>.
    /// 
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// This preference is only available for the Amazon EC2 instance and Auto Scaling group
    /// resource types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Compute Optimizer only supports the customization of <c>Ec2InstanceTypes</c>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class PreferredResource
    {
        private List<string> _excludeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PreferredResourceName _name;

        /// <summary>
        /// Gets and sets the property ExcludeList. 
        /// <para>
        ///  The preferred resource type values to exclude from the recommendation candidates.
        /// If this isn’t specified, all supported resources are included by default. You can
        /// specify up to 1000 values in this list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludeList
        {
            get { return this._excludeList; }
            set { this._excludeList = value; }
        }

        // Check to see if ExcludeList property is set
        internal bool IsSetExcludeList()
        {
            return this._excludeList != null && (this._excludeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeList. 
        /// <para>
        ///  The preferred resource type values to include in the recommendation candidates. You
        /// can specify the exact resource type value, such as m5.large, or use wild card expressions,
        /// such as m5. If this isn’t specified, all supported resources are included by default.
        /// You can specify up to 1000 values in this list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludeList
        {
            get { return this._includeList; }
            set { this._includeList = value; }
        }

        // Check to see if IncludeList property is set
        internal bool IsSetIncludeList()
        {
            return this._includeList != null && (this._includeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The type of preferred resource to customize. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Compute Optimizer only supports the customization of <c>Ec2InstanceTypes</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public PreferredResourceName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}