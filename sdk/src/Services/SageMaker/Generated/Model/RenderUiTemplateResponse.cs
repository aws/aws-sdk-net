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
    /// This is the response object from the RenderUiTemplate operation.
    /// </summary>
    public partial class RenderUiTemplateResponse : AmazonWebServiceResponse
    {
        private List<RenderingError> _errors = AWSConfigs.InitializeCollections ? new List<RenderingError>() : null;
        private string _renderedContent;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of one or more <c>RenderingError</c> objects if any were encountered while
        /// rendering the template. If there were no errors, the list is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RenderingError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RenderedContent. 
        /// <para>
        /// A Liquid template that renders the HTML for the worker UI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RenderedContent
        {
            get { return this._renderedContent; }
            set { this._renderedContent = value; }
        }

        // Check to see if RenderedContent property is set
        internal bool IsSetRenderedContent()
        {
            return this._renderedContent != null;
        }

    }
}