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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Information about an Azure Event Hub.
    /// </summary>
    public partial class AzureEventHubSummary
    {
        /// <summary>
        /// Gets and sets the property EventHubName. 
        /// <para>
        /// The name of the Event Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventHubName { get; set; }

        /// <summary>
        /// Checks to see if the EventHubName property is set.
        /// </summary>
        internal bool IsSetEventHubName() => this.EventHubName != null;

        /// <summary>
        /// Gets and sets the property FullyQualifiedNamespace. 
        /// <para>
        /// The fully qualified host name of the Event Hubs namespace, for example <c>&lt;namespace&gt;.servicebus.windows.net</c>.
        /// The suffix differs in sovereign clouds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FullyQualifiedNamespace { get; set; }

        /// <summary>
        /// Checks to see if the FullyQualifiedNamespace property is set.
        /// </summary>
        internal bool IsSetFullyQualifiedNamespace() => this.FullyQualifiedNamespace != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the Event Hubs namespace that contains the Event Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 50)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Azure Region of the Event Hub, for example <c>eastus</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Azure Resource Manager ID of the Event Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The Azure subscription that contains the Event Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;
    }
}
