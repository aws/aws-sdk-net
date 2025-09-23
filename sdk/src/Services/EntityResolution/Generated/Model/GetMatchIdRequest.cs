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
    /// Container for the parameters to the GetMatchId operation.
    /// Returns the corresponding Match ID of a customer record if the record has been processed
    /// in a rule-based matching workflow.
    /// 
    ///  
    /// <para>
    /// You can call this API as a dry run of an incremental load on the rule-based matching
    /// workflow.
    /// </para>
    /// </summary>
    public partial class GetMatchIdRequest : AmazonEntityResolutionRequest
    {
        private bool? _applyNormalization;
        private Dictionary<string, string> _record = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property ApplyNormalization. 
        /// <para>
        /// Normalizes the attributes defined in the schema in the input data. For example, if
        /// an attribute has an <c>AttributeType</c> of <c>PHONE_NUMBER</c>, and the data in the
        /// input table is in a format of 1234567890, Entity Resolution will normalize this field
        /// in the output to (123)-456-7890.
        /// </para>
        /// </summary>
        public bool? ApplyNormalization
        {
            get { return this._applyNormalization; }
            set { this._applyNormalization = value; }
        }

        // Check to see if ApplyNormalization property is set
        internal bool IsSetApplyNormalization()
        {
            return this._applyNormalization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Record. 
        /// <para>
        /// The record to fetch the Match ID for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null && (this._record.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow.
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