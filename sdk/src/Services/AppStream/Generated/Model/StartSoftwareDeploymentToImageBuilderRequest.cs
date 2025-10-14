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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the StartSoftwareDeploymentToImageBuilder operation.
    /// Initiates license included applications deployment to an image builder instance.
    /// </summary>
    public partial class StartSoftwareDeploymentToImageBuilderRequest : AmazonAppStreamRequest
    {
        private string _imageBuilderName;
        private bool? _retryFailedDeployments;

        /// <summary>
        /// Gets and sets the property ImageBuilderName. 
        /// <para>
        /// The name of the target image builder instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageBuilderName
        {
            get { return this._imageBuilderName; }
            set { this._imageBuilderName = value; }
        }

        // Check to see if ImageBuilderName property is set
        internal bool IsSetImageBuilderName()
        {
            return this._imageBuilderName != null;
        }

        /// <summary>
        /// Gets and sets the property RetryFailedDeployments. 
        /// <para>
        /// Whether to retry previously failed license included application deployments.
        /// </para>
        /// </summary>
        public bool RetryFailedDeployments
        {
            get { return this._retryFailedDeployments.GetValueOrDefault(); }
            set { this._retryFailedDeployments = value; }
        }

        // Check to see if RetryFailedDeployments property is set
        internal bool IsSetRetryFailedDeployments()
        {
            return this._retryFailedDeployments.HasValue; 
        }

    }
}