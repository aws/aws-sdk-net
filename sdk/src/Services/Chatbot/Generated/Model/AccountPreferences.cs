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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Preferences related to AWS Chatbot usage in the calling AWS account.
    /// </summary>
    public partial class AccountPreferences
    {
        private bool? _trainingDataCollectionEnabled;
        private bool? _userAuthorizationRequired;

        /// <summary>
        /// Gets and sets the property TrainingDataCollectionEnabled. 
        /// <para>
        /// Turns on training data collection.
        /// </para>
        ///  
        /// <para>
        /// This helps improve the AWS Chatbot experience by allowing AWS Chatbot to store and
        /// use your customer information, such as AWS Chatbot configurations, notifications,
        /// user inputs, AWS Chatbot generated responses, and interaction data. This data helps
        /// us to continuously improve and develop Artificial Intelligence (AI) technologies.
        /// Your data is not shared with any third parties and is protected using sophisticated
        /// controls to prevent unauthorized access and misuse. AWS Chatbot does not store or
        /// use interactions in chat channels with Amazon Q for training AI technologies for AWS
        /// Chatbot. 
        /// </para>
        /// </summary>
        public bool? TrainingDataCollectionEnabled
        {
            get { return this._trainingDataCollectionEnabled; }
            set { this._trainingDataCollectionEnabled = value; }
        }

        // Check to see if TrainingDataCollectionEnabled property is set
        internal bool IsSetTrainingDataCollectionEnabled()
        {
            return this._trainingDataCollectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAuthorizationRequired. 
        /// <para>
        /// Enables use of a user role requirement in your chat configuration.
        /// </para>
        /// </summary>
        public bool? UserAuthorizationRequired
        {
            get { return this._userAuthorizationRequired; }
            set { this._userAuthorizationRequired = value; }
        }

        // Check to see if UserAuthorizationRequired property is set
        internal bool IsSetUserAuthorizationRequired()
        {
            return this._userAuthorizationRequired.HasValue; 
        }

    }
}