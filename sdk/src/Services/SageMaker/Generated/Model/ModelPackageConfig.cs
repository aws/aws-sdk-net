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
    /// The configuration for the Model package.
    /// </summary>
    public partial class ModelPackageConfig
    {
        private string _modelPackageGroupArn;
        private string _sourceModelPackageArn;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the model package group of output model package.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelPackageGroupArn
        {
            get { return this._modelPackageGroupArn; }
            set { this._modelPackageGroupArn = value; }
        }

        // Check to see if ModelPackageGroupArn property is set
        internal bool IsSetModelPackageGroupArn()
        {
            return this._modelPackageGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelPackageArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the source model package used for continued fine-tuning
        /// and custom model evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceModelPackageArn
        {
            get { return this._sourceModelPackageArn; }
            set { this._sourceModelPackageArn = value; }
        }

        // Check to see if SourceModelPackageArn property is set
        internal bool IsSetSourceModelPackageArn()
        {
            return this._sourceModelPackageArn != null;
        }

    }
}