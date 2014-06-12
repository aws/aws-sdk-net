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
    /// Container for the parameters to the CreateEventSubscription operation.
    /// Creates an Amazon Redshift event notification subscription. This action
    /// requires an ARN (Amazon Resource Name) of            an Amazon SNS topic created by
    /// either the Amazon Redshift console, the Amazon SNS console, or the             Amazon
    /// SNS API. To obtain an ARN with Amazon SNS, you must create a topic in Amazon SNS and
    /// subscribe to the topic.            The ARN is displayed in the SNS console.      
    ///  
    /// 
    ///         
    /// <para>
    ///             You can specify the source type, and lists of Amazon Redshift source IDs,
    /// event categories, and event severities.            Notifications will be sent for
    /// all events you want that match those criteria. For example, you can specify      
    ///      source type = cluster, source ID = my-cluster-1 and mycluster2, event categories
    /// = Availability, Backup, and            severity = ERROR. The subscription will only
    /// send notifications for those ERROR events in the Availability and            Backup
    /// categories for the specified clusters.        
    /// </para>
    ///         
    /// <para>
    ///             If you specify both the source type and source IDs, such as source type
    /// = cluster and source identifier =             my-cluster-1, notifications will be
    /// sent for all the cluster events for my-cluster-1. If you specify a source type   
    ///         but do not specify a source identifier, you will receive notice of the events
    /// for the objects of that type in your            AWS account. If you do not specify
    /// either the SourceType nor the SourceIdentifier, you will be notified of events   
    ///         generated from all Amazon Redshift sources belonging to your AWS account.
    /// You must specify a source type if you            specify a source ID.        
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonRedshiftRequest
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
        ///             A Boolean value; set to <code>true</code> to activate the subscription,
        /// set to <code>false</code> to create the            subscription but not active it.
        ///        
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        /// Values: Configuration, Management, Monitoring, Security
        /// </para>
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
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

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }


        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        ///             The Amazon Resource Name (ARN) of the Amazon SNS topic used to transmit
        /// the event notifications. The ARN is created by            Amazon SNS when you create
        /// a topic and subscribe to it.        
        /// </para>
        /// </summary>
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

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }


        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        ///             The name of the event subscription to be created.        
        /// </para>
        ///         
        /// <para>
        /// Constraints:
        /// </para>
        ///         <ul>            <li>Cannot be null, empty, or blank.</li>            <li>Must
        /// contain from 1 to 255 alphanumeric characters or hyphens.</li>            <li>First
        /// character must be a letter.</li>            <li>Cannot end with a hyphen or contain
        /// two consecutive hyphens.</li>        </ul>
        /// </summary>
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