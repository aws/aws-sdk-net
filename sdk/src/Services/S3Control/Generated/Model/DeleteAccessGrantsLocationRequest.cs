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
    /// Container for the parameters to the DeleteAccessGrantsLocation operation.
    /// Deregisters a location from your S3 Access Grants instance. You can only delete a
    /// location registration from an S3 Access Grants instance if there are no grants associated
    /// with this location. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessGrant.html">Delete
    /// a grant</a> for information on how to delete grants. You need to have at least one
    /// registered location in your S3 Access Grants instance in order to create access grants.
    /// 
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:DeleteAccessGrantsLocation</c> permission to use this operation.
    /// 
    /// </para>
    ///  </dd> </dl> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteAccessGrantsLocationRequest : AmazonS3ControlRequest
    {
        private string _accessGrantsLocationId;
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationId. 
        /// <para>
        /// The ID of the registered location that you are deregistering from your S3 Access Grants
        /// instance. S3 Access Grants assigned this ID when you registered the location. S3 Access
        /// Grants assigns the ID <c>default</c> to the default location <c>s3://</c> and assigns
        /// an auto-generated ID to other locations that you register. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AccessGrantsLocationId
        {
            get { return this._accessGrantsLocationId; }
            set { this._accessGrantsLocationId = value; }
        }

        // Check to see if AccessGrantsLocationId property is set
        internal bool IsSetAccessGrantsLocationId()
        {
            return this._accessGrantsLocationId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 Access Grants instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

    }
}