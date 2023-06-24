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
    /// Container for the parameters to the UpdateFieldLevelEncryptionConfig operation.
    /// Update a field-level encryption configuration.
    /// </summary>
    public partial class UpdateFieldLevelEncryptionConfigRequest : AmazonCloudFrontRequest
    {
        private FieldLevelEncryptionConfig _fieldLevelEncryptionConfig;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionConfig. 
        /// <para>
        /// Request to update a field-level encryption configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldLevelEncryptionConfig FieldLevelEncryptionConfig
        {
            get { return this._fieldLevelEncryptionConfig; }
            set { this._fieldLevelEncryptionConfig = value; }
        }

        // Check to see if FieldLevelEncryptionConfig property is set
        internal bool IsSetFieldLevelEncryptionConfig()
        {
            return this._fieldLevelEncryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the configuration you want to update.
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
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <code>ETag</code> header that you received when retrieving the configuration
        /// identity to update. For example: <code>E2QWRUHAPOMQZL</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

    }
}