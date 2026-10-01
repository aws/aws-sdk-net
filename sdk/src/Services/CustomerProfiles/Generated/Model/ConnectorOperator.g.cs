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
    /// The operation to be performed on the provided source fields.
    /// </summary>
    public partial class ConnectorOperator
    {
        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        /// The operation to be performed on the provided Marketo source fields.
        /// </para>
        /// </summary>
        public MarketoConnectorOperator Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The operation to be performed on the provided Amazon S3 source fields.
        /// </para>
        /// </summary>
        public S3ConnectorOperator S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        /// The operation to be performed on the provided Salesforce source fields.
        /// </para>
        /// </summary>
        public SalesforceConnectorOperator Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        /// The operation to be performed on the provided ServiceNow source fields.
        /// </para>
        /// </summary>
        public ServiceNowConnectorOperator ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        /// The operation to be performed on the provided Zendesk source fields.
        /// </para>
        /// </summary>
        public ZendeskConnectorOperator Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}
