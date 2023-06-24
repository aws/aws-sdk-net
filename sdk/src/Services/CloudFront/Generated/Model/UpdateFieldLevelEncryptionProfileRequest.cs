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
    /// Container for the parameters to the UpdateFieldLevelEncryptionProfile operation.
    /// Update a field-level encryption profile.
    /// </summary>
    public partial class UpdateFieldLevelEncryptionProfileRequest : AmazonCloudFrontRequest
    {
        private FieldLevelEncryptionProfileConfig _fieldLevelEncryptionProfileConfig;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionProfileConfig. 
        /// <para>
        /// Request to update a field-level encryption profile.
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
        /// The ID of the field-level encryption profile request.
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
        /// The value of the <code>ETag</code> header that you received when retrieving the profile
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