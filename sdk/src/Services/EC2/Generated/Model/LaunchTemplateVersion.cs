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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a launch template version.
    /// </summary>
    public partial class LaunchTemplateVersion
    {
        private string _createdBy;
        private DateTime? _createTime;
        private bool? _defaultVersion;
        private ResponseLaunchTemplateData _launchTemplateData;
        private string _launchTemplateId;
        private string _launchTemplateName;
        private OperatorResponse _operator;
        private string _versionDescription;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that created the version.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the version was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// Indicates whether the version is the default version.
        /// </para>
        /// </summary>
        public bool? DefaultVersion
        {
            get { return this._defaultVersion; }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateData. 
        /// <para>
        /// Information about the launch template.
        /// </para>
        /// </summary>
        public ResponseLaunchTemplateData LaunchTemplateData
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
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        /// </summary>
        public string LaunchTemplateId
        {
            get { return this._launchTemplateId; }
            set { this._launchTemplateId = value; }
        }

        // Check to see if LaunchTemplateId property is set
        internal bool IsSetLaunchTemplateId()
        {
            return this._launchTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// The name of the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The entity that manages the launch template.
        /// </para>
        /// </summary>
        public OperatorResponse Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// The description for the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}