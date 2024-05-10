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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountPreferences operation.
    /// </summary>
    public partial class DescribeAccountPreferencesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private ResourceIdPreference _resourceIdPreference;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Present if there are more records than returned in the response. You can use the <c>NextToken</c>
        /// in the subsequent request to fetch the additional descriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ResourceIdPreference. 
        /// <para>
        /// Describes the resource ID preference setting for the Amazon Web Services account associated
        /// with the user making the request, in the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public ResourceIdPreference ResourceIdPreference
        {
            get { return this._resourceIdPreference; }
            set { this._resourceIdPreference = value; }
        }

        // Check to see if ResourceIdPreference property is set
        internal bool IsSetResourceIdPreference()
        {
            return this._resourceIdPreference != null;
        }

    }
}