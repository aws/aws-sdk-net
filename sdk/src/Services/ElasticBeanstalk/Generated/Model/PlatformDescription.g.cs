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
    /// Detailed information about a platform version.
    /// </summary>
    public partial class PlatformDescription
    {
        /// <summary>
        /// Gets and sets the property CustomAmiList. 
        /// <para>
        /// The AMIs of the platform version, by virtualization type. For Elastic Beanstalk managed
        /// platforms, these are the default <c>x86_64</c> AMIs; for custom platforms, the <c>hvm</c>
        /// entry is the AMI built for the platform version. To find a managed platform's default
        /// AMIs for every supported processor architecture, including <c>arm64</c>, use <c>DefaultAmiList</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAmi> CustomAmiList { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomAmi>() : null;

        /// <summary>
        /// Checks to see if the CustomAmiList property is set.
        /// </summary>
        internal bool IsSetCustomAmiList() => this.CustomAmiList != null && (this.CustomAmiList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the platform version was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date when the platform version was last updated.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultAmiList. 
        /// <para>
        /// The AMIs that Elastic Beanstalk uses by default for the platform version, one for
        /// each supported processor architecture. When an environment doesn't specify a custom
        /// AMI, Elastic Beanstalk chooses the default AMI that matches the environment's architecture.
        /// </para>
        ///  
        /// <para>
        /// This list isn't returned for custom platforms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DefaultAmi> DefaultAmiList { get; set; } = AWSConfigs.InitializeCollections ? new List<DefaultAmi>() : null;

        /// <summary>
        /// Checks to see if the DefaultAmiList property is set.
        /// </summary>
        internal bool IsSetDefaultAmiList() => this.DefaultAmiList != null && (this.DefaultAmiList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the platform version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Frameworks. 
        /// <para>
        /// The frameworks supported by the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlatformFramework> Frameworks { get; set; } = AWSConfigs.InitializeCollections ? new List<PlatformFramework>() : null;

        /// <summary>
        /// Checks to see if the Frameworks property is set.
        /// </summary>
        internal bool IsSetFrameworks() => this.Frameworks != null && (this.Frameworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Maintainer. 
        /// <para>
        /// Information about the maintainer of the platform version.
        /// </para>
        /// </summary>
        public string Maintainer { get; set; }

        /// <summary>
        /// Checks to see if the Maintainer property is set.
        /// </summary>
        internal bool IsSetMaintainer() => this.Maintainer != null;

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
        /// Possible values: <c>Beta</c> | <c>Supported</c> | <c>Deprecated</c> | <c>Retired</c>
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
        /// The category of the platform version.
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
        /// Possible values: <c>Recommended</c> | <c>null</c> 
        /// </para>
        ///  
        /// <para>
        /// If a null value is returned, the platform version isn't the recommended one for its
        /// branch. Each platform branch has a single recommended platform version, typically
        /// the most recent one.
        /// </para>
        /// </summary>
        public string PlatformLifecycleState { get; set; }

        /// <summary>
        /// Checks to see if the PlatformLifecycleState property is set.
        /// </summary>
        internal bool IsSetPlatformLifecycleState() => this.PlatformLifecycleState != null;

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the platform version.
        /// </para>
        /// </summary>
        public string PlatformName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformName property is set.
        /// </summary>
        internal bool IsSetPlatformName() => this.PlatformName != null;

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
        /// The status of the platform version.
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
        /// The version of the platform version.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property ProgrammingLanguages. 
        /// <para>
        /// The programming languages supported by the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlatformProgrammingLanguage> ProgrammingLanguages { get; set; } = AWSConfigs.InitializeCollections ? new List<PlatformProgrammingLanguage>() : null;

        /// <summary>
        /// Checks to see if the ProgrammingLanguages property is set.
        /// </summary>
        internal bool IsSetProgrammingLanguages() => this.ProgrammingLanguages != null && (this.ProgrammingLanguages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of the solution stack used by the platform version.
        /// </para>
        /// </summary>
        public string SolutionStackName { get; set; }

        /// <summary>
        /// Checks to see if the SolutionStackName property is set.
        /// </summary>
        internal bool IsSetSolutionStackName() => this.SolutionStackName != null;

        /// <summary>
        /// Gets and sets the property SupportedAddonList. 
        /// <para>
        /// The additions supported by the platform version.
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
        /// The tiers supported by the platform version.
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
