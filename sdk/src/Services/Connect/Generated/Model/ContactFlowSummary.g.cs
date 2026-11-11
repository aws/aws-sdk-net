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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about a flow.
    /// 
    ///  
    /// <para>
    /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Connect
    /// Customer Flow language</a>.
    /// </para>
    /// </summary>
    public partial class ContactFlowSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ContactFlowState. 
        /// <para>
        /// The type of flow.
        /// </para>
        /// </summary>
        public ContactFlowState ContactFlowState { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowState property is set.
        /// </summary>
        internal bool IsSetContactFlowState() => this.ContactFlowState != null;

        /// <summary>
        /// Gets and sets the property ContactFlowStatus. 
        /// <para>
        /// The status of the flow.
        /// </para>
        /// </summary>
        public ContactFlowStatus ContactFlowStatus { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowStatus property is set.
        /// </summary>
        internal bool IsSetContactFlowStatus() => this.ContactFlowStatus != null;

        /// <summary>
        /// Gets and sets the property ContactFlowType. 
        /// <para>
        /// The type of flow.
        /// </para>
        /// </summary>
        public ContactFlowType ContactFlowType { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowType property is set.
        /// </summary>
        internal bool IsSetContactFlowType() => this.ContactFlowType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
