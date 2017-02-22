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
    public partial class PlatformSummary
    {
        private string _operatingSystemName;
        private string _operatingSystemVersion;
        private string _platformArn;
        private string _platformCategory;
        private string _platformOwner;
        private PlatformStatus _platformStatus;
        private List<string> _supportedAddonList = new List<string>();
        private List<string> _supportedTierList = new List<string>();

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
        /// The category of platform.
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
        /// The status of the platform. You can create an environment from the platform once it
        /// is ready.
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
        /// Gets and sets the property SupportedAddonList. 
        /// <para>
        /// The additions associated with the platform.
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
        /// The tiers in which the platform runs.
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