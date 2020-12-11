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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePortal operation.
    /// Creates a portal, which can contain projects and dashboards. AWS IoT SiteWise Monitor
    /// uses AWS SSO or IAM to authenticate portal users and manage user permissions.
    /// 
    ///  <note> 
    /// <para>
    /// Before you can sign in to a new portal, you must add at least one identity to that
    /// portal. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/administer-portals.html#portal-change-admins">Adding
    /// or removing portal administrators</a> in the <i>AWS IoT SiteWise User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePortalRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private AuthMode _portalAuthMode;
        private string _portalContactEmail;
        private string _portalDescription;
        private ImageFile _portalLogoImageFile;
        private string _portalName;
        private string _roleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Gets and sets the property PortalAuthMode. 
        /// <para>
        /// The service to use to authenticate users to the portal. Choose from the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SSO</code> – The portal uses AWS Single Sign-On to authenticate users and manage
        /// user permissions. Before you can create a portal that uses AWS SSO, you must enable
        /// AWS SSO. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-get-started.html#mon-gs-sso">Enabling
        /// AWS SSO</a> in the <i>AWS IoT SiteWise User Guide</i>. This option is only available
        /// in AWS Regions other than the China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IAM</code> – The portal uses AWS Identity and Access Management (IAM) to authenticate
        /// users and manage user permissions. This option is only available in the China Regions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change this value after you create a portal.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>SSO</code> 
        /// </para>
        /// </summary>
        public AuthMode PortalAuthMode
        {
            get { return this._portalAuthMode; }
            set { this._portalAuthMode = value; }
        }

        // Check to see if PortalAuthMode property is set
        internal bool IsSetPortalAuthMode()
        {
            return this._portalAuthMode != null;
        }

        /// <summary>
        /// Gets and sets the property PortalContactEmail. 
        /// <para>
        /// The AWS administrator's contact email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PortalContactEmail
        {
            get { return this._portalContactEmail; }
            set { this._portalContactEmail = value; }
        }

        // Check to see if PortalContactEmail property is set
        internal bool IsSetPortalContactEmail()
        {
            return this._portalContactEmail != null;
        }

        /// <summary>
        /// Gets and sets the property PortalDescription. 
        /// <para>
        /// A description for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PortalDescription
        {
            get { return this._portalDescription; }
            set { this._portalDescription = value; }
        }

        // Check to see if PortalDescription property is set
        internal bool IsSetPortalDescription()
        {
            return this._portalDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PortalLogoImageFile. 
        /// <para>
        /// A logo image to display in the portal. Upload a square, high-resolution image. The
        /// image is displayed on a dark background.
        /// </para>
        /// </summary>
        public ImageFile PortalLogoImageFile
        {
            get { return this._portalLogoImageFile; }
            set { this._portalLogoImageFile = value; }
        }

        // Check to see if PortalLogoImageFile property is set
        internal bool IsSetPortalLogoImageFile()
        {
            return this._portalLogoImageFile != null;
        }

        /// <summary>
        /// Gets and sets the property PortalName. 
        /// <para>
        /// A friendly name for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PortalName
        {
            get { return this._portalName; }
            set { this._portalName = value; }
        }

        // Check to see if PortalName property is set
        internal bool IsSetPortalName()
        {
            return this._portalName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of a service role that allows the portal's users to access your AWS IoT SiteWise resources
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-service-role.html">Using
        /// service roles for AWS IoT SiteWise Monitor</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the portal. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your AWS IoT SiteWise resources</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}