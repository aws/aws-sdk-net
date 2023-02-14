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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDirectory operation.
    /// Creates a Simple AD directory. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_simple_ad.html">Simple
    /// Active Directory</a> in the <i>Directory Service Admin Guide</i>.
    /// 
    ///  
    /// <para>
    /// Before you call <code>CreateDirectory</code>, ensure that all of the required permissions
    /// have been explicitly granted through a policy. For details about what permissions
    /// are required to run the <code>CreateDirectory</code> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
    /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
    /// </para>
    /// </summary>
    public partial class CreateDirectoryRequest : AmazonDirectoryServiceRequest
    {
        private string _description;
        private string _name;
        private string _password;
        private string _shortName;
        private DirectorySize _size;
        private List<Tag> _tags = new List<Tag>();
        private DirectoryVpcSettings _vpcSettings;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// The fully qualified name for the directory, such as <code>corp.example.com</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The password for the directory administrator. The directory creation process creates
        /// a directory administrator account with the user name <code>Administrator</code> and
        /// this password.
        /// </para>
        ///  
        /// <para>
        /// If you need to change the password for the administrator account, you can use the
        /// <a>ResetUserPassword</a> API call.
        /// </para>
        ///  
        /// <para>
        /// The regex pattern for this string is made up of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Length (?=^.{8,64}$) – Must be between 8 and 64 characters
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AND any 3 of the following password complexity rules required by Active Directory:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Numbers and upper case and lowercase (?=.*\d)(?=.*[A-Z])(?=.*[a-z])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers and special characters and lower case (?=.*\d)(?=.*[^A-Za-z0-9\s])(?=.*[a-z])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Special characters and upper case and lower case (?=.*[^A-Za-z0-9\s])(?=.*[A-Z])(?=.*[a-z])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers and upper case and special characters (?=.*\d)(?=.*[A-Z])(?=.*[^A-Za-z0-9\s])
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For additional information about how Active Directory passwords are enforced, see
        /// <a href="https://docs.microsoft.com/en-us/windows/security/threat-protection/security-policy-settings/password-must-meet-complexity-requirements">Password
        /// must meet complexity requirements</a> on the Microsoft website.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// The NetBIOS name of the directory, such as <code>CORP</code>.
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
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DirectorySize Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the Simple AD directory.
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
        /// A <a>DirectoryVpcSettings</a> object that contains additional information for the
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