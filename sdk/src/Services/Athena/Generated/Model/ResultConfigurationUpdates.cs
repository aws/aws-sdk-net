/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private EncryptionConfiguration _encryptionConfiguration;
        private string _outputLocation;
        private bool? _removeEncryptionConfiguration;
        private bool? _removeOutputLocation;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the query results.
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
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The location in Amazon S3 where your query results are stored, such as <code>s3://path/to/query/bucket/</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Queries
        /// and Query Result Files.</a> If workgroup settings override client-side settings, then
        /// the query uses the location for the query results and the encryption configuration
        /// that are specified for the workgroup. The "workgroup settings override" is specified
        /// in EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
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
        /// Gets and sets the property RemoveEncryptionConfiguration. 
        /// <para>
        /// If set to "true", indicates that the previously-specified encryption configuration
        /// (also known as the client-side setting) for queries in this workgroup should be ignored
        /// and set to null. If set to "false" or not set, and a value is present in the EncryptionConfiguration
        /// in ResultConfigurationUpdates (the client-side setting), the EncryptionConfiguration
        /// in the workgroup's ResultConfiguration will be updated with the new value. For more
        /// information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
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
        /// Gets and sets the property RemoveOutputLocation. 
        /// <para>
        /// If set to "true", indicates that the previously-specified query results location (also
        /// known as a client-side setting) for queries in this workgroup should be ignored and
        /// set to null. If set to "false" or not set, and a value is present in the OutputLocation
        /// in ResultConfigurationUpdates (the client-side setting), the OutputLocation in the
        /// workgroup's ResultConfiguration will be updated with the new value. For more information,
        /// see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
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