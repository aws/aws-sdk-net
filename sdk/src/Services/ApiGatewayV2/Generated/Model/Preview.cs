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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Contains the preview status and preview URL.
    /// </summary>
    public partial class Preview
    {
        private PreviewStatus _previewStatus;
        private string _previewUrl;
        private StatusException _statusException;

        /// <summary>
        /// Gets and sets the property PreviewStatus. 
        /// <para>
        /// The status of the preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PreviewStatus PreviewStatus
        {
            get { return this._previewStatus; }
            set { this._previewStatus = value; }
        }

        // Check to see if PreviewStatus property is set
        internal bool IsSetPreviewStatus()
        {
            return this._previewStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PreviewUrl. 
        /// <para>
        /// The URL of the preview.
        /// </para>
        /// </summary>
        public string PreviewUrl
        {
            get { return this._previewUrl; }
            set { this._previewUrl = value; }
        }

        // Check to see if PreviewUrl property is set
        internal bool IsSetPreviewUrl()
        {
            return this._previewUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StatusException. 
        /// <para>
        /// The status exception information.
        /// </para>
        /// </summary>
        public StatusException StatusException
        {
            get { return this._statusException; }
            set { this._statusException = value; }
        }

        // Check to see if StatusException property is set
        internal bool IsSetStatusException()
        {
            return this._statusException != null;
        }

    }
}