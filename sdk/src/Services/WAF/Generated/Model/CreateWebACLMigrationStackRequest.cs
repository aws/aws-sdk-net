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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWebACLMigrationStack operation.
    /// Creates an AWS CloudFormation WAFV2 template for the specified web ACL in the specified
    /// Amazon S3 bucket. Then, in CloudFormation, you create a stack from the template, to
    /// create the web ACL and its resources in AWS WAFV2. Use this to migrate your AWS WAF
    /// Classic web ACL to the latest version of AWS WAF.
    /// 
    ///  
    /// <para>
    /// This is part of a larger migration procedure for web ACLs from AWS WAF Classic to
    /// the latest version of AWS WAF. For the full procedure, including caveats and manual
    /// steps to complete the migration and switch over to the new web ACL, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-migrating-from-classic.html">Migrating
    /// your AWS WAF Classic resources to AWS WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial class CreateWebACLMigrationStackRequest : AmazonWAFRequest
    {
        private bool? _ignoreUnsupportedType;
        private string _s3BucketName;
        private string _webACLId;

        /// <summary>
        /// Gets and sets the property IgnoreUnsupportedType. 
        /// <para>
        /// Indicates whether to exclude entities that can't be migrated or to stop the migration.
        /// Set this to true to ignore unsupported entities in the web ACL during the migration.
        /// Otherwise, if AWS WAF encounters unsupported entities, it stops the process and throws
        /// an exception. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IgnoreUnsupportedType
        {
            get { return this._ignoreUnsupportedType; }
            set { this._ignoreUnsupportedType = value; }
        }

        // Check to see if IgnoreUnsupportedType property is set
        internal bool IsSetIgnoreUnsupportedType()
        {
            return this._ignoreUnsupportedType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket to store the CloudFormation template in. The S3 bucket
        /// must be configured as follows for the migration: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The bucket name must start with <c>aws-waf-migration-</c>. For example, <c>aws-waf-migration-my-web-acl</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket must be in the Region where you are deploying the template. For example,
        /// for a web ACL in us-west-2, you must use an Amazon S3 bucket in us-west-2 and you
        /// must deploy the template stack to us-west-2. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bucket policies must permit the migration process to write data. For listings
        /// of the bucket policies, see the Examples section. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// The UUID of the WAF Classic web ACL that you want to migrate to WAF v2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WebACLId
        {
            get { return this._webACLId; }
            set { this._webACLId = value; }
        }

        // Check to see if WebACLId property is set
        internal bool IsSetWebACLId()
        {
            return this._webACLId != null;
        }

    }
}