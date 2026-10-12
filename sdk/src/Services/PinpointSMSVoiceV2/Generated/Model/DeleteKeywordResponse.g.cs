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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DeleteKeyword operation.
    /// </summary>
    public partial class DeleteKeywordResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The keyword that was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string Keyword { get; set; }

        /// <summary>
        /// Checks to see if the Keyword property is set.
        /// </summary>
        internal bool IsSetKeyword() => this.Keyword != null;

        /// <summary>
        /// Gets and sets the property KeywordAction. 
        /// <para>
        /// The action that was associated with the deleted keyword.
        /// </para>
        /// </summary>
        public KeywordAction KeywordAction { get; set; }

        /// <summary>
        /// Checks to see if the KeywordAction property is set.
        /// </summary>
        internal bool IsSetKeywordAction() => this.KeywordAction != null;

        /// <summary>
        /// Gets and sets the property KeywordMessage. 
        /// <para>
        /// The message that was associated with the deleted keyword.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string KeywordMessage { get; set; }

        /// <summary>
        /// Checks to see if the KeywordMessage property is set.
        /// </summary>
        internal bool IsSetKeywordMessage() => this.KeywordMessage != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The PhoneNumberId or PoolId that the keyword was associated with.
        /// </para>
        /// </summary>
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentityArn. 
        /// <para>
        /// The PhoneNumberArn or PoolArn that the keyword was associated with.
        /// </para>
        /// </summary>
        public string OriginationIdentityArn { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentityArn property is set.
        /// </summary>
        internal bool IsSetOriginationIdentityArn() => this.OriginationIdentityArn != null;
    }
}
