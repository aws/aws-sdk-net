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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AssociatedApplications. 
        /// <para>
        ///  The associated application group the server belongs to, as defined in AWS Application
        /// Discovery Service. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedApplication> AssociatedApplications { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedApplication>() : null;

        /// <summary>
        /// Checks to see if the AssociatedApplications property is set.
        /// </summary>
        internal bool IsSetAssociatedApplications() => this.AssociatedApplications != null && (this.AssociatedApplications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token you use to retrieve the next set of results, or null if there are no more
        /// results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServerDetail. 
        /// <para>
        ///  Detailed information about the server. 
        /// </para>
        /// </summary>
        public ServerDetail ServerDetail { get; set; }

        /// <summary>
        /// Checks to see if the ServerDetail property is set.
        /// </summary>
        internal bool IsSetServerDetail() => this.ServerDetail != null;
    }
}
