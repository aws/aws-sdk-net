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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex data type for field-level encryption profiles.
    /// </summary>
    public partial class FieldLevelEncryptionProfile
    {
        private FieldLevelEncryptionProfileConfig _fieldLevelEncryptionProfileConfig;
        private string _id;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionProfileConfig. 
        /// <para>
        /// A complex data type that includes the profile name and the encryption entities for
        /// the field-level encryption profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldLevelEncryptionProfileConfig FieldLevelEncryptionProfileConfig
        {
            get { return this._fieldLevelEncryptionProfileConfig; }
            set { this._fieldLevelEncryptionProfileConfig = value; }
        }

        // Check to see if FieldLevelEncryptionProfileConfig property is set
        internal bool IsSetFieldLevelEncryptionProfileConfig()
        {
            return this._fieldLevelEncryptionProfileConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for a field-level encryption profile configuration which includes a set of
        /// profiles that specify certain selected data fields to be encrypted by specific public
        /// keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the field-level encryption profile was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}