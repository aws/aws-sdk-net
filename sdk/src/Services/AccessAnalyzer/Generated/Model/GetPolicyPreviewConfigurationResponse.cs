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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the GetPolicyPreviewConfiguration operation.
    /// </summary>
    public partial class GetPolicyPreviewConfigurationResponse : AmazonWebServiceResponse
    {
        private List<PolicyPreviewConfiguration> _policyPreviewConfigurations = AWSConfigs.InitializeCollections ? new List<PolicyPreviewConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property PolicyPreviewConfigurations. 
        /// <para>
        /// A list of policy preview configurations for the account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyPreviewConfiguration> PolicyPreviewConfigurations
        {
            get { return this._policyPreviewConfigurations; }
            set { this._policyPreviewConfigurations = value; }
        }

        // Check to see if PolicyPreviewConfigurations property is set
        internal bool IsSetPolicyPreviewConfigurations()
        {
            return this._policyPreviewConfigurations != null && (this._policyPreviewConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}