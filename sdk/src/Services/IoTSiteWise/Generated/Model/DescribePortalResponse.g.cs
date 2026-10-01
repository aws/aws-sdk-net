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
    /// This is the response object from the DescribePortal operation.
    /// </summary>
    public partial class DescribePortalResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// Contains the configuration information of an alarm created in an IoT SiteWise Monitor
        /// portal.
        /// </para>
        /// </summary>
        public Alarms Alarms { get; set; }

        /// <summary>
        /// Checks to see if the Alarms property is set.
        /// </summary>
        internal bool IsSetAlarms() => this.Alarms != null;

        /// <summary>
        /// Gets and sets the property NotificationSenderEmail. 
        /// <para>
        /// The email address that sends alarm notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string NotificationSenderEmail { get; set; }

        /// <summary>
        /// Checks to see if the NotificationSenderEmail property is set.
        /// </summary>
        internal bool IsSetNotificationSenderEmail() => this.NotificationSenderEmail != null;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the portal, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:portal/${PortalId}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string PortalArn { get; set; }

        /// <summary>
        /// Checks to see if the PortalArn property is set.
        /// </summary>
        internal bool IsSetPortalArn() => this.PortalArn != null;

        /// <summary>
        /// Gets and sets the property PortalAuthMode. 
        /// <para>
        /// The service to use to authenticate users to the portal.
        /// </para>
        /// </summary>
        public AuthMode PortalAuthMode { get; set; }

        /// <summary>
        /// Checks to see if the PortalAuthMode property is set.
        /// </summary>
        internal bool IsSetPortalAuthMode() => this.PortalAuthMode != null;

        /// <summary>
        /// Gets and sets the property PortalClientId. 
        /// <para>
        /// The IAM Identity Center application generated client ID (used with IAM Identity Center
        /// API operations). IoT SiteWise includes <c>portalClientId</c> for only portals that
        /// use IAM Identity Center to authenticate users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PortalClientId { get; set; }

        /// <summary>
        /// Checks to see if the PortalClientId property is set.
        /// </summary>
        internal bool IsSetPortalClientId() => this.PortalClientId != null;

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
        /// Gets and sets the property PortalCreationDate. 
        /// <para>
        /// The date the portal was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? PortalCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the PortalCreationDate property is set.
        /// </summary>
        internal bool IsSetPortalCreationDate() => this.PortalCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property PortalDescription. 
        /// <para>
        /// The portal's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PortalDescription { get; set; }

        /// <summary>
        /// Checks to see if the PortalDescription property is set.
        /// </summary>
        internal bool IsSetPortalDescription() => this.PortalDescription != null;

        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The ID of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PortalId { get; set; }

        /// <summary>
        /// Checks to see if the PortalId property is set.
        /// </summary>
        internal bool IsSetPortalId() => this.PortalId != null;

        /// <summary>
        /// Gets and sets the property PortalLastUpdateDate. 
        /// <para>
        /// The date the portal was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? PortalLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the PortalLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetPortalLastUpdateDate() => this.PortalLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property PortalLogoImageLocation. 
        /// <para>
        /// The portal's logo image, which is available at a URL.
        /// </para>
        /// </summary>
        public ImageLocation PortalLogoImageLocation { get; set; }

        /// <summary>
        /// Checks to see if the PortalLogoImageLocation property is set.
        /// </summary>
        internal bool IsSetPortalLogoImageLocation() => this.PortalLogoImageLocation != null;

        /// <summary>
        /// Gets and sets the property PortalName. 
        /// <para>
        /// The name of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PortalName { get; set; }

        /// <summary>
        /// Checks to see if the PortalName property is set.
        /// </summary>
        internal bool IsSetPortalName() => this.PortalName != null;

        /// <summary>
        /// Gets and sets the property PortalStartUrl. 
        /// <para>
        /// The URL for the IoT SiteWise Monitor portal. You can use this URL to access portals
        /// that use IAM Identity Center for authentication. For portals that use IAM for authentication,
        /// you must use the IoT SiteWise console to get a URL that you can use to access the
        /// portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PortalStartUrl { get; set; }

        /// <summary>
        /// Checks to see if the PortalStartUrl property is set.
        /// </summary>
        internal bool IsSetPortalStartUrl() => this.PortalStartUrl != null;

        /// <summary>
        /// Gets and sets the property PortalStatus. 
        /// <para>
        /// The current status of the portal, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PortalStatus PortalStatus { get; set; }

        /// <summary>
        /// Checks to see if the PortalStatus property is set.
        /// </summary>
        internal bool IsSetPortalStatus() => this.PortalStatus != null;

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
        /// of the service role that allows the portal's users to access your IoT SiteWise resources
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-service-role.html">Using
        /// service roles for IoT SiteWise Monitor</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
