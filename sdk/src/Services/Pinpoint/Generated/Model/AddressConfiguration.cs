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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Address configuration.
    /// </summary>
    public partial class AddressConfiguration
    {
        private string _bodyOverride;
        private ChannelType _channelType;
        private Dictionary<string, string> _context = new Dictionary<string, string>();
        private string _rawContent;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
        private string _titleOverride;

        /// <summary>
        /// Gets and sets the property BodyOverride. Body override. If specified will override
        /// default body.
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
        /// Gets and sets the property ChannelType. The channel type.Valid values: GCM | APNS
        /// | APNS_SANDBOX | APNS_VOIP | APNS_VOIP_SANDBOX | ADM | SMS | EMAIL | BAIDU
        /// </summary>
        public ChannelType ChannelType
        {
            get { return this._channelType; }
            set { this._channelType = value; }
        }

        // Check to see if ChannelType property is set
        internal bool IsSetChannelType()
        {
            return this._channelType != null;
        }

        /// <summary>
        /// Gets and sets the property Context. A map of custom attributes to attributes to be
        /// attached to the message for this address. This payload is added to the push notification's
        /// 'data.pinpoint' object or added to the email/sms delivery receipt event attributes.
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
        /// Gets and sets the property RawContent. The Raw JSON formatted string to be used as
        /// the payload. This value overrides the message.
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
        /// Gets and sets the property Substitutions. A map of substitution values for the message
        /// to be merged with the DefaultMessage's substitutions. Substitutions on this map take
        /// precedence over the all other substitutions.
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
        /// Gets and sets the property TitleOverride. Title override. If specified will override
        /// default title if applicable.
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