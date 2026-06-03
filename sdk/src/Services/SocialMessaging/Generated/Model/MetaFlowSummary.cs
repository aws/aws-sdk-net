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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Contains summary information about a WhatsApp Flow, including its ID, name, status,
    /// and categories.
    /// </summary>
    public partial class MetaFlowSummary
    {
        private List<string> _flowCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _flowId;
        private string _flowName;
        private string _flowStatus;
        private List<string> _validationErrors = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FlowCategories. 
        /// <para>
        /// The categories that classify the business purpose of the Flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9)]
        public List<string> FlowCategories
        {
            get { return this._flowCategories; }
            set { this._flowCategories = value; }
        }

        // Check to see if FlowCategories property is set
        internal bool IsSetFlowCategories()
        {
            return this._flowCategories != null && (this._flowCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the Flow assigned by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string FlowId
        {
            get { return this._flowId; }
            set { this._flowId = value; }
        }

        // Check to see if FlowId property is set
        internal bool IsSetFlowId()
        {
            return this._flowId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The name of the Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        /// The lifecycle status of the Flow (DRAFT, PUBLISHED, DEPRECATED, BLOCKED, or THROTTLED).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string FlowStatus
        {
            get { return this._flowStatus; }
            set { this._flowStatus = value; }
        }

        // Check to see if FlowStatus property is set
        internal bool IsSetFlowStatus()
        {
            return this._flowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// A list of validation errors from Meta, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && (this._validationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}