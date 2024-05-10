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
    /// This is the response object from the UpdateAccessGrantsLocation operation.
    /// </summary>
    public partial class UpdateAccessGrantsLocationResponse : AmazonWebServiceResponse
    {
        private string _accessGrantsLocationArn;
        private string _accessGrantsLocationId;
        private DateTime? _createdAt;
        private string _iamRoleArn;
        private string _locationScope;

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registered location that you are updating. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AccessGrantsLocationArn
        {
            get { return this._accessGrantsLocationArn; }
            set { this._accessGrantsLocationArn = value; }
        }

        // Check to see if AccessGrantsLocationArn property is set
        internal bool IsSetAccessGrantsLocationArn()
        {
            return this._accessGrantsLocationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationId. 
        /// <para>
        /// The ID of the registered location to which you are granting access. S3 Access Grants
        /// assigned this ID when you registered the location. S3 Access Grants assigns the ID
        /// <c>default</c> to the default location <c>s3://</c> and assigns an auto-generated
        /// ID to other locations that you register. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when you registered the location. 
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
        /// Gets and sets the property IAMRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role of the registered location. S3 Access
        /// Grants assumes this role to manage access to the registered location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// The S3 URI path of the location that you are updating. You cannot update the scope
        /// of the registered location. The location scope can be the default S3 location <c>s3://</c>,
        /// the S3 path to a bucket <c>s3://&lt;bucket&gt;</c>, or the S3 path to a bucket and
        /// prefix <c>s3://&lt;bucket&gt;/&lt;prefix&gt;</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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

    }
}