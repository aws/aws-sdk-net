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
    /// Specifies which S3 buckets contain the objects that a classification job analyzes,
    /// and the scope of that analysis. The bucket specification can be static (bucketDefinitions)
    /// or dynamic (bucketCriteria). If it's static, the job analyzes objects in the same
    /// predefined set of buckets each time the job runs. If it's dynamic, the job analyzes
    /// objects in any buckets that match the specified criteria each time the job starts
    /// to run.
    /// </summary>
    public partial class S3JobDefinition
    {
        private S3BucketCriteriaForJob _bucketCriteria;
        private List<S3BucketDefinitionForJob> _bucketDefinitions = AWSConfigs.InitializeCollections ? new List<S3BucketDefinitionForJob>() : null;
        private Scoping _scoping;

        /// <summary>
        /// Gets and sets the property BucketCriteria. 
        /// <para>
        /// The property- and tag-based conditions that determine which S3 buckets to include
        /// or exclude from the analysis. Each time the job runs, the job uses these criteria
        /// to determine which buckets contain objects to analyze. A job's definition can contain
        /// a bucketCriteria object or a bucketDefinitions array, not both.
        /// </para>
        /// </summary>
        public S3BucketCriteriaForJob BucketCriteria
        {
            get { return this._bucketCriteria; }
            set { this._bucketCriteria = value; }
        }

        // Check to see if BucketCriteria property is set
        internal bool IsSetBucketCriteria()
        {
            return this._bucketCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property BucketDefinitions. 
        /// <para>
        /// An array of objects, one for each Amazon Web Services account that owns specific S3
        /// buckets to analyze. Each object specifies the account ID for an account and one or
        /// more buckets to analyze for that account. A job's definition can contain a bucketDefinitions
        /// array or a bucketCriteria object, not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3BucketDefinitionForJob> BucketDefinitions
        {
            get { return this._bucketDefinitions; }
            set { this._bucketDefinitions = value; }
        }

        // Check to see if BucketDefinitions property is set
        internal bool IsSetBucketDefinitions()
        {
            return this._bucketDefinitions != null && (this._bucketDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scoping. 
        /// <para>
        /// The property- and tag-based conditions that determine which S3 objects to include
        /// or exclude from the analysis. Each time the job runs, the job uses these criteria
        /// to determine which objects to analyze.
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