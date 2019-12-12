/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchInferenceJob operation.
    /// Creates a batch inference job. The operation can handle up to 50 million records and
    /// the input file must be in JSON format. For more information, see <a>recommendations-batch</a>.
    /// </summary>
    public partial class CreateBatchInferenceJobRequest : AmazonPersonalizeRequest
    {
        private BatchInferenceJobInput _jobInput;
        private string _jobName;
        private BatchInferenceJobOutput _jobOutput;
        private int? _numResults;
        private string _roleArn;
        private string _solutionVersionArn;

        /// <summary>
        /// Gets and sets the property JobInput. 
        /// <para>
        /// The Amazon S3 path that leads to the input file to base your recommendations on. The
        /// input material must be in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchInferenceJobInput JobInput
        {
            get { return this._jobInput; }
            set { this._jobInput = value; }
        }

        // Check to see if JobInput property is set
        internal bool IsSetJobInput()
        {
            return this._jobInput != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobOutput. 
        /// <para>
        /// The path to the Amazon S3 bucket where the job's output will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchInferenceJobOutput JobOutput
        {
            get { return this._jobOutput; }
            set { this._jobOutput = value; }
        }

        // Check to see if JobOutput property is set
        internal bool IsSetJobOutput()
        {
            return this._jobOutput != null;
        }

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of recommendations to retreive.
        /// </para>
        /// </summary>
        public int NumResults
        {
            get { return this._numResults.GetValueOrDefault(); }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Amazon Identity and Access Management role that has permissions to
        /// read and write to your input and out Amazon S3 buckets respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version that will be used to generate
        /// the batch inference recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

    }
}