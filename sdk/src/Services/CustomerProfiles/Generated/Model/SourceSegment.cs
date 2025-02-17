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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The source segments to build off of.
    /// </summary>
    public partial class SourceSegment
    {
        private string _segmentDefinitionName;

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The unique name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SegmentDefinitionName
        {
            get { return this._segmentDefinitionName; }
            set { this._segmentDefinitionName = value; }
        }

        // Check to see if SegmentDefinitionName property is set
        internal bool IsSetSegmentDefinitionName()
        {
            return this._segmentDefinitionName != null;
        }

    }
}