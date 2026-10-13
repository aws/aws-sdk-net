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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The last date that the tag was either activated or deactivated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate != null;

        /// <summary>
        /// Gets and sets the property LastUsedDate. 
        /// <para>
        /// The last month that the tag was used on an Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string LastUsedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUsedDate property is set.
        /// </summary>
        internal bool IsSetLastUsedDate() => this.LastUsedDate != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a cost allocation tag. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CostAllocationTagStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key for the cost allocation tag. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

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
        [AWSProperty(Required = true)]
        public CostAllocationTagType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
