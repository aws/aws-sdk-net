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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetCustomDataIdentifier operation.
    /// </summary>
    public partial class GetCustomDataIdentifierResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private bool? _deleted;
        private string _description;
        private string _id;
        private List<string> _ignoreWords = new List<string>();
        private List<string> _keywords = new List<string>();
        private int? _maximumMatchDistance;
        private string _name;
        private string _regex;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom data identifier.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the custom data identifier
        /// was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Specifies whether the custom data identifier was deleted. If you delete a custom data
        /// identifier, Amazon Macie doesn't delete it permanently. Instead, it soft deletes the
        /// identifier.
        /// </para>
        /// </summary>
        public bool Deleted
        {
            get { return this._deleted.GetValueOrDefault(); }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the custom data identifier.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the custom data identifier.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreWords. 
        /// <para>
        /// An array that lists specific character sequences (ignore words) to exclude from the
        /// results. If the text matched by the regular expression is the same as any string in
        /// this array, Amazon Macie ignores it. Ignore words are case sensitive.
        /// </para>
        /// </summary>
        public List<string> IgnoreWords
        {
            get { return this._ignoreWords; }
            set { this._ignoreWords = value; }
        }

        // Check to see if IgnoreWords property is set
        internal bool IsSetIgnoreWords()
        {
            return this._ignoreWords != null && this._ignoreWords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        /// An array that lists specific character sequences (keywords), one of which must be
        /// within proximity (maximumMatchDistance) of the regular expression to match. Keywords
        /// aren't case sensitive.
        /// </para>
        /// </summary>
        public List<string> Keywords
        {
            get { return this._keywords; }
            set { this._keywords = value; }
        }

        // Check to see if Keywords property is set
        internal bool IsSetKeywords()
        {
            return this._keywords != null && this._keywords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumMatchDistance. 
        /// <para>
        /// The maximum number of characters that can exist between text that matches the regex
        /// pattern and the character sequences specified by the keywords array. Macie includes
        /// or excludes a result based on the proximity of a keyword to text that matches the
        /// regex pattern.
        /// </para>
        /// </summary>
        public int MaximumMatchDistance
        {
            get { return this._maximumMatchDistance.GetValueOrDefault(); }
            set { this._maximumMatchDistance = value; }
        }

        // Check to see if MaximumMatchDistance property is set
        internal bool IsSetMaximumMatchDistance()
        {
            return this._maximumMatchDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name of the custom data identifier.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regular expression (<i>regex</i>) that defines the pattern to match.
        /// </para>
        /// </summary>
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that identifies the tags (keys and values) that are associated
        /// with the custom data identifier.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}