/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Detailed information about a platform.
    /// </summary>
    public partial class PlatformDescription
    {
        private List<CustomAmi> _customAmiList = new List<CustomAmi>();
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private string _description;
        private List<PlatformFramework> _frameworks = new List<PlatformFramework>();
        private string _maintainer;
        private string _operatingSystemName;
        private string _operatingSystemVersion;
        private string _platformArn;
        private string _platformCategory;
        private string _platformName;
        private string _platformOwner;
        private PlatformStatus _platformStatus;
        private string _platformVersion;
        private List<PlatformProgrammingLanguage> _programmingLanguages = new List<PlatformProgrammingLanguage>();
        private string _solutionStackName;
        private List<string> _supportedAddonList = new List<string>();
        private List<string> _supportedTierList = new List<string>();

        /// <summary>
        /// Gets and sets the property CustomAmiList. 
        /// <para>
        /// The custom AMIs supported by the platform.
        /// </para>
        /// </summary>
        public List<CustomAmi> CustomAmiList
        {
            get { return this._customAmiList; }
            set { this._customAmiList = value; }
        }

        // Check to see if CustomAmiList property is set
        internal bool IsSetCustomAmiList()
        {
            return this._customAmiList != null && this._customAmiList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the platform was created.
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
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
        /// The date when the platform was last updated.
        /// </para>
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this._dateUpdated.GetValueOrDefault(); }
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
        /// The description of the platform.
        /// </para>
        /// </summary>
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
        /// The frameworks supported by the platform.
        /// </para>
        /// </summary>
        public List<PlatformFramework> Frameworks
        {
            get { return this._frameworks; }
            set { this._frameworks = value; }
        }

        // Check to see if Frameworks property is set
        internal bool IsSetFrameworks()
        {
            return this._frameworks != null && this._frameworks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Maintainer. 
        /// <para>
        /// Information about the maintainer of the platform.
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
        /// The operating system used by the platform.
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
        /// The version of the operating system used by the platform.
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
        /// The ARN of the platform.
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
        /// Gets and sets the property PlatformCategory. 
        /// <para>
        /// The category of the platform.
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
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the platform.
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
        /// The AWS account ID of the person who created the platform.
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
        /// The status of the platform.
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
        /// The version of the platform.
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
        /// The programming languages supported by the platform.
        /// </para>
        /// </summary>
        public List<PlatformProgrammingLanguage> ProgrammingLanguages
        {
            get { return this._programmingLanguages; }
            set { this._programmingLanguages = value; }
        }

        // Check to see if ProgrammingLanguages property is set
        internal bool IsSetProgrammingLanguages()
        {
            return this._programmingLanguages != null && this._programmingLanguages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of the solution stack used by the platform.
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
        /// The additions supported by the platform.
        /// </para>
        /// </summary>
        public List<string> SupportedAddonList
        {
            get { return this._supportedAddonList; }
            set { this._supportedAddonList = value; }
        }

        // Check to see if SupportedAddonList property is set
        internal bool IsSetSupportedAddonList()
        {
            return this._supportedAddonList != null && this._supportedAddonList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedTierList. 
        /// <para>
        /// The tiers supported by the platform.
        /// </para>
        /// </summary>
        public List<string> SupportedTierList
        {
            get { return this._supportedTierList; }
            set { this._supportedTierList = value; }
        }

        // Check to see if SupportedTierList property is set
        internal bool IsSetSupportedTierList()
        {
            return this._supportedTierList != null && this._supportedTierList.Count > 0; 
        }

    }
}