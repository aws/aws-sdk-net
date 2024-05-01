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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Overrides the document relevance properties of a custom index field.
    /// </summary>
    public partial class DocumentRelevanceConfiguration
    {
        private string _name;
        private Relevance _relevance;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the index field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
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
        /// Gets and sets the property Relevance. 
        /// <para>
        /// Provides information for tuning the relevance of a field in a search. When a query
        /// includes terms that match the field, the results are given a boost in the response
        /// based on these tuning parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Relevance Relevance
        {
            get { return this._relevance; }
            set { this._relevance = value; }
        }

        // Check to see if Relevance property is set
        internal bool IsSetRelevance()
        {
            return this._relevance != null;
        }

    }
}