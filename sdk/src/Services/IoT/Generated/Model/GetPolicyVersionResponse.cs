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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The output from the GetPolicyVersion operation.
    /// </summary>
    public partial class GetPolicyVersionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private string _generationId;
        private bool? _isDefaultVersion;
        private DateTime? _lastModifiedDate;
        private string _policyArn;
        private string _policyDocument;
        private string _policyName;
        private string _policyVersionId;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the policy version was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The generation ID of the policy version.
        /// </para>
        /// </summary>
        public string GenerationId
        {
            get { return this._generationId; }
            set { this._generationId = value; }
        }

        // Check to see if GenerationId property is set
        internal bool IsSetGenerationId()
        {
            return this._generationId != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Specifies whether the policy version is the default.
        /// </para>
        /// </summary>
        public bool IsDefaultVersion
        {
            get { return this._isDefaultVersion.GetValueOrDefault(); }
            set { this._isDefaultVersion = value; }
        }

        // Check to see if IsDefaultVersion property is set
        internal bool IsSetIsDefaultVersion()
        {
            return this._isDefaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the policy version was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The policy ARN.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON document that describes the policy.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The policy name.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyVersionId. 
        /// <para>
        /// The policy version ID.
        /// </para>
        /// </summary>
        public string PolicyVersionId
        {
            get { return this._policyVersionId; }
            set { this._policyVersionId = value; }
        }

        // Check to see if PolicyVersionId property is set
        internal bool IsSetPolicyVersionId()
        {
            return this._policyVersionId != null;
        }

    }
}