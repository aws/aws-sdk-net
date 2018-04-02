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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the GetFieldLevelEncryptionProfileConfig operation.
    /// </summary>
    public partial class GetFieldLevelEncryptionProfileConfigResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private FieldLevelEncryptionProfileConfig _fieldLevelEncryptionProfileConfig;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the field-level encryption profile configuration result. For
        /// example: <code>E2QWRUHAPOMQZL</code>.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionProfileConfig. 
        /// <para>
        /// Return the field-level encryption profile configuration information.
        /// </para>
        /// </summary>
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

    }
}