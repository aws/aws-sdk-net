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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// This is the response object from the GetServerDetails operation.
    /// </summary>
    public partial class GetServerDetailsResponse : AmazonWebServiceResponse
    {
        private List<AssociatedApplication> _associatedApplications = AWSConfigs.InitializeCollections ? new List<AssociatedApplication>() : null;
        private string _nextToken;
        private ServerDetail _serverDetail;

        /// <summary>
        /// Gets and sets the property AssociatedApplications. 
        /// <para>
        ///  The associated application group the server belongs to, as defined in AWS Application
        /// Discovery Service. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedApplication> AssociatedApplications
        {
            get { return this._associatedApplications; }
            set { this._associatedApplications = value; }
        }

        // Check to see if AssociatedApplications property is set
        internal bool IsSetAssociatedApplications()
        {
            return this._associatedApplications != null && (this._associatedApplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token you use to retrieve the next set of results, or null if there are no more
        /// results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ServerDetail. 
        /// <para>
        ///  Detailed information about the server. 
        /// </para>
        /// </summary>
        public ServerDetail ServerDetail
        {
            get { return this._serverDetail; }
            set { this._serverDetail = value; }
        }

        // Check to see if ServerDetail property is set
        internal bool IsSetServerDetail()
        {
            return this._serverDetail != null;
        }

    }
}