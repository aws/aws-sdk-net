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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreatePortal operation. <important> <para> The
    /// IoT SiteWise Monitor feature will no longer be open to new customers starting November
    /// 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign up prior
    /// to that date. Existing customers can continue to use the service as normal. For more
    /// information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
    /// SiteWise Monitor availability change</a>. </para> </important> <para> Creates a portal,
    /// which can contain projects and dashboards. IoT SiteWise Monitor uses IAM Identity
    /// Center or IAM to authenticate portal users and manage user permissions. </para> <note>
    /// <para> Before you can sign in to a new portal, you must add at least one identity
    /// to that portal. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/administer-portals.html#portal-change-admins">Adding
    /// or removing portal administrators</a> in the <i>IoT SiteWise User Guide</i>. </para>
    /// </note>
    /// </summary>
    public partial class CreatePortalRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// Contains the configuration information of an alarm created in an IoT SiteWise Monitor
        /// portal. You can use the alarm to monitor an asset property and get notified when the
        /// asset property value is outside a specified range. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/monitor-alarms.html">Monitoring
        /// with alarms</a> in the <i>IoT SiteWise Application Guide</i>.
        /// </para>
        /// </summary>
        public Alarms Alarms { get; set; }

        /// <summary>
        /// Checks to see if the Alarms property is set.
        /// </summary>
        internal bool IsSetAlarms() => this.Alarms != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string NotificationSenderEmail { get; set; }

        /// <summary>
        /// Checks to see if the NotificationSenderEmail property is set.
        /// </summary>
        internal bool IsSetNotificationSenderEmail() => this.NotificationSenderEmail != null;

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
        public AuthMode PortalAuthMode { get; set; }

        /// <summary>
        /// Checks to see if the PortalAuthMode property is set.
        /// </summary>
        internal bool IsSetPortalAuthMode() => this.PortalAuthMode != null;

        /// <summary>
        /// Gets and sets the property PortalContactEmail. 
        /// <para>
        /// The Amazon Web Services administrator's contact email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string PortalContactEmail { get; set; }

        /// <summary>
        /// Checks to see if the PortalContactEmail property is set.
        /// </summary>
        internal bool IsSetPortalContactEmail() => this.PortalContactEmail != null;

        /// <summary>
        /// Gets and sets the property PortalDescription. 
        /// <para>
        /// A description for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PortalDescription { get; set; }

        /// <summary>
        /// Checks to see if the PortalDescription property is set.
        /// </summary>
        internal bool IsSetPortalDescription() => this.PortalDescription != null;

        /// <summary>
        /// Gets and sets the property PortalLogoImageFile. 
        /// <para>
        /// A logo image to display in the portal. Upload a square, high-resolution image. The
        /// image is displayed on a dark background.
        /// </para>
        /// </summary>
        public ImageFile PortalLogoImageFile { get; set; }

        /// <summary>
        /// Checks to see if the PortalLogoImageFile property is set.
        /// </summary>
        internal bool IsSetPortalLogoImageFile() => this.PortalLogoImageFile != null;

        /// <summary>
        /// Gets and sets the property PortalName. 
        /// <para>
        /// A friendly name for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PortalName { get; set; }

        /// <summary>
        /// Checks to see if the PortalName property is set.
        /// </summary>
        internal bool IsSetPortalName() => this.PortalName != null;

        /// <summary>
        /// Gets and sets the property PortalType. 
        /// <para>
        /// Define the type of portal. The value for IoT SiteWise Monitor (Classic) is <c>SITEWISE_PORTAL_V1</c>.
        /// The value for IoT SiteWise Monitor (AI-aware) is <c>SITEWISE_PORTAL_V2</c>.
        /// </para>
        /// </summary>
        public PortalType PortalType { get; set; }

        /// <summary>
        /// Checks to see if the PortalType property is set.
        /// </summary>
        internal bool IsSetPortalType() => this.PortalType != null;

        /// <summary>
        /// Gets and sets the property PortalTypeConfiguration. 
        /// <para>
        /// The configuration entry associated with the specific portal type. The value for IoT
        /// SiteWise Monitor (Classic) is <c>SITEWISE_PORTAL_V1</c>. The value for IoT SiteWise
        /// Monitor (AI-aware) is <c>SITEWISE_PORTAL_V2</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PortalTypeEntry> PortalTypeConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PortalTypeEntry>() : null;

        /// <summary>
        /// Checks to see if the PortalTypeConfiguration property is set.
        /// </summary>
        internal bool IsSetPortalTypeConfiguration() => this.PortalTypeConfiguration != null && (this.PortalTypeConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of a service role that allows the portal's users to access your IoT SiteWise resources
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-service-role.html">Using
        /// service roles for IoT SiteWise Monitor</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the portal. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your IoT SiteWise resources</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
