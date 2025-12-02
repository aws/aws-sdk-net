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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies the file system user identity that will be used for authorizing all file
    /// access requests that are made using the S3 access point. The identity can be either
    /// a UNIX user or a Windows user.
    /// </summary>
    public partial class OntapFileSystemIdentity
    {
        private OntapFileSystemUserType _type;
        private OntapUnixFileSystemUser _unixUser;
        private OntapWindowsFileSystemUser _windowsUser;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the FSx for ONTAP user identity type. Valid values are <c>UNIX</c> and <c>WINDOWS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OntapFileSystemUserType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UnixUser. 
        /// <para>
        /// Specifies the UNIX user identity for file system operations.
        /// </para>
        /// </summary>
        public OntapUnixFileSystemUser UnixUser
        {
            get { return this._unixUser; }
            set { this._unixUser = value; }
        }

        // Check to see if UnixUser property is set
        internal bool IsSetUnixUser()
        {
            return this._unixUser != null;
        }

        /// <summary>
        /// Gets and sets the property WindowsUser. 
        /// <para>
        /// Specifies the Windows user identity for file system operations.
        /// </para>
        /// </summary>
        public OntapWindowsFileSystemUser WindowsUser
        {
            get { return this._windowsUser; }
            set { this._windowsUser = value; }
        }

        // Check to see if WindowsUser property is set
        internal bool IsSetWindowsUser()
        {
            return this._windowsUser != null;
        }

    }
}