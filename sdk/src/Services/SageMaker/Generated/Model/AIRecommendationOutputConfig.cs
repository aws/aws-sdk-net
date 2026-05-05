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
    /// The output configuration for an AI recommendation job.
    /// </summary>
    public partial class AIRecommendationOutputConfig
    {
        private string _modelPackageGroupIdentifier;
        private string _s3OutputLocation;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model package group where the optimized
        /// model is registered as a new model package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ModelPackageGroupIdentifier
        {
            get { return this._modelPackageGroupIdentifier; }
            set { this._modelPackageGroupIdentifier = value; }
        }

        // Check to see if ModelPackageGroupIdentifier property is set
        internal bool IsSetModelPackageGroupIdentifier()
        {
            return this._modelPackageGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// The Amazon S3 URI where recommendation results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string S3OutputLocation
        {
            get { return this._s3OutputLocation; }
            set { this._s3OutputLocation = value; }
        }

        // Check to see if S3OutputLocation property is set
        internal bool IsSetS3OutputLocation()
        {
            return this._s3OutputLocation != null;
        }

    }
}