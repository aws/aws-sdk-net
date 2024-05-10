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
    /// This is the response object from the DeleteKeyword operation.
    /// </summary>
    public partial class DeleteKeywordResponse : AmazonWebServiceResponse
    {
        private string _keyword;
        private KeywordAction _keywordAction;
        private string _keywordMessage;
        private string _originationIdentity;
        private string _originationIdentityArn;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The keyword that was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
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
        /// The action that was associated with the deleted keyword.
        /// </para>
        /// </summary>
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
        /// The message that was associated with the deleted keyword.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The PhoneNumberId or PoolId that the keyword was associated with.
        /// </para>
        /// </summary>
        public string OriginationIdentity
        {
            get { return this._originationIdentity; }
            set { this._originationIdentity = value; }
        }

        // Check to see if OriginationIdentity property is set
        internal bool IsSetOriginationIdentity()
        {
            return this._originationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentityArn. 
        /// <para>
        /// The PhoneNumberArn or PoolArn that the keyword was associated with.
        /// </para>
        /// </summary>
        public string OriginationIdentityArn
        {
            get { return this._originationIdentityArn; }
            set { this._originationIdentityArn = value; }
        }

        // Check to see if OriginationIdentityArn property is set
        internal bool IsSetOriginationIdentityArn()
        {
            return this._originationIdentityArn != null;
        }

    }
}