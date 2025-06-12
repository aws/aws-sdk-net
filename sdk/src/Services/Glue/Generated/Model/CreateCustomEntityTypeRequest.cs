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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomEntityType operation.
    /// Creates a custom pattern that is used to detect sensitive data across the columns
    /// and rows of your structured data.
    /// 
    ///  
    /// <para>
    /// Each custom pattern you create specifies a regular expression and an optional list
    /// of context words. If no context words are passed only a regular expression is checked.
    /// </para>
    /// </summary>
    public partial class CreateCustomEntityTypeRequest : AmazonGlueRequest
    {
        private List<string> _contextWords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _regexString;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ContextWords. 
        /// <para>
        /// A list of context words. If none of these context words are found within the vicinity
        /// of the regular expression the data will not be detected as sensitive data.
        /// </para>
        ///  
        /// <para>
        /// If no context words are passed only a regular expression is checked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> ContextWords
        {
            get { return this._contextWords; }
            set { this._contextWords = value; }
        }

        // Check to see if ContextWords property is set
        internal bool IsSetContextWords()
        {
            return this._contextWords != null && (this._contextWords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the custom pattern that allows it to be retrieved or deleted later. This
        /// name must be unique per Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property RegexString. 
        /// <para>
        /// A regular expression string that is used for detecting sensitive data in a custom
        /// pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RegexString
        {
            get { return this._regexString; }
            set { this._regexString = value; }
        }

        // Check to see if RegexString property is set
        internal bool IsSetRegexString()
        {
            return this._regexString != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags applied to the custom entity type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}