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
    /// Container for the parameters to the ConnectDirectory operation.
    /// Creates an AD Connector to connect to a self-managed directory.
    /// 
    ///  
    /// <para>
    /// Before you call <code>ConnectDirectory</code>, ensure that all of the required permissions
    /// have been explicitly granted through a policy. For details about what permissions
    /// are required to run the <code>ConnectDirectory</code> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
    /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
    /// </para>
    /// </summary>
    public partial class ConnectDirectoryRequest : AmazonDirectoryServiceRequest
    {
        private DirectoryConnectSettings _connectSettings;
        private string _description;
        private string _name;
        private string _password;
        private string _shortName;
        private DirectorySize _size;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConnectSettings. 
        /// <para>
        /// A <a>DirectoryConnectSettings</a> object that contains additional information for
        /// the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DirectoryConnectSettings ConnectSettings
        {
            get { return this._connectSettings; }
            set { this._connectSettings = value; }
        }

        // Check to see if ConnectSettings property is set
        internal bool IsSetConnectSettings()
        {
            return this._connectSettings != null;
        }

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
        /// The fully qualified name of your self-managed directory, such as <code>corp.example.com</code>.
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
        /// The password for your self-managed user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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
        /// The NetBIOS name of your self-managed directory, such as <code>CORP</code>.
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
        /// The tags to be assigned to AD Connector.
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

    }
}