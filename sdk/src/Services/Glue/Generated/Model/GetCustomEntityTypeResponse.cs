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
    /// This is the response object from the GetCustomEntityType operation.
    /// </summary>
    public partial class GetCustomEntityTypeResponse : AmazonWebServiceResponse
    {
        private List<string> _contextWords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _regexString;

        /// <summary>
        /// Gets and sets the property ContextWords. 
        /// <para>
        /// A list of context words if specified when you created the custom pattern. If none
        /// of these context words are found within the vicinity of the regular expression the
        /// data will not be detected as sensitive data.
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
        /// The name of the custom pattern that you retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        [AWSProperty(Min=1, Max=255)]
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

    }
}