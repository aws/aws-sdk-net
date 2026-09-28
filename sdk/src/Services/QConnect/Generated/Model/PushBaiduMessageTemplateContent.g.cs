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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The content of the push message template that applies to Baidu notification service.
    /// </summary>
    public partial class PushBaiduMessageTemplateContent
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if a recipient taps a push notification that is based on the message
        /// template. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OPEN_APP</c> - Your app opens or it becomes the foreground app if it was sent
        /// to the background. This is the default action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEEP_LINK</c> - Your app opens and displays a designated user interface in the
        /// app. This action uses the deep-linking features of the Android platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>URL</c> - The default mobile browser on the recipient's device opens and loads
        /// the web page at a URL that you specify.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PushMessageAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body to use in a push notification that is based on the message template.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider Body { get; set; }

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
        [AWSProperty(Sensitive = true, Min = 1)]
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
        [AWSProperty(Sensitive = true, Min = 1)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageUrl property is set.
        /// </summary>
        internal bool IsSetImageUrl() => this.ImageUrl != null;

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The URL of the small icon image to display in the status bar and the content view
        /// of a push notification that's based on the message template.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider RawContent { get; set; }

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
        [AWSProperty(Sensitive = true, Min = 1)]
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
        /// in <c>/res/raw/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
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
        [AWSProperty(Sensitive = true, Min = 1)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to open in a recipient's default mobile browser, if a recipient taps a push
        /// notification that's based on the message template and the value of the <c>action</c>
        /// property is <c>URL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
