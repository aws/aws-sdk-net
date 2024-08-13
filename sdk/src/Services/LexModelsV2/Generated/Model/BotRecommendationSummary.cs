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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// A summary of the bot recommendation.
    /// </summary>
    public partial class BotRecommendationSummary
    {
        private string _botRecommendationId;
        private BotRecommendationStatus _botRecommendationStatus;
        private DateTime? _creationDateTime;
        private DateTime? _lastUpdatedDateTime;

        /// <summary>
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        /// The unique identifier of the bot recommendation to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotRecommendationId
        {
            get { return this._botRecommendationId; }
            set { this._botRecommendationId = value; }
        }

        // Check to see if BotRecommendationId property is set
        internal bool IsSetBotRecommendationId()
        {
            return this._botRecommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property BotRecommendationStatus. 
        /// <para>
        /// The status of the bot recommendation.
        /// </para>
        ///  
        /// <para>
        /// If the status is Failed, then the reasons for the failure are listed in the failureReasons
        /// field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BotRecommendationStatus BotRecommendationStatus
        {
            get { return this._botRecommendationStatus; }
            set { this._botRecommendationStatus = value; }
        }

        // Check to see if BotRecommendationStatus property is set
        internal bool IsSetBotRecommendationStatus()
        {
            return this._botRecommendationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot recommendation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot recommendation was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

    }
}