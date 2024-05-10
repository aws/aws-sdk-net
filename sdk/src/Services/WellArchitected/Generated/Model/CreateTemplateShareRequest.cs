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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplateShare operation.
    /// Create a review template share.
    /// 
    ///  
    /// <para>
    /// The owner of a review template can share it with other Amazon Web Services accounts,
    /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
    /// Region. 
    /// </para>
    ///  
    /// <para>
    ///  Shared access to a review template is not removed until the review template share
    /// invitation is deleted.
    /// </para>
    ///  
    /// <para>
    /// If you share a review template with an organization or OU, all accounts in the organization
    /// or OU are granted access to the review template.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Disclaimer</b> 
    /// </para>
    ///  
    /// <para>
    /// By sharing your review template with other Amazon Web Services accounts, you acknowledge
    /// that Amazon Web Services will make your review template available to those other accounts.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateTemplateShareRequest : AmazonWellArchitectedRequest
    {
        private string _clientRequestToken;
        private string _sharedWith;
        private string _templateArn;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=250)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

    }
}