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
    /// Input configuration information for a labeling job.
    /// </summary>
    public partial class LabelingJobInputConfig
    {
        private LabelingJobDataAttributes _dataAttributes;
        private LabelingJobDataSource _dataSource;

        /// <summary>
        /// Gets and sets the property DataAttributes. 
        /// <para>
        /// Attributes of the data specified by the customer.
        /// </para>
        /// </summary>
        public LabelingJobDataAttributes DataAttributes
        {
            get { return this._dataAttributes; }
            set { this._dataAttributes = value; }
        }

        // Check to see if DataAttributes property is set
        internal bool IsSetDataAttributes()
        {
            return this._dataAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The location of the input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelingJobDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

    }
}