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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeStorageSystemResources operation.
    /// </summary>
    public partial class DescribeStorageSystemResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private ResourceDetails _resourceDetails;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The opaque string that indicates the position to begin the next list of results in
        /// the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65535)]
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
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// The information collected about your storage system's resources. A response can also
        /// include Amazon Web Services storage service recommendations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-findings.html">storage
        /// resource information</a> collected by and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">recommendations</a>
        /// provided by DataSync Discovery.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

    }
}