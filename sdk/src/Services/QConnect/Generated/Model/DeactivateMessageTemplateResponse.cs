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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// This is the response object from the DeactivateMessageTemplate operation.
    /// </summary>
    public partial class DeactivateMessageTemplateResponse : AmazonWebServiceResponse
    {
        private string _messageTemplateArn;
        private string _messageTemplateId;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property MessageTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageTemplateArn
        {
            get { return this._messageTemplateArn; }
            set { this._messageTemplateArn = value; }
        }

        // Check to see if MessageTemplateArn property is set
        internal bool IsSetMessageTemplateArn()
        {
            return this._messageTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageTemplateId
        {
            get { return this._messageTemplateId; }
            set { this._messageTemplateId = value; }
        }

        // Check to see if MessageTemplateId property is set
        internal bool IsSetMessageTemplateId()
        {
            return this._messageTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the message template version that has been deactivated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}