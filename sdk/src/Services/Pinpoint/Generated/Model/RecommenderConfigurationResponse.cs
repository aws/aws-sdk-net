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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _creationDate;
        private string _description;
        private string _id;
        private string _lastModifiedDate;
        private string _name;
        private string _recommendationProviderIdType;
        private string _recommendationProviderRoleArn;
        private string _recommendationProviderUri;
        private string _recommendationsDisplayName;
        private int? _recommendationsPerMessage;
        private string _recommendationTransformerUri;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in extended ISO 8601 format, when the configuration was created for the
        /// recommender model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the configuration for the recommender model.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the recommender model configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in extended ISO 8601 format, when the configuration for the recommender
        /// model was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name of the configuration for the recommender model.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        public string RecommendationProviderIdType
        {
            get { return this._recommendationProviderIdType; }
            set { this._recommendationProviderIdType = value; }
        }

        // Check to see if RecommendationProviderIdType property is set
        internal bool IsSetRecommendationProviderIdType()
        {
            return this._recommendationProviderIdType != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationProviderRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorizes Amazon Pinpoint to retrieve recommendation data from the recommender
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationProviderRoleArn
        {
            get { return this._recommendationProviderRoleArn; }
            set { this._recommendationProviderRoleArn = value; }
        }

        // Check to see if RecommendationProviderRoleArn property is set
        internal bool IsSetRecommendationProviderRoleArn()
        {
            return this._recommendationProviderRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationProviderUri. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender model that Amazon Pinpoint retrieves
        /// the recommendation data from. This value is the ARN of an Amazon Personalize campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationProviderUri
        {
            get { return this._recommendationProviderUri; }
            set { this._recommendationProviderUri = value; }
        }

        // Check to see if RecommendationProviderUri property is set
        internal bool IsSetRecommendationProviderUri()
        {
            return this._recommendationProviderUri != null;
        }

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
        public string RecommendationsDisplayName
        {
            get { return this._recommendationsDisplayName; }
            set { this._recommendationsDisplayName = value; }
        }

        // Check to see if RecommendationsDisplayName property is set
        internal bool IsSetRecommendationsDisplayName()
        {
            return this._recommendationsDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationsPerMessage. 
        /// <para>
        /// The number of recommended items that are retrieved from the model for each endpoint
        /// or user, depending on the value for the RecommendationProviderIdType property. This
        /// number determines how many recommended items are available for use in message variables.
        /// </para>
        /// </summary>
        public int? RecommendationsPerMessage
        {
            get { return this._recommendationsPerMessage; }
            set { this._recommendationsPerMessage = value; }
        }

        // Check to see if RecommendationsPerMessage property is set
        internal bool IsSetRecommendationsPerMessage()
        {
            return this._recommendationsPerMessage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationTransformerUri. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AWS Lambda function that Amazon Pinpoint
        /// invokes to perform additional processing of recommendation data that it retrieves
        /// from the recommender model.
        /// </para>
        /// </summary>
        public string RecommendationTransformerUri
        {
            get { return this._recommendationTransformerUri; }
            set { this._recommendationTransformerUri = value; }
        }

        // Check to see if RecommendationTransformerUri property is set
        internal bool IsSetRecommendationTransformerUri()
        {
            return this._recommendationTransformerUri != null;
        }

    }
}