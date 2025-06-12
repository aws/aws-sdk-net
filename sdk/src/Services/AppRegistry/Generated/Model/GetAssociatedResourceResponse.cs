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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// This is the response object from the GetAssociatedResource operation.
    /// </summary>
    public partial class GetAssociatedResourceResponse : AmazonWebServiceResponse
    {
        private ApplicationTagResult _applicationTagResult;
        private List<string> _options = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Resource _resource;

        /// <summary>
        /// Gets and sets the property ApplicationTagResult. 
        /// <para>
        ///  The result of the application that's tag applied to a resource. 
        /// </para>
        /// </summary>
        public ApplicationTagResult ApplicationTagResult
        {
            get { return this._applicationTagResult; }
            set { this._applicationTagResult = value; }
        }

        // Check to see if ApplicationTagResult property is set
        internal bool IsSetApplicationTagResult()
        {
            return this._applicationTagResult != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        ///  Determines whether an application tag is applied or skipped. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource associated with the application.
        /// </para>
        /// </summary>
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}