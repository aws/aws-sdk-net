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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// The location in Amazon S3 where query and calculation results are stored and the encryption
    /// option, if any, used for query and calculation results. These are known as "client-side
    /// settings". If workgroup settings override client-side settings, then the query uses
    /// the workgroup settings.
    /// </summary>
    public partial class ResultConfiguration
    {
        private AclConfiguration _aclConfiguration;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _expectedBucketOwner;
        private string _outputLocation;

        /// <summary>
        /// Gets and sets the property AclConfiguration. 
        /// <para>
        /// Indicates that an Amazon S3 canned ACL should be set to control ownership of stored
        /// query results. Currently the only supported canned ACL is <c>BUCKET_OWNER_FULL_CONTROL</c>.
        /// This is a client-side setting. If workgroup settings override client-side settings,
        /// then the query uses the ACL configuration that is specified for the workgroup, and
        /// also uses the location for storing query results specified in the workgroup. For more
        /// information, see <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a> and <a
        /// href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public AclConfiguration AclConfiguration
        {
            get { return this._aclConfiguration; }
            set { this._aclConfiguration = value; }
        }

        // Check to see if AclConfiguration property is set
        internal bool IsSetAclConfiguration()
        {
            return this._aclConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// If query and calculation results are encrypted in Amazon S3, indicates the encryption
        /// option used (for example, <c>SSE_KMS</c> or <c>CSE_KMS</c>) and key information. This
        /// is a client-side setting. If workgroup settings override client-side settings, then
        /// the query uses the encryption configuration that is specified for the workgroup, and
        /// also uses the location for storing query results specified in the workgroup. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>
        /// and <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID that you expect to be the owner of the Amazon S3
        /// bucket specified by <a>ResultConfiguration$OutputLocation</a>. If set, Athena uses
        /// the value for <c>ExpectedBucketOwner</c> when it makes Amazon S3 calls to your specified
        /// output location. If the <c>ExpectedBucketOwner</c> Amazon Web Services account ID
        /// does not match the actual owner of the Amazon S3 bucket, the call fails with a permissions
        /// error.
        /// </para>
        ///  
        /// <para>
        /// This is a client-side setting. If workgroup settings override client-side settings,
        /// then the query uses the <c>ExpectedBucketOwner</c> setting that is specified for the
        /// workgroup, and also uses the location for storing query results specified in the workgroup.
        /// See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a> and <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The location in Amazon S3 where your query and calculation results are stored, such
        /// as <c>s3://path/to/query/bucket/</c>. To run the query, you must specify the query
        /// results location using one of the ways: either for individual queries using either
        /// this setting (client-side), or in the workgroup, using <a>WorkGroupConfiguration</a>.
        /// If none of them is set, Athena issues an error that no output location is provided.
        /// If workgroup settings override client-side settings, then the query uses the settings
        /// specified for the workgroup. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public string OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

    }
}