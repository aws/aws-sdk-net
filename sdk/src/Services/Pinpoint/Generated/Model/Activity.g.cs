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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the configuration and other settings for an activity in a journey.
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Gets and sets the property CUSTOM. 
        /// <para>
        /// The settings for a custom message activity. This type of activity calls an AWS Lambda
        /// function or web hook that sends messages to participants.
        /// </para>
        /// </summary>
        public CustomMessageActivity CUSTOM { get; set; }

        /// <summary>
        /// Checks to see if the CUSTOM property is set.
        /// </summary>
        internal bool IsSetCUSTOM() => this.CUSTOM != null;

        /// <summary>
        /// Gets and sets the property ConditionalSplit. 
        /// <para>
        /// The settings for a yes/no split activity. This type of activity sends participants
        /// down one of two paths in a journey, based on conditions that you specify.
        /// </para>
        /// </summary>
        public ConditionalSplitActivity ConditionalSplit { get; set; }

        /// <summary>
        /// Checks to see if the ConditionalSplit property is set.
        /// </summary>
        internal bool IsSetConditionalSplit() => this.ConditionalSplit != null;

        /// <summary>
        /// Gets and sets the property ContactCenter. 
        /// <para>
        /// The settings for a connect activity. This type of activity initiates a contact center
        /// call to participants.
        /// </para>
        /// </summary>
        public ContactCenterActivity ContactCenter { get; set; }

        /// <summary>
        /// Checks to see if the ContactCenter property is set.
        /// </summary>
        internal bool IsSetContactCenter() => this.ContactCenter != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the activity.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EMAIL. 
        /// <para>
        /// The settings for an email activity. This type of activity sends an email message to
        /// participants.
        /// </para>
        /// </summary>
        public EmailMessageActivity EMAIL { get; set; }

        /// <summary>
        /// Checks to see if the EMAIL property is set.
        /// </summary>
        internal bool IsSetEMAIL() => this.EMAIL != null;

        /// <summary>
        /// Gets and sets the property Holdout. 
        /// <para>
        /// The settings for a holdout activity. This type of activity stops a journey for a specified
        /// percentage of participants.
        /// </para>
        /// </summary>
        public HoldoutActivity Holdout { get; set; }

        /// <summary>
        /// Checks to see if the Holdout property is set.
        /// </summary>
        internal bool IsSetHoldout() => this.Holdout != null;

        /// <summary>
        /// Gets and sets the property MultiCondition. 
        /// <para>
        /// The settings for a multivariate split activity. This type of activity sends participants
        /// down one of as many as five paths (including a default <i>Else</i> path) in a journey,
        /// based on conditions that you specify.
        /// </para>
        /// </summary>
        public MultiConditionalSplitActivity MultiCondition { get; set; }

        /// <summary>
        /// Checks to see if the MultiCondition property is set.
        /// </summary>
        internal bool IsSetMultiCondition() => this.MultiCondition != null;

        /// <summary>
        /// Gets and sets the property PUSH. 
        /// <para>
        /// The settings for a push notification activity. This type of activity sends a push
        /// notification to participants.
        /// </para>
        /// </summary>
        public PushMessageActivity PUSH { get; set; }

        /// <summary>
        /// Checks to see if the PUSH property is set.
        /// </summary>
        internal bool IsSetPUSH() => this.PUSH != null;

        /// <summary>
        /// Gets and sets the property RandomSplit. 
        /// <para>
        /// The settings for a random split activity. This type of activity randomly sends specified
        /// percentages of participants down one of as many as five paths in a journey, based
        /// on conditions that you specify.
        /// </para>
        /// </summary>
        public RandomSplitActivity RandomSplit { get; set; }

        /// <summary>
        /// Checks to see if the RandomSplit property is set.
        /// </summary>
        internal bool IsSetRandomSplit() => this.RandomSplit != null;

        /// <summary>
        /// Gets and sets the property SMS. 
        /// <para>
        /// The settings for an SMS activity. This type of activity sends a text message to participants.
        /// </para>
        /// </summary>
        public SMSMessageActivity SMS { get; set; }

        /// <summary>
        /// Checks to see if the SMS property is set.
        /// </summary>
        internal bool IsSetSMS() => this.SMS != null;

        /// <summary>
        /// Gets and sets the property Wait. 
        /// <para>
        /// The settings for a wait activity. This type of activity waits for a certain amount
        /// of time or until a specific date and time before moving participants to the next activity
        /// in a journey.
        /// </para>
        /// </summary>
        public WaitActivity Wait { get; set; }

        /// <summary>
        /// Checks to see if the Wait property is set.
        /// </summary>
        internal bool IsSetWait() => this.Wait != null;
    }
}
