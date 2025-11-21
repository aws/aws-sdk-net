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
    /// Container for the parameters to the CreateAccessGrantsLocation operation.
    /// The S3 data location that you would like to register in your S3 Access Grants instance.
    /// Your S3 data must be in the same Region as your S3 Access Grants instance. The location
    /// can be one of the following: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The default S3 location <c>s3://</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A bucket - <c>S3://&lt;bucket-name&gt;</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A bucket and prefix - <c>S3://&lt;bucket-name&gt;/&lt;prefix&gt;</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you register a location, you must include the IAM role that has permission to
    /// manage the S3 location that you are registering. Give S3 Access Grants permission
    /// to assume this role <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-location.html">using
    /// a policy</a>. S3 Access Grants assumes this role to manage access to the location
    /// and to vend temporary credentials to grantees or client applications. 
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:CreateAccessGrantsLocation</c> permission to use this operation.
    /// 
    /// </para>
    ///  </dd> <dt>Additional Permissions</dt> <dd> 
    /// <para>
    /// You must also have the following permission for the specified IAM role: <c>iam:PassRole</c>
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
    public partial class CreateAccessGrantsLocationRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _iamRoleArn;
        private string _locationScope;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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

        /// <summary>
        /// Gets and sets the property IAMRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role for the registered location. S3 Access
        /// Grants assumes this role to manage access to the registered location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string IAMRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IAMRoleArn property is set
        internal bool IsSetIAMRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocationScope. 
        /// <para>
        /// The S3 path to the location that you are registering. The location scope can be the
        /// default S3 location <c>s3://</c>, the S3 path to a bucket <c>s3://&lt;bucket&gt;</c>,
        /// or the S3 path to a bucket and prefix <c>s3://&lt;bucket&gt;/&lt;prefix&gt;</c>. A
        /// prefix in S3 is a string of characters at the beginning of an object key name used
        /// to organize the objects that you store in your S3 buckets. For example, object key
        /// names that start with the <c>engineering/</c> prefix or object key names that start
        /// with the <c>marketing/campaigns/</c> prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string LocationScope
        {
            get { return this._locationScope; }
            set { this._locationScope = value; }
        }

        // Check to see if LocationScope property is set
        internal bool IsSetLocationScope()
        {
            return this._locationScope != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Amazon Web Services resource tags that you are adding to the S3 Access Grants
        /// location. Each tag is a label consisting of a user-defined key and value. Tags can
        /// help you manage, identify, organize, search for, and filter resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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