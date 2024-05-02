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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListLabelGroups operation.
    /// Returns a list of the label groups.
    /// </summary>
    public partial class ListLabelGroupsRequest : AmazonLookoutEquipmentRequest
    {
        private string _labelGroupNameBeginsWith;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LabelGroupNameBeginsWith. 
        /// <para>
        ///  The beginning of the name of the label groups to be listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LabelGroupNameBeginsWith
        {
            get { return this._labelGroupNameBeginsWith; }
            set { this._labelGroupNameBeginsWith = value; }
        }

        // Check to see if LabelGroupNameBeginsWith property is set
        internal bool IsSetLabelGroupNameBeginsWith()
        {
            return this._labelGroupNameBeginsWith != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of label groups to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of label groups.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}