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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeModelCard operation.
    /// Describes the content, creation time, and security configuration of an Amazon SageMaker
    /// Model Card.
    /// </summary>
    public partial class DescribeModelCardRequest : AmazonSageMakerRequest
    {
        private string _modelCardName;
        private int? _modelCardVersion;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name of the model card to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelCardName
        {
            get { return this._modelCardName; }
            set { this._modelCardName = value; }
        }

        // Check to see if ModelCardName property is set
        internal bool IsSetModelCardName()
        {
            return this._modelCardName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card to describe. If a version is not provided, then the
        /// latest version of the model card is described.
        /// </para>
        /// </summary>
        public int ModelCardVersion
        {
            get { return this._modelCardVersion.GetValueOrDefault(); }
            set { this._modelCardVersion = value; }
        }

        // Check to see if ModelCardVersion property is set
        internal bool IsSetModelCardVersion()
        {
            return this._modelCardVersion.HasValue; 
        }

    }
}