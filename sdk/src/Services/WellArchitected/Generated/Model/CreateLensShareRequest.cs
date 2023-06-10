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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLensShare operation.
    /// Create a lens share.
    /// 
    ///  
    /// <para>
    /// The owner of a lens can share it with other Amazon Web Services accounts, users, an
    /// organization, and organizational units (OUs) in the same Amazon Web Services Region.
    /// Lenses provided by Amazon Web Services (Amazon Web Services Official Content) cannot
    /// be shared.
    /// </para>
    ///  
    /// <para>
    ///  Shared access to a lens is not removed until the lens invitation is deleted.
    /// </para>
    ///  
    /// <para>
    /// If you share a lens with an organization or OU, all accounts in the organization or
    /// OU are granted access to the lens.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-sharing.html">Sharing
    /// a custom lens</a> in the <i>Well-Architected Tool User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Disclaimer</b> 
    /// </para>
    ///  
    /// <para>
    /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
    /// that Amazon Web Services will make your custom lenses available to those other accounts.
    /// Those other accounts may continue to access and use your shared custom lenses even
    /// if you delete the custom lenses from your own Amazon Web Services account or terminate
    /// your Amazon Web Services account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateLensShareRequest : AmazonWellArchitectedRequest
    {
        private string _clientRequestToken;
        private string _lensAlias;
        private string _sharedWith;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
        }

        /// <summary>
        /// Gets and sets the property SharedWith.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=2048)]
        public string SharedWith
        {
            get { return this._sharedWith; }
            set { this._sharedWith = value; }
        }

        // Check to see if SharedWith property is set
        internal bool IsSetSharedWith()
        {
            return this._sharedWith != null;
        }

    }
}