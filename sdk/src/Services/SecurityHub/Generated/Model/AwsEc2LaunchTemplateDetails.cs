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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the properties for creating an Amazon Elastic Compute Cloud (Amazon EC2)
    /// launch template.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDetails
    {
        private long? _defaultVersionNumber;
        private string _id;
        private long? _latestVersionNumber;
        private AwsEc2LaunchTemplateDataDetails _launchTemplateData;
        private string _launchTemplateName;

        /// <summary>
        /// Gets and sets the property DefaultVersionNumber. 
        /// <para>
        ///  The default version of the launch template. 
        /// </para>
        /// </summary>
        public long DefaultVersionNumber
        {
            get { return this._defaultVersionNumber.GetValueOrDefault(); }
            set { this._defaultVersionNumber = value; }
        }

        // Check to see if DefaultVersionNumber property is set
        internal bool IsSetDefaultVersionNumber()
        {
            return this._defaultVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  An ID for the launch template. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        ///  The latest version of the launch template. 
        /// </para>
        /// </summary>
        public long LatestVersionNumber
        {
            get { return this._latestVersionNumber.GetValueOrDefault(); }
            set { this._latestVersionNumber = value; }
        }

        // Check to see if LatestVersionNumber property is set
        internal bool IsSetLatestVersionNumber()
        {
            return this._latestVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateData. 
        /// <para>
        ///  The information to include in the launch template. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataDetails LaunchTemplateData
        {
            get { return this._launchTemplateData; }
            set { this._launchTemplateData = value; }
        }

        // Check to see if LaunchTemplateData property is set
        internal bool IsSetLaunchTemplateData()
        {
            return this._launchTemplateData != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        ///  A name for the launch template. 
        /// </para>
        /// </summary>
        public string LaunchTemplateName
        {
            get { return this._launchTemplateName; }
            set { this._launchTemplateName = value; }
        }

        // Check to see if LaunchTemplateName property is set
        internal bool IsSetLaunchTemplateName()
        {
            return this._launchTemplateName != null;
        }

    }
}