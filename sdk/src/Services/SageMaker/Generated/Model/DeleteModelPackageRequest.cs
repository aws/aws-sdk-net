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
    /// Container for the parameters to the DeleteModelPackage operation.
    /// Deletes a model package.
    /// 
    ///  
    /// <para>
    /// A model package is used to create SageMaker models or list on Amazon Web Services
    /// Marketplace. Buyers can subscribe to model packages listed on Amazon Web Services
    /// Marketplace to create models in SageMaker.
    /// </para>
    /// </summary>
    public partial class DeleteModelPackageRequest : AmazonSageMakerRequest
    {
        private string _modelPackageName;

        /// <summary>
        /// Gets and sets the property ModelPackageName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model package to delete.
        /// </para>
        ///  
        /// <para>
        /// When you specify a name, the name must have 1 to 63 characters. Valid characters are
        /// a-z, A-Z, 0-9, and - (hyphen).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=176)]
        public string ModelPackageName
        {
            get { return this._modelPackageName; }
            set { this._modelPackageName = value; }
        }

        // Check to see if ModelPackageName property is set
        internal bool IsSetModelPackageName()
        {
            return this._modelPackageName != null;
        }

    }
}