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
    /// This is the response object from the DescribePortal operation.
    /// </summary>
    public partial class DescribePortalResponse : AmazonWebServiceResponse
    {
        private Alarms _alarms;
        private string _notificationSenderEmail;
        private string _portalArn;
        private AuthMode _portalAuthMode;
        private string _portalClientId;
        private string _portalContactEmail;
        private DateTime? _portalCreationDate;
        private string _portalDescription;
        private string _portalId;
        private DateTime? _portalLastUpdateDate;
        private ImageLocation _portalLogoImageLocation;
        private string _portalName;
        private string _portalStartUrl;
        private PortalStatus _portalStatus;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// Contains the configuration information of an alarm created in an IoT SiteWise Monitor
        /// portal.
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
        /// Gets and sets the property NotificationSenderEmail. 
        /// <para>
        /// The email address that sends alarm notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the portal, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:${Partition}:iotsitewise:${Region}:${Account}:portal/${PortalId}</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string PortalArn
        {
            get { return this._portalArn; }
            set { this._portalArn = value; }
        }

        // Check to see if PortalArn property is set
        internal bool IsSetPortalArn()
        {
            return this._portalArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortalAuthMode. 
        /// <para>
        /// The service to use to authenticate users to the portal.
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
        /// Gets and sets the property PortalClientId. 
        /// <para>
        /// The IAM Identity Center application generated client ID (used with IAM Identity Center
        /// APIs). IoT SiteWise includes <code>portalClientId</code> for only portals that use
        /// IAM Identity Center to authenticate users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PortalClientId
        {
            get { return this._portalClientId; }
            set { this._portalClientId = value; }
        }

        // Check to see if PortalClientId property is set
        internal bool IsSetPortalClientId()
        {
            return this._portalClientId != null;
        }

        /// <summary>
        /// Gets and sets the property PortalContactEmail. 
        /// <para>
        /// The Amazon Web Services administrator's contact email address.
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
        /// Gets and sets the property PortalCreationDate. 
        /// <para>
        /// The date the portal was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime PortalCreationDate
        {
            get { return this._portalCreationDate.GetValueOrDefault(); }
            set { this._portalCreationDate = value; }
        }

        // Check to see if PortalCreationDate property is set
        internal bool IsSetPortalCreationDate()
        {
            return this._portalCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortalDescription. 
        /// <para>
        /// The portal's description.
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
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The ID of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PortalId
        {
            get { return this._portalId; }
            set { this._portalId = value; }
        }

        // Check to see if PortalId property is set
        internal bool IsSetPortalId()
        {
            return this._portalId != null;
        }

        /// <summary>
        /// Gets and sets the property PortalLastUpdateDate. 
        /// <para>
        /// The date the portal was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime PortalLastUpdateDate
        {
            get { return this._portalLastUpdateDate.GetValueOrDefault(); }
            set { this._portalLastUpdateDate = value; }
        }

        // Check to see if PortalLastUpdateDate property is set
        internal bool IsSetPortalLastUpdateDate()
        {
            return this._portalLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortalLogoImageLocation. 
        /// <para>
        /// The portal's logo image, which is available at a URL.
        /// </para>
        /// </summary>
        public ImageLocation PortalLogoImageLocation
        {
            get { return this._portalLogoImageLocation; }
            set { this._portalLogoImageLocation = value; }
        }

        // Check to see if PortalLogoImageLocation property is set
        internal bool IsSetPortalLogoImageLocation()
        {
            return this._portalLogoImageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property PortalName. 
        /// <para>
        /// The name of the portal.
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
        /// Gets and sets the property PortalStartUrl. 
        /// <para>
        /// The URL for the IoT SiteWise Monitor portal. You can use this URL to access portals
        /// that use IAM Identity Center for authentication. For portals that use IAM for authentication,
        /// you must use the IoT SiteWise console to get a URL that you can use to access the
        /// portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PortalStartUrl
        {
            get { return this._portalStartUrl; }
            set { this._portalStartUrl = value; }
        }

        // Check to see if PortalStartUrl property is set
        internal bool IsSetPortalStartUrl()
        {
            return this._portalStartUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PortalStatus. 
        /// <para>
        /// The current status of the portal, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PortalStatus PortalStatus
        {
            get { return this._portalStatus; }
            set { this._portalStatus = value; }
        }

        // Check to see if PortalStatus property is set
        internal bool IsSetPortalStatus()
        {
            return this._portalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the service role that allows the portal's users to access your IoT SiteWise resources
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/monitor-service-role.html">Using
        /// service roles for IoT SiteWise Monitor</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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

    }
}