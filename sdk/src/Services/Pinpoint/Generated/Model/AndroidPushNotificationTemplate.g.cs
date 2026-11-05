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
    /// used in push notifications that are sent through the ADM (Amazon Device Messaging),
    /// Baidu (Baidu Cloud Push), or GCM (Firebase Cloud Messaging, formerly Google Cloud
    /// Messaging) channel.
    /// </summary>
    public partial class AndroidPushNotificationTemplate
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
        /// action uses the deep-linking features of the Android platform.
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
        /// The message body to use in a push notification that's based on the message template.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ImageIconUrl. 
        /// <para>
        /// The URL of the large icon image to display in the content view of a push notification
        /// that's based on the message template.
        /// </para>
        /// </summary>
        public string ImageIconUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageIconUrl property is set.
        /// </summary>
        internal bool IsSetImageIconUrl() => this.ImageIconUrl != null;

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image to display in a push notification that's based on the message
        /// template.
        /// </para>
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageUrl property is set.
        /// </summary>
        internal bool IsSetImageUrl() => this.ImageUrl != null;

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for a push notification that's
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
        /// Gets and sets the property SmallImageIconUrl. 
        /// <para>
        /// The URL of the small icon image to display in the status bar and the content view
        /// of a push notification that's based on the message template.
        /// </para>
        /// </summary>
        public string SmallImageIconUrl { get; set; }

        /// <summary>
        /// Checks to see if the SmallImageIconUrl property is set.
        /// </summary>
        internal bool IsSetSmallImageIconUrl() => this.SmallImageIconUrl != null;

        /// <summary>
        /// Gets and sets the property Sound. 
        /// <para>
        /// The sound to play when a recipient receives a push notification that's based on the
        /// message template. You can use the default stream or specify the file name of a sound
        /// resource that's bundled in your app. On an Android platform, the sound file must reside
        /// in /res/raw/.
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
        /// The title to use in a push notification that's based on the message template. This
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
        /// The URL to open in a recipient's default mobile browser, if a recipient taps a push
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
