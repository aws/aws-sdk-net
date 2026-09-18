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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains details about a guardrail.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListGuardrails.html#API_ListGuardrails_ResponseSyntax">ListGuardrails
    /// response body</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GuardrailSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time at which the guardrail was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CrossRegionDetails. 
        /// <para>
        /// Details about the system-defined guardrail profile that you're using with your guardrail,
        /// including the guardrail profile ID and Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public GuardrailCrossRegionDetails CrossRegionDetails { get; set; }

        /// <summary>
        /// Checks to see if the CrossRegionDetails property is set.
        /// </summary>
        internal bool IsSetCrossRegionDetails() => this.CrossRegionDetails != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time at which the guardrail was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
