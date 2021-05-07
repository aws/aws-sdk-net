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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure describing a database resource with tags.
    /// </summary>
    public partial class TaggedDatabase
    {
        private DatabaseResource _database;
        private List<LFTagPair> _lfTags = new List<LFTagPair>();

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// A database that has tags attached to it.
        /// </para>
        /// </summary>
        public DatabaseResource Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property LFTags. 
        /// <para>
        /// A list of tags attached to the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<LFTagPair> LFTags
        {
            get { return this._lfTags; }
            set { this._lfTags = value; }
        }

        // Check to see if LFTags property is set
        internal bool IsSetLFTags()
        {
            return this._lfTags != null && this._lfTags.Count > 0; 
        }

    }
}