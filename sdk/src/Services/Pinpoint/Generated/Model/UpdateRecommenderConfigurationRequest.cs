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
    /// Container for the parameters to the UpdateRecommenderConfiguration operation.
    /// Updates an Amazon Pinpoint configuration for a recommender model.
    /// </summary>
    public partial class UpdateRecommenderConfigurationRequest : AmazonPinpointRequest
    {
        private string _recommenderId;
        private UpdateRecommenderConfiguration _updateRecommenderConfiguration;

        /// <summary>
        /// Gets and sets the property RecommenderId. 
        /// <para>
        /// The unique identifier for the recommender model configuration. This identifier is
        /// displayed as the <b>Recommender ID</b> on the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommenderId
        {
            get { return this._recommenderId; }
            set { this._recommenderId = value; }
        }

        // Check to see if RecommenderId property is set
        internal bool IsSetRecommenderId()
        {
            return this._recommenderId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateRecommenderConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateRecommenderConfiguration UpdateRecommenderConfiguration
        {
            get { return this._updateRecommenderConfiguration; }
            set { this._updateRecommenderConfiguration = value; }
        }

        // Check to see if UpdateRecommenderConfiguration property is set
        internal bool IsSetUpdateRecommenderConfiguration()
        {
            return this._updateRecommenderConfiguration != null;
        }

    }
}