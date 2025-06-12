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
    /// Detailed information about a platform version.
    /// </summary>
    public partial class PlatformDescription
    {
        private List<CustomAmi> _customAmiList = AWSConfigs.InitializeCollections ? new List<CustomAmi>() : null;
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private string _description;
        private List<PlatformFramework> _frameworks = AWSConfigs.InitializeCollections ? new List<PlatformFramework>() : null;
        private string _maintainer;
        private string _operatingSystemName;
        private string _operatingSystemVersion;
        private string _platformArn;
        private string _platformBranchLifecycleState;
        private string _platformBranchName;
        private string _platformCategory;
        private string _platformLifecycleState;
        private string _platformName;
        private string _platformOwner;
        private PlatformStatus _platformStatus;
        private string _platformVersion;
        private List<PlatformProgrammingLanguage> _programmingLanguages = AWSConfigs.InitializeCollections ? new List<PlatformProgrammingLanguage>() : null;
        private string _solutionStackName;
        private List<string> _supportedAddonList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedTierList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomAmiList. 
        /// <para>
        /// The custom AMIs supported by the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAmi> CustomAmiList
        {
            get { return this._customAmiList; }
            set { this._customAmiList = value; }
        }

        // Check to see if CustomAmiList property is set
        internal bool IsSetCustomAmiList()
        {
            return this._customAmiList != null && (this._customAmiList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the platform version was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date when the platform version was last updated.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated
        {
            get { return this._dateUpdated; }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the platform version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Frameworks. 
        /// <para>
        /// The frameworks supported by the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlatformFramework> Frameworks
        {
            get { return this._frameworks; }
            set { this._frameworks = value; }
        }

        // Check to see if Frameworks property is set
        internal bool IsSetFrameworks()
        {
            return this._frameworks != null && (this._frameworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Maintainer. 
        /// <para>
        /// Information about the maintainer of the platform version.
        /// </para>
        /// </summary>
        public string Maintainer
        {
            get { return this._maintainer; }
            set { this._maintainer = value; }
        }

        // Check to see if Maintainer property is set
        internal bool IsSetMaintainer()
        {
            return this._maintainer != null;
        }

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
        /// Possible values: <c>Beta</c> | <c>Supported</c> | <c>Deprecated</c> | <c>Retired</c>
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
        /// The category of the platform version.
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
        /// Possible values: <c>Recommended</c> | <c>null</c> 
        /// </para>
        ///  
        /// <para>
        /// If a null value is returned, the platform version isn't the recommended one for its
        /// branch. Each platform branch has a single recommended platform version, typically
        /// the most recent one.
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
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the platform version.
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
        /// The status of the platform version.
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
        /// The version of the platform version.
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
        /// Gets and sets the property ProgrammingLanguages. 
        /// <para>
        /// The programming languages supported by the platform version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlatformProgrammingLanguage> ProgrammingLanguages
        {
            get { return this._programmingLanguages; }
            set { this._programmingLanguages = value; }
        }

        // Check to see if ProgrammingLanguages property is set
        internal bool IsSetProgrammingLanguages()
        {
            return this._programmingLanguages != null && (this._programmingLanguages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of the solution stack used by the platform version.
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedAddonList. 
        /// <para>
        /// The additions supported by the platform version.
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
        /// The tiers supported by the platform version.
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