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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRevision operation.
    /// This operation creates a revision for a data set.
    /// </summary>
    public partial class CreateRevisionRequest : AmazonDataExchangeRequest
    {
        private string _comment;
        private string _dataSetId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for a data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A revision tag is an optional label that you can assign to a revision when you create
        /// it. Each tag consists of a key and an optional value, both of which you define. When
        /// you use tagging, you can also use tag-based access control in IAM policies to control
        /// access to these data sets and revisions.
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