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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the StartIncident operation.
    /// Used to start an incident from CloudWatch alarms, EventBridge events, or manually.
    /// </summary>
    public partial class StartIncidentRequest : AmazonSSMIncidentsRequest
    {
        private string _clientToken;
        private int? _impact;
        private List<RelatedItem> _relatedItems = new List<RelatedItem>();
        private string _responsePlanArn;
        private string _title;
        private TriggerDetails _triggerDetails;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// Defines the impact to the customers. Providing an impact overwrites the impact provided
        /// by a response plan.
        /// </para>
        ///  <p class="title"> <b>Possible impacts:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>1</code> - Critical impact, this typically relates to full application failure
        /// that impacts many to all customers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>2</code> - High impact, partial application failure with impact to many customers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>3</code> - Medium impact, the application is providing reduced service to customers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>4</code> - Low impact, customer might aren't impacted by the problem yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5</code> - No impact, customers aren't currently impacted but urgent action
        /// is needed to avoid impact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int Impact
        {
            get { return this._impact.GetValueOrDefault(); }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedItems. 
        /// <para>
        /// Add related items to the incident for other responders to use. Related items are Amazon
        /// Web Services resources, external links, or files uploaded to an Amazon S3 bucket.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<RelatedItem> RelatedItems
        {
            get { return this._relatedItems; }
            set { this._relatedItems = value; }
        }

        // Check to see if RelatedItems property is set
        internal bool IsSetRelatedItems()
        {
            return this._relatedItems != null && this._relatedItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponsePlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the response plan that pre-defines summary, chat
        /// channels, Amazon SNS topics, runbooks, title, and impact of the incident. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string ResponsePlanArn
        {
            get { return this._responsePlanArn; }
            set { this._responsePlanArn = value; }
        }

        // Check to see if ResponsePlanArn property is set
        internal bool IsSetResponsePlanArn()
        {
            return this._responsePlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Provide a title for the incident. Providing a title overwrites the title provided
        /// by the response plan. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Details of what created the incident record in Incident Manager.
        /// </para>
        /// </summary>
        public TriggerDetails TriggerDetails
        {
            get { return this._triggerDetails; }
            set { this._triggerDetails = value; }
        }

        // Check to see if TriggerDetails property is set
        internal bool IsSetTriggerDetails()
        {
            return this._triggerDetails != null;
        }

    }
}