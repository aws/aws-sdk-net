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
    /// Specifies a property- or tag-based condition that defines criteria for including or
    /// excluding S3 objects from a classification job. A JobScopeTerm object can contain
    /// only one simpleScopeTerm object or one tagScopeTerm object.
    /// </summary>
    public partial class JobScopeTerm
    {
        private SimpleScopeTerm _simpleScopeTerm;
        private TagScopeTerm _tagScopeTerm;

        /// <summary>
        /// Gets and sets the property SimpleScopeTerm. 
        /// <para>
        /// A property-based condition that defines a property, operator, and one or more values
        /// for including or excluding objects from the job.
        /// </para>
        /// </summary>
        public SimpleScopeTerm SimpleScopeTerm
        {
            get { return this._simpleScopeTerm; }
            set { this._simpleScopeTerm = value; }
        }

        // Check to see if SimpleScopeTerm property is set
        internal bool IsSetSimpleScopeTerm()
        {
            return this._simpleScopeTerm != null;
        }

        /// <summary>
        /// Gets and sets the property TagScopeTerm. 
        /// <para>
        /// A tag-based condition that defines the operator and tag keys or tag key and value
        /// pairs for including or excluding objects from the job.
        /// </para>
        /// </summary>
        public TagScopeTerm TagScopeTerm
        {
            get { return this._tagScopeTerm; }
            set { this._tagScopeTerm = value; }
        }

        // Check to see if TagScopeTerm property is set
        internal bool IsSetTagScopeTerm()
        {
            return this._tagScopeTerm != null;
        }

    }
}