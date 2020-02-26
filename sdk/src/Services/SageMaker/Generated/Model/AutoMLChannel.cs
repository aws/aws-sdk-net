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
    /// Similar to Channel. A channel is a named input source that training algorithms can
    /// consume. Refer to Channel for detailed descriptions.
    /// </summary>
    public partial class AutoMLChannel
    {
        private CompressionType _compressionType;
        private AutoMLDataSource _dataSource;
        private string _targetAttributeName;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// You can use Gzip or None. The default value is None.
        /// </para>
        /// </summary>
        public CompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAttributeName. 
        /// <para>
        /// The name of the target variable in supervised learning, a.k.a. 'y'.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string TargetAttributeName
        {
            get { return this._targetAttributeName; }
            set { this._targetAttributeName = value; }
        }

        // Check to see if TargetAttributeName property is set
        internal bool IsSetTargetAttributeName()
        {
            return this._targetAttributeName != null;
        }

    }
}