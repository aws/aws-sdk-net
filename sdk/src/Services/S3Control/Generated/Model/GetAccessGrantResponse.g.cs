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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetAccessGrant operation.
    /// </summary>
    public partial class GetAccessGrantResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessGrantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access grant. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AccessGrantArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessGrantArn property is set.
        /// </summary>
        internal bool IsSetAccessGrantArn() => this.AccessGrantArn != null;

        /// <summary>
        /// Gets and sets the property AccessGrantId. 
        /// <para>
        /// The ID of the access grant. S3 Access Grants auto-generates this ID when you create
        /// the access grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AccessGrantId { get; set; }

        /// <summary>
        /// Checks to see if the AccessGrantId property is set.
        /// </summary>
        internal bool IsSetAccessGrantId() => this.AccessGrantId != null;

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationConfiguration. 
        /// <para>
        /// The configuration options of the grant location. The grant location is the S3 path
        /// to the data to which you are granting access. 
        /// </para>
        /// </summary>
        public AccessGrantsLocationConfiguration AccessGrantsLocationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AccessGrantsLocationConfiguration property is set.
        /// </summary>
        internal bool IsSetAccessGrantsLocationConfiguration() => this.AccessGrantsLocationConfiguration != null;

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationId. 
        /// <para>
        /// The ID of the registered location to which you are granting access. S3 Access Grants
        /// assigns this ID when you register the location. S3 Access Grants assigns the ID <c>default</c>
        /// to the default location <c>s3://</c> and assigns an auto-generated ID to other locations
        /// that you register. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AccessGrantsLocationId { get; set; }

        /// <summary>
        /// Checks to see if the AccessGrantsLocationId property is set.
        /// </summary>
        internal bool IsSetAccessGrantsLocationId() => this.AccessGrantsLocationId != null;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services IAM Identity Center application
        /// associated with your Identity Center instance. If the grant includes an application
        /// ARN, the grantee can only access the S3 data through this application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when you created the access grant. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property GrantScope. 
        /// <para>
        /// The S3 path of the data to which you are granting access. It is the result of appending
        /// the <c>Subprefix</c> to the location scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string GrantScope { get; set; }

        /// <summary>
        /// Checks to see if the GrantScope property is set.
        /// </summary>
        internal bool IsSetGrantScope() => this.GrantScope != null;

        /// <summary>
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The user, group, or role to which you are granting access. You can grant access to
        /// an IAM user or role. If you have added a corporate directory to Amazon Web Services
        /// IAM Identity Center and associated this Identity Center instance with the S3 Access
        /// Grants instance, the grantee can also be a corporate directory user or group.
        /// </para>
        /// </summary>
        public Grantee Grantee { get; set; }

        /// <summary>
        /// Checks to see if the Grantee property is set.
        /// </summary>
        internal bool IsSetGrantee() => this.Grantee != null;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission that was granted in the access grant. Can be one of the following
        /// values:
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
        public Permission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;
    }
}
