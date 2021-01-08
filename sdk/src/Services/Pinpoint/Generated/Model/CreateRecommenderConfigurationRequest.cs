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
    /// Container for the parameters to the CreateRecommenderConfiguration operation.
    /// Creates an Amazon Pinpoint configuration for a recommender model.
    /// </summary>
    public partial class CreateRecommenderConfigurationRequest : AmazonPinpointRequest
    {
        private CreateRecommenderConfiguration _createRecommenderConfiguration;

        /// <summary>
        /// Gets and sets the property CreateRecommenderConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public CreateRecommenderConfiguration CreateRecommenderConfiguration
        {
            get { return this._createRecommenderConfiguration; }
            set { this._createRecommenderConfiguration = value; }
        }

        // Check to see if CreateRecommenderConfiguration property is set
        internal bool IsSetCreateRecommenderConfiguration()
        {
            return this._createRecommenderConfiguration != null;
        }

    }
}