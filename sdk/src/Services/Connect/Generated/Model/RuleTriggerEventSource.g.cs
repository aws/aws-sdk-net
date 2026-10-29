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
    /// The name of the event source. This field is required if <c>TriggerEventSource</c>
    /// is one of the following values: <c>OnZendeskTicketCreate</c> | <c>OnZendeskTicketStatusUpdate</c>
    /// | <c>OnSalesforceCaseCreate</c> | <c>OnContactEvaluationSubmit</c> | <c>OnMetricDataUpdate</c>.
    /// </summary>
    public partial class RuleTriggerEventSource
    {
        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// The name of the event source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventSourceName EventSourceName { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceName property is set.
        /// </summary>
        internal bool IsSetEventSourceName() => this.EventSourceName != null;

        /// <summary>
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the integration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string IntegrationAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationAssociationId property is set.
        /// </summary>
        internal bool IsSetIntegrationAssociationId() => this.IntegrationAssociationId != null;
    }
}
