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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents a resource associated with a service.
    /// </summary>
    public partial class ServiceResource
    {
        private InputSource _inputSource;
        private Resource _resource;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property InputSource. 
        /// <para>
        /// The input source that discovered the resource.
        /// </para>
        /// </summary>
        public InputSource InputSource
        {
            get { return this._inputSource; }
            set { this._inputSource = value; }
        }

        // Check to see if InputSource property is set
        internal bool IsSetInputSource()
        {
            return this._inputSource != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}