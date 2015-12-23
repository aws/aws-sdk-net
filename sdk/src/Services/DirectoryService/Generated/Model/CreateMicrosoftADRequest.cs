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
    /// Creates a Microsoft AD in the AWS cloud.
    /// </summary>
    public partial class CreateMicrosoftADRequest : AmazonDirectoryServiceRequest
    {
        private string _description;
        private string _name;
        private string _password;
        private string _shortName;
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
        /// Gets and sets the property VpcSettings.
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