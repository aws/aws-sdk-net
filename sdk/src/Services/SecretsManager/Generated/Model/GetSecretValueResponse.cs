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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the GetSecretValue operation.
    /// </summary>
    public partial class GetSecretValueResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdDate;
        private string _name;
        private MemoryStream _secretBinary;
        private string _secretString;
        private string _versionId;
        private List<string> _versionStages = new List<string>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the secret.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that this version of the secret was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the secret.
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

        /// <summary>
        /// Gets and sets the property SecretBinary. 
        /// <para>
        /// The decrypted part of the protected secret information that was originally provided
        /// as binary data in the form of a byte array. The response parameter represents the
        /// binary data as a <a href="https://tools.ietf.org/html/rfc4648#section-4">base64-encoded</a>
        /// string.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not used if the secret is created by the Secrets Manager console.
        /// </para>
        ///  
        /// <para>
        /// If you store custom information in this field of the secret, then you must code your
        /// Lambda rotation function to parse and interpret whatever you store in the <code>SecretString</code>
        /// or <code>SecretBinary</code> fields.
        /// </para>
        /// </summary>
        public MemoryStream SecretBinary
        {
            get { return this._secretBinary; }
            set { this._secretBinary = value; }
        }

        // Check to see if SecretBinary property is set
        internal bool IsSetSecretBinary()
        {
            return this._secretBinary != null;
        }

        /// <summary>
        /// Gets and sets the property SecretString. 
        /// <para>
        /// The decrypted part of the protected secret information that was originally provided
        /// as a string.
        /// </para>
        ///  
        /// <para>
        /// If you create this secret by using the Secrets Manager console then only the <code>SecretString</code>
        /// parameter contains data. Secrets Manager stores the information as a JSON structure
        /// of key/value pairs that the Lambda rotation function knows how to parse.
        /// </para>
        ///  
        /// <para>
        /// If you store custom information in the secret by using the <a>CreateSecret</a>, <a>UpdateSecret</a>,
        /// or <a>PutSecretValue</a> API operations instead of the Secrets Manager console, or
        /// by using the <b>Other secret type</b> in the console, then you must code your Lambda
        /// rotation function to parse and interpret those values.
        /// </para>
        /// </summary>
        public string SecretString
        {
            get { return this._secretString; }
            set { this._secretString = value; }
        }

        // Check to see if SecretString property is set
        internal bool IsSetSecretString()
        {
            return this._secretString != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The unique identifier of this version of the secret.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStages. 
        /// <para>
        /// A list of all of the staging labels currently attached to this version of the secret.
        /// </para>
        /// </summary>
        public List<string> VersionStages
        {
            get { return this._versionStages; }
            set { this._versionStages = value; }
        }

        // Check to see if VersionStages property is set
        internal bool IsSetVersionStages()
        {
            return this._versionStages != null && this._versionStages.Count > 0; 
        }

    }
}