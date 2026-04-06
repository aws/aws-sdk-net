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
    /// Specifies the configuration for a policy preview analysis, including the type of analysis,
    /// the target resource, and the policy documents to evaluate.
    /// </summary>
    public partial class PolicyConfiguration
    {
        private ImpactAnalysisJobType _jobType;
        private List<string> _policyDocumentsList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of impact analysis job. Currently only <c>SCP</c> (Service Control Policy)
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImpactAnalysisJobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocumentsList. 
        /// <para>
        /// A list of SCP policy documents to test. Each policy document is a JSON string with
        /// a maximum length of 5,120 characters. The analysis evaluates how these policies would
        /// affect access to resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PolicyDocumentsList
        {
            get { return this._policyDocumentsList; }
            set { this._policyDocumentsList = value; }
        }

        // Check to see if PolicyDocumentsList property is set
        internal bool IsSetPolicyDocumentsList()
        {
            return this._policyDocumentsList != null && (this._policyDocumentsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The identifier of the target resource for the policy analysis. This can be an Amazon
        /// Web Services account ID (12-digit number), an organization root ID (format: <c>r-[0-9a-z]{4,32}</c>),
        /// or an organizational unit ID (format: <c>ou-[0-9a-z]{4,32}-[a-z0-9]{8,32}</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}