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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriber operation. Updates an existing
    /// subscription for the given Amazon Security Lake account ID. You can update a subscriber
    /// by changing the sources that the subscriber consumes data from.
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonSecurityLakeRequest
    {
        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The supported Amazon Web Services services from which logs and events are collected.
        /// For the list of supported Amazon Web Services services, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogSourceResource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<LogSourceResource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The description of the Security Lake account subscriber.
        /// </para>
        /// </summary>
        public string SubscriberDescription { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberDescription property is set.
        /// </summary>
        internal bool IsSetSubscriberDescription() => this.SubscriberDescription != null;

        /// <summary>
        /// Gets and sets the property SubscriberId. 
        /// <para>
        /// A value created by Security Lake that uniquely identifies your subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriberId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberId property is set.
        /// </summary>
        internal bool IsSetSubscriberId() => this.SubscriberId != null;

        /// <summary>
        /// Gets and sets the property SubscriberIdentity. 
        /// <para>
        /// The Amazon Web Services identity used to access your data.
        /// </para>
        /// </summary>
        public AwsIdentity SubscriberIdentity { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberIdentity property is set.
        /// </summary>
        internal bool IsSetSubscriberIdentity() => this.SubscriberIdentity != null;

        /// <summary>
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of the Security Lake account subscriber.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string SubscriberName { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberName property is set.
        /// </summary>
        internal bool IsSetSubscriberName() => this.SubscriberName != null;
    }
}
