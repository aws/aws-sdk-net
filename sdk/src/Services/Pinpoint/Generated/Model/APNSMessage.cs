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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
    /// through the APNs (Apple Push Notification service) channel.
    /// </summary>
    public partial class APNSMessage
    {
        private Action _action;
        private string _apnsPushType;
        private int? _badge;
        private string _body;
        private string _category;
        private string _collapseId;
        private Dictionary<string, string> _data = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _mediaUrl;
        private string _preferredAuthenticationMethod;
        private string _priority;
        private string _rawContent;
        private bool? _silentPush;
        private string _sound;
        private Dictionary<string, List<string>> _substitutions = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _threadId;
        private int? _timeToLive;
        private string _title;
        private string _url;

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
        /// setting uses the deep-linking features of the iOS platform.
        /// </para>
        /// </li> <li>
        /// <para>
        /// URL - The default mobile browser on the recipient's device opens and loads the web
        /// page at a URL that you specify.
        /// </para>
        /// </li></ul>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property APNSPushType. 
        /// <para>
        /// The type of push notification to send. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// alert - For a standard notification that's displayed on recipients' devices and prompts
        /// a recipient to interact with the notification.
        /// </para>
        /// </li> <li>
        /// <para>
        /// background - For a silent notification that delivers content in the background and
        /// isn't displayed on recipients' devices.
        /// </para>
        /// </li> <li>
        /// <para>
        /// complication - For a notification that contains update information for an app’s complication
        /// timeline.
        /// </para>
        /// </li> <li>
        /// <para>
        /// fileprovider - For a notification that signals changes to a File Provider extension.
        /// </para>
        /// </li> <li>
        /// <para>
        /// mdm - For a notification that tells managed devices to contact the MDM server.
        /// </para>
        /// </li> <li>
        /// <para>
        /// voip - For a notification that provides information about an incoming VoIP call.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// Amazon Pinpoint specifies this value in the apns-push-type request header when it
        /// sends the notification message to APNs. If you don't specify a value for this property,
        /// Amazon Pinpoint sets the value to alert or background automatically, based on the
        /// value that you specify for the SilentPush or RawContent property of the message.
        /// </para>
        ///  
        /// <para>
        /// For more information about the apns-push-type request header, see <a href="https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/sending_notification_requests_to_apns">Sending
        /// Notification Requests to APNs</a> on the Apple Developer website.
        /// </para>
        /// </summary>
        public string APNSPushType
        {
            get { return this._apnsPushType; }
            set { this._apnsPushType = value; }
        }

        // Check to see if APNSPushType property is set
        internal bool IsSetAPNSPushType()
        {
            return this._apnsPushType != null;
        }

        /// <summary>
        /// Gets and sets the property Badge. 
        /// <para>
        /// The key that indicates whether and how to modify the badge of your app's icon when
        /// the recipient receives the push notification. If this key isn't included in the dictionary,
        /// the badge doesn't change. To remove the badge, set this value to 0.
        /// </para>
        /// </summary>
        public int? Badge
        {
            get { return this._badge; }
            set { this._badge = value; }
        }

        // Check to see if Badge property is set
        internal bool IsSetBadge()
        {
            return this._badge.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the notification message.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The key that indicates the notification type for the push notification. This key is
        /// a value that's defined by the identifier property of one of your app's registered
        /// categories.
        /// </para>
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CollapseId. 
        /// <para>
        /// An arbitrary identifier that, if assigned to multiple messages, APNs uses to coalesce
        /// the messages into a single push notification instead of delivering each message individually.
        /// This value can't exceed 64 bytes.
        /// </para>
        ///  
        /// <para>
        /// Amazon Pinpoint specifies this value in the apns-collapse-id request header when it
        /// sends the notification message to APNs.
        /// </para>
        /// </summary>
        public string CollapseId
        {
            get { return this._collapseId; }
            set { this._collapseId = value; }
        }

        // Check to see if CollapseId property is set
        internal bool IsSetCollapseId()
        {
            return this._collapseId != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The JSON payload to use for a silent push notification. This payload is added to the
        /// data.pinpoint.jsonBody object of the notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null && (this._data.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MediaUrl. 
        /// <para>
        /// The URL of an image or video to display in the push notification.
        /// </para>
        /// </summary>
        public string MediaUrl
        {
            get { return this._mediaUrl; }
            set { this._mediaUrl = value; }
        }

        // Check to see if MediaUrl property is set
        internal bool IsSetMediaUrl()
        {
            return this._mediaUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredAuthenticationMethod. 
        /// <para>
        /// The authentication method that you want Amazon Pinpoint to use when authenticating
        /// with APNs, CERTIFICATE or TOKEN.
        /// </para>
        /// </summary>
        public string PreferredAuthenticationMethod
        {
            get { return this._preferredAuthenticationMethod; }
            set { this._preferredAuthenticationMethod = value; }
        }

        // Check to see if PreferredAuthenticationMethod property is set
        internal bool IsSetPreferredAuthenticationMethod()
        {
            return this._preferredAuthenticationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// para>5 - Low priority, the notification might be delayed, delivered as part of a group,
        /// or throttled.
        /// </para>
        /// /listitem> <li>
        /// <para>
        /// 10 - High priority, the notification is sent immediately. This is the default value.
        /// A high priority notification should trigger an alert, play a sound, or badge your
        /// app's icon on the recipient's device.
        /// </para>
        /// </li>/para> 
        /// <para>
        /// Amazon Pinpoint specifies this value in the apns-priority request header when it sends
        /// the notification message to APNs.
        /// </para>
        ///  
        /// <para>
        /// The equivalent values for Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging
        /// (GCM), are normal, for 5, and high, for 10. If you specify an FCM value for this property,
        /// Amazon Pinpoint accepts and converts the value to the corresponding APNs value.
        /// </para>
        /// </summary>
        public string Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for the notification message.
        /// If specified, this value overrides all other content for the message.
        /// </para>
        ///  <note>
        /// <para>
        /// If you specify the raw content of an APNs push notification, the message payload has
        /// to include the content-available key. The value of the content-available key has to
        /// be an integer, and can only be 0 or 1. If you're sending a standard notification,
        /// set the value of content-available to 0. If you're sending a silent (background) notification,
        /// set the value of content-available to 1. Additionally, silent notification payloads
        /// can't include the alert, badge, or sound keys. For more information, see <a href="https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/generating_a_remote_notification">Generating
        /// a Remote Notification</a> and <a href="https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/pushing_background_updates_to_your_app">Pushing
        /// Background Updates to Your App</a> on the Apple Developer website.
        /// </para>
        /// </note>
        /// </summary>
        public string RawContent
        {
            get { return this._rawContent; }
            set { this._rawContent = value; }
        }

        // Check to see if RawContent property is set
        internal bool IsSetRawContent()
        {
            return this._rawContent != null;
        }

        /// <summary>
        /// Gets and sets the property SilentPush. 
        /// <para>
        /// Specifies whether the notification is a silent push notification. A silent (or background)
        /// push notification isn't displayed on recipients' devices. You can use silent push
        /// notifications to make small updates to your app, or to display messages in an in-app
        /// message center.
        /// </para>
        ///  
        /// <para>
        /// Amazon Pinpoint uses this property to determine the correct value for the apns-push-type
        /// request header when it sends the notification message to APNs. If you specify a value
        /// of true for this property, Amazon Pinpoint sets the value for the apns-push-type header
        /// field to background.
        /// </para>
        ///  <note>
        /// <para>
        /// If you specify the raw content of an APNs push notification, the message payload has
        /// to include the content-available key. For silent (background) notifications, set the
        /// value of content-available to 1. Additionally, the message payload for a silent notification
        /// can't include the alert, badge, or sound keys. For more information, see <a href="https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/generating_a_remote_notification">Generating
        /// a Remote Notification</a> and <a href="https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/pushing_background_updates_to_your_app">Pushing
        /// Background Updates to Your App</a> on the Apple Developer website.
        /// </para>
        ///  
        /// <para>
        /// Apple has indicated that they will throttle "excessive" background notifications based
        /// on current traffic volumes. To prevent your notifications being throttled, Apple recommends
        /// that you send no more than 3 silent push notifications to each recipient per hour.
        /// </para>
        /// </note>
        /// </summary>
        public bool? SilentPush
        {
            get { return this._silentPush; }
            set { this._silentPush = value; }
        }

        // Check to see if SilentPush property is set
        internal bool IsSetSilentPush()
        {
            return this._silentPush.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sound. 
        /// <para>
        /// The key for the sound to play when the recipient receives the push notification. The
        /// value for this key is the name of a sound file in your app's main bundle or the Library/Sounds
        /// folder in your app's data container. If the sound file can't be found or you specify
        /// default for the value, the system plays the default alert sound.
        /// </para>
        /// </summary>
        public string Sound
        {
            get { return this._sound; }
            set { this._sound = value; }
        }

        // Check to see if Sound property is set
        internal bool IsSetSound()
        {
            return this._sound != null;
        }

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The default message variables to use in the notification message. You can override
        /// these default variables with individual address variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && (this._substitutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreadId. 
        /// <para>
        /// The key that represents your app-specific identifier for grouping notifications. If
        /// you provide a Notification Content app extension, you can use this value to group
        /// your notifications together.
        /// </para>
        /// </summary>
        public string ThreadId
        {
            get { return this._threadId; }
            set { this._threadId = value; }
        }

        // Check to see if ThreadId property is set
        internal bool IsSetThreadId()
        {
            return this._threadId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The amount of time, in seconds, that APNs should store and attempt to deliver the
        /// push notification, if the service is unable to deliver the notification the first
        /// time. If this value is 0, APNs treats the notification as if it expires immediately
        /// and the service doesn't store or try to deliver the notification again.
        /// </para>
        ///  
        /// <para>
        /// Amazon Pinpoint specifies this value in the apns-expiration request header when it
        /// sends the notification message to APNs.
        /// </para>
        /// </summary>
        public int? TimeToLive
        {
            get { return this._timeToLive; }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to display above the notification message on the recipient's device.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to open in the recipient's default mobile browser, if a recipient taps the
        /// push notification and the value of the Action property is URL.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}