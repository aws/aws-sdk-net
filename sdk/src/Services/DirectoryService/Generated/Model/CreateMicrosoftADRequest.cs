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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMicrosoftAD operation.
    /// Creates an AWS Managed Microsoft AD directory.
    /// 
    ///  
    /// <para>
    /// Before you call <i>CreateMicrosoftAD</i>, ensure that all of the required permissions
    /// have been explicitly granted through a policy. For details about what permissions
    /// are required to run the <i>CreateMicrosoftAD</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
    /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
    /// </para>
    /// </summary>
    public partial class CreateMicrosoftADRequest : AmazonDirectoryServiceRequest
    {
        private string _description;
        private DirectoryEdition _edition;
        private string _name;
        private string _password;
        private string _shortName;
        private List<Tag> _tags = new List<Tag>();
        private DirectoryVpcSettings _vpcSettings;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A textual description for the directory. This label will appear on the AWS console
        /// <code>Directory Details</code> page after the directory is created.
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
        /// Gets and sets the property Edition. 
        /// <para>
        /// AWS Managed Microsoft AD is available in two editions: Standard and Enterprise. Enterprise
        /// is the default.
        /// </para>
        /// </summary>
        public DirectoryEdition Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        // Check to see if Edition property is set
        internal bool IsSetEdition()
        {
            return this._edition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified domain name for the directory, such as <code>corp.example.com</code>.
        /// This name will resolve inside your VPC only. It does not need to be publicly resolvable.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the default administrative user named <code>Admin</code>.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        /// The NetBIOS name for your domain. A short identifier for your domain, such as <code>CORP</code>.
        /// If you don't specify a NetBIOS name, it will default to the first part of your directory
        /// DNS. For example, <code>CORP</code> for the directory DNS <code>corp.example.com</code>.
        /// 
        /// </para>
        /// </summary>
        public string ShortName
        {
            get { return this._shortName; }
            set { this._shortName = value; }
        }

        // Check to see if ShortName property is set
        internal bool IsSetShortName()
        {
            return this._shortName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the AWS Managed Microsoft AD directory.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcSettings. 
        /// <para>
        /// Contains VPC information for the <a>CreateDirectory</a> or <a>CreateMicrosoftAD</a>
        /// operation.
        /// </para>
        /// </summary>
        public DirectoryVpcSettings VpcSettings
        {
            get { return this._vpcSettings; }
            set { this._vpcSettings = value; }
        }

        // Check to see if VpcSettings property is set
        internal bool IsSetVpcSettings()
        {
            return this._vpcSettings != null;
        }

    }
}