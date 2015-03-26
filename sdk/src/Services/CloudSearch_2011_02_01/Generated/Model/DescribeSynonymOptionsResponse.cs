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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// A response message that contains the synonym options for a search domain.
    /// </summary>
    public partial class DescribeSynonymOptionsResponse : AmazonWebServiceResponse
    {
        private SynonymOptionsStatus _synonyms;

        /// <summary>
        /// Gets and sets the property Synonyms.
        /// </summary>
        public SynonymOptionsStatus Synonyms
        {
            get { return this._synonyms; }
            set { this._synonyms = value; }
        }

        // Check to see if Synonyms property is set
        internal bool IsSetSynonyms()
        {
            return this._synonyms != null;
        }

    }
}