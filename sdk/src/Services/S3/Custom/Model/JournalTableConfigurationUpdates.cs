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
using System;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The journal table configuration updates.
    /// </summary>
    public partial class JournalTableConfigurationUpdates
    {
        private JournalConfigurationState configurationState;
        private MetadataTableEncryptionConfiguration encryptionConfiguration;

        /// <summary>
        /// <para>
        /// The state of the journal table configuration.
        /// </para>
        /// </summary>
        public JournalConfigurationState ConfigurationState
        {
            get { return this.configurationState; }
            set { this.configurationState = value; }
        }

        internal bool IsSetConfigurationState()
        {
            return this.configurationState != null;
        }

        /// <summary>
        /// <para>
        /// The encryption configuration for the journal table.
        /// </para>
        /// </summary>
        public MetadataTableEncryptionConfiguration EncryptionConfiguration
        {
            get { return this.encryptionConfiguration; }
            set { this.encryptionConfiguration = value; }
        }

        internal bool IsSetEncryptionConfiguration()
        {
            return this.encryptionConfiguration != null;
        }
    }
}