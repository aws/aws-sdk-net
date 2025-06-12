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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Summary information about a platform branch.
    /// </summary>
    public partial class PlatformBranchSummary
    {
        private string _branchName;
        private int? _branchOrder;
        private string _lifecycleState;
        private string _platformName;
        private List<string> _supportedTierList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the platform branch.
        /// </para>
        /// </summary>
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property BranchOrder. 
        /// <para>
        /// An ordinal number that designates the order in which platform branches have been added
        /// to a platform. This can be helpful, for example, if your code calls the <c>ListPlatformBranches</c>
        /// action and then displays a list of platform branches.
        /// </para>
        ///  
        /// <para>
        /// A larger <c>BranchOrder</c> value designates a newer platform branch within the platform.
        /// </para>
        /// </summary>
        public int? BranchOrder
        {
            get { return this._branchOrder; }
            set { this._branchOrder = value; }
        }

        // Check to see if BranchOrder property is set
        internal bool IsSetBranchOrder()
        {
            return this._branchOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The support life cycle state of the platform branch.
        /// </para>
        ///  
        /// <para>
        /// Possible values: <c>beta</c> | <c>supported</c> | <c>deprecated</c> | <c>retired</c>
        /// 
        /// </para>
        /// </summary>
        public string LifecycleState
        {
            get { return this._lifecycleState; }
            set { this._lifecycleState = value; }
        }

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this._lifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the platform to which this platform branch belongs.
        /// </para>
        /// </summary>
        public string PlatformName
        {
            get { return this._platformName; }
            set { this._platformName = value; }
        }

        // Check to see if PlatformName property is set
        internal bool IsSetPlatformName()
        {
            return this._platformName != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedTierList. 
        /// <para>
        /// The environment tiers that platform versions in this branch support.
        /// </para>
        ///  
        /// <para>
        /// Possible values: <c>WebServer/Standard</c> | <c>Worker/SQS/HTTP</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedTierList
        {
            get { return this._supportedTierList; }
            set { this._supportedTierList = value; }
        }

        // Check to see if SupportedTierList property is set
        internal bool IsSetSupportedTierList()
        {
            return this._supportedTierList != null && (this._supportedTierList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}