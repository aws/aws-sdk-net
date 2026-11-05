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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains detailed information about where a threat was detected.
    /// </summary>
    public partial class ItemDetails
    {
        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional information about the detected threat item.
        /// </para>
        /// </summary>
        public AdditionalInfo AdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInfo property is set.
        /// </summary>
        internal bool IsSetAdditionalInfo() => this.AdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property Hash. 
        /// <para>
        /// The hash value of the infected item.
        /// </para>
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Checks to see if the Hash property is set.
        /// </summary>
        internal bool IsSetHash() => this.Hash != null;

        /// <summary>
        /// Gets and sets the property ItemPath. 
        /// <para>
        /// The path where the threat was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ItemPath { get; set; }

        /// <summary>
        /// Checks to see if the ItemPath property is set.
        /// </summary>
        internal bool IsSetItemPath() => this.ItemPath != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource where the threat was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
