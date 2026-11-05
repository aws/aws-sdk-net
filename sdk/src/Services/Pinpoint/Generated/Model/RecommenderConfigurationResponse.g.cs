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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about Amazon Pinpoint configuration settings for retrieving and
    /// processing data from a recommender model.
    /// </summary>
    public partial class RecommenderConfigurationResponse
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map that defines 1-10 custom endpoint or user attributes, depending on the value
        /// for the RecommendationProviderIdType property. Each of these attributes temporarily
        /// stores a recommended item that's retrieved from the recommender model and sent to
        /// an AWS Lambda function for additional processing. Each attribute can be used as a
        /// message variable in a message template.
        /// </para>
        ///  
        /// <para>
        /// This value is null if the configuration doesn't invoke an AWS Lambda function (RecommendationTransformerUri)
        /// to perform additional processing of recommendation data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in extended ISO 8601 format, when the configuration was created for the
        /// recommender model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the configuration for the recommender model.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the recommender model configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in extended ISO 8601 format, when the configuration for the recommender
        /// model was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name of the configuration for the recommender model.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecommendationProviderIdType. 
        /// <para>
        /// The type of Amazon Pinpoint ID that's associated with unique user IDs in the recommender
        /// model. This value enables the model to use attribute and event data that’s specific
        /// to a particular endpoint or user in an Amazon Pinpoint application. Possible values
        /// are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// PINPOINT_ENDPOINT_ID - Each user in the model is associated with a particular endpoint
        /// in Amazon Pinpoint. The data is correlated based on endpoint IDs in Amazon Pinpoint.
        /// This is the default value.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PINPOINT_USER_ID - Each user in the model is associated with a particular user and
        /// endpoint in Amazon Pinpoint. The data is correlated based on user IDs in Amazon Pinpoint.
        /// If this value is specified, an endpoint definition in Amazon Pinpoint has to specify
        /// both a user ID (UserId) and an endpoint ID. Otherwise, messages won’t be sent to the
        /// user's endpoint.
        /// </para>
        /// </li></ul>
        /// </summary>
        public string RecommendationProviderIdType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationProviderIdType property is set.
        /// </summary>
        internal bool IsSetRecommendationProviderIdType() => this.RecommendationProviderIdType != null;

        /// <summary>
        /// Gets and sets the property RecommendationProviderRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorizes Amazon Pinpoint to retrieve recommendation data from the recommender
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecommendationProviderRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationProviderRoleArn property is set.
        /// </summary>
        internal bool IsSetRecommendationProviderRoleArn() => this.RecommendationProviderRoleArn != null;

        /// <summary>
        /// Gets and sets the property RecommendationProviderUri. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender model that Amazon Pinpoint retrieves
        /// the recommendation data from. This value is the ARN of an Amazon Personalize campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecommendationProviderUri { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationProviderUri property is set.
        /// </summary>
        internal bool IsSetRecommendationProviderUri() => this.RecommendationProviderUri != null;

        /// <summary>
        /// Gets and sets the property RecommendationTransformerUri. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AWS Lambda function that Amazon Pinpoint
        /// invokes to perform additional processing of recommendation data that it retrieves
        /// from the recommender model.
        /// </para>
        /// </summary>
        public string RecommendationTransformerUri { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationTransformerUri property is set.
        /// </summary>
        internal bool IsSetRecommendationTransformerUri() => this.RecommendationTransformerUri != null;

        /// <summary>
        /// Gets and sets the property RecommendationsDisplayName. 
        /// <para>
        /// The custom display name for the standard endpoint or user attribute (RecommendationItems)
        /// that temporarily stores recommended items for each endpoint or user, depending on
        /// the value for the RecommendationProviderIdType property. This name appears in the
        /// <b>Attribute finder</b> of the template editor on the Amazon Pinpoint console.
        /// </para>
        ///  
        /// <para>
        /// This value is null if the configuration doesn't invoke an AWS Lambda function (RecommendationTransformerUri)
        /// to perform additional processing of recommendation data.
        /// </para>
        /// </summary>
        public string RecommendationsDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationsDisplayName property is set.
        /// </summary>
        internal bool IsSetRecommendationsDisplayName() => this.RecommendationsDisplayName != null;

        /// <summary>
        /// Gets and sets the property RecommendationsPerMessage. 
        /// <para>
        /// The number of recommended items that are retrieved from the model for each endpoint
        /// or user, depending on the value for the RecommendationProviderIdType property. This
        /// number determines how many recommended items are available for use in message variables.
        /// </para>
        /// </summary>
        public int? RecommendationsPerMessage { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationsPerMessage property is set.
        /// </summary>
        internal bool IsSetRecommendationsPerMessage() => this.RecommendationsPerMessage.HasValue;
    }
}
