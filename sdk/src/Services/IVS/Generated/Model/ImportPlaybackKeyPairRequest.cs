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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the ImportPlaybackKeyPair operation.
    /// Imports the public portion of a new key pair and returns its <code>arn</code> and
    /// <code>fingerprint</code>. The <code>privateKey</code> can then be used to generate
    /// viewer authorization tokens, to grant viewers access to authorized channels.
    /// </summary>
    public partial class ImportPlaybackKeyPairRequest : AmazonIVSRequest
    {
        private string _name;
        private string _publicKeyMaterial;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An arbitrary string (a nickname) assigned to a playback key pair that helps the customer
        /// identify that resource. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyMaterial. 
        /// <para>
        /// The public portion of a customer-generated key pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PublicKeyMaterial
        {
            get { return this._publicKeyMaterial; }
            set { this._publicKeyMaterial = value; }
        }

        // Check to see if PublicKeyMaterial property is set
        internal bool IsSetPublicKeyMaterial()
        {
            return this._publicKeyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags provided with the request are added to the playback key pair tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}