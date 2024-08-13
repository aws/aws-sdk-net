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
    /// Container for the parameters to the CreatePresignedMlflowTrackingServerUrl operation.
    /// Returns a presigned URL that you can use to connect to the MLflow UI attached to your
    /// tracking server. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow-launch-ui.html">Launch
    /// the MLflow UI using a presigned URL</a>.
    /// </summary>
    public partial class CreatePresignedMlflowTrackingServerUrlRequest : AmazonSageMakerRequest
    {
        private int? _expiresInSeconds;
        private int? _sessionExpirationDurationInSeconds;
        private string _trackingServerName;

        /// <summary>
        /// Gets and sets the property ExpiresInSeconds. 
        /// <para>
        /// The duration in seconds that your presigned URL is valid. The presigned URL can be
        /// used only once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
        public int? ExpiresInSeconds
        {
            get { return this._expiresInSeconds; }
            set { this._expiresInSeconds = value; }
        }

        // Check to see if ExpiresInSeconds property is set
        internal bool IsSetExpiresInSeconds()
        {
            return this._expiresInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The duration in seconds that your MLflow UI session is valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1800, Max=43200)]
        public int? SessionExpirationDurationInSeconds
        {
            get { return this._sessionExpirationDurationInSeconds; }
            set { this._sessionExpirationDurationInSeconds = value; }
        }

        // Check to see if SessionExpirationDurationInSeconds property is set
        internal bool IsSetSessionExpirationDurationInSeconds()
        {
            return this._sessionExpirationDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of the tracking server to connect to your MLflow UI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrackingServerName
        {
            get { return this._trackingServerName; }
            set { this._trackingServerName = value; }
        }

        // Check to see if TrackingServerName property is set
        internal bool IsSetTrackingServerName()
        {
            return this._trackingServerName != null;
        }

    }
}