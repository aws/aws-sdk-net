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
    /// The configuration for the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-feature-attribute-shap-baselines.html">SHAP
    /// baseline</a> (also called the background or reference dataset) of the Kernal SHAP
    /// algorithm.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// The number of records in the baseline data determines the size of the synthetic dataset,
    /// which has an impact on latency of explainability requests. For more information, see
    /// the <b>Synthetic data</b> of <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-create-endpoint.html">Configure
    /// and create an endpoint</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ShapBaseline</c> and <c>ShapBaselineUri</c> are mutually exclusive parameters.
    /// One or the either is required to configure a SHAP baseline. 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ClarifyShapBaselineConfig
    {
        private string _mimeType;
        private string _shapBaseline;
        private string _shapBaselineUri;

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the baseline data. Choose from <c>'text/csv'</c> or <c>'application/jsonlines'</c>.
        /// Defaults to <c>'text/csv'</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string MimeType
        {
            get { return this._mimeType; }
            set { this._mimeType = value; }
        }

        // Check to see if MimeType property is set
        internal bool IsSetMimeType()
        {
            return this._mimeType != null;
        }

        /// <summary>
        /// Gets and sets the property ShapBaseline. 
        /// <para>
        /// The inline SHAP baseline data in string format. <c>ShapBaseline</c> can have one or
        /// multiple records to be used as the baseline dataset. The format of the SHAP baseline
        /// file should be the same format as the training dataset. For example, if the training
        /// dataset is in CSV format and each record contains four features, and all features
        /// are numerical, then the format of the baseline data should also share these characteristics.
        /// For natural language processing (NLP) of text columns, the baseline value should be
        /// the value used to replace the unit of text specified by the <c>Granularity</c> of
        /// the <c>TextConfig</c> parameter. The size limit for <c>ShapBasline</c> is 4 KB. Use
        /// the <c>ShapBaselineUri</c> parameter if you want to provide more than 4 KB of baseline
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ShapBaseline
        {
            get { return this._shapBaseline; }
            set { this._shapBaseline = value; }
        }

        // Check to see if ShapBaseline property is set
        internal bool IsSetShapBaseline()
        {
            return this._shapBaseline != null;
        }

        /// <summary>
        /// Gets and sets the property ShapBaselineUri. 
        /// <para>
        /// The uniform resource identifier (URI) of the S3 bucket where the SHAP baseline file
        /// is stored. The format of the SHAP baseline file should be the same format as the format
        /// of the training dataset. For example, if the training dataset is in CSV format, and
        /// each record in the training dataset has four features, and all features are numerical,
        /// then the baseline file should also have this same format. Each record should contain
        /// only the features. If you are using a virtual private cloud (VPC), the <c>ShapBaselineUri</c>
        /// should be accessible to the VPC. For more information about setting up endpoints with
        /// Amazon Virtual Private Cloud, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html">Give
        /// SageMaker access to Resources in your Amazon Virtual Private Cloud</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ShapBaselineUri
        {
            get { return this._shapBaselineUri; }
            set { this._shapBaselineUri = value; }
        }

        // Check to see if ShapBaselineUri property is set
        internal bool IsSetShapBaselineUri()
        {
            return this._shapBaselineUri != null;
        }

    }
}