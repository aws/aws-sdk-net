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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Used to filter the workflow executions in visibility APIs based on a tag.
    /// </summary>
    public partial class TagFilter
    {
        private string _tag;

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        ///  Specifies the tag that must be associated with the execution for it to meet the filter
        /// criteria.
        /// </para>
        ///  
        /// <para>
        /// Tags may only contain unicode letters, digits, whitespace, or these symbols: <c>_
        /// . : / = + - @</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        // Check to see if Tag property is set
        internal bool IsSetTag()
        {
            return this._tag != null;
        }

    }
}