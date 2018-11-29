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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies configurations for one or more training jobs that Amazon SageMaker runs
    /// to test the algorithm.
    /// </summary>
    public partial class AlgorithmValidationSpecification
    {
        private List<AlgorithmValidationProfile> _validationProfiles = new List<AlgorithmValidationProfile>();
        private string _validationRole;

        /// <summary>
        /// Gets and sets the property ValidationProfiles. 
        /// <para>
        /// An array of <code>AlgorithmValidationProfile</code> objects, each of which specifies
        /// a training job and batch transform job that Amazon SageMaker runs to validate your
        /// algorithm.
        /// </para>
        /// </summary>
        public List<AlgorithmValidationProfile> ValidationProfiles
        {
            get { return this._validationProfiles; }
            set { this._validationProfiles = value; }
        }

        // Check to see if ValidationProfiles property is set
        internal bool IsSetValidationProfiles()
        {
            return this._validationProfiles != null && this._validationProfiles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidationRole. 
        /// <para>
        /// The IAM roles that Amazon SageMaker uses to run the training jobs.
        /// </para>
        /// </summary>
        public string ValidationRole
        {
            get { return this._validationRole; }
            set { this._validationRole = value; }
        }

        // Check to see if ValidationRole property is set
        internal bool IsSetValidationRole()
        {
            return this._validationRole != null;
        }

    }
}