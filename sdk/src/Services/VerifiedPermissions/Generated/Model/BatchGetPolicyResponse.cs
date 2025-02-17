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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the BatchGetPolicy operation.
    /// </summary>
    public partial class BatchGetPolicyResponse : AmazonWebServiceResponse
    {
        private List<BatchGetPolicyErrorItem> _errors = AWSConfigs.InitializeCollections ? new List<BatchGetPolicyErrorItem>() : null;
        private List<BatchGetPolicyOutputItem> _results = AWSConfigs.InitializeCollections ? new List<BatchGetPolicyOutputItem>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Information about the policies from the request that resulted in an error. These results
        /// are returned in the order they were requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetPolicyErrorItem> Errors
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
        /// Gets and sets the property Results. 
        /// <para>
        /// Information about the policies listed in the request that were successfully returned.
        /// These results are returned in the order they were requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetPolicyOutputItem> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && (this._results.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}