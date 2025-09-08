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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessPolicy operation.
    /// Creates an access policy that grants the specified identity (IAM Identity Center user,
    /// IAM Identity Center group, or IAM user) access to the specified IoT SiteWise Monitor
    /// portal or project resource.
    /// 
    ///  <note> 
    /// <para>
    /// Support for access policies that use an SSO Group as the identity is not supported
    /// at this time.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateAccessPolicyRequest : AmazonIoTSiteWiseRequest
    {
        private Identity _accessPolicyIdentity;
        private Permission _accessPolicyPermission;
        private Resource _accessPolicyResource;
        private string _clientToken;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccessPolicyIdentity. 
        /// <para>
        /// The identity for this access policy. Choose an IAM Identity Center user, an IAM Identity
        /// Center group, or an IAM user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Identity AccessPolicyIdentity
        {
            get { return this._accessPolicyIdentity; }
            set { this._accessPolicyIdentity = value; }
        }

        // Check to see if AccessPolicyIdentity property is set
        internal bool IsSetAccessPolicyIdentity()
        {
            return this._accessPolicyIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyPermission. 
        /// <para>
        /// The permission level for this access policy. Note that a project <c>ADMINISTRATOR</c>
        /// is also known as a project owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Permission AccessPolicyPermission
        {
            get { return this._accessPolicyPermission; }
            set { this._accessPolicyPermission = value; }
        }

        // Check to see if AccessPolicyPermission property is set
        internal bool IsSetAccessPolicyPermission()
        {
            return this._accessPolicyPermission != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyResource. 
        /// <para>
        /// The IoT SiteWise Monitor resource for this access policy. Choose either a portal or
        /// a project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Resource AccessPolicyResource
        {
            get { return this._accessPolicyResource; }
            set { this._accessPolicyResource = value; }
        }

        // Check to see if AccessPolicyResource property is set
        internal bool IsSetAccessPolicyResource()
        {
            return this._accessPolicyResource != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the access policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your IoT SiteWise resources</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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