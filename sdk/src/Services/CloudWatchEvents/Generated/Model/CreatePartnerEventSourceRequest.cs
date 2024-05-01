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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePartnerEventSource operation.
    /// Called by an SaaS partner to create a partner event source. This operation is not
    /// used by Amazon Web Services customers.
    /// 
    ///  
    /// <para>
    /// Each partner event source can be used by one Amazon Web Services account to create
    /// a matching partner event bus in that Amazon Web Services account. A SaaS partner must
    /// create one partner event source for each Amazon Web Services account that wants to
    /// receive those event types. 
    /// </para>
    ///  
    /// <para>
    /// A partner event source creates events based on resources within the SaaS partner's
    /// service or application.
    /// </para>
    ///  
    /// <para>
    /// An Amazon Web Services account that creates a partner event bus that matches the partner
    /// event source can use that event bus to receive events from the partner, and then process
    /// them using Amazon Web Services Events rules and targets.
    /// </para>
    ///  
    /// <para>
    /// Partner event source names follow this format:
    /// </para>
    ///  
    /// <para>
    ///  <c> <i>partner_name</i>/<i>event_namespace</i>/<i>event_name</i> </c> 
    /// </para>
    ///  
    /// <para>
    ///  <i>partner_name</i> is determined during partner registration and identifies the
    /// partner to Amazon Web Services customers. <i>event_namespace</i> is determined by
    /// the partner and is a way for the partner to categorize their events. <i>event_name</i>
    /// is determined by the partner, and should uniquely identify an event-generating resource
    /// within the partner system. The combination of <i>event_namespace</i> and <i>event_name</i>
    /// should help Amazon Web Services customers decide whether to create an event bus to
    /// receive these events.
    /// </para>
    /// </summary>
    public partial class CreatePartnerEventSourceRequest : AmazonCloudWatchEventsRequest
    {
        private string _account;
        private string _name;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The Amazon Web Services account ID that is permitted to create a matching partner
        /// event bus for this partner event source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the partner event source. This name must be unique and must be in the
        /// format <c> <i>partner_name</i>/<i>event_namespace</i>/<i>event_name</i> </c>. The
        /// Amazon Web Services account that wants to use this partner event source must create
        /// a partner event bus with a name that matches the name of the partner event source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}