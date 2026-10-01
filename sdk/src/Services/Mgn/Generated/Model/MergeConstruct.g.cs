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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A construct reference specifying the source segment and construct to merge.
    /// </summary>
    public partial class MergeConstruct
    {
        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The construct ID to merge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConstructID { get; set; }

        /// <summary>
        /// Checks to see if the ConstructID property is set.
        /// </summary>
        internal bool IsSetConstructID() => this.ConstructID != null;

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The segment ID of the construct to merge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SegmentID { get; set; }

        /// <summary>
        /// Checks to see if the SegmentID property is set.
        /// </summary>
        internal bool IsSetSegmentID() => this.SegmentID != null;
    }
}
