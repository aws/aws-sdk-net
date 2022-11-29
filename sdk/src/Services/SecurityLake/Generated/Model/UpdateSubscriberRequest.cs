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
    /// Container for the parameters to the UpdateSubscriber operation.
    /// Update the subscription permission for the given Security Lake account ID.
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonSecurityLakeRequest
    {
        private string _externalId;
        private string _id;
        private List<SourceType> _sourceTypes = new List<SourceType>();
        private string _subscriberDescription;
        private string _subscriberName;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// External ID of the Security Lake account.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A value created by Security Lake that uniquely identifies your <code>UpdateSubscriber</code>
        /// API request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTypes. 
        /// <para>
        /// The supported Amazon Web Services services from which logs and events are collected.
        /// Amazon Security Lake supports logs and events collection for the following natively-supported
        /// Amazon Web Services services. For more information, see the Amazon Security Lake User
        /// Guide.
        /// </para>
        /// </summary>
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
        /// Description of the Security Lake account subscriber.
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
        /// Name of the Security Lake account subscriber. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
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