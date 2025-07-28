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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeComputationModelExecutionSummary operation.
    /// </summary>
    public partial class DescribeComputationModelExecutionSummaryResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _computationModelExecutionSummary = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _computationModelId;
        private ResolveTo _resolveTo;

        /// <summary>
        /// Gets and sets the property ComputationModelExecutionSummary. 
        /// <para>
        /// Contains the execution summary of the computation model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ComputationModelExecutionSummary
        {
            get { return this._computationModelExecutionSummary; }
            set { this._computationModelExecutionSummary = value; }
        }

        // Check to see if ComputationModelExecutionSummary property is set
        internal bool IsSetComputationModelExecutionSummary()
        {
            return this._computationModelExecutionSummary != null && (this._computationModelExecutionSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputationModelId. 
        /// <para>
        /// The ID of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ComputationModelId
        {
            get { return this._computationModelId; }
            set { this._computationModelId = value; }
        }

        // Check to see if ComputationModelId property is set
        internal bool IsSetComputationModelId()
        {
            return this._computationModelId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolveTo. 
        /// <para>
        /// The detailed resource this execution summary resolves to.
        /// </para>
        /// </summary>
        public ResolveTo ResolveTo
        {
            get { return this._resolveTo; }
            set { this._resolveTo = value; }
        }

        // Check to see if ResolveTo property is set
        internal bool IsSetResolveTo()
        {
            return this._resolveTo != null;
        }

    }
}