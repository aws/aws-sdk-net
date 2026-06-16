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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies updates to apply to the annotation table configuration. Used as the request
    /// body for <c>UpdateBucketMetadataAnnotationTableConfiguration</c>.
    /// </summary>
    public partial class AnnotationTableConfigurationUpdates
    {
        private AnnotationConfigurationState _configurationState;
        private MetadataTableEncryptionConfiguration _encryptionConfiguration;
        private string _role;

        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The new configuration state to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnnotationConfigurationState ConfigurationState
        {
            get { return this._configurationState; }
            set { this._configurationState = value; }
        }

        // Check to see if ConfigurationState property is set
        internal bool IsSetConfigurationState()
        {
            return this._configurationState != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration.
        /// </summary>
        public MetadataTableEncryptionConfiguration EncryptionConfiguration
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The new IAM role ARN to apply.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}