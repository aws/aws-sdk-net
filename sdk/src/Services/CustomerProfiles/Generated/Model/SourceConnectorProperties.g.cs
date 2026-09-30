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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Specifies the information that is required to query a particular Amazon AppFlow connector.
    /// Customer Profiles supports Salesforce, Zendesk, Marketo, ServiceNow and Amazon S3.
    /// </summary>
    public partial class SourceConnectorProperties
    {
        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        /// The properties that are applied when Marketo is being used as a source.
        /// </para>
        /// </summary>
        public MarketoSourceProperties Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The properties that are applied when Amazon S3 is being used as the flow source.
        /// </para>
        /// </summary>
        public S3SourceProperties S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        /// The properties that are applied when Salesforce is being used as a source.
        /// </para>
        /// </summary>
        public SalesforceSourceProperties Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        /// The properties that are applied when ServiceNow is being used as a source.
        /// </para>
        /// </summary>
        public ServiceNowSourceProperties ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        /// The properties that are applied when using Zendesk as a flow source.
        /// </para>
        /// </summary>
        public ZendeskSourceProperties Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}
