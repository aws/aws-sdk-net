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
    /// Describes the effective preferred resources that Compute Optimizer considers as rightsizing
    /// recommendation candidates. 
    /// 
    ///  <note> 
    /// <para>
    /// Compute Optimizer only supports Amazon EC2 instance types.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EffectivePreferredResource
    {
        private List<string> _effectiveIncludeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PreferredResourceName _name;

        /// <summary>
        /// Gets and sets the property EffectiveIncludeList. 
        /// <para>
        ///  The expanded version of your preferred resource's include list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EffectiveIncludeList
        {
            get { return this._effectiveIncludeList; }
            set { this._effectiveIncludeList = value; }
        }

        // Check to see if EffectiveIncludeList property is set
        internal bool IsSetEffectiveIncludeList()
        {
            return this._effectiveIncludeList != null && (this._effectiveIncludeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeList. 
        /// <para>
        ///  The list of preferred resources values that you want excluded from rightsizing recommendation
        /// candidates. 
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
        ///  The list of preferred resource values that you want considered as rightsizing recommendation
        /// candidates. 
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
        ///  The name of the preferred resource list. 
        /// </para>
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