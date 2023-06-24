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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// This is the response object from the ListOutpostsWithS3 operation.
    /// </summary>
    public partial class ListOutpostsWithS3Response : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Outpost> _outposts = new List<Outpost>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Returns a token that you can use to call <code>ListOutpostsWithS3</code> again and
        /// receive additional results, if there are any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Outposts. 
        /// <para>
        /// Returns the list of Outposts that have the following characteristics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// outposts that have S3 provisioned
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// outposts that are <code>Active</code> (not pending any provisioning nor decommissioned)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// outposts to which the the calling Amazon Web Services account has access
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Outpost> Outposts
        {
            get { return this._outposts; }
            set { this._outposts = value; }
        }

        // Check to see if Outposts property is set
        internal bool IsSetOutposts()
        {
            return this._outposts != null && this._outposts.Count > 0; 
        }

    }
}