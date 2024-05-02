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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the StartMailboxExportJob operation.
    /// Starts a mailbox export job to export MIME-format email messages and calendar items
    /// from the specified mailbox to the specified Amazon Simple Storage Service (Amazon
    /// S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/mail-export.html">Exporting
    /// mailbox content</a> in the <i>WorkMail Administrator Guide</i>.
    /// </summary>
    public partial class StartMailboxExportJobRequest : AmazonWorkMailRequest
    {
        private string _clientToken;
        private string _description;
        private string _entityId;
        private string _kmsKeyArn;
        private string _organizationId;
        private string _roleArn;
        private string _s3BucketName;
        private string _s3Prefix;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The mailbox export job description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1023)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the user or resource associated with the mailbox.
        /// </para>
        ///  
        /// <para>
        /// The identifier can accept <i>UserId or ResourceId</i>, <i>Username or Resourcename</i>,
        /// or <i>email</i>. The following identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Entity ID: 12345678-1234-1234-1234-123456789012, r-0123456789a0123456789b0123456789
        /// , or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: entity@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Entity name: entity
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the symmetric AWS Key Management Service (AWS KMS)
        /// key that encrypts the exported mailbox content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that grants write permission
        /// to the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The S3 bucket prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1023)]
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

    }
}