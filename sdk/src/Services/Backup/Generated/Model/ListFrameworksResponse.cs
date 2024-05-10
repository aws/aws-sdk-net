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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the ListFrameworks operation.
    /// </summary>
    public partial class ListFrameworksResponse : AmazonWebServiceResponse
    {
        private List<Framework> _frameworks = AWSConfigs.InitializeCollections ? new List<Framework>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Frameworks. 
        /// <para>
        /// A list of frameworks with details for each framework, including the framework name,
        /// Amazon Resource Name (ARN), description, number of controls, creation time, and deployment
        /// status.
        /// </para>
        /// </summary>
        public List<Framework> Frameworks
        {
            get { return this._frameworks; }
            set { this._frameworks = value; }
        }

        // Check to see if Frameworks property is set
        internal bool IsSetFrameworks()
        {
            return this._frameworks != null && (this._frameworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
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

    }
}