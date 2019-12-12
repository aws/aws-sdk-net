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

/*
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for an email activity in a journey. This type of activity sends
    /// an email message to participants.
    /// </summary>
    public partial class EmailMessageActivity
    {
        private JourneyEmailMessage _messageConfig;
        private string _nextActivity;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property MessageConfig. 
        /// <para>
        /// The "From" address to use for the message.
        /// </para>
        /// </summary>
        public JourneyEmailMessage MessageConfig
        {
            get { return this._messageConfig; }
            set { this._messageConfig = value; }
        }

        // Check to see if MessageConfig property is set
        internal bool IsSetMessageConfig()
        {
            return this._messageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property NextActivity. 
        /// <para>
        /// The unique identifier for the next activity to perform, after the message is sent.
        /// </para>
        /// </summary>
        public string NextActivity
        {
            get { return this._nextActivity; }
            set { this._nextActivity = value; }
        }

        // Check to see if NextActivity property is set
        internal bool IsSetNextActivity()
        {
            return this._nextActivity != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the email template to use for the message.
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}