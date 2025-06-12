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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the BatchGetSecretValue operation.
    /// </summary>
    public partial class BatchGetSecretValueResponse : AmazonWebServiceResponse
    {
        private List<APIErrorType> _errors = AWSConfigs.InitializeCollections ? new List<APIErrorType>() : null;
        private string _nextToken;
        private List<SecretValueEntry> _secretValues = AWSConfigs.InitializeCollections ? new List<SecretValueEntry>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors Secrets Manager encountered while attempting to retrieve individual
        /// secrets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<APIErrorType> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Secrets Manager includes this value if there's more output available than what is
        /// included in the current response. This can occur even when the response includes no
        /// values at all, such as when you ask for a filtered view of a long list. To get the
        /// next results, call <c>BatchGetSecretValue</c> again with this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecretValues. 
        /// <para>
        /// A list of secret values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecretValueEntry> SecretValues
        {
            get { return this._secretValues; }
            set { this._secretValues = value; }
        }

        // Check to see if SecretValues property is set
        internal bool IsSetSecretValues()
        {
            return this._secretValues != null && (this._secretValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}