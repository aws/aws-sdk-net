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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies configurations for one or more training jobs that SageMaker runs to test
    /// the algorithm.
    /// </summary>
    public partial class AlgorithmValidationSpecification
    {
        private List<AlgorithmValidationProfile> _validationProfiles = AWSConfigs.InitializeCollections ? new List<AlgorithmValidationProfile>() : null;
        private string _validationRole;

        /// <summary>
        /// Gets and sets the property ValidationProfiles. 
        /// <para>
        /// An array of <c>AlgorithmValidationProfile</c> objects, each of which specifies a training
        /// job and batch transform job that SageMaker runs to validate your algorithm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<AlgorithmValidationProfile> ValidationProfiles
        {
            get { return this._validationProfiles; }
            set { this._validationProfiles = value; }
        }

        // Check to see if ValidationProfiles property is set
        internal bool IsSetValidationProfiles()
        {
            return this._validationProfiles != null && (this._validationProfiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationRole. 
        /// <para>
        /// The IAM roles that SageMaker uses to run the training jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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