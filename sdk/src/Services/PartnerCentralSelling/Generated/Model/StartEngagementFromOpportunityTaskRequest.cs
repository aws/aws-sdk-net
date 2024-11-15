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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the StartEngagementFromOpportunityTask operation.
    /// This action initiates the engagement process from an existing opportunity by accepting
    /// the engagement invitation and creating a corresponding opportunity in the partner’s
    /// system. Similar to <c>StartEngagementByAcceptingInvitationTask</c>, this action is
    /// asynchronous and performs multiple steps before completion.
    /// </summary>
    public partial class StartEngagementFromOpportunityTaskRequest : AmazonPartnerCentralSellingRequest
    {
        private AwsSubmission _awsSubmission;
        private string _catalog;
        private string _clientToken;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property AwsSubmission.
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsSubmission AwsSubmission
        {
            get { return this._awsSubmission; }
            set { this._awsSubmission = value; }
        }

        // Check to see if AwsSubmission property is set
        internal bool IsSetAwsSubmission()
        {
            return this._awsSubmission != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the engagement is tracked. Acceptable values include
        /// <c>AWS</c> for production and <c>Sandbox</c> for testing environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token provided by the client to help ensure the idempotency of the request.
        /// It helps prevent the same task from being performed multiple times.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the opportunity from which the engagement task is to be initiated.
        /// This helps ensure that the task is applied to the correct opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}