/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEventSubscription operation.
    /// Modifies an existing Amazon Redshift event notification subscription.
    /// </summary>
    public partial class ModifyEventSubscriptionRequest : AmazonWebServiceRequest
    {
        private bool? _enabled;
        private List<string> _eventCategories = new List<string>();
        private string _severity;
        private string _snsTopicArn;
        private List<string> _sourceIds = new List<string>();
        private string _sourceType;
        private string _subscriptionName;


        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///             A Boolean value indicating if the subscription is enabled. <code>true</code>
        /// indicates the subscription is enabled        
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }


        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithEnabled(bool enabled)
        {
            this._enabled = enabled;
            return this;
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
        /// Values: Configuration, Management, Monitoring, Security
        /// </para>
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        /// <summary>
        /// Sets the EventCategories property
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithEventCategories(params string[] eventCategories)
        {
            foreach (var element in eventCategories)
            {
                this._eventCategories.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EventCategories property
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithEventCategories(IEnumerable<string> eventCategories)
        {
            foreach (var element in eventCategories)
            {
                this._eventCategories.Add(element);
            }
            return this;
        }
        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && this._eventCategories.Count > 0; 
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
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }


        /// <summary>
        /// Sets the Severity property
        /// </summary>
        /// <param name="severity">The value to set for the Severity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithSeverity(string severity)
        {
            this._severity = severity;
            return this;
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }


        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        ///             The Amazon Resource Name (ARN) of the SNS topic to be used by the event
        /// notification subscription.        
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }


        /// <summary>
        /// Sets the SnsTopicArn property
        /// </summary>
        /// <param name="snsTopicArn">The value to set for the SnsTopicArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithSnsTopicArn(string snsTopicArn)
        {
            this._snsTopicArn = snsTopicArn;
            return this;
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }


        /// <summary>
        /// Gets and sets the property SourceIds. 
        /// <para>
        ///             A list of one or more identifiers of Amazon Redshift source objects. All
        /// of the objects must be of the same type as            was specified in the source
        /// type parameter. The event subscription will return only events generated by the  
        ///          specified objects. If not specified, then events are returned for all objects
        /// within the source type specified.        
        /// </para>
        ///         
        /// <para>
        /// Example: my-cluster-1, my-cluster-2
        /// </para>
        ///         
        /// <para>
        /// Example: my-snapshot-20131010
        /// </para>
        /// </summary>
        public List<string> SourceIds
        {
            get { return this._sourceIds; }
            set { this._sourceIds = value; }
        }

        /// <summary>
        /// Sets the SourceIds property
        /// </summary>
        /// <param name="sourceIds">The values to add to the SourceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithSourceIds(params string[] sourceIds)
        {
            foreach (var element in sourceIds)
            {
                this._sourceIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SourceIds property
        /// </summary>
        /// <param name="sourceIds">The values to add to the SourceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithSourceIds(IEnumerable<string> sourceIds)
        {
            foreach (var element in sourceIds)
            {
                this._sourceIds.Add(element);
            }
            return this;
        }
        // Check to see if SourceIds property is set
        internal bool IsSetSourceIds()
        {
            return this._sourceIds != null && this._sourceIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///             The type of source that will be generating the events. For example, if
        /// you want to be notified of events generated by a            cluster, you would set
        /// this parameter to cluster. If this value is not specified, events are returned for
        /// all             Amazon Redshift objects in your AWS account. You must specify a source
        /// type in order to specify source IDs.        
        /// </para>
        ///         
        /// <para>
        /// Valid values: cluster, cluster-parameter-group, cluster-security-group, and cluster-snapshot.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }


        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithSourceType(string sourceType)
        {
            this._sourceType = sourceType;
            return this;
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }


        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        ///             The name of the modified Amazon Redshift event notification subscription.
        ///        
        /// </para>
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }


        /// <summary>
        /// Sets the SubscriptionName property
        /// </summary>
        /// <param name="subscriptionName">The value to set for the SubscriptionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyEventSubscriptionRequest WithSubscriptionName(string subscriptionName)
        {
            this._subscriptionName = subscriptionName;
            return this;
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

    }
}