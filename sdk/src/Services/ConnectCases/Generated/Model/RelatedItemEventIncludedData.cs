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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Details of what related item data is published through the case event stream.
    /// </summary>
    public partial class RelatedItemEventIncludedData
    {
        private bool? _includeContent;

        /// <summary>
        /// Gets and sets the property IncludeContent. 
        /// <para>
        /// Details of what related item data is published through the case event stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IncludeContent
        {
            get { return this._includeContent; }
            set { this._includeContent = value; }
        }

        // Check to see if IncludeContent property is set
        internal bool IsSetIncludeContent()
        {
            return this._includeContent.HasValue; 
        }

    }
}