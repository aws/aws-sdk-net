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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDevEndpoint operation.
    /// Updates a specified DevEndpoint.
    /// </summary>
    public partial class UpdateDevEndpointRequest : AmazonGlueRequest
    {
        private DevEndpointCustomLibraries _customLibraries;
        private string _endpointName;
        private string _publicKey;

        /// <summary>
        /// Gets and sets the property CustomLibraries. 
        /// <para>
        /// Custom Python or Java custom libraries to be loaded in the DevEndpoint.
        /// </para>
        /// </summary>
        public DevEndpointCustomLibraries CustomLibraries
        {
            get { return this._customLibraries; }
            set { this._customLibraries = value; }
        }

        // Check to see if CustomLibraries property is set
        internal bool IsSetCustomLibraries()
        {
            return this._customLibraries != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the DevEndpoint to be updated.
        /// </para>
        /// </summary>
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key for the DevEndpoint to use.
        /// </para>
        /// </summary>
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

    }
}