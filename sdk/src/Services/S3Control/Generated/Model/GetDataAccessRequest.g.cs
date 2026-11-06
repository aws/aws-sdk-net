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
    /// Container for the parameters to the GetDataAccess operation. Returns a temporary access
    /// credential from S3 Access Grants to the grantee or client application. The <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_Credentials.html">temporary
    /// credential</a> is an Amazon Web Services STS token that grants them access to the
    /// S3 data. <dl> <dt>Permissions</dt> <dd> <para> You must have the <c>s3:GetDataAccess</c>
    /// permission to use this operation. </para> </dd> <dt>Additional Permissions</dt> <dd>
    /// <para> The IAM role that S3 Access Grants assumes must have the following permissions
    /// specified in the trust policy when registering the location: <c>sts:AssumeRole</c>,
    /// for directory users or groups <c>sts:SetContext</c>, and for IAM users or roles <c>sts:SetSourceIdentity</c>.
    /// </para> </dd> </dl>
    /// </summary>
    public partial class GetDataAccessRequest : AmazonS3ControlRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 Access Grants instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// The context to identify the job or query associated with the credential request. This
        /// information will be displayed in CloudTrail log in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AuditContext { get; set; }

        /// <summary>
        /// Checks to see if the AuditContext property is set.
        /// </summary>
        internal bool IsSetAuditContext() => this.AuditContext != null;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The session duration, in seconds, of the temporary access credential that S3 Access
        /// Grants vends to the grantee or client application. The default value is 1 hour, but
        /// the grantee can specify a range from 900 seconds (15 minutes) up to 43200 seconds
        /// (12 hours). If the grantee requests a value higher than this maximum, the operation
        /// fails. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 900, Max = 43200)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission granted to your S3 data, which can be set to one of the following
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
        [AWSProperty(Required = true)]
        public Permission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;

        /// <summary>
        /// Gets and sets the property Privilege. 
        /// <para>
        /// The scope of the temporary access credential that S3 Access Grants vends to the grantee
        /// or client application. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Default</c> – The scope of the returned temporary access token is the scope of
        /// the grant that is closest to the target scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Minimal</c> – The scope of the returned temporary access token is the same as
        /// the requested target scope as long as the requested scope is the same as or a subset
        /// of the grant scope. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Privilege Privilege { get; set; }

        /// <summary>
        /// Checks to see if the Privilege property is set.
        /// </summary>
        internal bool IsSetPrivilege() => this.Privilege != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The S3 URI path of the data to which you are requesting temporary access credentials.
        /// If the requesting account has an access grant for this data, S3 Access Grants vends
        /// temporary access credentials in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of <c>Target</c>. The only possible value is <c>Object</c>. Pass this value
        /// if the target data that you would like to access is a path to an object. Do not pass
        /// this value if the target data is a bucket or a bucket and a prefix. 
        /// </para>
        /// </summary>
        public S3PrefixType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
