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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// This is the response object from the ListWorkgroups operation.
    /// </summary>
    public partial class ListWorkgroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Workgroup> _workgroups = AWSConfigs.InitializeCollections ? new List<Workgroup>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. To retrieve the next page, make the call
        /// again using the returned token.
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
        /// Gets and sets the property Workgroups. 
        /// <para>
        /// The returned array of workgroups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Workgroup> Workgroups
        {
            get { return this._workgroups; }
            set { this._workgroups = value; }
        }

        // Check to see if Workgroups property is set
        internal bool IsSetWorkgroups()
        {
            return this._workgroups != null && (this._workgroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}