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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The information for all keywords in a pool.
    /// </summary>
    public partial class KeywordInformation
    {
        private string _keyword;
        private KeywordAction _keywordAction;
        private string _keywordMessage;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The keyword as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string Keyword
        {
            get { return this._keyword; }
            set { this._keyword = value; }
        }

        // Check to see if Keyword property is set
        internal bool IsSetKeyword()
        {
            return this._keyword != null;
        }

        /// <summary>
        /// Gets and sets the property KeywordAction. 
        /// <para>
        /// The action to perform for the keyword.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeywordAction KeywordAction
        {
            get { return this._keywordAction; }
            set { this._keywordAction = value; }
        }

        // Check to see if KeywordAction property is set
        internal bool IsSetKeywordAction()
        {
            return this._keywordAction != null;
        }

        /// <summary>
        /// Gets and sets the property KeywordMessage. 
        /// <para>
        /// A custom message that can be used with the keyword.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string KeywordMessage
        {
            get { return this._keywordMessage; }
            set { this._keywordMessage = value; }
        }

        // Check to see if KeywordMessage property is set
        internal bool IsSetKeywordMessage()
        {
            return this._keywordMessage != null;
        }

    }
}