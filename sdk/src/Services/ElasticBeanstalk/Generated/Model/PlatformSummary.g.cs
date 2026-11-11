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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property OperatingSystemName. 
        /// <para>
        /// The operating system used by the platform version.
        /// </para>
        /// </summary>
        public string OperatingSystemName { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystemName property is set.
        /// </summary>
        internal bool IsSetOperatingSystemName() => this.OperatingSystemName != null;

        /// <summary>
        /// Gets and sets the property OperatingSystemVersion. 
        /// <para>
        /// The version of the operating system used by the platform version.
        /// </para>
        /// </summary>
        public string OperatingSystemVersion { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystemVersion property is set.
        /// </summary>
        internal bool IsSetOperatingSystemVersion() => this.OperatingSystemVersion != null;

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the platform version.
        /// </para>
        /// </summary>
        public string PlatformArn { get; set; }

        /// <summary>
        /// Checks to see if the PlatformArn property is set.
        /// </summary>
        internal bool IsSetPlatformArn() => this.PlatformArn != null;

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
        public string PlatformBranchLifecycleState { get; set; }

        /// <summary>
        /// Checks to see if the PlatformBranchLifecycleState property is set.
        /// </summary>
        internal bool IsSetPlatformBranchLifecycleState() => this.PlatformBranchLifecycleState != null;

        /// <summary>
        /// Gets and sets the property PlatformBranchName. 
        /// <para>
        /// The platform branch to which the platform version belongs.
        /// </para>
        /// </summary>
        public string PlatformBranchName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformBranchName property is set.
        /// </summary>
        internal bool IsSetPlatformBranchName() => this.PlatformBranchName != null;

        /// <summary>
        /// Gets and sets the property PlatformCategory. 
        /// <para>
        /// The category of platform version.
        /// </para>
        /// </summary>
        public string PlatformCategory { get; set; }

        /// <summary>
        /// Checks to see if the PlatformCategory property is set.
        /// </summary>
        internal bool IsSetPlatformCategory() => this.PlatformCategory != null;

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
        public string PlatformLifecycleState { get; set; }

        /// <summary>
        /// Checks to see if the PlatformLifecycleState property is set.
        /// </summary>
        internal bool IsSetPlatformLifecycleState() => this.PlatformLifecycleState != null;

        /// <summary>
        /// Gets and sets the property PlatformOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the person who created the platform version.
        /// </para>
        /// </summary>
        public string PlatformOwner { get; set; }

        /// <summary>
        /// Checks to see if the PlatformOwner property is set.
        /// </summary>
        internal bool IsSetPlatformOwner() => this.PlatformOwner != null;

        /// <summary>
        /// Gets and sets the property PlatformStatus. 
        /// <para>
        /// The status of the platform version. You can create an environment from the platform
        /// version once it is ready.
        /// </para>
        /// </summary>
        public PlatformStatus PlatformStatus { get; set; }

        /// <summary>
        /// Checks to see if the PlatformStatus property is set.
        /// </summary>
        internal bool IsSetPlatformStatus() => this.PlatformStatus != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The version string of the platform version.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property SupportedAddonList. 
        /// <para>
        /// The additions associated with the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedAddonList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedAddonList property is set.
        /// </summary>
        internal bool IsSetSupportedAddonList() => this.SupportedAddonList != null && (this.SupportedAddonList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedTierList. 
        /// <para>
        /// The tiers in which the platform version runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedTierList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedTierList property is set.
        /// </summary>
        internal bool IsSetSupportedTierList() => this.SupportedTierList != null && (this.SupportedTierList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
