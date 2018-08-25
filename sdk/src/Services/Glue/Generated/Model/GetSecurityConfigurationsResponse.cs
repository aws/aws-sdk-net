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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetSecurityConfigurations operation.
    /// </summary>
    public partial class GetSecurityConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SecurityConfiguration> _securityConfigurations = new List<SecurityConfiguration>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if there are more security configurations to return.
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
        /// Gets and sets the property SecurityConfigurations. 
        /// <para>
        /// A list of security configurations.
        /// </para>
        /// </summary>
        public List<SecurityConfiguration> SecurityConfigurations
        {
            get { return this._securityConfigurations; }
            set { this._securityConfigurations = value; }
        }

        // Check to see if SecurityConfigurations property is set
        internal bool IsSetSecurityConfigurations()
        {
            return this._securityConfigurations != null && this._securityConfigurations.Count > 0; 
        }

    }
}