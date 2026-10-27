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
    /// Specifies the settings for a one-time message that's sent directly to an endpoint
    /// through the ADM (Amazon Device Messaging) channel.
    /// </summary>
    public partial class ADMMessage
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if the recipient taps the push notification. Valid values are:
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
        /// The body of the notification message.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ConsolidationKey. 
        /// <para>
        /// An arbitrary string that indicates that multiple messages are logically the same and
        /// that Amazon Device Messaging (ADM) can drop previously enqueued messages in favor
        /// of this message.
        /// </para>
        /// </summary>
        public string ConsolidationKey { get; set; }

        /// <summary>
        /// Checks to see if the ConsolidationKey property is set.
        /// </summary>
        internal bool IsSetConsolidationKey() => this.ConsolidationKey != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The JSON data payload to use for the push notification, if the notification is a silent
        /// push notification. This payload is added to the data.pinpoint.jsonBody object of the
        /// notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Data { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null && (this.Data.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpiresAfter. 
        /// <para>
        /// The amount of time, in seconds, that ADM should store the message if the recipient's
        /// device is offline. Amazon Pinpoint specifies this value in the expiresAfter parameter
        /// when it sends the notification message to ADM.
        /// </para>
        /// </summary>
        public string ExpiresAfter { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAfter property is set.
        /// </summary>
        internal bool IsSetExpiresAfter() => this.ExpiresAfter != null;

        /// <summary>
        /// Gets and sets the property IconReference. 
        /// <para>
        /// The icon image name of the asset saved in your app.
        /// </para>
        /// </summary>
        public string IconReference { get; set; }

        /// <summary>
        /// Checks to see if the IconReference property is set.
        /// </summary>
        internal bool IsSetIconReference() => this.IconReference != null;

        /// <summary>
        /// Gets and sets the property ImageIconUrl. 
        /// <para>
        /// The URL of the large icon image to display in the content view of the push notification.
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
        /// The URL of an image to display in the push notification.
        /// </para>
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageUrl property is set.
        /// </summary>
        internal bool IsSetImageUrl() => this.ImageUrl != null;

        /// <summary>
        /// Gets and sets the property MD5. 
        /// <para>
        /// The base64-encoded, MD5 checksum of the value specified by the Data property. ADM
        /// uses the MD5 value to verify the integrity of the data.
        /// </para>
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// Checks to see if the MD5 property is set.
        /// </summary>
        internal bool IsSetMD5() => this.MD5 != null;

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for the notification message.
        /// If specified, this value overrides all other content for the message.
        /// </para>
        /// </summary>
        public string RawContent { get; set; }

        /// <summary>
        /// Checks to see if the RawContent property is set.
        /// </summary>
        internal bool IsSetRawContent() => this.RawContent != null;

        /// <summary>
        /// Gets and sets the property SilentPush. 
        /// <para>
        /// Specifies whether the notification is a silent push notification, which is a push
        /// notification that doesn't display on a recipient's device. Silent push notifications
        /// can be used for cases such as updating an app's configuration or supporting phone
        /// home functionality.
        /// </para>
        /// </summary>
        public bool? SilentPush { get; set; }

        /// <summary>
        /// Checks to see if the SilentPush property is set.
        /// </summary>
        internal bool IsSetSilentPush() => this.SilentPush.HasValue;

        /// <summary>
        /// Gets and sets the property SmallImageIconUrl. 
        /// <para>
        /// The URL of the small icon image to display in the status bar and the content view
        /// of the push notification.
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
        /// The sound to play when the recipient receives the push notification. You can use the
        /// default stream or specify the file name of a sound resource that's bundled in your
        /// app. On an Android platform, the sound file must reside in /res/raw/.
        /// </para>
        /// </summary>
        public string Sound { get; set; }

        /// <summary>
        /// Checks to see if the Sound property is set.
        /// </summary>
        internal bool IsSetSound() => this.Sound != null;

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The default message variables to use in the notification message. You can override
        /// the default variables with individual address variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Substitutions property is set.
        /// </summary>
        internal bool IsSetSubstitutions() => this.Substitutions != null && (this.Substitutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to display above the notification message on the recipient's device.
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
        /// The URL to open in the recipient's default mobile browser, if a recipient taps the
        /// push notification and the value of the Action property is URL.
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
