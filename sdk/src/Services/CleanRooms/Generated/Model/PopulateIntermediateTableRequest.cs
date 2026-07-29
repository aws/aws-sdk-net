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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the PopulateIntermediateTable operation.
    /// Executes the stored query of an intermediate table to materialize data into managed
    /// storage. With this operation, you can perform initial population and subsequent refreshes.
    /// Each call creates a new version. The returned analysis ID can be tracked using <c>GetProtectedQuery</c>.
    /// Only the intermediate table owner can call this operation.
    /// </summary>
    public partial class PopulateIntermediateTableRequest : AmazonCleanRoomsRequest
    {
        private string _analysisPayerAccountId;
        private IntermediateTableComputeConfiguration _computeConfiguration;
        private string _intermediateTableIdentifier;
        private string _membershipIdentifier;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AnalysisPayerAccountId. 
        /// <para>
        /// The account ID of the member that pays for the analysis compute costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AnalysisPayerAccountId
        {
            get { return this._analysisPayerAccountId; }
            set { this._analysisPayerAccountId = value; }
        }

        // Check to see if AnalysisPayerAccountId property is set
        internal bool IsSetAnalysisPayerAccountId()
        {
            return this._analysisPayerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the population query execution.
        /// </para>
        /// </summary>
        public IntermediateTableComputeConfiguration ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IntermediateTableIdentifier. 
        /// <para>
        /// The unique identifier of the intermediate table to populate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IntermediateTableIdentifier
        {
            get { return this._intermediateTableIdentifier; }
            set { this._intermediateTableIdentifier = value; }
        }

        // Check to see if IntermediateTableIdentifier property is set
        internal bool IsSetIntermediateTableIdentifier()
        {
            return this._intermediateTableIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The runtime parameter values that override the defaults in the stored query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}