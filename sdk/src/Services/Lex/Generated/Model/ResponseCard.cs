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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// If you configure a response card when creating your bots, Amazon Lex substitutes the
    /// session attributes and slot values available, and then returns it. The response card
    /// can also come from a Lambda function ( <code>dialogCodeHook</code> and <code>fulfillmentActivity</code>
    /// on an intent).
    /// </summary>
    public partial class ResponseCard
    {
        private ContentType _contentType;
        private List<GenericAttachment> _genericAttachments = new List<GenericAttachment>();
        private string _version;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Content type of the response.
        /// </para>
        /// </summary>
        public ContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property GenericAttachments. 
        /// <para>
        /// An array of attachment objects representing options.
        /// </para>
        /// </summary>
        public List<GenericAttachment> GenericAttachments
        {
            get { return this._genericAttachments; }
            set { this._genericAttachments = value; }
        }

        // Check to see if GenericAttachments property is set
        internal bool IsSetGenericAttachments()
        {
            return this._genericAttachments != null && this._genericAttachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version of response card format.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}