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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the DetectAnomalies operation.
    /// Detects anomalies in an image that you supply. 
    /// 
    ///  
    /// <para>
    /// The response from <c>DetectAnomalies</c> includes a boolean prediction that the image
    /// contains one or more anomalies and a confidence value for the prediction. If the model
    /// is an image segmentation model, the response also includes segmentation information
    /// for each type of anomaly found in the image.
    /// </para>
    ///  <note> 
    /// <para>
    /// Before calling <c>DetectAnomalies</c>, you must first start your model with the <a>StartModel</a>
    /// operation. You are charged for the amount of time, in minutes, that a model runs and
    /// for the number of anomaly detection units that your model uses. If you are not using
    /// a model, use the <a>StopModel</a> operation to stop your model. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <i>Detecting anomalies in an image</i> in the Amazon Lookout
    /// for Vision developer guide.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:DetectAnomalies</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DetectAnomaliesRequest : AmazonLookoutforVisionRequest
    {
        private Stream _body;
        private string _contentType;
        private string _modelVersion;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The unencrypted image bytes that you want to analyze. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of the image passed in <c>Body</c>. Valid values are <c>image/png</c> (PNG
        /// format images) and <c>image/jpeg</c> (JPG format images). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that contains the model version that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}