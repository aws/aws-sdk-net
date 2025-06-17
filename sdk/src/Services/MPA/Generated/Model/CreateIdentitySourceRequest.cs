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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIdentitySource operation.
    /// Creates a new identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
    /// Source</a> in the <i>Multi-party approval User Guide</i>.
    /// </summary>
    public partial class CreateIdentitySourceRequest : AmazonMPARequest
    {
        private string _clientToken;
        private IdentitySourceParameters _identitySourceParameters;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If not provided, the Amazon Web Services populates this field.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>What is idempotency?</b> 
        /// </para>
        ///  
        /// <para>
        /// When you make a mutating API request, the request typically returns a result before
        /// the operation's asynchronous workflows have completed. Operations might also time
        /// out or encounter other server issues before they complete, even though the request
        /// has already returned a result. This could make it difficult to determine whether the
        /// request succeeded or not, and could lead to multiple retries to ensure that the operation
        /// completes successfully. However, if the original request and the subsequent retries
        /// are successful, the operation is completed multiple times. This means that you might
        /// create more resources than you intended.
        /// </para>
        ///  
        /// <para>
        ///  <i>Idempotency</i> ensures that an API request completes no more than one time. With
        /// an idempotent request, if the original request completes successfully, any subsequent
        /// retries complete successfully without performing any further actions.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IdentitySourceParameters. 
        /// <para>
        /// A <c> IdentitySourceParameters</c> object. Contains details for the resource that
        /// provides identities to the identity source. For example, an IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentitySourceParameters IdentitySourceParameters
        {
            get { return this._identitySourceParameters; }
            set { this._identitySourceParameters = value; }
        }

        // Check to see if IdentitySourceParameters property is set
        internal bool IsSetIdentitySourceParameters()
        {
            return this._identitySourceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tag you want to attach to the identity source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}