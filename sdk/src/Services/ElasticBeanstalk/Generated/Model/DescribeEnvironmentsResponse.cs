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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Result message containing a list of environment descriptions.
    /// </summary>
    public partial class DescribeEnvironmentsResponse : AmazonWebServiceResponse
    {
        private List<EnvironmentDescription> _environments = new List<EnvironmentDescription>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        ///  Returns an <a>EnvironmentDescription</a> list. 
        /// </para>
        /// </summary>
        public List<EnvironmentDescription> Environments
        {
            get { return this._environments; }
            set { this._environments = value; }
        }

        // Check to see if Environments property is set
        internal bool IsSetEnvironments()
        {
            return this._environments != null && this._environments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// In a paginated request, the token that you can pass in a subsequent request to get
        /// the next response page.
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