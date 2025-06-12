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
    /// Summary information about a platform version.
    /// </summary>
    public partial class PlatformSummary
    {
        private string _operatingSystemName;
        private string _operatingSystemVersion;
        private string _platformArn;
        private string _platformBranchLifecycleState;
        private string _platformBranchName;
        private string _platformCategory;
        private string _platformLifecycleState;
        private string _platformOwner;
        private PlatformStatus _platformStatus;
        private string _platformVersion;
        private List<string> _supportedAddonList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedTierList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property OperatingSystemName. 
        /// <para>
        /// The operating system used by the platform version.
        /// </para>
        /// </summary>
        public string OperatingSystemName
        {
            get { return this._operatingSystemName; }
            set { this._operatingSystemName = value; }
        }

        // Check to see if OperatingSystemName property is set
        internal bool IsSetOperatingSystemName()
        {
            return this._operatingSystemName != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystemVersion. 
        /// <para>
        /// The version of the operating system used by the platform version.
        /// </para>
        /// </summary>
        public string OperatingSystemVersion
        {
            get { return this._operatingSystemVersion; }
            set { this._operatingSystemVersion = value; }
        }

        // Check to see if OperatingSystemVersion property is set
        internal bool IsSetOperatingSystemVersion()
        {
            return this._operatingSystemVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the platform version.
        /// </para>
        /// </summary>
        public string PlatformArn
        {
            get { return this._platformArn; }
            set { this._platformArn = value; }
        }

        // Check to see if PlatformArn property is set
        internal bool IsSetPlatformArn()
        {
            return this._platformArn != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformBranchLifecycleState. 
        /// <para>
        /// The state of the platform version's branch in its lifecycle.
        /// </para>
        ///  
        /// <para>
        /// Possible values: <c>beta</c> | <c>supported</c> | <c>deprecated</c> | <c>retired</c>
        /// 
        /// </para>
        /// </summary>
        public string PlatformBranchLifecycleState
        {
            get { return this._platformBranchLifecycleState; }
            set { this._platformBranchLifecycleState = value; }
        }

        // Check to see if PlatformBranchLifecycleState property is set
        internal bool IsSetPlatformBranchLifecycleState()
        {
            return this._platformBranchLifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformBranchName. 
        /// <para>
        /// The platform branch to which the platform version belongs.
        /// </para>
        /// </summary>
        public string PlatformBranchName
        {
            get { return this._platformBranchName; }
            set { this._platformBranchName = value; }
        }

        // Check to see if PlatformBranchName property is set
        internal bool IsSetPlatformBranchName()
        {
            return this._platformBranchName != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformCategory. 
        /// <para>
        /// The category of platform version.
        /// </para>
        /// </summary>
        public string PlatformCategory
        {
            get { return this._platformCategory; }
            set { this._platformCategory = value; }
        }

        // Check to see if PlatformCategory property is set
        internal bool IsSetPlatformCategory()
        {
            return this._platformCategory != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformLifecycleState. 
        /// <para>
        /// The state of the platform version in its lifecycle.
        /// </para>
        ///  
        /// <para>
        /// Possible values: <c>recommended</c> | empty
        /// </para>
        ///  
        /// <para>
        /// If an empty value is returned, the platform version is supported but isn't the recommended
        /// one for its branch.
        /// </para>
        /// </summary>
        public string PlatformLifecycleState
        {
            get { return this._platformLifecycleState; }
            set { this._platformLifecycleState = value; }
        }

        // Check to see if PlatformLifecycleState property is set
        internal bool IsSetPlatformLifecycleState()
        {
            return this._platformLifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformOwner. 
        /// <para>
        /// The AWS account ID of the person who created the platform version.
        /// </para>
        /// </summary>
        public string PlatformOwner
        {
            get { return this._platformOwner; }
            set { this._platformOwner = value; }
        }

        // Check to see if PlatformOwner property is set
        internal bool IsSetPlatformOwner()
        {
            return this._platformOwner != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformStatus. 
        /// <para>
        /// The status of the platform version. You can create an environment from the platform
        /// version once it is ready.
        /// </para>
        /// </summary>
        public PlatformStatus PlatformStatus
        {
            get { return this._platformStatus; }
            set { this._platformStatus = value; }
        }

        // Check to see if PlatformStatus property is set
        internal bool IsSetPlatformStatus()
        {
            return this._platformStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The version string of the platform version.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedAddonList. 
        /// <para>
        /// The additions associated with the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedAddonList
        {
            get { return this._supportedAddonList; }
            set { this._supportedAddonList = value; }
        }

        // Check to see if SupportedAddonList property is set
        internal bool IsSetSupportedAddonList()
        {
            return this._supportedAddonList != null && (this._supportedAddonList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedTierList. 
        /// <para>
        /// The tiers in which the platform version runs.
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