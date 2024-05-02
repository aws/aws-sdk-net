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
    /// This is the response object from the CreateAccessGrant operation.
    /// </summary>
    public partial class CreateAccessGrantResponse : AmazonWebServiceResponse
    {
        private string _accessGrantArn;
        private string _accessGrantId;
        private AccessGrantsLocationConfiguration _accessGrantsLocationConfiguration;
        private string _accessGrantsLocationId;
        private string _applicationArn;
        private DateTime? _createdAt;
        private Grantee _grantee;
        private string _grantScope;
        private Permission _permission;

        /// <summary>
        /// Gets and sets the property AccessGrantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access grant. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AccessGrantArn
        {
            get { return this._accessGrantArn; }
            set { this._accessGrantArn = value; }
        }

        // Check to see if AccessGrantArn property is set
        internal bool IsSetAccessGrantArn()
        {
            return this._accessGrantArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccessGrantId. 
        /// <para>
        /// The ID of the access grant. S3 Access Grants auto-generates this ID when you create
        /// the access grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AccessGrantId
        {
            get { return this._accessGrantId; }
            set { this._accessGrantId = value; }
        }

        // Check to see if AccessGrantId property is set
        internal bool IsSetAccessGrantId()
        {
            return this._accessGrantId != null;
        }

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationConfiguration. 
        /// <para>
        /// The configuration options of the grant location. The grant location is the S3 path
        /// to the data to which you are granting access. 
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when you created the access grant. 
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
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The user, group, or role to which you are granting access. You can grant access to
        /// an IAM user or role. If you have added your corporate directory to Amazon Web Services
        /// IAM Identity Center and associated your Identity Center instance with your S3 Access
        /// Grants instance, the grantee can also be a corporate directory user or group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GrantScope. 
        /// <para>
        /// The S3 path of the data to which you are granting access. It is the result of appending
        /// the <c>Subprefix</c> to the location scope. 
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