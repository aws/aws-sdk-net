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
    /// Container for the parameters to the CreateAccessGrant operation.
    /// Creates an access grant that gives a grantee access to your S3 data. The grantee can
    /// be an IAM user or role or a directory user, or group. Before you can create a grant,
    /// you must have an S3 Access Grants instance in the same Region as the S3 data. You
    /// can create an S3 Access Grants instance using the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessGrantsInstance.html">CreateAccessGrantsInstance</a>.
    /// You must also have registered at least one S3 data location in your S3 Access Grants
    /// instance using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessGrantsLocation.html">CreateAccessGrantsLocation</a>.
    /// 
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:CreateAccessGrant</c> permission to use this operation. 
    /// </para>
    ///  </dd> <dt>Additional Permissions</dt> <dd> 
    /// <para>
    /// For any directory identity - <c>sso:DescribeInstance</c> and <c>sso:DescribeApplication</c>
    /// 
    /// </para>
    ///  
    /// <para>
    /// For directory users - <c>identitystore:DescribeUser</c> 
    /// </para>
    ///  
    /// <para>
    /// For directory groups - <c>identitystore:DescribeGroup</c> 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class CreateAccessGrantRequest : AmazonS3ControlRequest
    {
        private AccessGrantsLocationConfiguration _accessGrantsLocationConfiguration;
        private string _accessGrantsLocationId;
        private string _accountId;
        private string _applicationArn;
        private Grantee _grantee;
        private Permission _permission;
        private S3PrefixType _s3PrefixType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationConfiguration. 
        /// <para>
        /// The configuration options of the grant location. The grant location is the S3 path
        /// to the data to which you are granting access. It contains the <c>S3SubPrefix</c> field.
        /// The grant scope is the result of appending the subprefix to the location scope of
        /// the registered location.
        /// </para>
        /// </summary>
        public AccessGrantsLocationConfiguration AccessGrantsLocationConfiguration
        {
            get { return this._accessGrantsLocationConfiguration; }
            set { this._accessGrantsLocationConfiguration = value; }
        }

        // Check to see if AccessGrantsLocationConfiguration property is set
        internal bool IsSetAccessGrantsLocationConfiguration()
        {
            return this._accessGrantsLocationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationId. 
        /// <para>
        /// The ID of the registered location to which you are granting access. S3 Access Grants
        /// assigns this ID when you register the location. S3 Access Grants assigns the ID <c>default</c>
        /// to the default location <c>s3://</c> and assigns an auto-generated ID to other locations
        /// that you register. 
        /// </para>
        ///  
        /// <para>
        /// If you are passing the <c>default</c> location, you cannot create an access grant
        /// for the entire default location. You must also specify a bucket or a bucket and prefix
        /// in the <c>Subprefix</c> field. 
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
            return !string.IsNullOrEmpty(this._accountId);
        }

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services IAM Identity Center application
        /// associated with your Identity Center instance. If an application ARN is included in
        /// the request to create an access grant, the grantee can only access the S3 data through
        /// this application. 
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
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The user, group, or role to which you are granting access. You can grant access to
        /// an IAM user or role. If you have added your corporate directory to Amazon Web Services
        /// IAM Identity Center and associated your Identity Center instance with your S3 Access
        /// Grants instance, the grantee can also be a corporate directory user or group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Grantee Grantee
        {
            get { return this._grantee; }
            set { this._grantee = value; }
        }

        // Check to see if Grantee property is set
        internal bool IsSetGrantee()
        {
            return this._grantee != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of access that you are granting to your S3 data, which can be set to one
        /// of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c> – Grant read-only access to the S3 data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WRITE</c> – Grant write-only access to the S3 data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READWRITE</c> – Grant both read and write access to the S3 data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property S3PrefixType. 
        /// <para>
        /// The type of <c>S3SubPrefix</c>. The only possible value is <c>Object</c>. Pass this
        /// value if the access grant scope is an object. Do not pass this value if the access
        /// grant scope is a bucket or a bucket and a prefix. 
        /// </para>
        /// </summary>
        public S3PrefixType S3PrefixType
        {
            get { return this._s3PrefixType; }
            set { this._s3PrefixType = value; }
        }

        // Check to see if S3PrefixType property is set
        internal bool IsSetS3PrefixType()
        {
            return this._s3PrefixType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Amazon Web Services resource tags that you are adding to the access grant. Each
        /// tag is a label consisting of a user-defined key and value. Tags can help you manage,
        /// identify, organize, search for, and filter resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}