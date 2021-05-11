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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptPage operation.
    /// Used to acknowledge an engagement to a contact channel during an incident.
    /// </summary>
    public partial class AcceptPageRequest : AmazonSSMContactsRequest
    {
        private string _acceptCode;
        private AcceptType _acceptType;
        private string _contactChannelId;
        private string _note;
        private string _pageId;

        /// <summary>
        /// Gets and sets the property AcceptCode. 
        /// <para>
        /// The accept code is a 6-digit code used to acknowledge the page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=10)]
        public string AcceptCode
        {
            get { return this._acceptCode; }
            set { this._acceptCode = value; }
        }

        // Check to see if AcceptCode property is set
        internal bool IsSetAcceptCode()
        {
            return this._acceptCode != null;
        }

        /// <summary>
        /// Gets and sets the property AcceptType. 
        /// <para>
        /// The type indicates if the page was <code>DELIVERED</code> or <code>READ</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AcceptType AcceptType
        {
            get { return this._acceptType; }
            set { this._acceptType = value; }
        }

        // Check to see if AcceptType property is set
        internal bool IsSetAcceptType()
        {
            return this._acceptType != null;
        }

        /// <summary>
        /// Gets and sets the property ContactChannelId. 
        /// <para>
        /// The ARN of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ContactChannelId
        {
            get { return this._contactChannelId; }
            set { this._contactChannelId = value; }
        }

        // Check to see if ContactChannelId property is set
        internal bool IsSetContactChannelId()
        {
            return this._contactChannelId != null;
        }

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// Information provided by the user when the user acknowledges the page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property PageId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the engagement to a contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PageId
        {
            get { return this._pageId; }
            set { this._pageId = value; }
        }

        // Check to see if PageId property is set
        internal bool IsSetPageId()
        {
            return this._pageId != null;
        }

    }
}