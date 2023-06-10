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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the ListRotations operation.
    /// Retrieves a list of on-call rotations.
    /// </summary>
    public partial class ListRotationsRequest : AmazonSSMContactsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _rotationNamePrefix;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. Use this token to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property RotationNamePrefix. 
        /// <para>
        /// A filter to include rotations in list results based on their common prefix. For example,
        /// entering prod returns a list of all rotation names that begin with <code>prod</code>,
        /// such as <code>production</code> and <code>prod-1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RotationNamePrefix
        {
            get { return this._rotationNamePrefix; }
            set { this._rotationNamePrefix = value; }
        }

        // Check to see if RotationNamePrefix property is set
        internal bool IsSetRotationNamePrefix()
        {
            return this._rotationNamePrefix != null;
        }

    }
}