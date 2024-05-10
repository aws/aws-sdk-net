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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the ListResourceProfileArtifacts operation.
    /// </summary>
    public partial class ListResourceProfileArtifactsResponse : AmazonWebServiceResponse
    {
        private List<ResourceProfileArtifact> _artifacts = AWSConfigs.InitializeCollections ? new List<ResourceProfileArtifact>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// An array of objects, one for each of 1-100 S3 objects that Amazon Macie selected for
        /// analysis.
        /// </para>
        ///  
        /// <para>
        /// If Macie has analyzed more than 100 objects in the bucket, Macie populates the array
        /// based on the value for the ResourceProfileArtifact.sensitive field for an object:
        /// true (sensitive), followed by false (not sensitive). Macie then populates any remaining
        /// items in the array with information about objects where the value for the ResourceProfileArtifact.classificationResultStatus
        /// field is SKIPPED.
        /// </para>
        /// </summary>
        public List<ResourceProfileArtifact> Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null && (this._artifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string to use in a subsequent request to get the next page of results in a paginated
        /// response. This value is null if there are no additional pages.
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