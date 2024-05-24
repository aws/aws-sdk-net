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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The cost allocation tag structure. This includes detailed metadata for the <c>CostAllocationTag</c>
    /// object.
    /// </summary>
    public partial class CostAllocationTag
    {
        private string _lastUpdatedDate;
        private string _lastUsedDate;
        private CostAllocationTagStatus _status;
        private string _tagKey;
        private CostAllocationTagType _type;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The last date that the tag was either activated or deactivated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate != null;
        }

        /// <summary>
        /// Gets and sets the property LastUsedDate. 
        /// <para>
        /// The last month that the tag was used on an Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string LastUsedDate
        {
            get { return this._lastUsedDate; }
            set { this._lastUsedDate = value; }
        }

        // Check to see if LastUsedDate property is set
        internal bool IsSetLastUsedDate()
        {
            return this._lastUsedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a cost allocation tag. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CostAllocationTagStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key for the cost allocation tag. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of cost allocation tag. You can use <c>AWSGenerated</c> or <c>UserDefined</c>
        /// type tags. <c>AWSGenerated</c> type tags are tags that Amazon Web Services defines
        /// and applies to support Amazon Web Services resources for cost allocation purposes.
        /// <c>UserDefined</c> type tags are tags that you define, create, and apply to resources.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CostAllocationTagType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}