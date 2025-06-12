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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriber operation.
    /// Updates an existing subscription for the given Amazon Security Lake account ID. You
    /// can update a subscriber by changing the sources that the subscriber consumes data
    /// from.
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonSecurityLakeRequest
    {
        private List<LogSourceResource> _sources = AWSConfigs.InitializeCollections ? new List<LogSourceResource>() : null;
        private string _subscriberDescription;
        private string _subscriberId;
        private AwsIdentity _subscriberIdentity;
        private string _subscriberName;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The supported Amazon Web Services services from which logs and events are collected.
        /// For the list of supported Amazon Web Services services, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogSourceResource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The description of the Security Lake account subscriber.
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
        /// Gets and sets the property SubscriberId. 
        /// <para>
        /// A value created by Security Lake that uniquely identifies your subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriberId
        {
            get { return this._subscriberId; }
            set { this._subscriberId = value; }
        }

        // Check to see if SubscriberId property is set
        internal bool IsSetSubscriberId()
        {
            return this._subscriberId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberIdentity. 
        /// <para>
        /// The Amazon Web Services identity used to access your data.
        /// </para>
        /// </summary>
        public AwsIdentity SubscriberIdentity
        {
            get { return this._subscriberIdentity; }
            set { this._subscriberIdentity = value; }
        }

        // Check to see if SubscriberIdentity property is set
        internal bool IsSetSubscriberIdentity()
        {
            return this._subscriberIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of the Security Lake account subscriber.
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