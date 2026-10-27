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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies channel-specific content and settings for a message template that can be
    /// used in push notifications that are sent through the APNs (Apple Push Notification
    /// service) channel.
    /// </summary>
    public partial class APNSPushNotificationTemplate
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if a recipient taps a push notification that's based on the message
        /// template. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background.
        /// This is the default action.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DEEP_LINK - Your app opens and displays a designated user interface in the app. This
        /// setting uses the deep-linking features of the iOS platform.
        /// </para>
        /// </li> <li>
        /// <para>
        /// URL - The default mobile browser on the recipient's device opens and loads the web
        /// page at a URL that you specify.
        /// </para>
        /// </li></ul>
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body to use in push notifications that are based on the message template.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property MediaUrl. 
        /// <para>
        /// The URL of an image or video to display in push notifications that are based on the
        /// message template.
        /// </para>
        /// </summary>
        public string MediaUrl { get; set; }

        /// <summary>
        /// Checks to see if the MediaUrl property is set.
        /// </summary>
        internal bool IsSetMediaUrl() => this.MediaUrl != null;

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for push notifications that are
        /// based on the message template. If specified, this value overrides all other content
        /// for the message template.
        /// </para>
        /// </summary>
        public string RawContent { get; set; }

        /// <summary>
        /// Checks to see if the RawContent property is set.
        /// </summary>
        internal bool IsSetRawContent() => this.RawContent != null;

        /// <summary>
        /// Gets and sets the property Sound. 
        /// <para>
        /// The key for the sound to play when the recipient receives a push notification that's
        /// based on the message template. The value for this key is the name of a sound file
        /// in your app's main bundle or the Library/Sounds folder in your app's data container.
        /// If the sound file can't be found or you specify default for the value, the system
        /// plays the default alert sound.
        /// </para>
        /// </summary>
        public string Sound { get; set; }

        /// <summary>
        /// Checks to see if the Sound property is set.
        /// </summary>
        internal bool IsSetSound() => this.Sound != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to use in push notifications that are based on the message template. This
        /// title appears above the notification message on a recipient's device.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to open in the recipient's default mobile browser, if a recipient taps a push
        /// notification that's based on the message template and the value of the Action property
        /// is URL.
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
