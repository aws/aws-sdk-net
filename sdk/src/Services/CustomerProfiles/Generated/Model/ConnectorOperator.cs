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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private MarketoConnectorOperator _marketo;
        private S3ConnectorOperator _s3;
        private SalesforceConnectorOperator _salesforce;
        private ServiceNowConnectorOperator _serviceNow;
        private ZendeskConnectorOperator _zendesk;

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        /// The operation to be performed on the provided Marketo source fields.
        /// </para>
        /// </summary>
        public MarketoConnectorOperator Marketo
        {
            get { return this._marketo; }
            set { this._marketo = value; }
        }

        // Check to see if Marketo property is set
        internal bool IsSetMarketo()
        {
            return this._marketo != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The operation to be performed on the provided Amazon S3 source fields.
        /// </para>
        /// </summary>
        public S3ConnectorOperator S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        /// The operation to be performed on the provided Salesforce source fields.
        /// </para>
        /// </summary>
        public SalesforceConnectorOperator Salesforce
        {
            get { return this._salesforce; }
            set { this._salesforce = value; }
        }

        // Check to see if Salesforce property is set
        internal bool IsSetSalesforce()
        {
            return this._salesforce != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        /// The operation to be performed on the provided ServiceNow source fields.
        /// </para>
        /// </summary>
        public ServiceNowConnectorOperator ServiceNow
        {
            get { return this._serviceNow; }
            set { this._serviceNow = value; }
        }

        // Check to see if ServiceNow property is set
        internal bool IsSetServiceNow()
        {
            return this._serviceNow != null;
        }

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        /// The operation to be performed on the provided Zendesk source fields.
        /// </para>
        /// </summary>
        public ZendeskConnectorOperator Zendesk
        {
            get { return this._zendesk; }
            set { this._zendesk = value; }
        }

        // Check to see if Zendesk property is set
        internal bool IsSetZendesk()
        {
            return this._zendesk != null;
        }

    }
}