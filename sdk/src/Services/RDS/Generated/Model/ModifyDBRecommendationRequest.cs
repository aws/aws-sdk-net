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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBRecommendation operation.
    /// Updates the recommendation status and recommended action status for the specified
    /// recommendation.
    /// </summary>
    public partial class ModifyDBRecommendationRequest : AmazonRDSRequest
    {
        private string _locale;
        private string _recommendationId;
        private List<RecommendedActionUpdate> _recommendedActionUpdates = AWSConfigs.InitializeCollections ? new List<RecommendedActionUpdate>() : null;
        private string _status;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The language of the modified recommendation.
        /// </para>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The identifier of the recommendation to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionUpdates. 
        /// <para>
        /// The list of recommended action status to update. You can update multiple recommended
        /// actions at one time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedActionUpdate> RecommendedActionUpdates
        {
            get { return this._recommendedActionUpdates; }
            set { this._recommendedActionUpdates = value; }
        }

        // Check to see if RecommendedActionUpdates property is set
        internal bool IsSetRecommendedActionUpdates()
        {
            return this._recommendedActionUpdates != null && (this._recommendedActionUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The recommendation status to update.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// active
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dismissed
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}