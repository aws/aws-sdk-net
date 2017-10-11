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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// An array that contains one or more Destinations, as well as the tags and replacement
    /// data associated with each of those Destinations.
    /// </summary>
    public partial class BulkEmailDestination
    {
        private Destination _destination;
        private List<MessageTag> _replacementTags = new List<MessageTag>();
        private string _replacementTemplateData;

        /// <summary>
        /// Gets and sets the property Destination.
        /// </summary>
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ReplacementTags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// using <code>SendBulkTemplatedEmail</code>. Tags correspond to characteristics of the
        /// email that you define, so that you can publish email sending events.
        /// </para>
        /// </summary>
        public List<MessageTag> ReplacementTags
        {
            get { return this._replacementTags; }
            set { this._replacementTags = value; }
        }

        // Check to see if ReplacementTags property is set
        internal bool IsSetReplacementTags()
        {
            return this._replacementTags != null && this._replacementTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplacementTemplateData. 
        /// <para>
        /// A list of replacement values to apply to the template. This parameter is a JSON object,
        /// typically consisting of key-value pairs in which the keys correspond to replacement
        /// tags in the email template.
        /// </para>
        /// </summary>
        public string ReplacementTemplateData
        {
            get { return this._replacementTemplateData; }
            set { this._replacementTemplateData = value; }
        }

        // Check to see if ReplacementTemplateData property is set
        internal bool IsSetReplacementTemplateData()
        {
            return this._replacementTemplateData != null;
        }

    }
}