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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpace operation.
    /// Creates an AWS re:Post Private private re:Post.
    /// </summary>
    public partial class CreateSpaceRequest : AmazonRepostspaceRequest
    {
        private string _description;
        private string _name;
        private string _roleArn;
        private string _subdomain;
        private SupportedEmailDomainsParameters _supportedEmailDomains;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TierLevel _tier;
        private string _userkmsKey;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the private re:Post. This is used only to help you identify this
        /// private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the private re:Post. This must be unique in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=30)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants permissions to the private re:Post to convert unanswered
        /// questions into AWS support tickets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subdomain. 
        /// <para>
        /// The subdomain that you use to access your AWS re:Post Private private re:Post. All
        /// custom subdomains must be approved by AWS before use. In addition to your custom subdomain,
        /// all private re:Posts are issued an AWS generated subdomain for immediate use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Subdomain
        {
            get { return this._subdomain; }
            set { this._subdomain = value; }
        }

        // Check to see if Subdomain property is set
        internal bool IsSetSubdomain()
        {
            return this._subdomain != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedEmailDomains.
        /// </summary>
        public SupportedEmailDomainsParameters SupportedEmailDomains
        {
            get { return this._supportedEmailDomains; }
            set { this._supportedEmailDomains = value; }
        }

        // Check to see if SupportedEmailDomains property is set
        internal bool IsSetSupportedEmailDomains()
        {
            return this._supportedEmailDomains != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the private re:Post.
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

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The pricing tier for the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TierLevel Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property UserKMSKey. 
        /// <para>
        /// The AWS KMS key ARN that’s used for the AWS KMS encryption. If you don't provide a
        /// key, your data is encrypted by default with a key that AWS owns and manages for you.
        /// </para>
        /// </summary>
        public string UserKMSKey
        {
            get { return this._userkmsKey; }
            set { this._userkmsKey = value; }
        }

        // Check to see if UserKMSKey property is set
        internal bool IsSetUserKMSKey()
        {
            return this._userkmsKey != null;
        }

    }
}