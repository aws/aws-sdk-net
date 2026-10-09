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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The information about the updates in the query results, such as output location and
    /// encryption configuration for the query results.
    /// </summary>
    public partial class ResultConfigurationUpdates
    {
        /// <summary>
        /// Gets and sets the property AclConfiguration. 
        /// <para>
        /// The ACL configuration for the query results.
        /// </para>
        /// </summary>
        public AclConfiguration AclConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AclConfiguration property is set.
        /// </summary>
        internal bool IsSetAclConfiguration() => this.AclConfiguration != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for query and calculation results.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

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
        /// If workgroup settings override client-side settings, then the query uses the <c>ExpectedBucketOwner</c>
        /// setting that is specified for the workgroup, and also uses the location for storing
        /// query results specified in the workgroup. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>
        /// and <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The location in Amazon S3 where your query and calculation results are stored, such
        /// as <c>s3://path/to/query/bucket/</c>. If workgroup settings override client-side settings,
        /// then the query uses the location for the query results and the encryption configuration
        /// that are specified for the workgroup. The "workgroup settings override" is specified
        /// in <c>EnforceWorkGroupConfiguration</c> (true/false) in the <c>WorkGroupConfiguration</c>.
        /// See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public string OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;

        /// <summary>
        /// Gets and sets the property RemoveAclConfiguration. 
        /// <para>
        /// If set to <c>true</c>, indicates that the previously-specified ACL configuration for
        /// queries in this workgroup should be ignored and set to null. If set to <c>false</c>
        /// or not set, and a value is present in the <c>AclConfiguration</c> of <c>ResultConfigurationUpdates</c>,
        /// the <c>AclConfiguration</c> in the workgroup's <c>ResultConfiguration</c> is updated
        /// with the new value. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool? RemoveAclConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveAclConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveAclConfiguration() => this.RemoveAclConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveEncryptionConfiguration. 
        /// <para>
        /// If set to "true", indicates that the previously-specified encryption configuration
        /// (also known as the client-side setting) for queries in this workgroup should be ignored
        /// and set to null. If set to "false" or not set, and a value is present in the <c>EncryptionConfiguration</c>
        /// in <c>ResultConfigurationUpdates</c> (the client-side setting), the <c>EncryptionConfiguration</c>
        /// in the workgroup's <c>ResultConfiguration</c> will be updated with the new value.
        /// For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool? RemoveEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveEncryptionConfiguration() => this.RemoveEncryptionConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveExpectedBucketOwner. 
        /// <para>
        /// If set to "true", removes the Amazon Web Services account ID previously specified
        /// for <a>ResultConfiguration$ExpectedBucketOwner</a>. If set to "false" or not set,
        /// and a value is present in the <c>ExpectedBucketOwner</c> in <c>ResultConfigurationUpdates</c>
        /// (the client-side setting), the <c>ExpectedBucketOwner</c> in the workgroup's <c>ResultConfiguration</c>
        /// is updated with the new value. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool? RemoveExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the RemoveExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetRemoveExpectedBucketOwner() => this.RemoveExpectedBucketOwner.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveOutputLocation. 
        /// <para>
        /// If set to "true", indicates that the previously-specified query results location (also
        /// known as a client-side setting) for queries in this workgroup should be ignored and
        /// set to null. If set to "false" or not set, and a value is present in the <c>OutputLocation</c>
        /// in <c>ResultConfigurationUpdates</c> (the client-side setting), the <c>OutputLocation</c>
        /// in the workgroup's <c>ResultConfiguration</c> will be updated with the new value.
        /// For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool? RemoveOutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the RemoveOutputLocation property is set.
        /// </summary>
        internal bool IsSetRemoveOutputLocation() => this.RemoveOutputLocation.HasValue;
    }
}
