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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkInsightsAccessScopeAnalysis operation.
    /// Deletes the specified Network Access Scope analysis.
    /// </summary>
    public partial class DeleteNetworkInsightsAccessScopeAnalysisRequest : AmazonEC2Request
    {
        private string _networkInsightsAccessScopeAnalysisId;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisId. 
        /// <para>
        /// The ID of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInsightsAccessScopeAnalysisId
        {
            get { return this._networkInsightsAccessScopeAnalysisId; }
            set { this._networkInsightsAccessScopeAnalysisId = value; }
        }

        // Check to see if NetworkInsightsAccessScopeAnalysisId property is set
        internal bool IsSetNetworkInsightsAccessScopeAnalysisId()
        {
            return this._networkInsightsAccessScopeAnalysisId != null;
        }

    }
}