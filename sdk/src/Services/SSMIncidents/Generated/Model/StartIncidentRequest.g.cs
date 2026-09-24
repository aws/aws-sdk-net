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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the StartIncident operation. Used to start an incident
    /// from CloudWatch alarms, EventBridge events, or manually.
    /// </summary>
    public partial class StartIncidentRequest : AmazonSSMIncidentsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// Defines the impact to the customers. Providing an impact overwrites the impact provided
        /// by a response plan.
        /// </para>
        ///  
        /// <para>
        ///  <b>Supported impact codes</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>1</c> - Critical
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2</c> - High
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>3</c> - Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>4</c> - Low
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>5</c> - No Impact
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact.HasValue;

        /// <summary>
        /// Gets and sets the property RelatedItems. 
        /// <para>
        /// Add related items to the incident for other responders to use. Related items are Amazon
        /// Web Services resources, external links, or files uploaded to an Amazon S3 bucket.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<RelatedItem> RelatedItems { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedItem>() : null;

        /// <summary>
        /// Checks to see if the RelatedItems property is set.
        /// </summary>
        internal bool IsSetRelatedItems() => this.RelatedItems != null && (this.RelatedItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponsePlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the response plan that pre-defines summary, chat
        /// channels, Amazon SNS topics, runbooks, title, and impact of the incident. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string ResponsePlanArn { get; set; }

        /// <summary>
        /// Checks to see if the ResponsePlanArn property is set.
        /// </summary>
        internal bool IsSetResponsePlanArn() => this.ResponsePlanArn != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Provide a title for the incident. Providing a title overwrites the title provided
        /// by the response plan. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Details of what created the incident record in Incident Manager.
        /// </para>
        /// </summary>
        public TriggerDetails TriggerDetails { get; set; }

        /// <summary>
        /// Checks to see if the TriggerDetails property is set.
        /// </summary>
        internal bool IsSetTriggerDetails() => this.TriggerDetails != null;
    }
}
