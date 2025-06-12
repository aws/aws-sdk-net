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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateMatchId operation.
    /// Generates or retrieves Match IDs for records using a rule-based matching workflow.
    /// When you call this operation, it processes your records against the workflow's matching
    /// rules to identify potential matches. For existing records, it retrieves their Match
    /// IDs and associated rules. For records without matches, it generates new Match IDs.
    /// The operation saves results to Amazon S3. 
    /// 
    ///  
    /// <para>
    /// The processing type (<c>processingType</c>) you choose affects both the accuracy and
    /// response time of the operation. Additional charges apply for each API call, whether
    /// made through the Entity Resolution console or directly via the API. The rule-based
    /// matching workflow must exist and be active before calling this operation.
    /// </para>
    /// </summary>
    public partial class GenerateMatchIdRequest : AmazonEntityResolutionRequest
    {
        private ProcessingType _processingType;
        private List<Record> _records = AWSConfigs.InitializeCollections ? new List<Record>() : null;
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property ProcessingType. 
        /// <para>
        /// The processing mode that determines how Match IDs are generated and results are saved.
        /// Each mode provides different levels of accuracy, response time, and completeness of
        /// results.
        /// </para>
        ///  
        /// <para>
        /// If not specified, defaults to <c>CONSISTENT</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>CONSISTENT</c>: Performs immediate lookup and matching against all existing records,
        /// with results saved synchronously. Provides highest accuracy but slower response time.
        /// </para>
        ///  
        /// <para>
        ///  <c>EVENTUAL</c> (shown as <i>Background</i> in the console): Performs initial match
        /// ID lookup or generation immediately, with record updates processed asynchronously
        /// in the background. Offers faster initial response time, with complete matching results
        /// available later in S3. 
        /// </para>
        ///  
        /// <para>
        ///  <c>EVENTUAL_NO_LOOKUP</c> (shown as <i>Quick ID generation</i> in the console): Generates
        /// new match IDs without checking existing matches, with updates processed asynchronously.
        /// Provides fastest response time but should only be used for records known to be unique.
        /// 
        /// </para>
        /// </summary>
        public ProcessingType ProcessingType
        {
            get { return this._processingType; }
            set { this._processingType = value; }
        }

        // Check to see if ProcessingType property is set
        internal bool IsSetProcessingType()
        {
            return this._processingType != null;
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        ///  The records to match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        ///  The name of the rule-based matching workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WorkflowName
        {
            get { return this._workflowName; }
            set { this._workflowName = value; }
        }

        // Check to see if WorkflowName property is set
        internal bool IsSetWorkflowName()
        {
            return this._workflowName != null;
        }

    }
}