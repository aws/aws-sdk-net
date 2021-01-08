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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies which S3 buckets contain the objects that a classification job analyzes,
    /// and the scope of that analysis.
    /// </summary>
    public partial class S3JobDefinition
    {
        private List<S3BucketDefinitionForJob> _bucketDefinitions = new List<S3BucketDefinitionForJob>();
        private Scoping _scoping;

        /// <summary>
        /// Gets and sets the property BucketDefinitions. 
        /// <para>
        /// An array of objects, one for each AWS account that owns buckets to analyze. Each object
        /// specifies the account ID for an account and one or more buckets to analyze for the
        /// account.
        /// </para>
        /// </summary>
        public List<S3BucketDefinitionForJob> BucketDefinitions
        {
            get { return this._bucketDefinitions; }
            set { this._bucketDefinitions = value; }
        }

        // Check to see if BucketDefinitions property is set
        internal bool IsSetBucketDefinitions()
        {
            return this._bucketDefinitions != null && this._bucketDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scoping. 
        /// <para>
        /// The property- and tag-based conditions that determine which objects to include or
        /// exclude from the analysis.
        /// </para>
        /// </summary>
        public Scoping Scoping
        {
            get { return this._scoping; }
            set { this._scoping = value; }
        }

        // Check to see if Scoping property is set
        internal bool IsSetScoping()
        {
            return this._scoping != null;
        }

    }
}