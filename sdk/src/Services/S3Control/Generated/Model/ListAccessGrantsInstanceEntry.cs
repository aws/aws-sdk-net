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
    /// Information about the S3 Access Grants instance.
    /// </summary>
    public partial class ListAccessGrantsInstanceEntry
    {
        private string _accessGrantsInstanceArn;
        private string _accessGrantsInstanceId;
        private DateTime? _createdAt;
        private string _identityCenterApplicationArn;
        private string _identityCenterArn;
        private string _identityCenterInstanceArn;

        /// <summary>
        /// Gets and sets the property AccessGrantsInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 Access Grants instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AccessGrantsInstanceArn
        {
            get { return this._accessGrantsInstanceArn; }
            set { this._accessGrantsInstanceArn = value; }
        }

        // Check to see if AccessGrantsInstanceArn property is set
        internal bool IsSetAccessGrantsInstanceArn()
        {
            return this._accessGrantsInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccessGrantsInstanceId. 
        /// <para>
        /// The ID of the S3 Access Grants instance. The ID is <c>default</c>. You can have one
        /// S3 Access Grants instance per Region per account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AccessGrantsInstanceId
        {
            get { return this._accessGrantsInstanceId; }
            set { this._accessGrantsInstanceId = value; }
        }

        // Check to see if AccessGrantsInstanceId property is set
        internal bool IsSetAccessGrantsInstanceId()
        {
            return this._accessGrantsInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when you created the S3 Access Grants instance. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// If you associated your S3 Access Grants instance with an Amazon Web Services IAM Identity
        /// Center instance, this field returns the Amazon Resource Name (ARN) of the IAM Identity
        /// Center instance application; a subresource of the original Identity Center instance.
        /// S3 Access Grants creates this Identity Center application for the specific S3 Access
        /// Grants instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterApplicationArn
        {
            get { return this._identityCenterApplicationArn; }
            set { this._identityCenterApplicationArn = value; }
        }

        // Check to see if IdentityCenterApplicationArn property is set
        internal bool IsSetIdentityCenterApplicationArn()
        {
            return this._identityCenterApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterArn. 
        /// <para>
        /// If you associated your S3 Access Grants instance with an Amazon Web Services IAM Identity
        /// Center instance, this field returns the Amazon Resource Name (ARN) of the IAM Identity
        /// Center instance application; a subresource of the original Identity Center instance.
        /// S3 Access Grants creates this Identity Center application for the specific S3 Access
        /// Grants instance. 
        /// </para>
        /// </summary>
        [Obsolete("IdentityCenterArn has been deprecated. Use IdentityCenterInstanceArn or IdentityCenterApplicationArn.")]
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterArn
        {
            get { return this._identityCenterArn; }
            set { this._identityCenterArn = value; }
        }

        // Check to see if IdentityCenterArn property is set
        internal bool IsSetIdentityCenterArn()
        {
            return this._identityCenterArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services IAM Identity Center instance
        /// that you are associating with your S3 Access Grants instance. An IAM Identity Center
        /// instance is your corporate identity directory that you added to the IAM Identity Center.
        /// You can use the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListInstances.html">ListInstances</a>
        /// API operation to retrieve a list of your Identity Center instances and their ARNs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterInstanceArn
        {
            get { return this._identityCenterInstanceArn; }
            set { this._identityCenterInstanceArn = value; }
        }

        // Check to see if IdentityCenterInstanceArn property is set
        internal bool IsSetIdentityCenterInstanceArn()
        {
            return this._identityCenterInstanceArn != null;
        }

    }
}