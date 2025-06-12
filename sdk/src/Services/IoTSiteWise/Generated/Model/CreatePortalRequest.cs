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
    /// Container for the parameters to the CreatePortal operation.
    /// Creates a portal, which can contain projects and dashboards. IoT SiteWise Monitor
    /// uses IAM Identity Center or IAM to authenticate portal users and manage user permissions.
    /// 
    ///  <note> 
    /// <para>
    /// Before you can sign in to a new portal, you must add at least one identity to that
    /// portal. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/administer-portals.html#portal-change-admins">Adding
    /// or removing portal administrators</a> in the <i>IoT SiteWise User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePortalRequest : AmazonIoTSiteWiseRequest
    {
        private Alarms _alarms;
        private string _clientToken;
        private string _notificationSenderEmail;
        private AuthMode _portalAuthMode;
        private string _portalContactEmail;
        private string _portalDescription;
        private ImageFile _portalLogoImageFile;
        private string _portalName;
        private PortalType _portalType;
        private Dictionary<string, PortalTypeEntry> _portalTypeConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, PortalTypeEntry>() : null;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// Contains the configuration information of an alarm created in an IoT SiteWise Monitor
        /// portal. You can use the alarm to monitor an asset property and get notified when the
        /// asset property value is outside a specified range. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/monitor-alarms.html">Monitoring
        /// with alarms</a> in the <i>IoT SiteWise Application Guide</i>.
        /// </para>
        /// </summary>
        public Alarms Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null;
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
        /// Gets and sets the property NotificationSenderEmail. 
        /// <para>
        /// The email address that sends alarm notifications.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you use the <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/lambda-support.html">IoT
        /// Events managed Lambda function</a> to manage your emails, you must <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-email-addresses.html">verify
        /// the sender email address in Amazon SES</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string NotificationSenderEmail
        {
            get { return this._notificationSenderEmail; }
            set { this._notificationSenderEmail = value; }
        }

        // Check to see if NotificationSenderEmail property is set
        internal bool IsSetNotificationSenderEmail()
        {
            return this._notificationSenderEmail != null;
        }

        /// <summary>
        /// Gets and sets the property PortalAuthMode. 
        /// <para>
        /// The service to use to authenticate users to the portal. Choose from the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SSO</c> – The portal uses IAM Identity Center to authenticate users and manage
        /// user permissions. Before you can create a portal that uses IAM Identity Center, you
        /// must enable IAM Identity Center. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-get-started.html#mon-gs-sso">Enabling
        /// IAM Identity Center</a> in the <i>IoT SiteWise User Guide</i>. This option is only
        /// available in Amazon Web Services Regions other than the China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IAM</c> – The portal uses Identity and Access Management to authenticate users
        /// and manage user permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change this value after you create a portal.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>SSO</c> 
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
        /// The Amazon Web Services administrator's contact email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property PortalType. 
        /// <para>
        /// Define the type of portal. The value for IoT SiteWise Monitor (Classic) is <c>SITEWISE_PORTAL_V1</c>.
        /// The value for IoT SiteWise Monitor (AI-aware) is <c>SITEWISE_PORTAL_V2</c>.
        /// </para>
        /// </summary>
        public PortalType PortalType
        {
            get { return this._portalType; }
            set { this._portalType = value; }
        }

        // Check to see if PortalType property is set
        internal bool IsSetPortalType()
        {
            return this._portalType != null;
        }

        /// <summary>
        /// Gets and sets the property PortalTypeConfiguration. 
        /// <para>
        /// The configuration entry associated with the specific portal type. The value for IoT
        /// SiteWise Monitor (Classic) is <c>SITEWISE_PORTAL_V1</c>. The value for IoT SiteWise
        /// Monitor (AI-aware) is <c>SITEWISE_PORTAL_V2</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PortalTypeEntry> PortalTypeConfiguration
        {
            get { return this._portalTypeConfiguration; }
            set { this._portalTypeConfiguration = value; }
        }

        // Check to see if PortalTypeConfiguration property is set
        internal bool IsSetPortalTypeConfiguration()
        {
            return this._portalTypeConfiguration != null && (this._portalTypeConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of a service role that allows the portal's users to access your IoT SiteWise resources
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-service-role.html">Using
        /// service roles for IoT SiteWise Monitor</a> in the <i>IoT SiteWise User Guide</i>.
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