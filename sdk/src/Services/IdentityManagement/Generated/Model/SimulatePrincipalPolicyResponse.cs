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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>
    /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
    /// request.
    /// </summary>
    public partial class SimulatePrincipalPolicyResponse : AmazonWebServiceResponse
    {
        private List<EvaluationResult> _evaluationResults = AWSConfigs.InitializeCollections ? new List<EvaluationResult>() : null;
        private bool? _isTruncated;
        private string _marker;

        /// <summary>
        /// Gets and sets the property EvaluationResults. 
        /// <para>
        /// The results of the simulation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationResult> EvaluationResults
        {
            get { return this._evaluationResults; }
            set { this._evaluationResults = value; }
        }

        // Check to see if EvaluationResults property is set
        internal bool IsSetEvaluationResults()
        {
            return this._evaluationResults != null && (this._evaluationResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more items to return. If your results were
        /// truncated, you can make a subsequent pagination request using the <c>Marker</c> request
        /// parameter to retrieve more items. Note that IAM might return fewer than the <c>MaxItems</c>
        /// number of results even when there are more results available. We recommend that you
        /// check <c>IsTruncated</c> after every call to ensure that you receive all your results.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// When <c>IsTruncated</c> is <c>true</c>, this element is present and contains the value
        /// to use for the <c>Marker</c> parameter in a subsequent pagination request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}