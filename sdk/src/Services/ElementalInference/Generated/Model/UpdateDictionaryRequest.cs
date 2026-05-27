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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDictionary operation.
    /// Updates the specified dictionary.
    /// </summary>
    public partial class UpdateDictionaryRequest : AmazonElementalInferenceRequest
    {
        private string _entries;
        private string _id;
        private DictionaryLanguage _language;
        private string _name;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// New dictionary entries. If not specified, the entries are not changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40960)]
        public string Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the dictionary to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=19)]
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
        /// Gets and sets the property Language. 
        /// <para>
        /// A new language for the dictionary. If not specified, the language is not changed.
        /// </para>
        /// </summary>
        public DictionaryLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the dictionary. If not specified, the name is not changed.
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

    }
}