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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRecommender operation.
    /// Updates the properties of an existing recommender, allowing you to modify its configuration
    /// and description.
    /// </summary>
    public partial class UpdateRecommenderRequest : AmazonCustomerProfilesRequest
    {
        private string _description;
        private string _domainName;
        private RecommenderConfig _recommenderConfig;
        private string _recommenderName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description to assign to the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The new configuration settings to apply to the recommender, including updated parameters
        /// and settings that define its behavior.
        /// </para>
        /// </summary>
        public RecommenderConfig RecommenderConfig
        {
            get { return this._recommenderConfig; }
            set { this._recommenderConfig = value; }
        }

        // Check to see if RecommenderConfig property is set
        internal bool IsSetRecommenderConfig()
        {
            return this._recommenderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderName. 
        /// <para>
        /// The name of the recommender to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RecommenderName
        {
            get { return this._recommenderName; }
            set { this._recommenderName = value; }
        }

        // Check to see if RecommenderName property is set
        internal bool IsSetRecommenderName()
        {
            return this._recommenderName != null;
        }

    }
}