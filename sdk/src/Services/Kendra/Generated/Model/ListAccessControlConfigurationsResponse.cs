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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the ListAccessControlConfigurations operation.
    /// </summary>
    public partial class ListAccessControlConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<AccessControlConfigurationSummary> _accessControlConfigurations = AWSConfigs.InitializeCollections ? new List<AccessControlConfigurationSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccessControlConfigurations. 
        /// <para>
        /// The details of your access control configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AccessControlConfigurationSummary> AccessControlConfigurations
        {
            get { return this._accessControlConfigurations; }
            set { this._accessControlConfigurations = value; }
        }

        // Check to see if AccessControlConfigurations property is set
        internal bool IsSetAccessControlConfigurations()
        {
            return this._accessControlConfigurations != null && (this._accessControlConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Kendra returns this token, which you can use
        /// in the subsequent request to retrieve the next set of access control configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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