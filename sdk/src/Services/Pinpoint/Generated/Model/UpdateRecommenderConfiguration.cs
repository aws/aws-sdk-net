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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies Amazon Pinpoint configuration settings for retrieving and processing recommendation
    /// data from a recommender model.
    /// </summary>
    public partial class UpdateRecommenderConfiguration
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _description;
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
        /// A map of key-value pairs that defines 1-10 custom endpoint or user attributes, depending
        /// on the value for the RecommendationProviderIdType property. Each of these attributes
        /// temporarily stores a recommended item that's retrieved from the recommender model
        /// and sent to an AWS Lambda function for additional processing. Each attribute can be
        /// used as a message variable in a message template.
        /// </para>
        ///  
        /// <para>
        /// In the map, the key is the name of a custom attribute and the value is a custom display
        /// name for that attribute. The display name appears in the <b>Attribute finder</b> of
        /// the template editor on the Amazon Pinpoint console. The following restrictions apply
        /// to these names:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// An attribute name must start with a letter or number and it can contain up to 50 characters.
        /// The characters can be letters, numbers, underscores (_), or hyphens (-). Attribute
        /// names are case sensitive and must be unique.
        /// </para>
        /// </li> <li>
        /// <para>
        /// An attribute display name must start with a letter or number and it can contain up
        /// to 25 characters. The characters can be letters, numbers, spaces, underscores (_),
        /// or hyphens (-).
        /// </para>
        /// </li></ul> 
        /// <para>
        /// This object is required if the configuration invokes an AWS Lambda function (RecommendationTransformerUri)
        /// to process recommendation data. Otherwise, don't include this object in your request.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the configuration for the recommender model. The description
        /// can contain up to 128 characters. The characters can be letters, numbers, spaces,
        /// or the following symbols: _ ; () , ‐.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name of the configuration for the recommender model. The name must start
        /// with a letter or number and it can contain up to 128 characters. The characters can
        /// be letters, numbers, spaces, underscores (_), or hyphens (-).
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
        /// The type of Amazon Pinpoint ID to associate with unique user IDs in the recommender
        /// model. This value enables the model to use attribute and event data that’s specific
        /// to a particular endpoint or user in an Amazon Pinpoint application. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// PINPOINT_ENDPOINT_ID - Associate each user in the model with a particular endpoint
        /// in Amazon Pinpoint. The data is correlated based on endpoint IDs in Amazon Pinpoint.
        /// This is the default value.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PINPOINT_USER_ID - Associate each user in the model with a particular user and endpoint
        /// in Amazon Pinpoint. The data is correlated based on user IDs in Amazon Pinpoint. If
        /// you specify this value, an endpoint definition in Amazon Pinpoint has to specify both
        /// a user ID (UserId) and an endpoint ID. Otherwise, messages won’t be sent to the user's
        /// endpoint.
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
        /// The Amazon Resource Name (ARN) of the recommender model to retrieve recommendation
        /// data from. This value must match the ARN of an Amazon Personalize campaign.
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
        /// A custom display name for the standard endpoint or user attribute (RecommendationItems)
        /// that temporarily stores recommended items for each endpoint or user, depending on
        /// the value for the RecommendationProviderIdType property. This value is required if
        /// the configuration doesn't invoke an AWS Lambda function (RecommendationTransformerUri)
        /// to perform additional processing of recommendation data.
        /// </para>
        ///  
        /// <para>
        /// This name appears in the <b>Attribute finder</b> of the template editor on the Amazon
        /// Pinpoint console. The name can contain up to 25 characters. The characters can be
        /// letters, numbers, spaces, underscores (_), or hyphens (-). These restrictions don't
        /// apply to attribute values.
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
        /// The number of recommended items to retrieve from the model for each endpoint or user,
        /// depending on the value for the RecommendationProviderIdType property. This number
        /// determines how many recommended items are available for use in message variables.
        /// The minimum value is 1. The maximum value is 5. The default value is 5.
        /// </para>
        ///  
        /// <para>
        /// To use multiple recommended items and custom attributes with message variables, you
        /// have to use an AWS Lambda function (RecommendationTransformerUri) to perform additional
        /// processing of recommendation data.
        /// </para>
        /// </summary>
        public int RecommendationsPerMessage
        {
            get { return this._recommendationsPerMessage.GetValueOrDefault(); }
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
        /// The name or Amazon Resource Name (ARN) of the AWS Lambda function to invoke for additional
        /// processing of recommendation data that's retrieved from the recommender model.
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