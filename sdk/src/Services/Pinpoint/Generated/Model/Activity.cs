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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the configuration and other settings for an activity in a journey.
    /// </summary>
    public partial class Activity
    {
        private ConditionalSplitActivity _conditionalSplit;
        private ContactCenterActivity _contactCenter;
        private CustomMessageActivity _custom;
        private string _description;
        private EmailMessageActivity _email;
        private HoldoutActivity _holdout;
        private MultiConditionalSplitActivity _multiCondition;
        private PushMessageActivity _push;
        private RandomSplitActivity _randomSplit;
        private SMSMessageActivity _sms;
        private WaitActivity _wait;

        /// <summary>
        /// Gets and sets the property ConditionalSplit. 
        /// <para>
        /// The settings for a yes/no split activity. This type of activity sends participants
        /// down one of two paths in a journey, based on conditions that you specify.
        /// </para>
        /// </summary>
        public ConditionalSplitActivity ConditionalSplit
        {
            get { return this._conditionalSplit; }
            set { this._conditionalSplit = value; }
        }

        // Check to see if ConditionalSplit property is set
        internal bool IsSetConditionalSplit()
        {
            return this._conditionalSplit != null;
        }

        /// <summary>
        /// Gets and sets the property ContactCenter. 
        /// <para>
        /// The settings for a connect activity. This type of activity initiates a contact center
        /// call to participants.
        /// </para>
        /// </summary>
        public ContactCenterActivity ContactCenter
        {
            get { return this._contactCenter; }
            set { this._contactCenter = value; }
        }

        // Check to see if ContactCenter property is set
        internal bool IsSetContactCenter()
        {
            return this._contactCenter != null;
        }

        /// <summary>
        /// Gets and sets the property CUSTOM. 
        /// <para>
        /// The settings for a custom message activity. This type of activity calls an AWS Lambda
        /// function or web hook that sends messages to participants.
        /// </para>
        /// </summary>
        public CustomMessageActivity CUSTOM
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if CUSTOM property is set
        internal bool IsSetCUSTOM()
        {
            return this._custom != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the activity.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EMAIL. 
        /// <para>
        /// The settings for an email activity. This type of activity sends an email message to
        /// participants.
        /// </para>
        /// </summary>
        public EmailMessageActivity EMAIL
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if EMAIL property is set
        internal bool IsSetEMAIL()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Holdout. 
        /// <para>
        /// The settings for a holdout activity. This type of activity stops a journey for a specified
        /// percentage of participants.
        /// </para>
        /// </summary>
        public HoldoutActivity Holdout
        {
            get { return this._holdout; }
            set { this._holdout = value; }
        }

        // Check to see if Holdout property is set
        internal bool IsSetHoldout()
        {
            return this._holdout != null;
        }

        /// <summary>
        /// Gets and sets the property MultiCondition. 
        /// <para>
        /// The settings for a multivariate split activity. This type of activity sends participants
        /// down one of as many as five paths (including a default <i>Else</i> path) in a journey,
        /// based on conditions that you specify.
        /// </para>
        /// </summary>
        public MultiConditionalSplitActivity MultiCondition
        {
            get { return this._multiCondition; }
            set { this._multiCondition = value; }
        }

        // Check to see if MultiCondition property is set
        internal bool IsSetMultiCondition()
        {
            return this._multiCondition != null;
        }

        /// <summary>
        /// Gets and sets the property PUSH. 
        /// <para>
        /// The settings for a push notification activity. This type of activity sends a push
        /// notification to participants.
        /// </para>
        /// </summary>
        public PushMessageActivity PUSH
        {
            get { return this._push; }
            set { this._push = value; }
        }

        // Check to see if PUSH property is set
        internal bool IsSetPUSH()
        {
            return this._push != null;
        }

        /// <summary>
        /// Gets and sets the property RandomSplit. 
        /// <para>
        /// The settings for a random split activity. This type of activity randomly sends specified
        /// percentages of participants down one of as many as five paths in a journey, based
        /// on conditions that you specify.
        /// </para>
        /// </summary>
        public RandomSplitActivity RandomSplit
        {
            get { return this._randomSplit; }
            set { this._randomSplit = value; }
        }

        // Check to see if RandomSplit property is set
        internal bool IsSetRandomSplit()
        {
            return this._randomSplit != null;
        }

        /// <summary>
        /// Gets and sets the property SMS. 
        /// <para>
        /// The settings for an SMS activity. This type of activity sends a text message to participants.
        /// </para>
        /// </summary>
        public SMSMessageActivity SMS
        {
            get { return this._sms; }
            set { this._sms = value; }
        }

        // Check to see if SMS property is set
        internal bool IsSetSMS()
        {
            return this._sms != null;
        }

        /// <summary>
        /// Gets and sets the property Wait. 
        /// <para>
        /// The settings for a wait activity. This type of activity waits for a certain amount
        /// of time or until a specific date and time before moving participants to the next activity
        /// in a journey.
        /// </para>
        /// </summary>
        public WaitActivity Wait
        {
            get { return this._wait; }
            set { this._wait = value; }
        }

        // Check to see if Wait property is set
        internal bool IsSetWait()
        {
            return this._wait != null;
        }

    }
}