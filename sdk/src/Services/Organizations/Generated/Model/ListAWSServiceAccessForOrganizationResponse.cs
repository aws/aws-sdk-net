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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the ListAWSServiceAccessForOrganization operation.
    /// </summary>
    public partial class ListAWSServiceAccessForOrganizationResponse : AmazonWebServiceResponse
    {
        private List<EnabledServicePrincipal> _enabledServicePrincipals = AWSConfigs.InitializeCollections ? new List<EnabledServicePrincipal>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EnabledServicePrincipals. 
        /// <para>
        /// A list of the service principals for the services that are enabled to integrate with
        /// your organization. Each principal is a structure that includes the name and the date
        /// that it was enabled for integration with Organizations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledServicePrincipal> EnabledServicePrincipals
        {
            get { return this._enabledServicePrincipals; }
            set { this._enabledServicePrincipals = value; }
        }

        // Check to see if EnabledServicePrincipals property is set
        internal bool IsSetEnabledServicePrincipals()
        {
            return this._enabledServicePrincipals != null && (this._enabledServicePrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <c>NextToken</c> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <c>NextToken</c> response element comes back as <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100000)]
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