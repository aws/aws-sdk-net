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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ListTestGridSessionArtifacts operation.
    /// Retrieves a list of artifacts created during the session.
    /// </summary>
    public partial class ListTestGridSessionArtifactsRequest : AmazonDeviceFarmRequest
    {
        private int? _maxResult;
        private string _nextToken;
        private string _sessionArn;
        private TestGridSessionArtifactCategory _type;

        /// <summary>
        /// Gets and sets the property MaxResult. 
        /// <para>
        /// The maximum number of results to be returned by a request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResult
        {
            get { return this._maxResult.GetValueOrDefault(); }
            set { this._maxResult = value; }
        }

        // Check to see if MaxResult property is set
        internal bool IsSetMaxResult()
        {
            return this._maxResult.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The ARN of a <a>TestGridSession</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Limit results to a specified type of artifact.
        /// </para>
        /// </summary>
        public TestGridSessionArtifactCategory Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}