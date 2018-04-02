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
    /// Information about a public key you add to CloudFront to use with features like field-level
    /// encryption.
    /// </summary>
    public partial class PublicKeyConfig
    {
        private string _callerReference;
        private string _comment;
        private string _encodedKey;
        private string _name;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique number that ensures the request can't be replayed.
        /// </para>
        /// </summary>
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
        /// An optional comment about a public key.
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
        /// Gets and sets the property EncodedKey. 
        /// <para>
        /// The encoded public key that you want to add to CloudFront to use with features like
        /// field-level encryption.
        /// </para>
        /// </summary>
        public string EncodedKey
        {
            get { return this._encodedKey; }
            set { this._encodedKey = value; }
        }

        // Check to see if EncodedKey property is set
        internal bool IsSetEncodedKey()
        {
            return this._encodedKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for a public key you add to CloudFront to use with features like field-level
        /// encryption.
        /// </para>
        /// </summary>
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