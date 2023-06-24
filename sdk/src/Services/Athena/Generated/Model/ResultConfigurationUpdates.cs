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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The information about the updates in the query results, such as output location and
    /// encryption configuration for the query results.
    /// </summary>
    public partial class ResultConfigurationUpdates
    {
        private AclConfiguration _aclConfiguration;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _expectedBucketOwner;
        private string _outputLocation;
        private bool? _removeAclConfiguration;
        private bool? _removeEncryptionConfiguration;
        private bool? _removeExpectedBucketOwner;
        private bool? _removeOutputLocation;

        /// <summary>
        /// Gets and sets the property AclConfiguration. 
        /// <para>
        /// The ACL configuration for the query results.
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
        /// The encryption configuration for query and calculation results.
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
        /// the value for <code>ExpectedBucketOwner</code> when it makes Amazon S3 calls to your
        /// specified output location. If the <code>ExpectedBucketOwner</code> Amazon Web Services
        /// account ID does not match the actual owner of the Amazon S3 bucket, the call fails
        /// with a permissions error.
        /// </para>
        ///  
        /// <para>
        /// If workgroup settings override client-side settings, then the query uses the <code>ExpectedBucketOwner</code>
        /// setting that is specified for the workgroup, and also uses the location for storing
        /// query results specified in the workgroup. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>
        /// and <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
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
        /// as <code>s3://path/to/query/bucket/</code>. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Working
        /// with query results, recent queries, and output files</a>. If workgroup settings override
        /// client-side settings, then the query uses the location for the query results and the
        /// encryption configuration that are specified for the workgroup. The "workgroup settings
        /// override" is specified in <code>EnforceWorkGroupConfiguration</code> (true/false)
        /// in the <code>WorkGroupConfiguration</code>. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
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

        /// <summary>
        /// Gets and sets the property RemoveAclConfiguration. 
        /// <para>
        /// If set to <code>true</code>, indicates that the previously-specified ACL configuration
        /// for queries in this workgroup should be ignored and set to null. If set to <code>false</code>
        /// or not set, and a value is present in the <code>AclConfiguration</code> of <code>ResultConfigurationUpdates</code>,
        /// the <code>AclConfiguration</code> in the workgroup's <code>ResultConfiguration</code>
        /// is updated with the new value. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool RemoveAclConfiguration
        {
            get { return this._removeAclConfiguration.GetValueOrDefault(); }
            set { this._removeAclConfiguration = value; }
        }

        // Check to see if RemoveAclConfiguration property is set
        internal bool IsSetRemoveAclConfiguration()
        {
            return this._removeAclConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveEncryptionConfiguration. 
        /// <para>
        /// If set to "true", indicates that the previously-specified encryption configuration
        /// (also known as the client-side setting) for queries in this workgroup should be ignored
        /// and set to null. If set to "false" or not set, and a value is present in the <code>EncryptionConfiguration</code>
        /// in <code>ResultConfigurationUpdates</code> (the client-side setting), the <code>EncryptionConfiguration</code>
        /// in the workgroup's <code>ResultConfiguration</code> will be updated with the new value.
        /// For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool RemoveEncryptionConfiguration
        {
            get { return this._removeEncryptionConfiguration.GetValueOrDefault(); }
            set { this._removeEncryptionConfiguration = value; }
        }

        // Check to see if RemoveEncryptionConfiguration property is set
        internal bool IsSetRemoveEncryptionConfiguration()
        {
            return this._removeEncryptionConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveExpectedBucketOwner. 
        /// <para>
        /// If set to "true", removes the Amazon Web Services account ID previously specified
        /// for <a>ResultConfiguration$ExpectedBucketOwner</a>. If set to "false" or not set,
        /// and a value is present in the <code>ExpectedBucketOwner</code> in <code>ResultConfigurationUpdates</code>
        /// (the client-side setting), the <code>ExpectedBucketOwner</code> in the workgroup's
        /// <code>ResultConfiguration</code> is updated with the new value. For more information,
        /// see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool RemoveExpectedBucketOwner
        {
            get { return this._removeExpectedBucketOwner.GetValueOrDefault(); }
            set { this._removeExpectedBucketOwner = value; }
        }

        // Check to see if RemoveExpectedBucketOwner property is set
        internal bool IsSetRemoveExpectedBucketOwner()
        {
            return this._removeExpectedBucketOwner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveOutputLocation. 
        /// <para>
        /// If set to "true", indicates that the previously-specified query results location (also
        /// known as a client-side setting) for queries in this workgroup should be ignored and
        /// set to null. If set to "false" or not set, and a value is present in the <code>OutputLocation</code>
        /// in <code>ResultConfigurationUpdates</code> (the client-side setting), the <code>OutputLocation</code>
        /// in the workgroup's <code>ResultConfiguration</code> will be updated with the new value.
        /// For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool RemoveOutputLocation
        {
            get { return this._removeOutputLocation.GetValueOrDefault(); }
            set { this._removeOutputLocation = value; }
        }

        // Check to see if RemoveOutputLocation property is set
        internal bool IsSetRemoveOutputLocation()
        {
            return this._removeOutputLocation.HasValue; 
        }

    }
}