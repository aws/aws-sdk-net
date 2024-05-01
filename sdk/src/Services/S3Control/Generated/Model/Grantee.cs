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
    /// The user, group, or role to which you are granting access. You can grant access to
    /// an IAM user or role. If you have added your corporate directory to Amazon Web Services
    /// IAM Identity Center and associated your Identity Center instance with your S3 Access
    /// Grants instance, the grantee can also be a corporate directory user or group.
    /// </summary>
    public partial class Grantee
    {
        private string _granteeIdentifier;
        private GranteeType _granteeType;

        /// <summary>
        /// Gets and sets the property GranteeIdentifier. 
        /// <para>
        /// The unique identifier of the <c>Grantee</c>. If the grantee type is <c>IAM</c>, the
        /// identifier is the IAM Amazon Resource Name (ARN) of the user or role. If the grantee
        /// type is a directory user or group, the identifier is 128-bit universally unique identifier
        /// (UUID) in the format <c>a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>. You can obtain this
        /// UUID from your Amazon Web Services IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string GranteeIdentifier
        {
            get { return this._granteeIdentifier; }
            set { this._granteeIdentifier = value; }
        }

        // Check to see if GranteeIdentifier property is set
        internal bool IsSetGranteeIdentifier()
        {
            return this._granteeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GranteeType. 
        /// <para>
        /// The type of the grantee to which access has been granted. It can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IAM</c> - An IAM user or role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECTORY_USER</c> - Your corporate directory user. You can use this option if
        /// you have added your corporate identity directory to IAM Identity Center and associated
        /// the IAM Identity Center instance with your S3 Access Grants instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECTORY_GROUP</c> - Your corporate directory group. You can use this option
        /// if you have added your corporate identity directory to IAM Identity Center and associated
        /// the IAM Identity Center instance with your S3 Access Grants instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GranteeType GranteeType
        {
            get { return this._granteeType; }
            set { this._granteeType = value; }
        }

        // Check to see if GranteeType property is set
        internal bool IsSetGranteeType()
        {
            return this._granteeType != null;
        }

    }
}