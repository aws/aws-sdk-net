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
    /// access requests that are made using the S3 access point.
    /// </summary>
    public partial class OpenZFSFileSystemIdentity
    {
        private OpenZFSPosixFileSystemUser _posixUser;
        private OpenZFSFileSystemUserType _type;

        /// <summary>
        /// Gets and sets the property PosixUser. 
        /// <para>
        /// Specifies the UID and GIDs of the file system POSIX user.
        /// </para>
        /// </summary>
        public OpenZFSPosixFileSystemUser PosixUser
        {
            get { return this._posixUser; }
            set { this._posixUser = value; }
        }

        // Check to see if PosixUser property is set
        internal bool IsSetPosixUser()
        {
            return this._posixUser != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the FSx for OpenZFS user identity type, accepts only <c>POSIX</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenZFSFileSystemUserType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}