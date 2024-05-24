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
    /// A complex data type of profiles for the field-level encryption.
    /// </summary>
    public partial class FieldLevelEncryptionProfileConfig
    {
        private string _callerReference;
        private string _comment;
        private EncryptionEntities _encryptionEntities;
        private string _name;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique number that ensures that the request can't be replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment for the field-level encryption profile. The comment cannot be
        /// longer than 128 characters.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionEntities. 
        /// <para>
        /// A complex data type of encryption entities for the field-level encryption profile
        /// that include the public key ID, provider, and field patterns for specifying which
        /// fields to encrypt with this key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionEntities EncryptionEntities
        {
            get { return this._encryptionEntities; }
            set { this._encryptionEntities = value; }
        }

        // Check to see if EncryptionEntities property is set
        internal bool IsSetEncryptionEntities()
        {
            return this._encryptionEntities != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Profile name for the field-level encryption profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}