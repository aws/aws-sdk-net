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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Recommendations to rightsize resources.
    /// </summary>
    public partial class RightsizingRecommendation
    {
        private string _accountId;
        private CurrentInstance _currentInstance;
        private List<string> _findingReasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ModifyRecommendationDetail _modifyRecommendationDetail;
        private RightsizingType _rightsizingType;
        private TerminateRecommendationDetail _terminateRecommendationDetail;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that this recommendation is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentInstance. 
        /// <para>
        /// Context regarding the current instance.
        /// </para>
        /// </summary>
        public CurrentInstance CurrentInstance
        {
            get { return this._currentInstance; }
            set { this._currentInstance = value; }
        }

        // Check to see if CurrentInstance property is set
        internal bool IsSetCurrentInstance()
        {
            return this._currentInstance != null;
        }

        /// <summary>
        /// Gets and sets the property FindingReasonCodes. 
        /// <para>
        /// The list of possible reasons why the recommendation is generated, such as under- or
        /// over-utilization of specific metrics (for example, CPU, Memory, Network). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FindingReasonCodes
        {
            get { return this._findingReasonCodes; }
            set { this._findingReasonCodes = value; }
        }

        // Check to see if FindingReasonCodes property is set
        internal bool IsSetFindingReasonCodes()
        {
            return this._findingReasonCodes != null && (this._findingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModifyRecommendationDetail. 
        /// <para>
        /// The details for the modification recommendations. 
        /// </para>
        /// </summary>
        public ModifyRecommendationDetail ModifyRecommendationDetail
        {
            get { return this._modifyRecommendationDetail; }
            set { this._modifyRecommendationDetail = value; }
        }

        // Check to see if ModifyRecommendationDetail property is set
        internal bool IsSetModifyRecommendationDetail()
        {
            return this._modifyRecommendationDetail != null;
        }

        /// <summary>
        /// Gets and sets the property RightsizingType. 
        /// <para>
        /// A recommendation to either terminate or modify the resource.
        /// </para>
        /// </summary>
        public RightsizingType RightsizingType
        {
            get { return this._rightsizingType; }
            set { this._rightsizingType = value; }
        }

        // Check to see if RightsizingType property is set
        internal bool IsSetRightsizingType()
        {
            return this._rightsizingType != null;
        }

        /// <summary>
        /// Gets and sets the property TerminateRecommendationDetail. 
        /// <para>
        /// The details for termination recommendations.
        /// </para>
        /// </summary>
        public TerminateRecommendationDetail TerminateRecommendationDetail
        {
            get { return this._terminateRecommendationDetail; }
            set { this._terminateRecommendationDetail = value; }
        }

        // Check to see if TerminateRecommendationDetail property is set
        internal bool IsSetTerminateRecommendationDetail()
        {
            return this._terminateRecommendationDetail != null;
        }

    }
}