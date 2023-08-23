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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies the event feedback type.
    /// </summary>
    public partial class EventFeedbackType
    {
        private DateTime? _feedbackDate;
        private FeedbackValueType _feedbackValue;
        private string _provider;

        /// <summary>
        /// Gets and sets the property FeedbackDate. 
        /// <para>
        /// The event feedback date.
        /// </para>
        /// </summary>
        public DateTime FeedbackDate
        {
            get { return this._feedbackDate.GetValueOrDefault(); }
            set { this._feedbackDate = value; }
        }

        // Check to see if FeedbackDate property is set
        internal bool IsSetFeedbackDate()
        {
            return this._feedbackDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeedbackValue. 
        /// <para>
        /// The authentication event feedback value. When you provide a <code>FeedbackValue</code>
        /// value of <code>valid</code>, you tell Amazon Cognito that you trust a user session
        /// where Amazon Cognito has evaluated some level of risk. When you provide a <code>FeedbackValue</code>
        /// value of <code>invalid</code>, you tell Amazon Cognito that you don't trust a user
        /// session, or you don't believe that Amazon Cognito evaluated a high-enough risk level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeedbackValueType FeedbackValue
        {
            get { return this._feedbackValue; }
            set { this._feedbackValue = value; }
        }

        // Check to see if FeedbackValue property is set
        internal bool IsSetFeedbackValue()
        {
            return this._feedbackValue != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

    }
}