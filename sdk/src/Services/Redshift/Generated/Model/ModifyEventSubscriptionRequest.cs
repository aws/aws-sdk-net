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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEventSubscription operation.
    /// Modifies an existing Amazon Redshift event notification subscription.
    /// </summary>
    public partial class ModifyEventSubscriptionRequest : AmazonRedshiftRequest
    {
        private bool? _enabled;
        private List<string> _eventCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _severity;
        private string _snsTopicArn;
        private List<string> _sourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceType;
        private string _subscriptionName;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean value indicating if the subscription is enabled. <c>true</c> indicates the
        /// subscription is enabled 
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventCategories. 
        /// <para>
        /// Specifies the Amazon Redshift event categories to be published by the event notification
        /// subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: configuration, management, monitoring, security, pending
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && (this._eventCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Specifies the Amazon Redshift event severity to be published by the event notification
        /// subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: ERROR, INFO
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS topic to be used by the event notification
        /// subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIds. 
        /// <para>
        /// A list of one or more identifiers of Amazon Redshift source objects. All of the objects
        /// must be of the same type as was specified in the source type parameter. The event
        /// subscription will return only events generated by the specified objects. If not specified,
        /// then events are returned for all objects within the source type specified.
        /// </para>
        ///  
        /// <para>
        /// Example: my-cluster-1, my-cluster-2
        /// </para>
        ///  
        /// <para>
        /// Example: my-snapshot-20131010
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceIds
        {
            get { return this._sourceIds; }
            set { this._sourceIds = value; }
        }

        // Check to see if SourceIds property is set
        internal bool IsSetSourceIds()
        {
            return this._sourceIds != null && (this._sourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source that will be generating the events. For example, if you want to
        /// be notified of events generated by a cluster, you would set this parameter to cluster.
        /// If this value is not specified, events are returned for all Amazon Redshift objects
        /// in your Amazon Web Services account. You must specify a source type in order to specify
        /// source IDs.
        /// </para>
        ///  
        /// <para>
        /// Valid values: cluster, cluster-parameter-group, cluster-security-group, cluster-snapshot,
        /// and scheduled-action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the modified Amazon Redshift event notification subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

    }
}