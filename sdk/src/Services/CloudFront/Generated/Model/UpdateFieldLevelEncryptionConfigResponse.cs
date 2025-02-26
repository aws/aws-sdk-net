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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the UpdateFieldLevelEncryptionConfig operation.
    /// </summary>
    public partial class UpdateFieldLevelEncryptionConfigResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private FieldLevelEncryption _fieldLevelEncryption;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The value of the <c>ETag</c> header that you received when updating the configuration.
        /// For example: <c>E2QWRUHAPOMQZL</c>.
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
        /// Return the results of updating the configuration.
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

    }
}