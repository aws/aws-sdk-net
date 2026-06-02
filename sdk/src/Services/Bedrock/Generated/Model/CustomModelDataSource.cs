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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The data source for a custom model. This is a union type that supports the following
    /// member:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>modelPackageArnDataSource</c> — Specifies a SageMaker AI model package as the
    /// data source.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CustomModelDataSource
    {
        private ModelPackageArnDataSource _modelPackageArnDataSource;

        /// <summary>
        /// Gets and sets the property ModelPackageArnDataSource. 
        /// <para>
        /// A SageMaker AI model package ARN as the data source for the custom model. When you
        /// specify a model package ARN, Amazon Bedrock resolves the model package to retrieve
        /// the model artifacts.
        /// </para>
        /// </summary>
        public ModelPackageArnDataSource ModelPackageArnDataSource
        {
            get { return this._modelPackageArnDataSource; }
            set { this._modelPackageArnDataSource = value; }
        }

        // Check to see if ModelPackageArnDataSource property is set
        internal bool IsSetModelPackageArnDataSource()
        {
            return this._modelPackageArnDataSource != null;
        }

    }
}