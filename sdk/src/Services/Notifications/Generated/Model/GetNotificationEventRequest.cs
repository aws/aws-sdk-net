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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Container for the parameters to the GetNotificationEvent operation.
    /// Returns a specified <c>NotificationEvent</c>.
    /// 
    ///  <important> 
    /// <para>
    /// User Notifications stores notifications in the individual Regions you register as
    /// notification hubs and the Region of the source event rule. <c>GetNotificationEvent</c>
    /// only returns notifications stored in the same Region in which the action is called.
    /// User Notifications doesn't backfill notifications to new Regions selected as notification
    /// hubs. For this reason, we recommend that you make calls in your oldest registered
    /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
    /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetNotificationEventRequest : AmazonNotificationsRequest
    {
        private string _arn;
        private LocaleCode _locale;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>NotificationEvent</c> to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale code of the language used for the retrieved <c>NotificationEvent</c>. The
        /// default locale is English <c>en_US</c>.
        /// </para>
        /// </summary>
        public LocaleCode Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

    }
}