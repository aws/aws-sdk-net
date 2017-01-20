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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Contains an array of <code>S3Resource</code> objects. Each <code>S3Resource</code>
    /// object represents an Amazon S3 bucket that your transferred data will be exported
    /// from or imported into.
    /// </summary>
    public partial class JobResource
    {
        private List<LambdaResource> _lambdaResources = new List<LambdaResource>();
        private List<S3Resource> _s3Resources = new List<S3Resource>();

        /// <summary>
        /// Gets and sets the property LambdaResources. 
        /// <para>
        /// The Python-language Lambda functions for this job.
        /// </para>
        /// </summary>
        public List<LambdaResource> LambdaResources
        {
            get { return this._lambdaResources; }
            set { this._lambdaResources = value; }
        }

        // Check to see if LambdaResources property is set
        internal bool IsSetLambdaResources()
        {
            return this._lambdaResources != null && this._lambdaResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3Resources. 
        /// <para>
        /// An array of <code>S3Resource</code> objects.
        /// </para>
        /// </summary>
        public List<S3Resource> S3Resources
        {
            get { return this._s3Resources; }
            set { this._s3Resources = value; }
        }

        // Check to see if S3Resources property is set
        internal bool IsSetS3Resources()
        {
            return this._s3Resources != null && this._s3Resources.Count > 0; 
        }

    }
}