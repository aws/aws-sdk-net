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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRecommendationTemplate operation.
    /// Deletes a recommendation template. This is a destructive action that can't be undone.
    /// </summary>
    public partial class DeleteRecommendationTemplateRequest : AmazonResilienceHubRequest
    {
        private string _clientToken;
        private string _recommendationTemplateArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for an idempotency token. A client token is a unique, case-sensitive string of
        /// up to 64 ASCII characters. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property RecommendationTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationTemplateArn
        {
            get { return this._recommendationTemplateArn; }
            set { this._recommendationTemplateArn = value; }
        }

        // Check to see if RecommendationTemplateArn property is set
        internal bool IsSetRecommendationTemplateArn()
        {
            return this._recommendationTemplateArn != null;
        }

    }
}