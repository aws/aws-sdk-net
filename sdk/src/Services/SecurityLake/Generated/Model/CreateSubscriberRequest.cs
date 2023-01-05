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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriber operation.
    /// Creates a subscription permission for accounts that are already enabled in Amazon
    /// Security Lake. You can create a subscriber with access to data in the current Amazon
    /// Web Services Region.
    /// </summary>
    public partial class CreateSubscriberRequest : AmazonSecurityLakeRequest
    {
        private List<string> _accessTypes = new List<string>();
        private string _accountId;
        private string _externalId;
        private List<SourceType> _sourceTypes = new List<SourceType>();
        private string _subscriberDescription;
        private string _subscriberName;

        /// <summary>
        /// Gets and sets the property AccessTypes. 
        /// <para>
        /// The Amazon S3 or Lake Formation access type.
        /// </para>
        /// </summary>
        public List<string> AccessTypes
        {
            get { return this._accessTypes; }
            set { this._accessTypes = value; }
        }

        // Check to see if AccessTypes property is set
        internal bool IsSetAccessTypes()
        {
            return this._accessTypes != null && this._accessTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID used to access your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID of the subscriber. This lets the user that is assuming the role assert
        /// the circumstances in which they are operating. It also provides a way for the account
        /// owner to permit the role to be assumed only under specific circumstances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTypes. 
        /// <para>
        /// The supported Amazon Web Services from which logs and events are collected. Security
        /// Lake supports log and event collection for natively supported Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SourceType> SourceTypes
        {
            get { return this._sourceTypes; }
            set { this._sourceTypes = value; }
        }

        // Check to see if SourceTypes property is set
        internal bool IsSetSourceTypes()
        {
            return this._sourceTypes != null && this._sourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The description for your subscriber account in Security Lake. 
        /// </para>
        /// </summary>
        public string SubscriberDescription
        {
            get { return this._subscriberDescription; }
            set { this._subscriberDescription = value; }
        }

        // Check to see if SubscriberDescription property is set
        internal bool IsSetSubscriberDescription()
        {
            return this._subscriberDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of your Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string SubscriberName
        {
            get { return this._subscriberName; }
            set { this._subscriberName = value; }
        }

        // Check to see if SubscriberName property is set
        internal bool IsSetSubscriberName()
        {
            return this._subscriberName != null;
        }

    }
}