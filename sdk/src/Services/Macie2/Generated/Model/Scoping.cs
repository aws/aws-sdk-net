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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies one or more property- and tag-based conditions that define criteria for
    /// including or excluding S3 objects from a classification job. Exclude conditions take
    /// precedence over include conditions.
    /// </summary>
    public partial class Scoping
    {
        private JobScopingBlock _excludes;
        private JobScopingBlock _includes;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// The property- and tag-based conditions that determine which objects to exclude from
        /// the analysis.
        /// </para>
        /// </summary>
        public JobScopingBlock Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null;
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// The property- and tag-based conditions that determine which objects to include in
        /// the analysis.
        /// </para>
        /// </summary>
        public JobScopingBlock Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null;
        }

    }
}