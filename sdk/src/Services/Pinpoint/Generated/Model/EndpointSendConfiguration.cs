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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the content, including message variables and attributes, to use in a message
    /// that's sent directly to an endpoint.
    /// </summary>
    public partial class EndpointSendConfiguration
    {
        private string _bodyOverride;
        private Dictionary<string, string> _context = new Dictionary<string, string>();
        private string _rawContent;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
        private string _titleOverride;

        /// <summary>
        /// Gets and sets the property BodyOverride. 
        /// <para>
        /// The body of the message. If specified, this value overrides the default message body.
        /// </para>
        /// </summary>
        public string BodyOverride
        {
            get { return this._bodyOverride; }
            set { this._bodyOverride = value; }
        }

        // Check to see if BodyOverride property is set
        internal bool IsSetBodyOverride()
        {
            return this._bodyOverride != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// A map of custom attributes to attach to the message for the address. Attribute names
        /// are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// For a push notification, this payload is added to the data.pinpoint object. For an
        /// email or text message, this payload is added to email/SMS delivery receipt event attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && this._context.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for the message. If specified,
        /// this value overrides all other values for the message.
        /// </para>
        /// </summary>
        public string RawContent
        {
            get { return this._rawContent; }
            set { this._rawContent = value; }
        }

        // Check to see if RawContent property is set
        internal bool IsSetRawContent()
        {
            return this._rawContent != null;
        }

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// A map of the message variables to merge with the variables specified for the default
        /// message (DefaultMessage.Substitutions). The variables specified in this map take precedence
        /// over all other variables.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && this._substitutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TitleOverride. 
        /// <para>
        /// The title or subject line of the message. If specified, this value overrides the default
        /// message title or subject line.
        /// </para>
        /// </summary>
        public string TitleOverride
        {
            get { return this._titleOverride; }
            set { this._titleOverride = value; }
        }

        // Check to see if TitleOverride property is set
        internal bool IsSetTitleOverride()
        {
            return this._titleOverride != null;
        }

    }
}