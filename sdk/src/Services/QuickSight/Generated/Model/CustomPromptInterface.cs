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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The custom prompt interface configuration that defines how an agent's prompt is configured.
    /// </summary>
    public partial class CustomPromptInterface
    {
        private string _customInstructions;
        private string _identity;
        private string _modelProfileId;
        private string _outputStyle;
        private string _promptSummary;
        private string _qbsAwsAccountId;
        private string _responseLength;
        private string _subscriptionId;
        private string _tone;

        /// <summary>
        /// Gets and sets the property CustomInstructions. 
        /// <para>
        /// Custom instructions for the agent's behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=350000)]
        public string CustomInstructions
        {
            get { return this._customInstructions; }
            set { this._customInstructions = value; }
        }

        // Check to see if CustomInstructions property is set
        internal bool IsSetCustomInstructions()
        {
            return this._customInstructions != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// Instructions that define the agent's identity and persona.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=350000)]
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property ModelProfileId. 
        /// <para>
        /// The identifier of the model profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ModelProfileId
        {
            get { return this._modelProfileId; }
            set { this._modelProfileId = value; }
        }

        // Check to see if ModelProfileId property is set
        internal bool IsSetModelProfileId()
        {
            return this._modelProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputStyle. 
        /// <para>
        /// Instructions for the desired output style.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=350000)]
        public string OutputStyle
        {
            get { return this._outputStyle; }
            set { this._outputStyle = value; }
        }

        // Check to see if OutputStyle property is set
        internal bool IsSetOutputStyle()
        {
            return this._outputStyle != null;
        }

        /// <summary>
        /// Gets and sets the property PromptSummary. 
        /// <para>
        /// A summary of the custom prompt configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PromptSummary
        {
            get { return this._promptSummary; }
            set { this._promptSummary = value; }
        }

        // Check to see if PromptSummary property is set
        internal bool IsSetPromptSummary()
        {
            return this._promptSummary != null;
        }

        /// <summary>
        /// Gets and sets the property QbsAwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the Q Business service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=15)]
        public string QbsAwsAccountId
        {
            get { return this._qbsAwsAccountId; }
            set { this._qbsAwsAccountId = value; }
        }

        // Check to see if QbsAwsAccountId property is set
        internal bool IsSetQbsAwsAccountId()
        {
            return this._qbsAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseLength. 
        /// <para>
        /// Instructions for the desired response length.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=350000)]
        public string ResponseLength
        {
            get { return this._responseLength; }
            set { this._responseLength = value; }
        }

        // Check to see if ResponseLength property is set
        internal bool IsSetResponseLength()
        {
            return this._responseLength != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The subscription identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property Tone. 
        /// <para>
        /// Instructions for the desired tone of responses.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=350000)]
        public string Tone
        {
            get { return this._tone; }
            set { this._tone = value; }
        }

        // Check to see if Tone property is set
        internal bool IsSetTone()
        {
            return this._tone != null;
        }

    }
}