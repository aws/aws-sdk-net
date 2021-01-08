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
    /// This is the response object from the CreateFieldLevelEncryptionConfig operation.
    /// </summary>
    public partial class CreateFieldLevelEncryptionConfigResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private FieldLevelEncryption _fieldLevelEncryption;
        private string _location;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the field level encryption configuration. For example: <code>E2QWRUHAPOMQZL</code>.
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
        /// Gets and sets the property FieldLevelEncryption. 
        /// <para>
        /// Returned when you create a new field-level encryption configuration.
        /// </para>
        /// </summary>
        public FieldLevelEncryption FieldLevelEncryption
        {
            get { return this._fieldLevelEncryption; }
            set { this._fieldLevelEncryption = value; }
        }

        // Check to see if FieldLevelEncryption property is set
        internal bool IsSetFieldLevelEncryption()
        {
            return this._fieldLevelEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fully qualified URI of the new configuration resource just created.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}