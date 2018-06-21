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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// This is the response object from the ListS3Resources operation.
    /// </summary>
    public partial class ListS3ResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<S3ResourceClassification> _s3Resources = new List<S3ResourceClassification>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When a response is generated, if there is more data to be listed, this parameter is
        /// present in the response and contains the value to use for the nextToken parameter
        /// in a subsequent pagination request. If there is no more data to be listed, this parameter
        /// is set to null. 
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

        /// <summary>
        /// Gets and sets the property S3Resources. 
        /// <para>
        /// A list of the associated S3 resources returned by the action.
        /// </para>
        /// </summary>
        public List<S3ResourceClassification> S3Resources
        {
            get { return this._s3Resources; }
            set { this._s3Resources = value; }
        }

        // Check to see if S3Resources property is set
        internal bool IsSetS3Resources()
        {
            return this._s3Resources != null && this._s3Resources.Count > 0; 
        }

    }
}