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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Part of <c>ListCallerAccessGrantsResult</c>. Each entry includes the permission level
    /// (READ, WRITE, or READWRITE) and the grant scope of the access grant. If the grant
    /// also includes an application ARN, the grantee can only access the S3 data through
    /// this application.
    /// </summary>
    public partial class ListCallerAccessGrantsEntry
    {
        private string _applicationArn;
        private string _grantScope;
        private Permission _permission;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services IAM Identity Center application
        /// associated with your Identity Center instance. If the grant includes an application
        /// ARN, the grantee can only access the S3 data through this application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property GrantScope. 
        /// <para>
        /// The S3 path of the data to which you have been granted access. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string GrantScope
        {
            get { return this._grantScope; }
            set { this._grantScope = value; }
        }

        // Check to see if GrantScope property is set
        internal bool IsSetGrantScope()
        {
            return this._grantScope != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission granted, which can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c> - Grants read-only access to the S3 data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WRITE</c> - Grants write-only access to the S3 data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READWRITE</c> - Grants both read and write access to the S3 data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Permission Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

    }
}