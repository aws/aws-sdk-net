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
    /// Container for the parameters to the CreateEngagement operation.
    /// The <c>CreateEngagement</c> action allows you to create an <c>Engagement</c>, which
    /// serves as a collaborative space between different parties such as AWS Partners and
    /// AWS Sellers. This action automatically adds the caller's AWS account as an active
    /// member of the newly created <c>Engagement</c>.
    /// </summary>
    public partial class CreateEngagementRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _clientToken;
        private List<EngagementContextDetails> _contexts = AWSConfigs.InitializeCollections ? new List<EngagementContextDetails>() : null;
        private string _description;
        private string _title;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The <c>CreateEngagementRequest$Catalog</c> parameter specifies the catalog related
        /// to the engagement. Accepted values are <c>AWS</c> and <c>Sandbox</c>, which determine
        /// the environment in which the engagement is managed.
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
        /// The <c>CreateEngagementRequest$ClientToken</c> parameter specifies a unique, case-sensitive
        /// identifier to ensure that the request is handled exactly once. The value must not
        /// exceed sixty-four alphanumeric characters.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Contexts. 
        /// <para>
        /// The <c>Contexts</c> field is a required array of objects, with a maximum of 5 contexts
        /// allowed, specifying detailed information about customer projects associated with the
        /// Engagement. Each context object contains a <c>Type</c> field indicating the context
        /// type, which must be <c>CustomerProject</c> in this version, and a <c>Payload</c> field
        /// containing the <c>CustomerProject</c> details. The <c>CustomerProject</c> object is
        /// composed of two main components: <c>Customer</c> and <c>Project</c>. The <c>Customer</c>
        /// object includes information such as <c>CompanyName</c>, <c>WebsiteUrl</c>, <c>Industry</c>,
        /// and <c>CountryCode</c>, providing essential details about the customer. The <c>Project</c>
        /// object contains <c>Title</c>, <c>BusinessProblem</c>, and <c>TargetCompletionDate</c>,
        /// offering insights into the specific project associated with the customer. This structure
        /// allows comprehensive context to be included within the Engagement, facilitating effective
        /// collaboration between parties by providing relevant customer and project information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<EngagementContextDetails> Contexts
        {
            get { return this._contexts; }
            set { this._contexts = value; }
        }

        // Check to see if Contexts property is set
        internal bool IsSetContexts()
        {
            return this._contexts != null && (this._contexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Provides a description of the <c>Engagement</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Specifies the title of the <c>Engagement</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}